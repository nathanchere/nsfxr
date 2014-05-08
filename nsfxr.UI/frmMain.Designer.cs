namespace nsfxr.UI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblAttack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.valVibratoSpeed = new nsfxr.UI.ValueSlider();
            this.valVibratoDepth = new nsfxr.UI.ValueSlider();
            this.valDeltaSlide = new nsfxr.UI.ValueSlider();
            this.valSlide = new nsfxr.UI.ValueSlider();
            this.valMinFrequency = new nsfxr.UI.ValueSlider();
            this.valStartFrequency = new nsfxr.UI.ValueSlider();
            this.panel2 = new System.Windows.Forms.Panel();
            this.valAttackTime = new nsfxr.UI.ValueSlider();
            this.valSustainTime = new nsfxr.UI.ValueSlider();
            this.valSustainPunch = new nsfxr.UI.ValueSlider();
            this.valDecayTime = new nsfxr.UI.ValueSlider();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.valChangeSpeed = new nsfxr.UI.ValueSlider();
            this.valChangeAmount = new nsfxr.UI.ValueSlider();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label43 = new System.Windows.Forms.Label();
            this.valLpfCutoff = new nsfxr.UI.ValueSlider();
            this.valLpfSweep = new nsfxr.UI.ValueSlider();
            this.label41 = new System.Windows.Forms.Label();
            this.valLpfResonance = new nsfxr.UI.ValueSlider();
            this.label40 = new System.Windows.Forms.Label();
            this.valHpfCutoff = new nsfxr.UI.ValueSlider();
            this.label22 = new System.Windows.Forms.Label();
            this.valHpfSweep = new nsfxr.UI.ValueSlider();
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.valDutySweep = new nsfxr.UI.ValueSlider();
            this.valSquareDuty = new nsfxr.UI.ValueSlider();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.valPhaserSweep = new nsfxr.UI.ValueSlider();
            this.valPhaserOffset = new nsfxr.UI.ValueSlider();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.valRepeatSpeed = new nsfxr.UI.ValueSlider();
            this.valVolume = new nsfxr.UI.ValueSlider();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtSerailized = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(415, 270);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 48);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // lblAttack
            // 
            this.lblAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack.Location = new System.Drawing.Point(1, 2);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(1);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(97, 17);
            this.lblAttack.TabIndex = 2;
            this.lblAttack.Text = "Attack Time";
            this.lblAttack.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sustain Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sustain Punch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min Frequency";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 2);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Frequency";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Decay Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 21);
            this.label6.Margin = new System.Windows.Forms.Padding(1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Change Speed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1, 2);
            this.label7.Margin = new System.Windows.Forms.Padding(1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Change Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vibrato Speed";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vibrato Depth";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1, 59);
            this.label10.Margin = new System.Windows.Forms.Padding(1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "Delta Slide";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1, 40);
            this.label11.Margin = new System.Windows.Forms.Padding(1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 17);
            this.label11.TabIndex = 14;
            this.label11.Text = "Slide";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valVibratoSpeed
            // 
            this.valVibratoSpeed.BackColor = System.Drawing.Color.PaleGreen;
            this.valVibratoSpeed.Location = new System.Drawing.Point(100, 96);
            this.valVibratoSpeed.Margin = new System.Windows.Forms.Padding(1);
            this.valVibratoSpeed.MaxValue = 1F;
            this.valVibratoSpeed.MinValue = 0F;
            this.valVibratoSpeed.Name = "valVibratoSpeed";
            this.valVibratoSpeed.Precision = 3;
            this.valVibratoSpeed.Size = new System.Drawing.Size(225, 17);
            this.valVibratoSpeed.TabIndex = 19;
            this.valVibratoSpeed.Value = 0.5F;
            this.valVibratoSpeed.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valVibratoDepth
            // 
            this.valVibratoDepth.BackColor = System.Drawing.Color.PaleGreen;
            this.valVibratoDepth.Location = new System.Drawing.Point(100, 77);
            this.valVibratoDepth.Margin = new System.Windows.Forms.Padding(1);
            this.valVibratoDepth.MaxValue = 1F;
            this.valVibratoDepth.MinValue = 0F;
            this.valVibratoDepth.Name = "valVibratoDepth";
            this.valVibratoDepth.Precision = 3;
            this.valVibratoDepth.Size = new System.Drawing.Size(225, 17);
            this.valVibratoDepth.TabIndex = 17;
            this.valVibratoDepth.Value = 0.5F;
            this.valVibratoDepth.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valDeltaSlide
            // 
            this.valDeltaSlide.BackColor = System.Drawing.Color.PaleGreen;
            this.valDeltaSlide.Location = new System.Drawing.Point(100, 58);
            this.valDeltaSlide.Margin = new System.Windows.Forms.Padding(1);
            this.valDeltaSlide.MaxValue = 1F;
            this.valDeltaSlide.MinValue = -1F;
            this.valDeltaSlide.Name = "valDeltaSlide";
            this.valDeltaSlide.Precision = 3;
            this.valDeltaSlide.Size = new System.Drawing.Size(225, 17);
            this.valDeltaSlide.TabIndex = 15;
            this.valDeltaSlide.Value = 0.5F;
            this.valDeltaSlide.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valSlide
            // 
            this.valSlide.BackColor = System.Drawing.Color.PaleGreen;
            this.valSlide.Location = new System.Drawing.Point(100, 39);
            this.valSlide.Margin = new System.Windows.Forms.Padding(1);
            this.valSlide.MaxValue = 1F;
            this.valSlide.MinValue = -1F;
            this.valSlide.Name = "valSlide";
            this.valSlide.Precision = 3;
            this.valSlide.Size = new System.Drawing.Size(225, 17);
            this.valSlide.TabIndex = 13;
            this.valSlide.Value = 0.5F;
            this.valSlide.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valMinFrequency
            // 
            this.valMinFrequency.BackColor = System.Drawing.Color.PaleGreen;
            this.valMinFrequency.Location = new System.Drawing.Point(100, 20);
            this.valMinFrequency.Margin = new System.Windows.Forms.Padding(1);
            this.valMinFrequency.MaxValue = 1F;
            this.valMinFrequency.MinValue = 0F;
            this.valMinFrequency.Name = "valMinFrequency";
            this.valMinFrequency.Precision = 3;
            this.valMinFrequency.Size = new System.Drawing.Size(225, 17);
            this.valMinFrequency.TabIndex = 11;
            this.valMinFrequency.Value = 0.5F;
            this.valMinFrequency.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valStartFrequency
            // 
            this.valStartFrequency.BackColor = System.Drawing.Color.PaleGreen;
            this.valStartFrequency.Location = new System.Drawing.Point(100, 1);
            this.valStartFrequency.Margin = new System.Windows.Forms.Padding(1);
            this.valStartFrequency.MaxValue = 1F;
            this.valStartFrequency.MinValue = 0F;
            this.valStartFrequency.Name = "valStartFrequency";
            this.valStartFrequency.Precision = 3;
            this.valStartFrequency.Size = new System.Drawing.Size(225, 17);
            this.valStartFrequency.TabIndex = 9;
            this.valStartFrequency.Value = 0.5F;
            this.valStartFrequency.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.valAttackTime);
            this.panel2.Controls.Add(this.valSustainTime);
            this.panel2.Controls.Add(this.valSustainPunch);
            this.panel2.Controls.Add(this.valDecayTime);
            this.panel2.Controls.Add(this.lblAttack);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(2, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 79);
            this.panel2.TabIndex = 26;
            // 
            // valAttackTime
            // 
            this.valAttackTime.BackColor = System.Drawing.Color.LemonChiffon;
            this.valAttackTime.Location = new System.Drawing.Point(100, 1);
            this.valAttackTime.Margin = new System.Windows.Forms.Padding(1);
            this.valAttackTime.MaxValue = 1F;
            this.valAttackTime.MinValue = 0F;
            this.valAttackTime.Name = "valAttackTime";
            this.valAttackTime.Precision = 3;
            this.valAttackTime.Size = new System.Drawing.Size(225, 17);
            this.valAttackTime.TabIndex = 16;
            this.valAttackTime.Value = 0.5F;
            this.valAttackTime.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valSustainTime
            // 
            this.valSustainTime.BackColor = System.Drawing.Color.LemonChiffon;
            this.valSustainTime.Location = new System.Drawing.Point(100, 20);
            this.valSustainTime.Margin = new System.Windows.Forms.Padding(1);
            this.valSustainTime.MaxValue = 1F;
            this.valSustainTime.MinValue = 0F;
            this.valSustainTime.Name = "valSustainTime";
            this.valSustainTime.Precision = 3;
            this.valSustainTime.Size = new System.Drawing.Size(225, 17);
            this.valSustainTime.TabIndex = 17;
            this.valSustainTime.Value = 0.5F;
            this.valSustainTime.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valSustainPunch
            // 
            this.valSustainPunch.BackColor = System.Drawing.Color.LemonChiffon;
            this.valSustainPunch.Location = new System.Drawing.Point(100, 39);
            this.valSustainPunch.Margin = new System.Windows.Forms.Padding(1);
            this.valSustainPunch.MaxValue = 1F;
            this.valSustainPunch.MinValue = 0F;
            this.valSustainPunch.Name = "valSustainPunch";
            this.valSustainPunch.Precision = 3;
            this.valSustainPunch.Size = new System.Drawing.Size(225, 17);
            this.valSustainPunch.TabIndex = 18;
            this.valSustainPunch.Value = 0.5F;
            this.valSustainPunch.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valDecayTime
            // 
            this.valDecayTime.BackColor = System.Drawing.Color.LemonChiffon;
            this.valDecayTime.Location = new System.Drawing.Point(100, 58);
            this.valDecayTime.Margin = new System.Windows.Forms.Padding(1);
            this.valDecayTime.MaxValue = 1F;
            this.valDecayTime.MinValue = 0F;
            this.valDecayTime.Name = "valDecayTime";
            this.valDecayTime.Precision = 3;
            this.valDecayTime.Size = new System.Drawing.Size(225, 17);
            this.valDecayTime.TabIndex = 19;
            this.valDecayTime.Value = 0.5F;
            this.valDecayTime.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.valStartFrequency);
            this.panel1.Controls.Add(this.valMinFrequency);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.valSlide);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.valDeltaSlide);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.valVibratoSpeed);
            this.panel1.Controls.Add(this.valVibratoDepth);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(2, 128);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 118);
            this.panel1.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.valChangeSpeed);
            this.panel3.Controls.Add(this.valChangeAmount);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(2, 249);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(332, 41);
            this.panel3.TabIndex = 28;
            // 
            // valChangeSpeed
            // 
            this.valChangeSpeed.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valChangeSpeed.Location = new System.Drawing.Point(100, 20);
            this.valChangeSpeed.Margin = new System.Windows.Forms.Padding(1);
            this.valChangeSpeed.MaxValue = 1F;
            this.valChangeSpeed.MinValue = 0F;
            this.valChangeSpeed.Name = "valChangeSpeed";
            this.valChangeSpeed.Precision = 3;
            this.valChangeSpeed.Size = new System.Drawing.Size(225, 17);
            this.valChangeSpeed.TabIndex = 22;
            this.valChangeSpeed.Value = 0.5F;
            this.valChangeSpeed.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valChangeAmount
            // 
            this.valChangeAmount.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valChangeAmount.Location = new System.Drawing.Point(100, 1);
            this.valChangeAmount.Margin = new System.Windows.Forms.Padding(1);
            this.valChangeAmount.MaxValue = 1F;
            this.valChangeAmount.MinValue = -1F;
            this.valChangeAmount.Name = "valChangeAmount";
            this.valChangeAmount.Precision = 3;
            this.valChangeAmount.Size = new System.Drawing.Size(225, 17);
            this.valChangeAmount.TabIndex = 21;
            this.valChangeAmount.Value = 0.5F;
            this.valChangeAmount.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.PaleGreen;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label43);
            this.panel4.Controls.Add(this.valLpfCutoff);
            this.panel4.Controls.Add(this.valLpfSweep);
            this.panel4.Controls.Add(this.label41);
            this.panel4.Controls.Add(this.valLpfResonance);
            this.panel4.Controls.Add(this.label40);
            this.panel4.Controls.Add(this.valHpfCutoff);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.valHpfSweep);
            this.panel4.Controls.Add(this.label23);
            this.panel4.Location = new System.Drawing.Point(2, 381);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 98);
            this.panel4.TabIndex = 28;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(1, 2);
            this.label43.Margin = new System.Windows.Forms.Padding(1);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(97, 17);
            this.label43.TabIndex = 10;
            this.label43.Text = "LPF Cutoff";
            this.label43.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valLpfCutoff
            // 
            this.valLpfCutoff.BackColor = System.Drawing.Color.PaleGreen;
            this.valLpfCutoff.Location = new System.Drawing.Point(100, 1);
            this.valLpfCutoff.Margin = new System.Windows.Forms.Padding(1);
            this.valLpfCutoff.MaxValue = 1F;
            this.valLpfCutoff.MinValue = 0F;
            this.valLpfCutoff.Name = "valLpfCutoff";
            this.valLpfCutoff.Precision = 3;
            this.valLpfCutoff.Size = new System.Drawing.Size(225, 17);
            this.valLpfCutoff.TabIndex = 9;
            this.valLpfCutoff.Value = 0.5F;
            this.valLpfCutoff.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valLpfSweep
            // 
            this.valLpfSweep.BackColor = System.Drawing.Color.PaleGreen;
            this.valLpfSweep.Location = new System.Drawing.Point(100, 20);
            this.valLpfSweep.Margin = new System.Windows.Forms.Padding(1);
            this.valLpfSweep.MaxValue = 1F;
            this.valLpfSweep.MinValue = -1F;
            this.valLpfSweep.Name = "valLpfSweep";
            this.valLpfSweep.Precision = 3;
            this.valLpfSweep.Size = new System.Drawing.Size(225, 17);
            this.valLpfSweep.TabIndex = 11;
            this.valLpfSweep.Value = 0.5F;
            this.valLpfSweep.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(1, 21);
            this.label41.Margin = new System.Windows.Forms.Padding(1);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(97, 17);
            this.label41.TabIndex = 12;
            this.label41.Text = "LPF Sweep";
            this.label41.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valLpfResonance
            // 
            this.valLpfResonance.BackColor = System.Drawing.Color.PaleGreen;
            this.valLpfResonance.Location = new System.Drawing.Point(100, 39);
            this.valLpfResonance.Margin = new System.Windows.Forms.Padding(1);
            this.valLpfResonance.MaxValue = 1F;
            this.valLpfResonance.MinValue = 0F;
            this.valLpfResonance.Name = "valLpfResonance";
            this.valLpfResonance.Precision = 3;
            this.valLpfResonance.Size = new System.Drawing.Size(225, 17);
            this.valLpfResonance.TabIndex = 13;
            this.valLpfResonance.Value = 0.5F;
            this.valLpfResonance.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(1, 40);
            this.label40.Margin = new System.Windows.Forms.Padding(1);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(97, 17);
            this.label40.TabIndex = 14;
            this.label40.Text = "LPF Resonance";
            this.label40.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valHpfCutoff
            // 
            this.valHpfCutoff.BackColor = System.Drawing.Color.PaleGreen;
            this.valHpfCutoff.Location = new System.Drawing.Point(100, 58);
            this.valHpfCutoff.Margin = new System.Windows.Forms.Padding(1);
            this.valHpfCutoff.MaxValue = 1F;
            this.valHpfCutoff.MinValue = 0F;
            this.valHpfCutoff.Name = "valHpfCutoff";
            this.valHpfCutoff.Precision = 3;
            this.valHpfCutoff.Size = new System.Drawing.Size(225, 17);
            this.valHpfCutoff.TabIndex = 15;
            this.valHpfCutoff.Value = 0.5F;
            this.valHpfCutoff.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(1, 59);
            this.label22.Margin = new System.Windows.Forms.Padding(1);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(97, 17);
            this.label22.TabIndex = 16;
            this.label22.Text = "HPF Cutoff";
            this.label22.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // valHpfSweep
            // 
            this.valHpfSweep.BackColor = System.Drawing.Color.PaleGreen;
            this.valHpfSweep.Location = new System.Drawing.Point(100, 77);
            this.valHpfSweep.Margin = new System.Windows.Forms.Padding(1);
            this.valHpfSweep.MaxValue = 1F;
            this.valHpfSweep.MinValue = -1F;
            this.valHpfSweep.Name = "valHpfSweep";
            this.valHpfSweep.Precision = 3;
            this.valHpfSweep.Size = new System.Drawing.Size(225, 17);
            this.valHpfSweep.TabIndex = 17;
            this.valHpfSweep.Value = 0.5F;
            this.valHpfSweep.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(1, 78);
            this.label23.Margin = new System.Windows.Forms.Padding(1);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(97, 17);
            this.label23.TabIndex = 18;
            this.label23.Text = "HPF Sweep";
            this.label23.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.valDutySweep);
            this.panel6.Controls.Add(this.valSquareDuty);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.label25);
            this.panel6.Location = new System.Drawing.Point(2, 293);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(332, 41);
            this.panel6.TabIndex = 29;
            // 
            // valDutySweep
            // 
            this.valDutySweep.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valDutySweep.Location = new System.Drawing.Point(100, 20);
            this.valDutySweep.Margin = new System.Windows.Forms.Padding(1);
            this.valDutySweep.MaxValue = 1F;
            this.valDutySweep.MinValue = 0F;
            this.valDutySweep.Name = "valDutySweep";
            this.valDutySweep.Precision = 3;
            this.valDutySweep.Size = new System.Drawing.Size(225, 17);
            this.valDutySweep.TabIndex = 22;
            this.valDutySweep.Value = 0.5F;
            this.valDutySweep.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valSquareDuty
            // 
            this.valSquareDuty.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valSquareDuty.Location = new System.Drawing.Point(100, 1);
            this.valSquareDuty.Margin = new System.Windows.Forms.Padding(1);
            this.valSquareDuty.MaxValue = 1F;
            this.valSquareDuty.MinValue = 0F;
            this.valSquareDuty.Name = "valSquareDuty";
            this.valSquareDuty.Precision = 3;
            this.valSquareDuty.Size = new System.Drawing.Size(225, 17);
            this.valSquareDuty.TabIndex = 21;
            this.valSquareDuty.Value = 0.5F;
            this.valSquareDuty.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(1, 2);
            this.label24.Margin = new System.Windows.Forms.Padding(1);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(97, 17);
            this.label24.TabIndex = 22;
            this.label24.Text = "Square Duty";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(1, 21);
            this.label25.Margin = new System.Windows.Forms.Padding(1);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(97, 17);
            this.label25.TabIndex = 24;
            this.label25.Text = "Duty Sweep";
            this.label25.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.valPhaserSweep);
            this.panel7.Controls.Add(this.valPhaserOffset);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.label27);
            this.panel7.Location = new System.Drawing.Point(2, 337);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(332, 41);
            this.panel7.TabIndex = 30;
            // 
            // valPhaserSweep
            // 
            this.valPhaserSweep.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valPhaserSweep.Location = new System.Drawing.Point(100, 20);
            this.valPhaserSweep.Margin = new System.Windows.Forms.Padding(1);
            this.valPhaserSweep.MaxValue = 1F;
            this.valPhaserSweep.MinValue = -1F;
            this.valPhaserSweep.Name = "valPhaserSweep";
            this.valPhaserSweep.Precision = 3;
            this.valPhaserSweep.Size = new System.Drawing.Size(225, 17);
            this.valPhaserSweep.TabIndex = 22;
            this.valPhaserSweep.Value = 0.5F;
            this.valPhaserSweep.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valPhaserOffset
            // 
            this.valPhaserOffset.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valPhaserOffset.Location = new System.Drawing.Point(100, 1);
            this.valPhaserOffset.Margin = new System.Windows.Forms.Padding(1);
            this.valPhaserOffset.MaxValue = 1F;
            this.valPhaserOffset.MinValue = -1F;
            this.valPhaserOffset.Name = "valPhaserOffset";
            this.valPhaserOffset.Precision = 3;
            this.valPhaserOffset.Size = new System.Drawing.Size(225, 17);
            this.valPhaserOffset.TabIndex = 21;
            this.valPhaserOffset.Value = 0.5F;
            this.valPhaserOffset.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(1, 2);
            this.label26.Margin = new System.Windows.Forms.Padding(1);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 17);
            this.label26.TabIndex = 22;
            this.label26.Text = "Phaser Offset";
            this.label26.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(1, 21);
            this.label27.Margin = new System.Windows.Forms.Padding(1);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(97, 17);
            this.label27.TabIndex = 24;
            this.label27.Text = "Phaser Sweep";
            this.label27.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.valRepeatSpeed);
            this.panel5.Controls.Add(this.valVolume);
            this.panel5.Controls.Add(this.label18);
            this.panel5.Controls.Add(this.label19);
            this.panel5.Location = new System.Drawing.Point(2, 2);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 41);
            this.panel5.TabIndex = 31;
            // 
            // valRepeatSpeed
            // 
            this.valRepeatSpeed.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valRepeatSpeed.Location = new System.Drawing.Point(100, 20);
            this.valRepeatSpeed.Margin = new System.Windows.Forms.Padding(1);
            this.valRepeatSpeed.MaxValue = 1F;
            this.valRepeatSpeed.MinValue = 0F;
            this.valRepeatSpeed.Name = "valRepeatSpeed";
            this.valRepeatSpeed.Precision = 3;
            this.valRepeatSpeed.Size = new System.Drawing.Size(225, 17);
            this.valRepeatSpeed.TabIndex = 22;
            this.valRepeatSpeed.Value = 0.5F;
            this.valRepeatSpeed.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // valVolume
            // 
            this.valVolume.BackColor = System.Drawing.Color.PaleTurquoise;
            this.valVolume.Location = new System.Drawing.Point(100, 1);
            this.valVolume.Margin = new System.Windows.Forms.Padding(1);
            this.valVolume.MaxValue = 1F;
            this.valVolume.MinValue = 0F;
            this.valVolume.Name = "valVolume";
            this.valVolume.Precision = 3;
            this.valVolume.Size = new System.Drawing.Size(225, 17);
            this.valVolume.TabIndex = 21;
            this.valVolume.Value = 0.5F;
            this.valVolume.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.inputValueUpdated);
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1, 2);
            this.label18.Margin = new System.Windows.Forms.Padding(1);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 17);
            this.label18.TabIndex = 22;
            this.label18.Text = "Master Volume";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1, 21);
            this.label19.Margin = new System.Windows.Forms.Padding(1);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(97, 17);
            this.label19.TabIndex = 24;
            this.label19.Text = "Repeat Speed";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtSerailized
            // 
            this.txtSerailized.Location = new System.Drawing.Point(2, 482);
            this.txtSerailized.Name = "txtSerailized";
            this.txtSerailized.ReadOnly = true;
            this.txtSerailized.Size = new System.Drawing.Size(605, 20);
            this.txtSerailized.TabIndex = 32;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 503);
            this.Controls.Add(this.txtSerailized);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnPlay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMain";
            this.Text = "nsfxr";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private ValueSlider valMinFrequency;
        private System.Windows.Forms.Label label4;
        private ValueSlider valStartFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ValueSlider valVibratoSpeed;
        private System.Windows.Forms.Label label9;
        private ValueSlider valVibratoDepth;
        private System.Windows.Forms.Label label10;
        private ValueSlider valDeltaSlide;
        private System.Windows.Forms.Label label11;
        private ValueSlider valSlide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private ValueSlider valAttackTime;
        private ValueSlider valSustainTime;
        private ValueSlider valSustainPunch;
        private ValueSlider valDecayTime;
        private ValueSlider valChangeSpeed;
        private ValueSlider valChangeAmount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label43;
        private ValueSlider valLpfCutoff;
        private ValueSlider valLpfSweep;
        private System.Windows.Forms.Label label41;
        private ValueSlider valLpfResonance;
        private System.Windows.Forms.Label label40;
        private ValueSlider valHpfCutoff;
        private System.Windows.Forms.Label label22;
        private ValueSlider valHpfSweep;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel6;
        private ValueSlider valDutySweep;
        private ValueSlider valSquareDuty;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel7;
        private ValueSlider valPhaserSweep;
        private ValueSlider valPhaserOffset;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel5;
        private ValueSlider valRepeatSpeed;
        private ValueSlider valVolume;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtSerailized;
    }
}

