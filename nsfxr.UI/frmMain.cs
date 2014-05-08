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
                WaveShape = 0, //TODO: input for wave shape
                DecayTime = valDecayTime.Value,
                DeltaSlide = valDeltaSlide.Value,
                DutySweep = valDutySweep.Value,
                HighPassFilterCutoff = valHpfCutoff.Value,
                HighPassFilterCutoffSweep = valHpfSweep.Value,
                LowPassFilterCutoff = valLpfCutoff.Value,
                LowPassFilterCutoffSweep = valLpfSweep.Value,
                LowPassFilterResonance = valLpfResonance.Value,
                MasterVolume = valVolume.Value,
                MinFrequency = valMinFrequency.Value,
                PhaserOffset = valPhaserOffset.Value,
                PhaserSweep = valPhaserSweep.Value,
                RepeatSpeed = valRepeatSpeed.Value,
                Slide = valSlide.Value,
                SquareDuty = valSquareDuty.Value,
                StartFrequency = valStartFrequency.Value,
                SustainPunch = valSustainPunch.Value,
                SustainTime = valSustainTime.Value,
                VibratoDepth = valVibratoDepth.Value,
                VibratoSpeed = valVibratoSpeed.Value,
            };
        }

        private void txtSerailized_Click(object sender, EventArgs e)
        {
            txtSerailized.SelectionStart = 0;
            txtSerailized.SelectionLength = txtSerailized.TextLength;
        }
    }
}
