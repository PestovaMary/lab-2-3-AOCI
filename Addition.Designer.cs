namespace Lab2
{
    partial class Addition
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstParamTrackBar = new System.Windows.Forms.TrackBar();
            this.SecondParamTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.FirstParamTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondParamTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(15, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstParamTrackBar
            // 
            this.FirstParamTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.FirstParamTrackBar.Location = new System.Drawing.Point(57, 26);
            this.FirstParamTrackBar.Name = "FirstParamTrackBar";
            this.FirstParamTrackBar.Size = new System.Drawing.Size(221, 45);
            this.FirstParamTrackBar.TabIndex = 2;
            this.FirstParamTrackBar.Scroll += new System.EventHandler(this.FirstParamTrackBar_Scroll);
            // 
            // SecondParamTrackBar
            // 
            this.SecondParamTrackBar.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.SecondParamTrackBar.Location = new System.Drawing.Point(57, 82);
            this.SecondParamTrackBar.Name = "SecondParamTrackBar";
            this.SecondParamTrackBar.Size = new System.Drawing.Size(221, 45);
            this.SecondParamTrackBar.TabIndex = 3;
            this.SecondParamTrackBar.Scroll += new System.EventHandler(this.SecondParamTrackBar_Scroll);
            // 
            // Addition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(302, 131);
            this.Controls.Add(this.SecondParamTrackBar);
            this.Controls.Add(this.FirstParamTrackBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Addition";
            this.Text = "Addition";
            ((System.ComponentModel.ISupportInitialize)(this.FirstParamTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondParamTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar FirstParamTrackBar;
        private System.Windows.Forms.TrackBar SecondParamTrackBar;
    }
}