namespace AnalogClock
{
    partial class AnalogClock
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
            if (disposing && (components != null))
            {
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
            this.pbAnalogClock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClock)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAnalogClock
            // 
            this.pbAnalogClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbAnalogClock.Location = new System.Drawing.Point(0, 0);
            this.pbAnalogClock.Name = "pbAnalogClock";
            this.pbAnalogClock.Size = new System.Drawing.Size(284, 261);
            this.pbAnalogClock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAnalogClock.TabIndex = 0;
            this.pbAnalogClock.TabStop = false;
            // 
            // AnalogClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pbAnalogClock);
            this.Name = "AnalogClock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Analog Clock";
            this.Load += new System.EventHandler(this.FormAnalogClock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnalogClock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAnalogClock;
    }
}

