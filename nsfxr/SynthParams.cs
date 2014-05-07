using System;
using System.Runtime.Serialization;
using System.Text;

namespace nsfxr
{
    public struct SynthParams
    {
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

        /// <summary>
        /// Initialise with defaut values
        /// </summary>
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

        /// <summary>
        /// Apply slight variation to existing synth parameters
        /// </summary>
        /// <param name="mutation">Maximum intensity of the variation</param>
        public void Mutate(float mutation = 0.05f)
        {
            if (GetRandom.Float() < 0.5f) StartFrequency += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) MinFrequency += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) Slide += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) DeltaSlide += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) SquareDuty += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) DutySweep += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) VibratoDepth += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) VibratoSpeed += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) AttackTime += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) SustainTime += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) DecayTime += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) SustainPunch += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) LowPassFilterCutoff += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) LowPassFilterCutoffSweep += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) LowPassFilterResonance += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) HighPassFilterCutoff += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) HighPassFilterCutoffSweep += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f)  PhaserOffset += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) PhaserSweep += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) RepeatSpeed += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) ChangeSpeed += GetRandom.Float(-mutation, mutation);
            if (GetRandom.Float() < 0.5f) ChangeAmount += GetRandom.Float(-mutation, mutation);
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

        public static class Preset
        {
            public static SynthParams Default()
            {
                var result = new SynthParams();
                result.Reset();
                return result;
            }

            public static SynthParams Random()
            {
                var result = new SynthParams
                {
                    WaveShape = (WaveShapeEnum) (GetRandom.Float()*4f),

                    AttackTime = (float) Math.Pow(GetRandom.Float(-1, 1), 4),
                    SustainTime = (float) Math.Pow(GetRandom.Float(-1, 1), 2),
                    SustainPunch = (float) Math.Pow(GetRandom.Float(0.8f), 2),
                    DecayTime = GetRandom.Float(),

                    StartFrequency = (GetRandom.Bool()) ? (float) Math.Pow(GetRandom.Float(-1, 1), 2) : ((float) Math.Pow(GetRandom.Float(0.5f), 3) + 0.5f),
                    MinFrequency = 0.0f,

                    Slide = (float) Math.Pow(GetRandom.Float(-1, 1), 5),
                    DeltaSlide = (float) Math.Pow(GetRandom.Float(-1, 1), 3),

                    VibratoDepth = (float) Math.Pow(GetRandom.Float(-1, 1), 3),
                    VibratoSpeed = GetRandom.Float(-1, 1),

                    ChangeAmount = GetRandom.Float(-1, 1),
                    ChangeSpeed = GetRandom.Float(-1, 1),

                    SquareDuty = GetRandom.Float(-1, 1),
                    DutySweep = (float) Math.Pow(GetRandom.Float(-1, 1), 3),

                    RepeatSpeed = GetRandom.Float(-1, 1),

                    PhaserOffset = (float) Math.Pow(GetRandom.Float(-1, 1), 3),
                    PhaserSweep = (float) Math.Pow(GetRandom.Float(-1, 1), 3),

                    LowPassFilterCutoff = 1f - (float) Math.Pow(GetRandom.Float(), 3),
                    LowPassFilterCutoffSweep = (float) Math.Pow(GetRandom.Float(-1, 1), 3),
                    LowPassFilterResonance = GetRandom.Float(-1, 1),
                    HighPassFilterCutoff = (float) Math.Pow(GetRandom.Float(), 5),
                    HighPassFilterCutoffSweep = (float) Math.Pow(GetRandom.Float(-1, 1), 5),
                };


                if (result.AttackTime + result.SustainTime + result.DecayTime < 0.2f)
                {
                    result.SustainTime = GetRandom.Float(0.2f, 0.5f);
                    result.DecayTime = GetRandom.Float(0.2f, 0.5f);
                }

                if ((result.StartFrequency > 0.7f && result.Slide > 0.2) || (result.StartFrequency < 0.2 && result.Slide < -0.05))
                {
                    result.Slide = -result.Slide;
                }

                if (result.LowPassFilterCutoff < 0.1f && result.LowPassFilterCutoffSweep < -0.05f)
                {
                    result.LowPassFilterCutoffSweep = -result.LowPassFilterCutoffSweep;
                }

                return result;
            }

            public static SynthParams Laser()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(GetRandom.Int(3));              

                result.StartFrequency = GetRandom.Float(0.5f,1);
                result.MinFrequency = result.StartFrequency - 0.2f - GetRandom.Float() * 0.6f;
                if (result.MinFrequency < 0.2f) result.MinFrequency = 0.2f;

                result.Slide = -0.15f - GetRandom.Float() * 0.2f;

                if (GetRandom.Float() < 0.33f) {
                    result.StartFrequency = 0.3f + GetRandom.Float() * 0.6f;
                    result.MinFrequency = GetRandom.Float(0.1f);
                    result.Slide = GetRandom.Float(-0.65f,-0.35f);
                }

                if (GetRandom.Bool()) {
                    result.SquareDuty = GetRandom.Float(0.5f);
                    result.DutySweep = GetRandom.Float(0.2f);
                } else {
                    result.SquareDuty = GetRandom.Float(0.4f,0.9f);
                    result.DutySweep = -GetRandom.Float(0.7f);
                }

                result.SustainTime = GetRandom.Float(0.1f,0.3f);
                result.DecayTime = GetRandom.Float(0.4f);
                if (GetRandom.Bool()) result.SustainPunch = GetRandom.Float(0.3f);

                if (GetRandom.Bool(1/3)) {
                    result.PhaserOffset = GetRandom.Float(0.2f);
                    result.PhaserSweep = GetRandom.Float(-0.2f,0);
                }

                if (GetRandom.Bool()) result.HighPassFilterCutoff = GetRandom.Float(0.3f);

                return result;
            }

            public static SynthParams Explosion()
            {
                var result = new SynthParams();
                result.WaveShape = WaveShapeEnum.Noise;

                if (GetRandom.Bool()) {
                    result.StartFrequency = GetRandom.Float(0.1f,0.5f);
                    result.Slide = -0.1f + GetRandom.Float() * 0.4f;
                } else {
                    result.StartFrequency = GetRandom.Float(0.2f,0.9f);
                    result.Slide = GetRandom.Float(-0.2f,0);
                }

                result.StartFrequency *= result.StartFrequency;

                if (GetRandom.Bool(1/5)) result.Slide = 0;
                if (GetRandom.Bool(1/3)) result.RepeatSpeed = GetRandom.Float(0.3f,0.8f);

                result.SustainTime = GetRandom.Float(0.1f,0.4f);
                result.DecayTime = GetRandom.Float(0.5f);
                result.SustainPunch = GetRandom.Float(0.2f,0.8f);

                if (GetRandom.Bool()) {
                    result.PhaserOffset = GetRandom.Float(-0.3f, 0.6f);
                    result.PhaserSweep = GetRandom.Float(-0.3f,0);
                }

                if (GetRandom.Bool(1/3)) {
                    result.ChangeSpeed = GetRandom.Float(0.6f,0.9f);
                    result.ChangeAmount = GetRandom.Float(0.8f,0.8f);
                }

                return result;
            }

            public static SynthParams Powerup()
            {
                var result = new SynthParams();

                if (GetRandom.Bool())
                {
                    result.WaveShape = WaveShapeEnum.Saw;
                }
                else
                {
                    result.SquareDuty = GetRandom.Float(0.6f);
                }

                if (GetRandom.Bool())
                {
                    result.StartFrequency = GetRandom.Float(0.2f, 0.5f);
                    result.Slide = GetRandom.Float(0.1f, 0.5f);
                    result.RepeatSpeed = GetRandom.Float(0.4f, 0.8f);
                }
                else
                {
                    result.StartFrequency = GetRandom.Float(0.2f, 0.5f);
                    result.Slide = GetRandom.Float(0.05f, 0.25f);

                    if (GetRandom.Bool())
                    {
                        result.VibratoDepth = GetRandom.Float(0.7f);
                        result.VibratoSpeed = GetRandom.Float(0.6f);
                    }
                }

                result.SustainTime = GetRandom.Float(0.4f);
                result.DecayTime = GetRandom.Float(0.1f, 0.5f);

                return result;
            }

            public static SynthParams PlayerHurt()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum)(GetRandom.Int(3));
                if (result.WaveShape == WaveShapeEnum.Sin) result.WaveShape = WaveShapeEnum.Noise;
                if (result.WaveShape == WaveShapeEnum.Square) result.SquareDuty = GetRandom.Float(0.6f);

                result.StartFrequency = GetRandom.Float(0.2f, 0.8f);
                result.Slide = GetRandom.Float(-0.3f, 0.1f);

                result.SustainTime = GetRandom.Float(0.1f);
                result.DecayTime = GetRandom.Float(0.1f,0.3f);

                if (GetRandom.Bool()) result.HighPassFilterCutoff = GetRandom.Float(0.3f);

                return result;
            }

            public static SynthParams Jump()
            {
                var result = new SynthParams();

                result.WaveShape = WaveShapeEnum.Square;
                result.SquareDuty = GetRandom.Float(0.6f);
                result.StartFrequency = GetRandom.Float(0.3f, 0.6f);
                result.Slide = GetRandom.Float(0.1f, 0.3f);

                result.SustainTime = GetRandom.Float(0.1f, 0.4f);
                result.DecayTime = GetRandom.Float(0.1f, 0.3f);

                if (GetRandom.Bool()) result.HighPassFilterCutoff = GetRandom.Float(0.3f);
                if (GetRandom.Bool()) result.LowPassFilterCutoff = GetRandom.Float(0.4f, 1.0f);

                return result;
            }

            public static SynthParams MenuBlip()
            {
                var result = new SynthParams();

                result.WaveShape = (WaveShapeEnum) (GetRandom.Int(2));
                if (result.WaveShape == WaveShapeEnum.Square) result.SquareDuty = GetRandom.Float(0.6f);

                result.StartFrequency = GetRandom.Float(0.2f, 0.6f);

                result.SustainTime = GetRandom.Float(0.1f, 0.2f);
                result.DecayTime = GetRandom.Float(0.2f);
                result.HighPassFilterCutoff = 0.1f;

                return result;
            }

            public static SynthParams Coin()
            {
                var result = new SynthParams();

                result.StartFrequency = GetRandom.Float(0.4f, 0.9f);

                result.SustainTime = GetRandom.Float(0.1f);
                result.DecayTime = GetRandom.Float(0.1f, 0.5f);
                result.SustainPunch = GetRandom.Float(0.3f, 0.6f);

                if (GetRandom.Bool())
                {
                    result.ChangeSpeed = GetRandom.Float(0.5f, 0.7f);
                    result.ChangeAmount = GetRandom.Float(0.2f, 0.6f);
                }

                return result;
            }                  
        }
    }
}