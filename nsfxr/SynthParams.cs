using System;
using System.Runtime.Serialization;
using System.Text;

namespace nsfxr
{
    public struct SynthParams
    {
        private static Random _random = new Random();

        public enum WaveShapeEnum
        {
            Square = 0,
            Saw = 1,
            Sin = 2,
            Noise = 3,
        }

          #region Properties
        public WaveShapeEnum WaveShape { get; set; }

        /// <summary>
        /// Master volume (ORLY?)
        /// </summary>
        /// /// <remarks>Valid range: 0 to 1</remarks>
        public float MasterVolume { get; set; }

        /// <summary>
        /// Length of the volume envelope attack
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float AttackTime { get; set; }

        /// <summary>
        /// Length of the volume envelope sustain
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float SustainTime { get; set; }

        /// <summary>
        /// Tilts the sustain punch envelope for more 'punch'
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float SustainPunch { get; set; }

        /// <summary>
        /// Length of the volume envelope decay / release
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float DecayTime { get; set; }

        /// <summary>
        /// Base note of the sound
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float StartFrequency { get; set; }

        /// <summary>
        /// If sliding, will start at this frequency to prevent really low notes
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float MinFrequency { get; set; }

        /// <summary>
        /// Slides the note up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float Slide { get; set; }

        /// <summary>
        /// Accelerates the slide
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>ry>
        public float DeltaSlide { get; set; }

        /// <summary>
        /// Strength of the vibrato effect
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float VibratoDepth { get; set; }

        /// <summary>
        /// Speed/frequency of the vibrato effect
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float VibratoSpeed { get; set; }

        /// <summary>
        /// Shift in note, either up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float ChangeAmount { get; set; }

        /// <summary>
        /// How fast the shift happens (only happens once)
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float ChangeSpeed { get; set; }

        /// <summary>
        /// Ratio between the up and down states of the square wave; affects timbre
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float SquareDuty { get; set; }

        /// <summary>
        /// Sweeps the square duty up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float DutySweep { get; set; }

        /// <summary>
        /// Speed of the note repeating
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float RepeatSpeed { get; set; }

        /// <summary>
        /// Offsets a second copy of the wave by a small phase; affects timbre
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float PhaserOffset { get; set; }

        /// <summary>
        /// Sweeps the phase up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float PhaserSweep { get; set; }

        /// <summary>
        /// Low pass filter frequency
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float LowPassFilterCutoff { get; set; }

        /// <summary>
        /// Sweeps the low pass filter up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float LowPassFilterCutoffSweep { get; set; }

        /// <summary>
        /// Changes attenuation rate of the LPF; affects timbre
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float LowPassFilterResonance { get; set; }

        /// <summary>
        /// High pass filter frequency
        /// </summary>
        /// <remarks>Valid range: 0 to 1</remarks>
        public float HighPassFilterCutoff { get; set; }

        /// <summary>
        /// Sweeps the high pass filter up or down
        /// </summary>
        /// <remarks>Valid range: -1 to 1</remarks>
        public float HighPassFilterCutoffSweep { get; set; }
        #endregion


        public static class Preset
        {
            public static SynthParams GenerateLaserShoot()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(getRandom() * 3);
                if (result.WaveShape == WaveShapeEnum.Sin && getRandom() < 0.5f)
                    result.WaveShape = (WaveShapeEnum)(getRandom() * 2f);

                result.StartFrequency = 0.5f + getRandom() * 0.5f;
                result.MinFrequency = result.StartFrequency - 0.2f - getRandom() * 0.6f;
                if (result.MinFrequency < 0.2f) result.MinFrequency = 0.2f;

                result.Slide = -0.15f - getRandom() * 0.2f;

                if (getRandom() < 0.33f) {
                    result.StartFrequency = 0.3f + getRandom() * 0.6f;
                    result.MinFrequency = getRandom() * 0.1f;
                    result.Slide = -0.35f - getRandom() * 0.3f;
                }

                if (getRandom() < 0.5f) {
                    result.SquareDuty = getRandom() * 0.5f;
                    result.DutySweep = getRandom() * 0.2f;
                } else {
                    result.SquareDuty = 0.4f + getRandom() * 0.5f;
                    result.DutySweep = -getRandom() * 0.7f;
                }

                result.SustainTime = 0.1f + getRandom() * 0.2f;
                result.DecayTime = getRandom() * 0.4f;
                if (getRandom() < 0.5f) result.SustainPunch = getRandom() * 0.3f;

                if (getRandom() < 0.33f) {
                    result.PhaserOffset = getRandom() * 0.2f;
                    result.PhaserSweep = -getRandom() * 0.2f;
                }

                if (getRandom() < 0.5f) result.HighPassFilterCutoff = getRandom() * 0.3f;

                return result;
            }

            public static SynthParams GenerateExplosion()
            {
                var result = new SynthParams();
                result.WaveShape = WaveShapeEnum.Noise;

                if (getRandom() < 0.5f) {
                    result.StartFrequency = 0.1f + getRandom() * 0.4f;
                    result.Slide = -0.1f + getRandom() * 0.4f;
                } else {
                    result.StartFrequency = 0.2f + getRandom() * 0.7f;
                    result.Slide = -0.2f - getRandom() * 0.2f;
                }

                result.StartFrequency *= result.StartFrequency;

                if (getRandom() < 0.2f) result.Slide = 0.0f;
                if (getRandom() < 0.33f) result.RepeatSpeed = 0.3f + getRandom() * 0.5f;

                result.SustainTime = 0.1f + getRandom() * 0.3f;
                result.DecayTime = getRandom() * 0.5f;
                result.SustainPunch = 0.2f + getRandom() * 0.6f;

                if (getRandom() < 0.5f) {
                    result.PhaserOffset = -0.3f + getRandom() * 0.9f;
                    result.PhaserSweep = -getRandom() * 0.3f;
                }

                if (getRandom() < 0.33f) {
                    result.ChangeSpeed = 0.6f + getRandom() * 0.3f;
                    result.ChangeAmount = 0.8f - getRandom() * 1.6f;
                }

                return result;
            }

            public static SynthParams GeneratePowerup()
            {
                var result = new SynthParams();

                if (getRandom() < 0.5f) {
                    result.WaveShape = WaveShapeEnum.Saw;
                } else {
                    result.SquareDuty = getRandom() * 0.6f;
                }

                if (getRandom() < 0.5f) {
                    result.StartFrequency = 0.2f + getRandom() * 0.3f;
                    result.Slide = 0.1f + getRandom() * 0.4f;
                    result.RepeatSpeed = 0.4f + getRandom() * 0.4f;
                } else {
                    result.StartFrequency = 0.2f + getRandom() * 0.3f;
                    result.Slide = 0.05f + getRandom() * 0.2f;

                    if (getRandom() < 0.5f) {
                        result.VibratoDepth = getRandom() * 0.7f;
                        result.VibratoSpeed = getRandom() * 0.6f;
                    }
                }

                result.SustainTime = getRandom() * 0.4f;
                result.DecayTime = 0.1f + getRandom() * 0.4f;

                return result;
            }

            public static SynthParams GenerateHitHurt()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(getRandom() * 3f);
                if (result.WaveShape == WaveShapeEnum.Sin) result.WaveShape = WaveShapeEnum.Noise;
                if (result.WaveShape == WaveShapeEnum.Square) result.SquareDuty = getRandom() * 0.6f;

                result.StartFrequency = 0.2f + getRandom() * 0.6f;
                result.Slide = -0.3f - getRandom() * 0.4f;

                result.SustainTime = getRandom() * 0.1f;
                result.DecayTime = 0.1f + getRandom() * 0.2f;

                if (getRandom() < 0.5f) result.HighPassFilterCutoff = getRandom() * 0.3f;

                return result;
            }

            public static SynthParams GenerateJump()
            {
                var result = new SynthParams();

                result.WaveShape = WaveShapeEnum.Square;
                result.SquareDuty = getRandom() * 0.6f;
                result.StartFrequency = 0.3f + getRandom() * 0.3f;
                result.Slide = 0.1f + getRandom() * 0.2f;

                result.SustainTime = 0.1f + getRandom() * 0.3f;
                result.DecayTime = 0.1f + getRandom() * 0.2f;

                if (getRandom() < 0.5f) result.HighPassFilterCutoff = getRandom() * 0.3f;
                if (getRandom() < 0.5f) result.LowPassFilterCutoff = 1.0f - getRandom() * 0.6f;

                return result;
            }

            public static SynthParams GenerateBlipSelect()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(getRandom() * 2f);
                if (result.WaveShape == WaveShapeEnum.Square)
                    result.SquareDuty = getRandom() * 0.6f;

                result.StartFrequency = 0.2f + getRandom() * 0.4f;

                result.SustainTime = 0.1f + getRandom() * 0.1f;
                result.DecayTime = getRandom() * 0.2f;
                result.HighPassFilterCutoff = 0.1f;

                return result;
            }

            public static SynthParams PickupCoin()
            {
                var result = new SynthParams();

                result.StartFrequency = 0.4f + getRandom() * 0.5f;

                result.SustainTime = getRandom() * 0.1f;
                result.DecayTime = 0.1f + getRandom() * 0.4f;
                result.SustainPunch = 0.3f + getRandom() * 0.3f;

                if (getRandom() < 0.5f) {
                    result.ChangeSpeed = 0.5f + getRandom() * 0.2f;
                    result.ChangeAmount = 0.2f + getRandom() * 0.4f;
                }

                return result;
            }

            public static SynthParams GenerateLaserShoot111136100()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(getRandom() * 3);
                if (result.WaveShape == WaveShapeEnum.Sin && getRandom() < 0.5f) result.WaveShape = (WaveShapeEnum)(getRandom() * 2f);

                result.StartFrequency = 0.5f + getRandom() * 0.5f;
                result.MinFrequency = result.StartFrequency - 0.2f - getRandom() * 0.6f;
                if (result.MinFrequency < 0.2f) result.MinFrequency = 0.2f;

                result.Slide = -0.15f - getRandom() * 0.2f;

                if (getRandom() < 0.33f) {
                    result.StartFrequency = 0.3f + getRandom() * 0.6f;
                    result.MinFrequency = getRandom() * 0.1f;
                    result.Slide = -0.35f - getRandom() * 0.3f;
                }

                if (getRandom() < 0.5f) {
                    result.SquareDuty = getRandom() * 0.5f;
                    result.DutySweep = getRandom() * 0.2f;
                } else {
                    result.SquareDuty = 0.4f + getRandom() * 0.5f;
                    result.DutySweep = -getRandom() * 0.7f;
                }

                result.SustainTime = 0.1f + getRandom() * 0.2f;
                result.DecayTime = getRandom() * 0.4f;
                if (getRandom() < 0.5f) result.SustainPunch = getRandom() * 0.3f;

                if (getRandom() < 0.33f) {
                    result.PhaserOffset = getRandom() * 0.2f;
                    result.PhaserSweep = -getRandom() * 0.2f;
                }

                if (getRandom() < 0.5f) result.HighPassFilterCutoff = getRandom() * 0.3f;

                return result;
            }

            public static SynthParams GenerateExplosion685407904()
            {
                var result = new SynthParams();
                result.WaveShape = WaveShapeEnum.Noise;

                if (getRandom() < 0.5f) {
                    result.StartFrequency = 0.1f + getRandom() * 0.4f;
                    result.Slide = -0.1f + getRandom() * 0.4f;
                } else {
                    result.StartFrequency = 0.2f + getRandom() * 0.7f;
                    result.Slide = -0.2f - getRandom() * 0.2f;
                }

                result.StartFrequency *= result.StartFrequency;

                if (getRandom() < 0.2f) result.Slide = 0.0f;
                if (getRandom() < 0.33f) result.RepeatSpeed = 0.3f + getRandom() * 0.5f;

                result.SustainTime = 0.1f + getRandom() * 0.3f;
                result.DecayTime = getRandom() * 0.5f;
                result.SustainPunch = 0.2f + getRandom() * 0.6f;

                if (getRandom() < 0.5f) {
                    result.PhaserOffset = -0.3f + getRandom() * 0.9f;
                    result.PhaserSweep = -getRandom() * 0.3f;
                }

                if (getRandom() < 0.33f) {
                    result.ChangeSpeed = 0.6f + getRandom() * 0.3f;
                    result.ChangeAmount = 0.8f - getRandom() * 1.6f;
                }

                return result;
            }

            public static SynthParams GeneratePowerup668022080()
            {
                var result = new SynthParams();

                if (getRandom() < 0.5f) {
                    result.WaveShape = WaveShapeEnum.Saw;
                } else {
                    result.SquareDuty = getRandom() * 0.6f;
                }

                if (getRandom() < 0.5f) {
                    result.StartFrequency = 0.2f + getRandom() * 0.3f;
                    result.Slide = 0.1f + getRandom() * 0.4f;
                    result.RepeatSpeed = 0.4f + getRandom() * 0.4f;
                } else {
                    result.StartFrequency = 0.2f + getRandom() * 0.3f;
                    result.Slide = 0.05f + getRandom() * 0.2f;

                    if (getRandom() < 0.5f) {
                        result.VibratoDepth = getRandom() * 0.7f;
                        result.VibratoSpeed = getRandom() * 0.6f;
                    }
                }

                result.SustainTime = getRandom() * 0.4f;
                result.DecayTime = 0.1f + getRandom() * 0.4f;

                return result;
            }

            public static SynthParams GenerateHitHurt827032743()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(getRandom() * 3f);
                if (result.WaveShape == WaveShapeEnum.Sin) result.WaveShape = WaveShapeEnum.Noise;
                if (result.WaveShape == WaveShapeEnum.Square) result.SquareDuty = getRandom() * 0.6f;

                result.StartFrequency = 0.2f + getRandom() * 0.6f;
                result.Slide = -0.3f - getRandom() * 0.4f;

                result.SustainTime = getRandom() * 0.1f;
                result.DecayTime = 0.1f + getRandom() * 0.2f;

                if (getRandom() < 0.5f) result.HighPassFilterCutoff = getRandom() * 0.3f;

                return result;
            }

            public static SynthParams GenerateJump1469841150()
            {
                var result = new SynthParams();

                result.WaveShape = WaveShapeEnum.Square;
                result.SquareDuty = getRandom() * 0.6f;
                result.StartFrequency = 0.3f + getRandom() * 0.3f;
                result.Slide = 0.1f + getRandom() * 0.2f;

                result.SustainTime = 0.1f + getRandom() * 0.3f;
                result.DecayTime = 0.1f + getRandom() * 0.2f;

                if (getRandom() < 0.5f) result.HighPassFilterCutoff = getRandom() * 0.3f;
                if (getRandom() < 0.5f) result.LowPassFilterCutoff = 1.0f - getRandom() * 0.6f;

                return result;
            }

            public static SynthParams GenerateBlipSelect1130259449()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(getRandom() * 2f);
                if (result.WaveShape == WaveShapeEnum.Square) result.SquareDuty = getRandom() * 0.6f;

                result.StartFrequency = 0.2f + getRandom() * 0.4f;

                result.SustainTime = 0.1f + getRandom() * 0.1f;
                result.DecayTime = getRandom() * 0.2f;
                result.HighPassFilterCutoff = 0.1f;

                return result;
            }

            private static float getRandom()
            {
                return (float)(_random.NextDouble());
            }
        }

        #region Helpers
        public void Reset()
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

        public void Randomize()
        {
            WaveShape = (WaveShapeEnum)(getRandom() * 4f);

            AttackTime = (float)Math.Pow(getRandom() * 2f - 1f, 4);
            SustainTime = (float)Math.Pow(getRandom() * 2f - 1f, 2);
            SustainPunch = (float)Math.Pow(getRandom() * 0.8f, 2);
            DecayTime = getRandom();

            StartFrequency = (getRandom() < 0.5f) ? (float)Math.Pow(getRandom() * 2f - 1f, 2) : ((float)Math.Pow(getRandom() * 0.5f, 3) + 0.5f);
            MinFrequency = 0.0f;

            Slide = (float)Math.Pow(getRandom() * 2f - 1f, 5);
            DeltaSlide = (float)Math.Pow(getRandom() * 2f - 1f, 3);

            VibratoDepth = (float)Math.Pow(getRandom() * 2f - 1f, 3);
            VibratoSpeed = getRandom() * 2f - 1f;

            ChangeAmount = getRandom() * 2f - 1f;
            ChangeSpeed = getRandom() * 2f - 1f;

            SquareDuty = getRandom() * 2f - 1f;
            DutySweep = (float)Math.Pow(getRandom() * 2f - 1f, 3);

            RepeatSpeed = getRandom() * 2f - 1f;

            PhaserOffset = (float)Math.Pow(getRandom() * 2f - 1f, 3);
            PhaserSweep = (float)Math.Pow(getRandom() * 2f - 1f, 3);

            LowPassFilterCutoff = 1f - (float)Math.Pow(getRandom(), 3);
            LowPassFilterCutoffSweep = (float)Math.Pow(getRandom() * 2f - 1f, 3);
            LowPassFilterResonance = getRandom() * 2f - 1f;

            HighPassFilterCutoff = (float)Math.Pow(getRandom(), 5);
            HighPassFilterCutoffSweep = (float)Math.Pow(getRandom() * 2f - 1f, 5);

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

        private float getRandom()
        {
            return (float)(_random.NextDouble());
        }

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

            if (values.Length != 24)
                throw new SerializationException("Expected 24 properties; found " + values.Length);

            return new SynthParams {
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
        #endregion
    }
}