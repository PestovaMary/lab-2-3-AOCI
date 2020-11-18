namespace Lab2
{
    partial class Zooming
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
            this.WidthTrackBar = new System.Windows.Forms.TrackBar();
            this.HeightTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // WidthTrackBar
            // 
            this.WidthTrackBar.Location = new System.Drawing.Point(83, 40);
            this.WidthTrackBar.Minimum = 1;
            this.WidthTrackBar.Name = "WidthTrackBar";
            this.WidthTrackBar.Size = new System.Drawing.Size(204, 45);
            this.WidthTrackBar.TabIndex = 0;
            this.WidthTrackBar.Value = 1;
            this.WidthTrackBar.Scroll += new System.EventHandler(this.WidthTrackBar_Scroll);
            // 
            // HeightTrackBar
            // 
            this.HeightTrackBar.Location = new System.Drawing.Point(83, 120);
            this.HeightTrackBar.Minimum = 1;
            this.HeightTrackBar.Name = "HeightTrackBar";
            this.HeightTrackBar.Size = new System.Drawing.Size(204, 45);
            this.HeightTrackBar.TabIndex = 1;
            this.HeightTrackBar.Value = 1;
            this.HeightTrackBar.Scroll += new System.EventHandler(this.HeightTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label2.ForeColor = System.Drawing.Color.BurlyWood;
            this.label2.Location = new System.Drawing.Point(79, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // Zooming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(387, 177);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HeightTrackBar);
            this.Controls.Add(this.WidthTrackBar);
            this.Name = "Zooming";
            this.Text = "Zooming";
            ((System.ComponentModel.ISupportInitialize)(this.WidthTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar WidthTrackBar;
        private System.Windows.Forms.TrackBar HeightTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}