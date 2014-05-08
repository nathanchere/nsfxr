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
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(309, 254);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(106, 48);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            // 
            // valueSlider1
            // 
            this.valueSlider1.Location = new System.Drawing.Point(105, 62);
            this.valueSlider1.MaxValue = 0F;
            this.valueSlider1.MinValue = 0F;
            this.valueSlider1.Name = "valueSlider1";
            this.valueSlider1.Size = new System.Drawing.Size(229, 53);
            this.valueSlider1.TabIndex = 1;
            this.valueSlider1.Value = 0F;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 314);
            this.Controls.Add(this.valueSlider1);
            this.Controls.Add(this.btnPlay);
            this.Name = "frmMain";
            this.Text = "nsfxr";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private ValueSlider valueSlider1;
    }
}

