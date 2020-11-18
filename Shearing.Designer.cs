namespace Lab2
{
    partial class Shearing
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
            this.ShiftTrackBarG = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ShiftTrackBarG)).BeginInit();
            this.SuspendLayout();
            // 
            // ShiftTrackBarG
            // 
            this.ShiftTrackBarG.BackColor = System.Drawing.SystemColors.GrayText;
            this.ShiftTrackBarG.Location = new System.Drawing.Point(32, 108);
            this.ShiftTrackBarG.Maximum = 1;
            this.ShiftTrackBarG.Name = "ShiftTrackBarG";
            this.ShiftTrackBarG.Size = new System.Drawing.Size(378, 45);
            this.ShiftTrackBarG.TabIndex = 0;
            this.ShiftTrackBarG.Value = 1;
            this.ShiftTrackBarG.Scroll += new System.EventHandler(this.ShiftTrackBarG_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 15.75F);
            this.label1.ForeColor = System.Drawing.Color.BurlyWood;
            this.label1.Location = new System.Drawing.Point(187, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shift";
            // 
            // Shearing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(422, 214);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShiftTrackBarG);
            this.Name = "Shearing";
            this.Text = "Shearing";
            ((System.ComponentModel.ISupportInitialize)(this.ShiftTrackBarG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar ShiftTrackBarG;
        private System.Windows.Forms.Label label1;
    }
}