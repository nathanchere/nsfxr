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
            this.valueSlider1 = new nsfxr.UI.ValueSlider();
            this.lblAttack = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.valueSlider2 = new nsfxr.UI.ValueSlider();
            this.label2 = new System.Windows.Forms.Label();
            this.valueSlider3 = new nsfxr.UI.ValueSlider();
            this.label3 = new System.Windows.Forms.Label();
            this.valueSlider4 = new nsfxr.UI.ValueSlider();
            this.label4 = new System.Windows.Forms.Label();
            this.valueSlider5 = new nsfxr.UI.ValueSlider();
            this.label5 = new System.Windows.Forms.Label();
            this.valueSlider6 = new nsfxr.UI.ValueSlider();
            this.label6 = new System.Windows.Forms.Label();
            this.valueSlider7 = new nsfxr.UI.ValueSlider();
            this.label7 = new System.Windows.Forms.Label();
            this.valueSlider8 = new nsfxr.UI.ValueSlider();
            this.label8 = new System.Windows.Forms.Label();
            this.valueSlider9 = new nsfxr.UI.ValueSlider();
            this.label9 = new System.Windows.Forms.Label();
            this.valueSlider10 = new nsfxr.UI.ValueSlider();
            this.label10 = new System.Windows.Forms.Label();
            this.valueSlider11 = new nsfxr.UI.ValueSlider();
            this.label11 = new System.Windows.Forms.Label();
            this.valueSlider12 = new nsfxr.UI.ValueSlider();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(64, 221);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 48);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // valueSlider1
            // 
            this.valueSlider1.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider1.Location = new System.Drawing.Point(254, 12);
            this.valueSlider1.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider1.MaxValue = 1F;
            this.valueSlider1.MinValue = 0F;
            this.valueSlider1.Name = "valueSlider1";
            this.valueSlider1.Precision = 3;
            this.valueSlider1.Size = new System.Drawing.Size(206, 22);
            this.valueSlider1.TabIndex = 1;
            this.valueSlider1.Value = 0.5F;
            this.valueSlider1.ValueUpdated += new nsfxr.UI.ValueSlider.ValueUpdatedEvent(this.valueSlider1_ValueUpdated);
            // 
            // lblAttack
            // 
            this.lblAttack.Location = new System.Drawing.Point(151, 12);
            this.lblAttack.Margin = new System.Windows.Forms.Padding(1);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(97, 22);
            this.lblAttack.TabIndex = 2;
            this.lblAttack.Text = "Attack Time";
            this.lblAttack.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(151, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sustain Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider2
            // 
            this.valueSlider2.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider2.Location = new System.Drawing.Point(254, 36);
            this.valueSlider2.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider2.MaxValue = 1F;
            this.valueSlider2.MinValue = 0F;
            this.valueSlider2.Name = "valueSlider2";
            this.valueSlider2.Precision = 3;
            this.valueSlider2.Size = new System.Drawing.Size(206, 22);
            this.valueSlider2.TabIndex = 3;
            this.valueSlider2.Value = 0.5F;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(151, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sustain Punch";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider3
            // 
            this.valueSlider3.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider3.Location = new System.Drawing.Point(254, 60);
            this.valueSlider3.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider3.MaxValue = 1F;
            this.valueSlider3.MinValue = 0F;
            this.valueSlider3.Name = "valueSlider3";
            this.valueSlider3.Precision = 3;
            this.valueSlider3.Size = new System.Drawing.Size(206, 22);
            this.valueSlider3.TabIndex = 5;
            this.valueSlider3.Value = 0.5F;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(151, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Min Frequency";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider4
            // 
            this.valueSlider4.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider4.Location = new System.Drawing.Point(254, 132);
            this.valueSlider4.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider4.MaxValue = 1F;
            this.valueSlider4.MinValue = 0F;
            this.valueSlider4.Name = "valueSlider4";
            this.valueSlider4.Precision = 3;
            this.valueSlider4.Size = new System.Drawing.Size(206, 22);
            this.valueSlider4.TabIndex = 11;
            this.valueSlider4.Value = 0.5F;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(151, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Start Frequency";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider5
            // 
            this.valueSlider5.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider5.Location = new System.Drawing.Point(254, 108);
            this.valueSlider5.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider5.MaxValue = 1F;
            this.valueSlider5.MinValue = 0F;
            this.valueSlider5.Name = "valueSlider5";
            this.valueSlider5.Precision = 3;
            this.valueSlider5.Size = new System.Drawing.Size(206, 22);
            this.valueSlider5.TabIndex = 9;
            this.valueSlider5.Value = 0.5F;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(151, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Decay Time";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider6
            // 
            this.valueSlider6.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider6.Location = new System.Drawing.Point(254, 84);
            this.valueSlider6.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider6.MaxValue = 1F;
            this.valueSlider6.MinValue = 0F;
            this.valueSlider6.Name = "valueSlider6";
            this.valueSlider6.Precision = 3;
            this.valueSlider6.Size = new System.Drawing.Size(206, 22);
            this.valueSlider6.TabIndex = 7;
            this.valueSlider6.Value = 0.5F;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(151, 276);
            this.label6.Margin = new System.Windows.Forms.Padding(1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 22);
            this.label6.TabIndex = 24;
            this.label6.Text = "Change Speed";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider7
            // 
            this.valueSlider7.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider7.Location = new System.Drawing.Point(254, 276);
            this.valueSlider7.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider7.MaxValue = 1F;
            this.valueSlider7.MinValue = 0F;
            this.valueSlider7.Name = "valueSlider7";
            this.valueSlider7.Precision = 3;
            this.valueSlider7.Size = new System.Drawing.Size(206, 22);
            this.valueSlider7.TabIndex = 23;
            this.valueSlider7.Value = 0.5F;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(151, 252);
            this.label7.Margin = new System.Windows.Forms.Padding(1);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 22);
            this.label7.TabIndex = 22;
            this.label7.Text = "Change Amount";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider8
            // 
            this.valueSlider8.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider8.Location = new System.Drawing.Point(254, 252);
            this.valueSlider8.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider8.MaxValue = 1F;
            this.valueSlider8.MinValue = 0F;
            this.valueSlider8.Name = "valueSlider8";
            this.valueSlider8.Precision = 3;
            this.valueSlider8.Size = new System.Drawing.Size(206, 22);
            this.valueSlider8.TabIndex = 21;
            this.valueSlider8.Value = 0.5F;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(151, 228);
            this.label8.Margin = new System.Windows.Forms.Padding(1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 22);
            this.label8.TabIndex = 20;
            this.label8.Text = "Vibrato Speed";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider9
            // 
            this.valueSlider9.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider9.Location = new System.Drawing.Point(254, 228);
            this.valueSlider9.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider9.MaxValue = 1F;
            this.valueSlider9.MinValue = 0F;
            this.valueSlider9.Name = "valueSlider9";
            this.valueSlider9.Precision = 3;
            this.valueSlider9.Size = new System.Drawing.Size(206, 22);
            this.valueSlider9.TabIndex = 19;
            this.valueSlider9.Value = 0.5F;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(151, 204);
            this.label9.Margin = new System.Windows.Forms.Padding(1);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 22);
            this.label9.TabIndex = 18;
            this.label9.Text = "Vibrato Depth";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider10
            // 
            this.valueSlider10.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider10.Location = new System.Drawing.Point(254, 204);
            this.valueSlider10.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider10.MaxValue = 1F;
            this.valueSlider10.MinValue = 0F;
            this.valueSlider10.Name = "valueSlider10";
            this.valueSlider10.Precision = 3;
            this.valueSlider10.Size = new System.Drawing.Size(206, 22);
            this.valueSlider10.TabIndex = 17;
            this.valueSlider10.Value = 0.5F;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(151, 180);
            this.label10.Margin = new System.Windows.Forms.Padding(1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Delta Slide";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider11
            // 
            this.valueSlider11.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider11.Location = new System.Drawing.Point(254, 180);
            this.valueSlider11.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider11.MaxValue = 1F;
            this.valueSlider11.MinValue = 0F;
            this.valueSlider11.Name = "valueSlider11";
            this.valueSlider11.Precision = 3;
            this.valueSlider11.Size = new System.Drawing.Size(206, 22);
            this.valueSlider11.TabIndex = 15;
            this.valueSlider11.Value = 0.5F;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(151, 156);
            this.label11.Margin = new System.Windows.Forms.Padding(1);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 22);
            this.label11.TabIndex = 14;
            this.label11.Text = "Slide";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // valueSlider12
            // 
            this.valueSlider12.BackColor = System.Drawing.Color.Yellow;
            this.valueSlider12.Location = new System.Drawing.Point(254, 156);
            this.valueSlider12.Margin = new System.Windows.Forms.Padding(1);
            this.valueSlider12.MaxValue = 1F;
            this.valueSlider12.MinValue = 0F;
            this.valueSlider12.Name = "valueSlider12";
            this.valueSlider12.Precision = 3;
            this.valueSlider12.Size = new System.Drawing.Size(206, 22);
            this.valueSlider12.TabIndex = 13;
            this.valueSlider12.Value = 0.5F;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 350);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valueSlider7);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.valueSlider8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.valueSlider9);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.valueSlider10);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.valueSlider11);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.valueSlider12);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueSlider4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.valueSlider5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.valueSlider6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valueSlider3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valueSlider2);
            this.Controls.Add(this.lblAttack);
            this.Controls.Add(this.valueSlider1);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmMain";
            this.Text = "nsfxr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private ValueSlider valueSlider1;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label label1;
        private ValueSlider valueSlider2;
        private System.Windows.Forms.Label label2;
        private ValueSlider valueSlider3;
        private System.Windows.Forms.Label label3;
        private ValueSlider valueSlider4;
        private System.Windows.Forms.Label label4;
        private ValueSlider valueSlider5;
        private System.Windows.Forms.Label label5;
        private ValueSlider valueSlider6;
        private System.Windows.Forms.Label label6;
        private ValueSlider valueSlider7;
        private System.Windows.Forms.Label label7;
        private ValueSlider valueSlider8;
        private System.Windows.Forms.Label label8;
        private ValueSlider valueSlider9;
        private System.Windows.Forms.Label label9;
        private ValueSlider valueSlider10;
        private System.Windows.Forms.Label label10;
        private ValueSlider valueSlider11;
        private System.Windows.Forms.Label label11;
        private ValueSlider valueSlider12;
    }
}

