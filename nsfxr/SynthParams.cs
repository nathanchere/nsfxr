using System;

namespace nsfxr
{
    public class SynthParams
    {
        public enum WaveShapeEnum
        {
            Square = 0,
            Saw = 1,
            Sin = 2,
            Noise = 3,
        }

        public SynthParams()
        {
            MasterVolume = 0.5f;
        }

        public WaveShapeEnum WaveShape { get; set; }
        /// <summary>
        /// 0 to 1
        /// </summary>
        public float MasterVolume { get; set; }

        /// <summary>
        /// Length of the volume envelope attack
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float AttackTime{ get; set; }

        /// <summary>
        /// Length of the volume envelope sustain
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _sustainTime{ get; set; }

        /// <summary>
        /// Tilts the sustain punch envelope for more 'punch'
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _sustainPunch{ get; set; }

        /// <summary>
        /// Length of the volume envelope decay / release
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _decayTime{ get; set; }

        /// <summary>
        /// Base note of the sound
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _startFrequency{ get; set; }

        /// <summary>
        /// If sliding, will start at this frequency to prevent really low notes
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _minFrequency{ get; set; }

        /// <summary>
        /// Slides the note up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float _slide{ get; set; }

        /// <summary>
        /// Accelerates the slide
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>ry>
        public float _deltaSlide{ get; set; }

        /// <summary>
        /// Strength of the vibrato effect
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _vibratoDepth{ get; set; }

        /// <summary>
        /// Speed/frequency of the vibrato effect
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _vibratoSpeed{ get; set; }

        /// <summary>
        /// Shift in note, either up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float _changeAmount{ get; set; }

        /// <summary>
        /// How fast the shift happens (only happens once)
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _changeSpeed{ get; set; }

        /// <summary>
        /// Ratio between the up and down states of the square wave; affects timbre
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _squareDuty{ get; set; }

        /// <summary>
        /// Sweeps the square duty up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float _dutySweep{ get; set; }

        /// <summary>
        /// Speed of the note repeating
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _repeatSpeed{ get; set; }

        /// <summary>
        /// Offsets a second copy of the wave by a small phase; affects timbre
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float _phaserOffset{ get; set; }

        /// <summary>
        /// Sweeps the phase up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float _phaserSweep{ get; set; }

        /// <summary>
        /// Low pass filter frequency
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _lpFilterCutoff{ get; set; }

        /// <summary>
        /// Sweeps the low pass filter up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float _lpFilterCutoffSweep{ get; set; }

        /// <summary>
        /// Changes attenuation rate of the LPF; affects timbre
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _lpFilterResonance{ get; set; }

        /// <summary>
        /// High pass filter frequency
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float _hpFilterCutoff{ get; set; }

        /// <summary>
        /// Sweeps the high pass filter up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float _hpFilterCutoffSweep{ get; set; }        

        public void Clean()
        {
            /*
             * Clamp mastervolume 0:1
             * 
             */
        }




        // ================================================================================================================
        // PUBLIC INTERFACE -----------------------------------------------------------------------------------------------
	
        // Generator methods

        /**
	 * Sets the parameters to generate a pickup/coin sound
	 */
        public void GeneratePickupCoin() {
            resetParams();

            _startFrequency = 0.4f + getRandom() * 0.5f;

            _sustainTime = getRandom() * 0.1f;
            _decayTime = 0.1f + getRandom() * 0.4f;
            _sustainPunch = 0.3f + getRandom() * 0.3f;

            if (getRandom() < 0.5f) {
                _changeSpeed = 0.5f + getRandom() * 0.2f;
                _changeAmount = 0.2f + getRandom() * 0.4f;
            }
        }

        /**
	 * Sets the parameters to generate a laser/shoot sound
	 */
        public void GenerateLaserShoot() {
            resetParams();

            _waveType = (uint)(getRandom() * 3);
            if (_waveType == 2 && getRandom() < 0.5f) _waveType = (uint)(getRandom() * 2f);

            _startFrequency = 0.5f + getRandom() * 0.5f;
            _minFrequency = _startFrequency - 0.2f - getRandom() * 0.6f;
            if (_minFrequency < 0.2f) _minFrequency = 0.2f;

            _slide = -0.15f - getRandom() * 0.2f;

            if (getRandom() < 0.33f) {
                _startFrequency = 0.3f + getRandom() * 0.6f;
                _minFrequency = getRandom() * 0.1f;
                _slide = -0.35f - getRandom() * 0.3f;
            }

            if (getRandom() < 0.5f) {
                _squareDuty = getRandom() * 0.5f;
                _dutySweep = getRandom() * 0.2f;
            } else {
                _squareDuty = 0.4f + getRandom() * 0.5f;
                _dutySweep =- getRandom() * 0.7f;
            }

            _sustainTime = 0.1f + getRandom() * 0.2f;
            _decayTime = getRandom() * 0.4f;
            if (getRandom() < 0.5f) _sustainPunch = getRandom() * 0.3f;

            if (getRandom() < 0.33f) {
                _phaserOffset = getRandom() * 0.2f;
                _phaserSweep = -getRandom() * 0.2f;
            }

            if (getRandom() < 0.5f) _hpFilterCutoff = getRandom() * 0.3f;
        }

        /**
	 * Sets the parameters to generate an explosion sound
	 */
        public void GenerateExplosion() {
            resetParams();
            _waveType = 3;

            if (getRandom() < 0.5f) {
                _startFrequency = 0.1f + getRandom() * 0.4f;
                _slide = -0.1f + getRandom() * 0.4f;
            } else {
                _startFrequency = 0.2f + getRandom() * 0.7f;
                _slide = -0.2f - getRandom() * 0.2f;
            }

            _startFrequency *= _startFrequency;

            if (getRandom() < 0.2f) _slide = 0.0f;
            if (getRandom() < 0.33f) _repeatSpeed = 0.3f + getRandom() * 0.5f;

            _sustainTime = 0.1f + getRandom() * 0.3f;
            _decayTime = getRandom() * 0.5f;
            _sustainPunch = 0.2f + getRandom() * 0.6f;

            if (getRandom() < 0.5f) {
                _phaserOffset = -0.3f + getRandom() * 0.9f;
                _phaserSweep = -getRandom() * 0.3f;
            }

            if (getRandom() < 0.33f) {
                _changeSpeed = 0.6f + getRandom() * 0.3f;
                _changeAmount = 0.8f - getRandom() * 1.6f;
            }
        }

        /**
	 * Sets the parameters to generate a powerup sound
	 */
        public void GeneratePowerup() {
            resetParams();

            if (getRandom() < 0.5f) {
                _waveType = 1;
            } else {
                _squareDuty = getRandom() * 0.6f;
            }

            if (getRandom() < 0.5f) {
                _startFrequency = 0.2f + getRandom() * 0.3f;
                _slide = 0.1f + getRandom() * 0.4f;
                _repeatSpeed = 0.4f + getRandom() * 0.4f;
            } else {
                _startFrequency = 0.2f + getRandom() * 0.3f;
                _slide = 0.05f + getRandom() * 0.2f;

                if (getRandom() < 0.5f) {
                    _vibratoDepth = getRandom() * 0.7f;
                    _vibratoSpeed = getRandom() * 0.6f;
                }
            }

            _sustainTime = getRandom() * 0.4f;
            _decayTime = 0.1f + getRandom() * 0.4f;
        }

        /**
	 * Sets the parameters to generate a hit/hurt sound
	 */
        public void GenerateHitHurt() {
            resetParams();

            _waveType = (uint)(getRandom() * 3f);
            if (_waveType == 2) {
                _waveType = 3;
            } else if (_waveType == 0) {
                _squareDuty = getRandom() * 0.6f;
            }

            _startFrequency = 0.2f + getRandom() * 0.6f;
            _slide = -0.3f - getRandom() * 0.4f;

            _sustainTime = getRandom() * 0.1f;
            _decayTime = 0.1f + getRandom() * 0.2f;

            if (getRandom() < 0.5f) _hpFilterCutoff = getRandom() * 0.3f;
        }

        /**
	 * Sets the parameters to generate a jump sound
	 */
        public void GenerateJump() {
            resetParams();

            _waveType = 0;
            _squareDuty = getRandom() * 0.6f;
            _startFrequency = 0.3f + getRandom() * 0.3f;
            _slide = 0.1f + getRandom() * 0.2f;

            _sustainTime = 0.1f + getRandom() * 0.3f;
            _decayTime = 0.1f + getRandom() * 0.2f;

            if (getRandom() < 0.5f) _hpFilterCutoff = getRandom() * 0.3f;
            if (getRandom() < 0.5f) _lpFilterCutoff = 1.0f - getRandom() * 0.6f;
        }

        /**
	 * Sets the parameters to generate a blip/select sound
	 */
        public void GenerateBlipSelect() {
            resetParams();

            _waveType = (uint)(getRandom() * 2f);
            if (_waveType == 0) _squareDuty = getRandom() * 0.6f;

            _startFrequency = 0.2f + getRandom() * 0.4f;

            _sustainTime = 0.1f + getRandom() * 0.1f;
            _decayTime = getRandom() * 0.2f;
            _hpFilterCutoff = 0.1f;
        }

        /**
	 * Resets the parameters, used at the start of each generate function
	 */
        protected void resetParams() {
            paramsDirty = true;

            _waveType = 0;
            _startFrequency = 0.3f;
            _minFrequency = 0.0f;
            _slide = 0.0f;
            _deltaSlide = 0.0f;
            _squareDuty = 0.0f;
            _dutySweep = 0.0f;

            _vibratoDepth = 0.0f;
            _vibratoSpeed = 0.0f;

            _attackTime = 0.0f;
            _sustainTime = 0.3f;
            _decayTime = 0.4f;
            _sustainPunch = 0.0f;

            _lpFilterResonance = 0.0f;
            _lpFilterCutoff = 1.0f;
            _lpFilterCutoffSweep = 0.0f;
            _hpFilterCutoff = 0.0f;
            _hpFilterCutoffSweep = 0.0f;

            _phaserOffset = 0.0f;
            _phaserSweep = 0.0f;

            _repeatSpeed = 0.0f;

            _changeSpeed = 0.0f;
            _changeAmount = 0.0f;
        }

	
        // Randomization methods

        /**
	 * Randomly adjusts the parameters ever so slightly
	 */
        public void Mutate(float __mutation = 0.05f) {
            if (getRandom() < 0.5f) startFrequency += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) minFrequency += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) slide += 				getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) deltaSlide += 			getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) squareDuty += 			getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) dutySweep += 			getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) vibratoDepth += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) vibratoSpeed += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) attackTime += 			getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) sustainTime += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) decayTime += 			getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) sustainPunch += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) lpFilterCutoff += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) lpFilterCutoffSweep += getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) lpFilterResonance += 	getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) hpFilterCutoff += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) hpFilterCutoffSweep += getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) phaserOffset += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) phaserSweep += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) repeatSpeed += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) changeSpeed += 		getRandom() * __mutation * 2f - __mutation;
            if (getRandom() < 0.5f) changeAmount += 		getRandom() * __mutation * 2f - __mutation;
        }

        /**
	 * Sets all parameters to random values
	 */
        public void Randomize() {
            paramsDirty = true;

            _waveType = (uint)(getRandom() * 4f);

            _attackTime =  		Pow(getRandom()*2f-1f, 4);
            _sustainTime =  	Pow(getRandom()*2f-1f, 2);
            _sustainPunch =  	Pow(getRandom()*0.8f, 2);
            _decayTime =  		getRandom();

            _startFrequency =  	(getRandom() < 0.5f) ? Pow(getRandom()*2f-1f, 2) : (Pow(getRandom() * 0.5f, 3) + 0.5f);
            _minFrequency =  	0.0f;

            _slide =  			Pow(getRandom()*2f-1f, 5);
            _deltaSlide =  		Pow(getRandom()*2f-1f, 3);

            _vibratoDepth =  	Pow(getRandom()*2f-1f, 3);
            _vibratoSpeed =  	getRandom()*2f-1f;

            _changeAmount =  	getRandom()*2f-1f;
            _changeSpeed =  	getRandom()*2f-1f;

            _squareDuty =  		getRandom()*2f-1f;
            _dutySweep =  		Pow(getRandom()*2f-1f, 3);

            _repeatSpeed =  	getRandom()*2f-1f;

            _phaserOffset =  	Pow(getRandom()*2f-1f, 3);
            _phaserSweep =  	Pow(getRandom()*2f-1f, 3);

            _lpFilterCutoff =  		1f - Pow(getRandom(), 3);
            _lpFilterCutoffSweep = 	Pow(getRandom()*2f-1f, 3);
            _lpFilterResonance =  	getRandom()*2f-1f;

            _hpFilterCutoff =  		Pow(getRandom(), 5);
            _hpFilterCutoffSweep = 	Pow(getRandom()*2f-1f, 5);

            if (_attackTime + _sustainTime + _decayTime < 0.2f) {
                _sustainTime = 0.2f + getRandom() * 0.3f;
                _decayTime = 0.2f + getRandom() * 0.3f;
            }

            if ((_startFrequency > 0.7f && _slide > 0.2) || (_startFrequency < 0.2 && _slide < -0.05)) {
                _slide = -_slide;
            }

            if (_lpFilterCutoff < 0.1f && _lpFilterCutoffSweep < -0.05f) {
                _lpFilterCutoffSweep = -_lpFilterCutoffSweep;
            }
        }
     
        public string GetSettingsString() {
            string str = waveType.ToString();
            str += "," + To4DP(_attackTime) + 			"," + To4DP(_sustainTime)
                   + "," + To4DP(_sustainPunch) + 			"," + To4DP(_decayTime)
                   + "," + To4DP(_startFrequency) + 		"," + To4DP(_minFrequency)
                   + "," + To4DP(_slide) + 				"," + To4DP(_deltaSlide)
                   + "," + To4DP(_vibratoDepth) + 			"," + To4DP(_vibratoSpeed)
                   + "," + To4DP(_changeAmount) + 			"," + To4DP(_changeSpeed)
                   + "," + To4DP(_squareDuty) + 			"," + To4DP(_dutySweep)
                   + "," + To4DP(_repeatSpeed) + 			"," + To4DP(_phaserOffset)
                   + "," + To4DP(_phaserSweep) + 			"," + To4DP(_lpFilterCutoff)
                   + "," + To4DP(_lpFilterCutoffSweep) + 	"," + To4DP(_lpFilterResonance)
                   + "," + To4DP(_hpFilterCutoff)+ 		"," + To4DP(_hpFilterCutoffSweep)
                   + "," + To4DP(_masterVolume);

            return str;
        }
        
        public bool SetSettingsString(string __string) {
            string[] values = __string.Split(new char[] { ',' });

            if (values.Length != 24) return false;

            waveType = 				UInt32.Parse(values[0]);
            attackTime =  			float.Parse(values[1]);
            sustainTime =  			float.Parse(values[2]);
            sustainPunch =  		float.Parse(values[3]);
            decayTime =  			float.Parse(values[4]);
            startFrequency =  		float.Parse(values[5]);
            minFrequency =  		float.Parse(values[6]);
            slide =  				float.Parse(values[7]);
            deltaSlide =  			float.Parse(values[8]);
            vibratoDepth =  		float.Parse(values[9]);
            vibratoSpeed =  		float.Parse(values[10]);
            changeAmount =  		float.Parse(values[11]);
            changeSpeed =  			float.Parse(values[12]);
            squareDuty =  			float.Parse(values[13]);
            dutySweep =  			float.Parse(values[14]);
            repeatSpeed =  			float.Parse(values[15]);
            phaserOffset =  		float.Parse(values[16]);
            phaserSweep =  			float.Parse(values[17]);
            lpFilterCutoff =  		float.Parse(values[18]);
            lpFilterCutoffSweep =	float.Parse(values[19]);
            lpFilterResonance =  	float.Parse(values[20]);
            hpFilterCutoff =  		float.Parse(values[21]);
            hpFilterCutoffSweep =	float.Parse(values[22]);
            masterVolume = 			float.Parse(values[23]);

            return true;
        }


        // Copying methods

        /**
	 * Returns a copy of this SfxrParams with all settings duplicated
	 * @return	A copy of this SfxrParams
	 */
        public SynthParams Clone() {
            SynthParams outp = new SynthParams();
            outp.CopyFrom(this);

            return outp;
        }

        /**
	 * Copies parameters from another instance
	 * @param	params	Instance to copy parameters from
	 */
        public void CopyFrom(SynthParams __params, bool __makeDirty = false) {
            _waveType = 			__params.waveType;
            _attackTime =           __params.attackTime;
            _sustainTime =          __params.sustainTime;
            _sustainPunch =         __params.sustainPunch;
            _decayTime =			__params.decayTime;
            _startFrequency = 		__params.startFrequency;
            _minFrequency = 		__params.minFrequency;
            _slide = 				__params.slide;
            _deltaSlide = 			__params.deltaSlide;
            _vibratoDepth = 		__params.vibratoDepth;
            _vibratoSpeed = 		__params.vibratoSpeed;
            _changeAmount = 		__params.changeAmount;
            _changeSpeed = 			__params.changeSpeed;
            _squareDuty = 			__params.squareDuty;
            _dutySweep = 			__params.dutySweep;
            _repeatSpeed = 			__params.repeatSpeed;
            _phaserOffset = 		__params.phaserOffset;
            _phaserSweep = 			__params.phaserSweep;
            _lpFilterCutoff = 		__params.lpFilterCutoff;
            _lpFilterCutoffSweep = 	__params.lpFilterCutoffSweep;
            _lpFilterResonance = 	__params.lpFilterResonance;
            _hpFilterCutoff = 		__params.hpFilterCutoff;
            _hpFilterCutoffSweep = 	__params.hpFilterCutoffSweep;
            _masterVolume = 		__params.masterVolume;

            if (__makeDirty) paramsDirty = true;
        }


        // Utility methods

        /**
	 * Clams a value to betwen 0 and 1
	 * @param	value	Input value
	 * @return			The value clamped between 0 and 1
	 */
        private float Clamp1(float value) {
            return (value > 1f) ? 1f : ((value < 0f) ? 0f : value);
        }

        /**
	 * Clams a value to betwen -1 and 1
	 * @param	value	Input value
	 * @return			The value clamped between -1 and 1
	 */
        private float Clamp2(float value) {
            return (value > 1f) ? 1f : ((value < -1f) ? -1f : value);
        }

        /**
	 * Quick power function
	 * @param	base		Base to raise to power
	 * @param	power		Power to raise base by
	 * @return				The calculated power
	 */
        private float Pow(float __pbase, int __power) {
            switch(__power) {
                case 2: return __pbase * __pbase;
                case 3: return __pbase * __pbase * __pbase;
                case 4: return __pbase * __pbase * __pbase * __pbase;
                case 5: return __pbase * __pbase * __pbase * __pbase * __pbase;
            }

            return 1f;
        }

        private string To4DP(float __value) {
            if (__value < 0.0001f && __value > -0.0001f) return "";
            return __value.ToString("#.####");
        }

        private float getRandom() {
            return (float)(_random.NextDouble());
        }

        private Random _random = new Random();
    }
}