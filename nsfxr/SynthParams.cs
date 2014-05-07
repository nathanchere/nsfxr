using System;
using System.Text;

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
            Reset();
        }

        public WaveShapeEnum WaveShape
        {
            get;
            set;
        }
        /// <summary>
        /// 0 to 1
        /// </summary>
        public float MasterVolume
        {
            get;
            set;
        }

        /// <summary>
        /// Length of the volume envelope attack
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float AttackTime
        {
            get;
            set;
        }

        /// <summary>
        /// Length of the volume envelope sustain
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float SustainTime
        {
            get;
            set;
        }

        /// <summary>
        /// Tilts the sustain punch envelope for more 'punch'
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float SustainPunch
        {
            get;
            set;
        }

        /// <summary>
        /// Length of the volume envelope decay / release
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float DecayTime
        {
            get;
            set;
        }

        /// <summary>
        /// Base note of the sound
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float StartFrequency
        {
            get;
            set;
        }

        /// <summary>
        /// If sliding, will start at this frequency to prevent really low notes
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float MinFrequency
        {
            get;
            set;
        }

        /// <summary>
        /// Slides the note up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float Slide
        {
            get;
            set;
        }

        /// <summary>
        /// Accelerates the slide
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>ry>
        public float DeltaSlide
        {
            get;
            set;
        }

        /// <summary>
        /// Strength of the vibrato effect
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float VibratoDepth
        {
            get;
            set;
        }

        /// <summary>
        /// Speed/frequency of the vibrato effect
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float VibratoSpeed
        {
            get;
            set;
        }

        /// <summary>
        /// Shift in note, either up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float ChangeAmount
        {
            get;
            set;
        }

        /// <summary>
        /// How fast the shift happens (only happens once)
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float ChangeSpeed
        {
            get;
            set;
        }

        /// <summary>
        /// Ratio between the up and down states of the square wave; affects timbre
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float SquareDuty
        {
            get;
            set;
        }

        /// <summary>
        /// Sweeps the square duty up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float DutySweep
        {
            get;
            set;
        }

        /// <summary>
        /// Speed of the note repeating
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float RepeatSpeed
        {
            get;
            set;
        }

        /// <summary>
        /// Offsets a second copy of the wave by a small phase; affects timbre
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float PhaserOffset
        {
            get;
            set;
        }

        /// <summary>
        /// Sweeps the phase up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float PhaserSweep
        {
            get;
            set;
        }

        /// <summary>
        /// Low pass filter frequency
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float LowPassFilterCutoff
        {
            get;
            set;
        }

        /// <summary>
        /// Sweeps the low pass filter up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float LowPassFilterCutoffSweep
        {
            get;
            set;
        }

        /// <summary>
        /// Changes attenuation rate of the LPF; affects timbre
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float LowPassFilterResonance
        {
            get;
            set;
        }

        /// <summary>
        /// High pass filter frequency
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float HighPassFilterCutoff
        {
            get;
            set;
        }

        /// <summary>
        /// Sweeps the high pass filter up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float HighPassFilterCutoffSweep
        {
            get;
            set;
        }

        public void Clean()
        {
            /*
             * Clamp mastervolume 0:1
             * 
             */
        }
        #region presets
        public void GeneratePickupCoin()
        {
            Reset();

            StartFrequency = 0.4f + getRandom() * 0.5f;

            SustainTime = getRandom() * 0.1f;
            DecayTime = 0.1f + getRandom() * 0.4f;
            SustainPunch = 0.3f + getRandom() * 0.3f;

            if (getRandom() < 0.5f) {
                ChangeSpeed = 0.5f + getRandom() * 0.2f;
                ChangeAmount = 0.2f + getRandom() * 0.4f;
            }
        }

        /**
	 * Sets the parameters to generate a laser/shoot sound
	 */
        public void GenerateLaserShoot()
        {
            Reset();

            WaveShape = (WaveShapeEnum)(getRandom() * 3);
            if (WaveShape == WaveShapeEnum.Sin && getRandom() < 0.5f)
                WaveShape = (WaveShapeEnum)(getRandom() * 2f);

            StartFrequency = 0.5f + getRandom() * 0.5f;
            MinFrequency = StartFrequency - 0.2f - getRandom() * 0.6f;
            if (MinFrequency < 0.2f)
                MinFrequency = 0.2f;

            Slide = -0.15f - getRandom() * 0.2f;

            if (getRandom() < 0.33f) {
                StartFrequency = 0.3f + getRandom() * 0.6f;
                MinFrequency = getRandom() * 0.1f;
                Slide = -0.35f - getRandom() * 0.3f;
            }

            if (getRandom() < 0.5f) {
                SquareDuty = getRandom() * 0.5f;
                DutySweep = getRandom() * 0.2f;
            } else {
                SquareDuty = 0.4f + getRandom() * 0.5f;
                DutySweep = -getRandom() * 0.7f;
            }

            SustainTime = 0.1f + getRandom() * 0.2f;
            DecayTime = getRandom() * 0.4f;
            if (getRandom() < 0.5f)
                SustainPunch = getRandom() * 0.3f;

            if (getRandom() < 0.33f) {
                PhaserOffset = getRandom() * 0.2f;
                PhaserSweep = -getRandom() * 0.2f;
            }

            if (getRandom() < 0.5f)
                HighPassFilterCutoff = getRandom() * 0.3f;
        }

        public void GenerateExplosion()
        {
            Reset();
            WaveShape = WaveShapeEnum.Noise;

            if (getRandom() < 0.5f) {
                StartFrequency = 0.1f + getRandom() * 0.4f;
                Slide = -0.1f + getRandom() * 0.4f;
            } else {
                StartFrequency = 0.2f + getRandom() * 0.7f;
                Slide = -0.2f - getRandom() * 0.2f;
            }

            StartFrequency *= StartFrequency;

            if (getRandom() < 0.2f)
                Slide = 0.0f;
            if (getRandom() < 0.33f)
                RepeatSpeed = 0.3f + getRandom() * 0.5f;

            SustainTime = 0.1f + getRandom() * 0.3f;
            DecayTime = getRandom() * 0.5f;
            SustainPunch = 0.2f + getRandom() * 0.6f;

            if (getRandom() < 0.5f) {
                PhaserOffset = -0.3f + getRandom() * 0.9f;
                PhaserSweep = -getRandom() * 0.3f;
            }

            if (getRandom() < 0.33f) {
                ChangeSpeed = 0.6f + getRandom() * 0.3f;
                ChangeAmount = 0.8f - getRandom() * 1.6f;
            }
        }

        public void GeneratePowerup()
        {
            Reset();

            if (getRandom() < 0.5f) {
                WaveShape = WaveShapeEnum.Saw;
            } else {
                SquareDuty = getRandom() * 0.6f;
            }

            if (getRandom() < 0.5f) {
                StartFrequency = 0.2f + getRandom() * 0.3f;
                Slide = 0.1f + getRandom() * 0.4f;
                RepeatSpeed = 0.4f + getRandom() * 0.4f;
            } else {
                StartFrequency = 0.2f + getRandom() * 0.3f;
                Slide = 0.05f + getRandom() * 0.2f;

                if (getRandom() < 0.5f) {
                    VibratoDepth = getRandom() * 0.7f;
                    VibratoSpeed = getRandom() * 0.6f;
                }
            }

            SustainTime = getRandom() * 0.4f;
            DecayTime = 0.1f + getRandom() * 0.4f;
        }

        public void GenerateHitHurt()
        {
            Reset();

            WaveShape = (WaveShapeEnum)(getRandom() * 3f);
            if (WaveShape == WaveShapeEnum.Sin)
                WaveShape = WaveShapeEnum.Noise;
            if (WaveShape == WaveShapeEnum.Square)
                SquareDuty = getRandom() * 0.6f;

            StartFrequency = 0.2f + getRandom() * 0.6f;
            Slide = -0.3f - getRandom() * 0.4f;

            SustainTime = getRandom() * 0.1f;
            DecayTime = 0.1f + getRandom() * 0.2f;

            if (getRandom() < 0.5f)
                HighPassFilterCutoff = getRandom() * 0.3f;
        }

        public void GenerateJump()
        {
            Reset();

            WaveShape = WaveShapeEnum.Square;
            SquareDuty = getRandom() * 0.6f;
            StartFrequency = 0.3f + getRandom() * 0.3f;
            Slide = 0.1f + getRandom() * 0.2f;

            SustainTime = 0.1f + getRandom() * 0.3f;
            DecayTime = 0.1f + getRandom() * 0.2f;

            if (getRandom() < 0.5f)
                HighPassFilterCutoff = getRandom() * 0.3f;
            if (getRandom() < 0.5f)
                LowPassFilterCutoff = 1.0f - getRandom() * 0.6f;
        }

        public void GenerateBlipSelect()
        {
            Reset();

            WaveShape = (WaveShapeEnum)(getRandom() * 2f);
            if (WaveShape == WaveShapeEnum.Square)
                SquareDuty = getRandom() * 0.6f;

            StartFrequency = 0.2f + getRandom() * 0.4f;

            SustainTime = 0.1f + getRandom() * 0.1f;
            DecayTime = getRandom() * 0.2f;
            HighPassFilterCutoff = 0.1f;
        }

        protected void Reset()
        {
            WaveShape = WaveShapeEnum.Square;
            StartFrequency = 0.3f;
            MinFrequency = 0.0f;
            Slide = 0.0f;
            DeltaSlide = 0.0f;
            SquareDuty = 0.0f;
            DutySweep = 0.0f;

            VibratoDepth = 0.0f;
            VibratoSpeed = 0.0f;

            AttackTime = 0.0f;
            SustainTime = 0.3f;
            DecayTime = 0.4f;
            SustainPunch = 0.0f;

            LowPassFilterResonance = 0.0f;
            LowPassFilterCutoff = 1.0f;
            LowPassFilterCutoffSweep = 0.0f;
            HighPassFilterCutoff = 0.0f;
            HighPassFilterCutoffSweep = 0.0f;

            PhaserOffset = 0.0f;
            PhaserSweep = 0.0f;

            RepeatSpeed = 0.0f;

            ChangeSpeed = 0.0f;
            ChangeAmount = 0.0f;
        }
        #endregion

        public void Mutate(float mutation = 0.05f)
        {
            if (getRandom() < 0.5f)
                StartFrequency += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                MinFrequency += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                Slide += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                DeltaSlide += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                SquareDuty += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                DutySweep += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                VibratoDepth += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                VibratoSpeed += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                AttackTime += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                SustainTime += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                DecayTime += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                SustainPunch += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                LowPassFilterCutoff += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                LowPassFilterCutoffSweep += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                LowPassFilterResonance += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                HighPassFilterCutoff += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                HighPassFilterCutoffSweep += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                PhaserOffset += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                PhaserSweep += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                RepeatSpeed += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                ChangeSpeed += getRandom() * mutation * 2f - mutation;
            if (getRandom() < 0.5f)
                ChangeAmount += getRandom() * mutation * 2f - mutation;
        }

        /**
	 * Sets all parameters to random values
	 */
        public void Randomize()
        {
            WaveShape = (WaveShapeEnum)(getRandom() * 4f);

            AttackTime = Pow(getRandom() * 2f - 1f, 4);
            SustainTime = Pow(getRandom() * 2f - 1f, 2);
            SustainPunch = Pow(getRandom() * 0.8f, 2);
            DecayTime = getRandom();

            StartFrequency = (getRandom() < 0.5f) ? Pow(getRandom() * 2f - 1f, 2) : (Pow(getRandom() * 0.5f, 3) + 0.5f);
            MinFrequency = 0.0f;

            Slide = Pow(getRandom() * 2f - 1f, 5);
            DeltaSlide = Pow(getRandom() * 2f - 1f, 3);

            VibratoDepth = Pow(getRandom() * 2f - 1f, 3);
            VibratoSpeed = getRandom() * 2f - 1f;

            ChangeAmount = getRandom() * 2f - 1f;
            ChangeSpeed = getRandom() * 2f - 1f;

            SquareDuty = getRandom() * 2f - 1f;
            DutySweep = Pow(getRandom() * 2f - 1f, 3);

            RepeatSpeed = getRandom() * 2f - 1f;

            PhaserOffset = Pow(getRandom() * 2f - 1f, 3);
            PhaserSweep = Pow(getRandom() * 2f - 1f, 3);

            LowPassFilterCutoff = 1f - Pow(getRandom(), 3);
            LowPassFilterCutoffSweep = Pow(getRandom() * 2f - 1f, 3);
            LowPassFilterResonance = getRandom() * 2f - 1f;

            HighPassFilterCutoff = Pow(getRandom(), 5);
            HighPassFilterCutoffSweep = Pow(getRandom() * 2f - 1f, 5);

            if (AttackTime + SustainTime + DecayTime < 0.2f) {
                SustainTime = 0.2f + getRandom() * 0.3f;
                DecayTime = 0.2f + getRandom() * 0.3f;
            }

            if ((StartFrequency > 0.7f && Slide > 0.2) || (StartFrequency < 0.2 && Slide < -0.05)) {
                Slide = -Slide;
            }

            if (LowPassFilterCutoff < 0.1f && LowPassFilterCutoffSweep < -0.05f) {
                LowPassFilterCutoffSweep = -LowPassFilterCutoffSweep;
            }
        }

        // Copying methods

        /**
	 * Returns a copy of this SfxrParams with all settings duplicated
	 * @return	A copy of this SfxrParams
	 */
        public SynthParams Clone()
        {
            SynthParams outp = new SynthParams();
            outp.CopyFrom(this);

            return outp;
        }

        /**
	 * Copies parameters from another instance
	 * @param	params	Instance to copy parameters from
	 */
        public void CopyFrom(SynthParams __params, bool __makeDirty = false)
        {
            _waveType = __params.waveType;
            _attackTime = __params.attackTime;
            _sustainTime = __params.sustainTime;
            _sustainPunch = __params.sustainPunch;
            _decayTime = __params.decayTime;
            _startFrequency = __params.startFrequency;
            _minFrequency = __params.minFrequency;
            _slide = __params.slide;
            _deltaSlide = __params.deltaSlide;
            _vibratoDepth = __params.vibratoDepth;
            _vibratoSpeed = __params.vibratoSpeed;
            _changeAmount = __params.changeAmount;
            _changeSpeed = __params.changeSpeed;
            _squareDuty = __params.squareDuty;
            _dutySweep = __params.dutySweep;
            _repeatSpeed = __params.repeatSpeed;
            _phaserOffset = __params.phaserOffset;
            _phaserSweep = __params.phaserSweep;
            _lpFilterCutoff = __params.lpFilterCutoff;
            _lpFilterCutoffSweep = __params.lpFilterCutoffSweep;
            _lpFilterResonance = __params.lpFilterResonance;
            _hpFilterCutoff = __params.hpFilterCutoff;
            _hpFilterCutoffSweep = __params.hpFilterCutoffSweep;
            _masterVolume = __params.masterVolume;

            if (__makeDirty)
                paramsDirty = true;
        }


        // Utility methods

        /**
	 * Clams a value to betwen 0 and 1
	 * @param	value	Input value
	 * @return			The value clamped between 0 and 1
	 */
        private float Clamp1(float value)
        {
            return (value > 1f) ? 1f : ((value < 0f) ? 0f : value);
        }

        /**
	 * Clams a value to betwen -1 and 1
	 * @param	value	Input value
	 * @return			The value clamped between -1 and 1
	 */
        private float Clamp2(float value)
        {
            return (value > 1f) ? 1f : ((value < -1f) ? -1f : value);
        }

        /**
	 * Quick power function
	 * @param	base		Base to raise to power
	 * @param	power		Power to raise base by
	 * @return				The calculated power
	 */
        private float Pow(float __pbase, int __power)
        {
            switch (__power) {
                case 2:
                    return __pbase * __pbase;
                case 3:
                    return __pbase * __pbase * __pbase;
                case 4:
                    return __pbase * __pbase * __pbase * __pbase;
                case 5:
                    return __pbase * __pbase * __pbase * __pbase * __pbase;
            }

            return 1f;
        }

        private string To4DP(float __value)
        {
            if (__value < 0.0001f && __value > -0.0001f)
                return "";
            return __value.ToString("#.####");
        }

        private float getRandom()
        {
            return (float)(_random.NextDouble());
        }

        private Random _random = new Random();


        public string Serialize(SynthParams input)
        {
            var result = new StringBuilder();
            result.Append((int)input.WaveShape);
            result.Append(",");
            result.Append(AttackTime.ToString("0.0000"));
            result.Append(",");
            result.Append(SustainTime.ToString("0.0000"));
            result.Append(",");
            result.Append(SustainPunch.ToString("0.0000"));
            result.Append(",");
            result.Append(DecayTime.ToString("0.0000"));
            result.Append(",");
            result.Append(StartFrequency.ToString("0.0000"));
            result.Append(",");
            result.Append(MinFrequency.ToString("0.0000"));
            result.Append(",");
            result.Append(Slide.ToString("0.0000"));
            result.Append(",");
            result.Append(DeltaSlide.ToString("0.0000"));
            result.Append(",");
            result.Append(VibratoDepth.ToString("0.0000"));
            result.Append(",");
            result.Append(VibratoSpeed.ToString("0.0000"));
            result.Append(",");
            result.Append(ChangeAmount.ToString("0.0000"));
            result.Append(",");
            result.Append(ChangeSpeed.ToString("0.0000"));
            result.Append(",");
            result.Append(SquareDuty.ToString("0.0000"));
            result.Append(",");
            result.Append(DutySweep.ToString("0.0000"));
            result.Append(",");
            result.Append(RepeatSpeed.ToString("0.0000"));
            result.Append(",");
            result.Append(PhaserOffset.ToString("0.0000"));
            result.Append(",");
            result.Append(PhaserSweep.ToString("0.0000"));
            result.Append(",");
            result.Append(LowPassFilterCutoff.ToString("0.0000"));
            result.Append(",");
            result.Append(LowPassFilterCutoffSweep.ToString("0.0000"));
            result.Append(",");
            result.Append(LowPassFilterResonance.ToString("0.0000"));
            result.Append(",");
            result.Append(HighPassFilterCutoff.ToString("0.0000"));
            result.Append(",");
            result.Append(HighPassFilterCutoffSweep.ToString("0.0000"));
            result.Append(",");
            result.Append(MasterVolume.ToString("0.0000"));

            return result.ToString();
        }

        public static SynthParams Deserialize(string input)
        {
            var values = input.Split(new[] { ',' });

            if (values.Length != 24) return null;

            return new SynthParams
            {
                WaveShape = (WaveShapeEnum)UInt32.Parse(values[0]),
                AttackTime = float.Parse(values[1]),
                SustainTime = float.Parse(values[2]),
                SustainPunch = float.Parse(values[3]),
                DecayTime = float.Parse(values[4]),
                StartFrequency = float.Parse(values[5]),
                MinFrequency = float.Parse(values[6]),
                Slide = float.Parse(values[7]),
                DeltaSlide = float.Parse(values[8]),
                VibratoDepth = float.Parse(values[9]),
                VibratoSpeed = float.Parse(values[10]),
                ChangeAmount = float.Parse(values[11]),
                ChangeSpeed = float.Parse(values[12]),
                SquareDuty = float.Parse(values[13]),
                DutySweep = float.Parse(values[14]),
                RepeatSpeed = float.Parse(values[15]),
                PhaserOffset = float.Parse(values[16]),
                PhaserSweep = float.Parse(values[17]),
                LowPassFilterCutoff = float.Parse(values[18]),
                LowPassFilterCutoffSweep = float.Parse(values[19]),
                LowPassFilterResonance = float.Parse(values[20]),
                HighPassFilterCutoff = float.Parse(values[21]),
                HighPassFilterCutoffSweep = float.Parse(values[22]),
                MasterVolume = float.Parse(values[23]),
            };
        }
    }
}