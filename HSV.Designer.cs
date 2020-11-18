namespace Lab2
{
    partial class HSV
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
            this.HueTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // HueTrackBar
            // 
            this.HueTrackBar.Location = new System.Drawing.Point(12, 12);
            this.HueTrackBar.Maximum = 255;
            this.HueTrackBar.Name = "HueTrackBar";
            this.HueTrackBar.Size = new System.Drawing.Size(225, 45);
            this.HueTrackBar.TabIndex = 3;
            this.HueTrackBar.Scroll += new System.EventHandler(this.HueTrackBar_Scroll);
            // 
            // HSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(247, 59);
            this.Controls.Add(this.HueTrackBar);
            this.Name = "HSV";
            this.Text = "HSV";
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TrackBar HueTrackBar;
    }
}