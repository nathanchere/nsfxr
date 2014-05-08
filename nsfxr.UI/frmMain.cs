using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace nsfxr.UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            rdoShapeNoise.Tag = SynthParams.WaveShapeEnum.Noise;
            rdoShapeSaw.Tag = SynthParams.WaveShapeEnum.Saw;
            rdoShapeSine.Tag = SynthParams.WaveShapeEnum.Sine;
            rdoShapeSquare.Tag = SynthParams.WaveShapeEnum.Square;
            BindParams(SynthParams.Preset.Default());
        }

        private SynthParams.WaveShapeEnum SelectedWaveShape
        {
            get
            {
                var result = groupWaveShape.Controls.OfType<RadioButton>().Single(r => r.Checked);
                return (SynthParams.WaveShapeEnum)result.Tag;
            }
            set
            {
                var radioButton = groupWaveShape.Controls.OfType<RadioButton>().Single(r => (SynthParams.WaveShapeEnum)r.Tag == value);
                radioButton.Checked = true;
            }
        }

        private void BindParams(SynthParams value)
        {
            SelectedWaveShape = value.WaveShape;
            valAttackTime.Value = value.AttackTime;
            valChangeAmount.Value = value.ChangeAmount;
            valChangeSpeed.Value = value.ChangeSpeed;            
            valDecayTime.Value = value.DecayTime;
            valDeltaSlide.Value = value.DeltaSlide;
            valDutySweep.Value = value.DutySweep;
            valHpfCutoff.Value = value.HighPassFilterCutoff;
            valHpfSweep.Value = value.HighPassFilterCutoffSweep;
            valLpfCutoff.Value = value.LowPassFilterCutoff;
            valLpfSweep.Value = value.LowPassFilterCutoffSweep;
            valLpfResonance.Value = value.LowPassFilterResonance;            
            valMinFrequency.Value = value.MinFrequency;
            valPhaserOffset.Value = value.PhaserOffset;
            valPhaserSweep.Value = value.PhaserSweep;            
            valSlide.Value = value.Slide;
            valSquareDuty.Value = value.SquareDuty;
            valStartFrequency.Value = value.StartFrequency;
            valSustainPunch.Value = value.SustainPunch;
            valSustainTime.Value = value.SustainTime;
            valVibratoDepth.Value = value.VibratoDepth;
            valVibratoSpeed.Value = value.VibratoSpeed;

            //// TODO: handle separately?
            //valRepeatSpeed.Value = value.RepeatSpeed;
            //valVolume.Value = value.MasterVolume;

            txtSerailized.Text = value.Serialize();
        }

        private void inputValueUpdated(object sender, EventArgs args)
        {
            txtSerailized.Text = GetSynthParamsFromInputs().Serialize();
        }

        private SynthParams GetSynthParamsFromInputs()
        {
            return new SynthParams {
                AttackTime = valAttackTime.Value,
                ChangeAmount = valChangeAmount.Value,
                ChangeSpeed = valChangeSpeed.Value,
                WaveShape = SelectedWaveShape, //TODO: input for wave shape
                DecayTime = valDecayTime.Value,
                DeltaSlide = valDeltaSlide.Value,
                DutySweep = valDutySweep.Value,
                HighPassFilterCutoff = valHpfCutoff.Value,
                HighPassFilterCutoffSweep = valHpfSweep.Value,
                LowPassFilterCutoff = valLpfCutoff.Value,
                LowPassFilterCutoffSweep = valLpfSweep.Value,
                LowPassFilterResonance = valLpfResonance.Value,
                MinFrequency = valMinFrequency.Value,
                PhaserOffset = valPhaserOffset.Value,
                PhaserSweep = valPhaserSweep.Value,
                Slide = valSlide.Value,
                SquareDuty = valSquareDuty.Value,
                StartFrequency = valStartFrequency.Value,
                SustainPunch = valSustainPunch.Value,
                SustainTime = valSustainTime.Value,
                VibratoDepth = valVibratoDepth.Value,
                VibratoSpeed = valVibratoSpeed.Value,

                MasterVolume = valVolume.Value,
                RepeatSpeed = valRepeatSpeed.Value,
            };
        }

        private void txtSerailized_Click(object sender, EventArgs e)
        {
            txtSerailized.SelectionStart = 0;
            txtSerailized.SelectionLength = txtSerailized.TextLength;
        }

        private void btnPresetCoin_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.Coin());
        }

        private void btnPresetLaser_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.Laser());
        }

        private void btnPresetExplosion_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.Explosion());
        }

        private void btnPresetPowerup_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.Powerup());
        }

        private void btnPresetHit_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.PlayerHurt());
        }

        private void btnPresetJump_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.Jump());
        }

        private void btnPresetMenuBlip_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.MenuBlip());
        }

        private void btnRandomize_Click(object sender, EventArgs e)
        {
            BindParams(SynthParams.Preset.Random());
        }

        private void btnMutate_Click(object sender, EventArgs e)
        {
            var result = GetSynthParamsFromInputs();
            result.Mutate();
            BindParams(result);
        }
    }
}
