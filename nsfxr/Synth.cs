using System;

namespace nsfxr
{
    public class Synth
    {
        private const float TOLERANCE = 0.00001f;

        private SynthParams Parameters { get; set; }

        #region crap        
        private float[] _waveData;						// Full wave, read out in chuncks by the onSampleData method
        private uint _waveDataPos;					// Current position in the waveData
        
        private float _masterVolume;						// masterVolume * masterVolume (for quick calculations)
        private uint _waveType;							// The type of wave to generate
        private float _envelopeVolume;					// Current volume of the envelope
        private int _envelopeStage;						// Current stage of the envelope (attack, sustain, decay, end)
        private float _envelopeTime;						// Current time through current enelope stage
        private float _envelopeLength;					// Length of the current envelope stage
        private float _envelopeLength0;					// Length of the attack stage
        private float _envelopeLength1;					// Length of the sustain stage
        private float _envelopeLength2;					// Length of the decay stage
        private float _envelopeOverLength0;				// 1 / _envelopeLength0 (for quick calculations)
        private float _envelopeOverLength1;				// 1 / _envelopeLength1 (for quick calculations)
        private float _envelopeOverLength2;				// 1 / _envelopeLength2 (for quick calculations)
        private uint _envelopeFullLength;				// Full length of the volume envelop (and therefore sound)

        private float _sustainPunch;						// The punch factor (louder at begining of sustain)

        private int _phase;								// Phase through the wave
        private float _pos;								// Phase expresed as a Number from 0-1, used for fast sin approx
        private float _period;							// Period of the wave
        private float _periodTemp;						// Period modified by vibrato
        private float _maxPeriod;							// Maximum period before sound stops (from minFrequency)

        private float _slide;								// Note slide
        private float _deltaSlide;						// Change in slide
        private float _minFrequency;						// Minimum frequency before stopping

        private float _vibratoPhase;						// Phase through the vibrato sine wave
        private float _vibratoSpeed;						// Speed at which the vibrato phase moves
        private float _vibratoAmplitude;					// Amount to change the period of the wave by at the peak of the vibrato wave

        private float _changeAmount;						// Amount to change the note by
        private int _changeTime;						// Counter for the note change
        private int _changeLimit;						// Once the time reaches this limit, the note changes

        private float _squareDuty;						// Offset of center switching point in the square wave
        private float _dutySweep;							// Amount to change the duty by

        private int _repeatTime;						// Counter for the repeats
        private int _repeatLimit;						// Once the time reaches this limit, some of the variables are reset

        private bool _phaser;							// If the phaser is active
        private float _phaserOffset;						// Phase offset for phaser effect
        private float _phaserDeltaOffset;					// Change in phase offset
        private int _phaserInt;							// Integer phaser offset, for bit maths
        private int _phaserPos;							// Position through the phaser buffer
        private float[] _phaserBuffer;						// Buffer of wave values used to create the out of phase second wave

        private bool _filters;							// If the filters are active
        private float _lpFilterPos;						// Adjusted wave position after low-pass filter
        private float _lpFilterOldPos;					// Previous low-pass wave position
        private float _lpFilterDeltaPos;					// Change in low-pass wave position, as allowed by the cutoff and damping
        private float _lpFilterCutoff;					// Cutoff multiplier which adjusts the amount the wave position can move
        private float _lpFilterDeltaCutoff;				// Speed of the low-pass cutoff multiplier
        private float _lpFilterDamping;					// Damping muliplier which restricts how fast the wave position can move
        private bool _lpFilterOn;						// If the low pass filter is active

        private float _hpFilterPos;						// Adjusted wave position after high-pass filter
        private float _hpFilterCutoff;					// Cutoff multiplier which adjusts the amount the wave position can move
        private float _hpFilterDeltaCutoff;				// Speed of the high-pass cutoff multiplier

        private float[] _noiseBuffer;						// Buffer of random values used to generate noise

        private float _superSample;						// Actual sample writen to the wave
        private float _sample;							// Sub-sample calculated 8 times per actual sample, averaged out to get the super sample

        #endregion
                
        public void Mutate(float __mutationAmount = 0.05f, uint __mutationsNum = 15)
        {                        
                Parameters.Mutate(__mutationAmount);          
        }

        private IntPtr WriteSamples(float[] __originSamples, int __originPos, float[] __targetSamples, int __targetChannels)
        {
            // Write samples to fMod format
            // TODO
            return new IntPtr();
        }

        public bool GenerateAudioFilterData(float[] _data, int _channels)
        {
            bool endOfSamples = false;                                                                        
            int samplesNeeded = _data.Length / _channels;

            if(samplesNeeded == 0) return false;

            if (SynthWave(_data, (uint) samplesNeeded))
            {
            //    WriteSamples(_cachedMutation, (int) _waveDataPos, _data, _channels);
            }
            return true;
        }

        private void Reset(bool __totalReset)
        {
            // Shorter reference
            var p = Parameters;

            _period = 100.0f / (p.StartFrequency * p.StartFrequency + 0.001f);
            _maxPeriod = 100.0f / (p.MinFrequency * p.MinFrequency + 0.001f);

            _slide = 1.0f - p.Slide * p.Slide * p.Slide * 0.01f;
            _deltaSlide = -p.DeltaSlide * p.DeltaSlide * p.DeltaSlide * 0.000001f;

            if (p.WaveShape == 0) {
                _squareDuty = 0.5f - p.SquareDuty * 0.5f;
                _dutySweep = -p.DutySweep * 0.00005f;
            }

            if (p.ChangeAmount > 0.0) {
                _changeAmount = 1.0f - p.ChangeAmount * p.ChangeAmount * 0.9f;
            } else {
                _changeAmount = 1.0f + p.ChangeAmount * p.ChangeAmount * 10.0f;
            }

            _changeTime = 0;

            if (p.ChangeSpeed == 1.0f) {
                _changeLimit = 0;
            } else {
                _changeLimit = (int)((1f - p.ChangeSpeed) * (1f - p.ChangeSpeed) * 20000f + 32f);
            }

            if (__totalReset) {
                //p.paramsDirty = false;

                _masterVolume = p.MasterVolume * p.MasterVolume;

                _waveType = (uint)p.WaveShape;

                if (p.SustainTime < 0.01)
                    p.SustainTime = 0.01f;

                float totalTime = p.AttackTime + p.SustainTime + p.DecayTime;
                if (totalTime < 0.18f) {
                    float multiplier = 0.18f / totalTime;
                    p.AttackTime *= multiplier;
                    p.SustainTime *= multiplier;
                    p.DecayTime *= multiplier;
                }

                _sustainPunch = p.SustainPunch;

                _phase = 0;

                _minFrequency = p.MinFrequency;

                _filters = p.LowPassFilterCutoff != 1.0 || p.HighPassFilterCutoff != 0.0;

                _lpFilterPos = 0.0f;
                _lpFilterDeltaPos = 0.0f;
                _lpFilterCutoff = p.LowPassFilterCutoff * p.LowPassFilterCutoff * p.LowPassFilterCutoff * 0.1f;
                _lpFilterDeltaCutoff = 1.0f + p.LowPassFilterCutoffSweep * 0.0001f;
                _lpFilterDamping = 5.0f / (1.0f + p.LowPassFilterResonance * p.LowPassFilterResonance * 20.0f) * (0.01f + _lpFilterCutoff);
                if (_lpFilterDamping > 0.8f)
                    _lpFilterDamping = 0.8f;
                _lpFilterDamping = 1.0f - _lpFilterDamping;
                _lpFilterOn = p.LowPassFilterCutoff != 1.0f;

                _hpFilterPos = 0.0f;
                _hpFilterCutoff = p.HighPassFilterCutoff * p.HighPassFilterCutoff * 0.1f;
                _hpFilterDeltaCutoff = 1.0f + p.HighPassFilterCutoffSweep * 0.0003f;

                _vibratoPhase = 0.0f;
                _vibratoSpeed = p.VibratoSpeed * p.VibratoSpeed * 0.01f;
                _vibratoAmplitude = p.VibratoDepth * 0.5f;

                _envelopeVolume = 0.0f;
                _envelopeStage = 0;
                _envelopeTime = 0;
                _envelopeLength0 = p.AttackTime * p.AttackTime * 100000.0f;
                _envelopeLength1 = p.SustainTime * p.SustainTime * 100000.0f;
                _envelopeLength2 = p.DecayTime * p.DecayTime * 100000.0f + 10f;
                _envelopeLength = _envelopeLength0;
                _envelopeFullLength = (uint)(_envelopeLength0 + _envelopeLength1 + _envelopeLength2);

                _envelopeOverLength0 = 1.0f / _envelopeLength0;
                _envelopeOverLength1 = 1.0f / _envelopeLength1;
                _envelopeOverLength2 = 1.0f / _envelopeLength2;

                _phaser = p.PhaserOffset != 0.0f || p.PhaserSweep != 0.0f;

                _phaserOffset = p.PhaserOffset * p.PhaserOffset * 1020.0f;
                if (p.PhaserOffset < 0.0f) _phaserOffset = -_phaserOffset;
                _phaserDeltaOffset = p.PhaserSweep * p.PhaserSweep * p.PhaserSweep * 0.2f;
                _phaserPos = 0;

                if (_phaserBuffer == null)
                    _phaserBuffer = new float[1024];
                if (_noiseBuffer == null)
                    _noiseBuffer = new float[32];

                uint i;
                for (i = 0; i < 1024; i++) _phaserBuffer[i] = 0.0f;
                for (i = 0; i < 32; i++) _noiseBuffer[i] = GetRandom.Float() * 2.0f - 1.0f;

                _repeatTime = 0;

                 _repeatLimit = Math.Abs(p.RepeatSpeed) < TOLERANCE
                     ? 0
                     : (int)((1.0 - p.RepeatSpeed) * (1.0 - p.RepeatSpeed) * 20000) + 32;
                }
            }
        
        
        private bool SynthWave(float[] buffer, uint __length)
        {            
            uint i, j, n;

            for (i = 0; i < __length; i++) {
                if (_finished)
                    return true;

                // Repeats every _repeatLimit times, partially resetting the sound parameters
                if (_repeatLimit != 0) {
                    if (++_repeatTime >= _repeatLimit) {
                        _repeatTime = 0;
                        Reset(false);
                    }
                }

                // If _changeLimit is reached, shifts the pitch
                if (_changeLimit != 0) {
                    if (++_changeTime >= _changeLimit) {
                        _changeLimit = 0;
                        _period *= _changeAmount;
                    }
                }

                // Acccelerate and apply slide
                _slide += _deltaSlide;
                _period *= _slide;

                // Checks for frequency getting too low, and stops the sound if a minFrequency was set
                if (_period > _maxPeriod) {
                    _period = _maxPeriod;
                    if (_minFrequency > 0)
                        _finished = true;
                }

                _periodTemp = _period;

                // Applies the vibrato effect
                if (_vibratoAmplitude > 0) {
                    _vibratoPhase += _vibratoSpeed;
                    _periodTemp = _period * (float)(1.0f + Math.Sin(_vibratoPhase) * _vibratoAmplitude);
                }

                _periodTemp = (int)_periodTemp;
                if (_periodTemp < 8)
                    _periodTemp = 8;

                // Sweeps the square duty
                if (_waveType == 0) {
                    _squareDuty += _dutySweep;
                    if (_squareDuty < 0.0) {
                        _squareDuty = 0.0f;
                    } else if (_squareDuty > 0.5) {
                        _squareDuty = 0.5f;
                    }
                }

                // Moves through the different stages of the volume envelope
                if (++_envelopeTime > _envelopeLength) {
                    _envelopeTime = 0;

                    switch (++_envelopeStage) {
                        case 1:
                            _envelopeLength = _envelopeLength1;
                            break;
                        case 2:
                            _envelopeLength = _envelopeLength2;
                            break;
                    }
                }

                // Sets the volume based on the position in the envelope
                switch (_envelopeStage) {
                    case 0:
                        _envelopeVolume = _envelopeTime * _envelopeOverLength0;
                        break;
                    case 1:
                        _envelopeVolume = 1.0f + (1.0f - _envelopeTime * _envelopeOverLength1) * 2.0f * _sustainPunch;
                        break;
                    case 2:
                        _envelopeVolume = 1.0f - _envelopeTime * _envelopeOverLength2;
                        break;
                    case 3:
                        _envelopeVolume = 0.0f;
                        _finished = true;
                        break;
                }

                // Moves the phaser offset
                if (_phaser) {
                    _phaserOffset += _phaserDeltaOffset;
                    _phaserInt = (int)_phaserOffset;
                    if (_phaserInt < 0) {
                        _phaserInt = -_phaserInt;
                    } else if (_phaserInt > 1023) {
                        _phaserInt = 1023;
                    }
                }

                // Moves the high-pass filter cutoff
                if (_filters && _hpFilterDeltaCutoff != 0) {
                    _hpFilterCutoff *= _hpFilterDeltaCutoff;
                    if (_hpFilterCutoff < 0.00001f) {
                        _hpFilterCutoff = 0.00001f;
                    } else if (_hpFilterCutoff > 0.1f) {
                        _hpFilterCutoff = 0.1f;
                    }
                }

                _superSample = 0;
                for (j = 0; j < 8; j++) {
                    // Cycles through the period
                    _phase++;
                    if (_phase >= _periodTemp) {
                        _phase = _phase % (int)_periodTemp;

                        // Generates new random noise for this period
                        if (_waveType == 3) {
                            for (n = 0; n < 32; n++)
                                _noiseBuffer[n] = GetRandom.Float() * 2.0f - 1.0f;
                        }
                    }

                    // Gets the sample from the oscillator
                    switch (_waveType) {
                        case 0: // Square wave
                            _sample = ((_phase / _periodTemp) < _squareDuty) ? 0.5f : -0.5f;
                            break;
                        case 1: // Saw wave
                            _sample = 1.0f - (_phase / _periodTemp) * 2.0f;
                            break;
                        case 2: // Sine wave (fast and accurate approx) {
                            _pos = _phase / _periodTemp;
                            _pos = _pos > 0.5f ? (_pos - 1.0f) * 6.28318531f : _pos * 6.28318531f;
                            _sample = _pos < 0 ? 1.27323954f * _pos + 0.405284735f * _pos * _pos : 1.27323954f * _pos - 0.405284735f * _pos * _pos;
                            _sample = _sample < 0 ? 0.225f * (_sample * -_sample - _sample) + _sample : 0.225f * (_sample * _sample - _sample) + _sample;
                            break;
                        case 3: // Noise
                            _sample = _noiseBuffer[(uint)(_phase * 32 / (int)_periodTemp)];
                            break;
                    }

                    // Applies the low and high pass filters
                    if (_filters) {
                        _lpFilterOldPos = _lpFilterPos;
                        _lpFilterCutoff *= _lpFilterDeltaCutoff;
                        if (_lpFilterCutoff < 0.0) {
                            _lpFilterCutoff = 0.0f;
                        } else if (_lpFilterCutoff > 0.1) {
                            _lpFilterCutoff = 0.1f;
                        }

                        if (_lpFilterOn) {
                            _lpFilterDeltaPos += (_sample - _lpFilterPos) * _lpFilterCutoff;
                            _lpFilterDeltaPos *= _lpFilterDamping;
                        } else {
                            _lpFilterPos = _sample;
                            _lpFilterDeltaPos = 0.0f;
                        }

                        _lpFilterPos += _lpFilterDeltaPos;

                        _hpFilterPos += _lpFilterPos - _lpFilterOldPos;
                        _hpFilterPos *= 1.0f - _hpFilterCutoff;
                        _sample = _hpFilterPos;
                    }

                    // Applies the phaser effect
                    if (_phaser) {
                        _phaserBuffer[_phaserPos & 1023] = _sample;
                        _sample += _phaserBuffer[(_phaserPos - _phaserInt + 1024) & 1023];
                        _phaserPos = (_phaserPos + 1) & 1023;
                    }

                    _superSample += _sample;
                }

                // Averages out the super samples and applies volumes
                _superSample = _masterVolume * _envelopeVolume * _superSample * 0.125f;

                // Clipping if too loud
                if (_superSample < -1f) {
                    _superSample = -1f;
                } else if (_superSample > 1f) {
                    _superSample = 1f;
                }

                // Writes value to list, ignoring left/right sound channels (this is applied when filtering the audio later)
                buffer[i + __bufferPos] = _superSample;
            }

            return false;
        }       
    }
}

