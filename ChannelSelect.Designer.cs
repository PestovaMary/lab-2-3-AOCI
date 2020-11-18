namespace Lab2
{
    partial class ChannelSelect
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
            this.BlueButton = new System.Windows.Forms.Button();
            this.GreenButton = new System.Windows.Forms.Button();
            this.RedButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BlueButton
            // 
            this.BlueButton.BackColor = System.Drawing.Color.RoyalBlue;
            this.BlueButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.BlueButton.Location = new System.Drawing.Point(13, 25);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(75, 40);
            this.BlueButton.TabIndex = 1;
            this.BlueButton.Text = "BLUE";
            this.BlueButton.UseVisualStyleBackColor = false;
            this.BlueButton.Click += new System.EventHandler(this.BlueButton_Click);
            // 
            // GreenButton
            // 
            this.GreenButton.BackColor = System.Drawing.Color.OliveDrab;
            this.GreenButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GreenButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.GreenButton.Location = new System.Drawing.Point(110, 25);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(75, 40);
            this.GreenButton.TabIndex = 2;
            this.GreenButton.Text = "GREEN";
            this.GreenButton.UseVisualStyleBackColor = false;
            this.GreenButton.Click += new System.EventHandler(this.GreenButton_Click);
            // 
            // RedButton
            // 
            this.RedButton.BackColor = System.Drawing.Color.Brown;
            this.RedButton.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.RedButton.Location = new System.Drawing.Point(205, 25);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(75, 40);
            this.RedButton.TabIndex = 3;
            this.RedButton.Text = "RED";
            this.RedButton.UseVisualStyleBackColor = false;
            this.RedButton.Click += new System.EventHandler(this.RedButton_Click);
            // 
            // ChannelSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(292, 83);
            this.Controls.Add(this.RedButton);
            this.Controls.Add(this.GreenButton);
            this.Controls.Add(this.BlueButton);
            this.Name = "ChannelSelect";
            this.Text = "Channel";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BlueButton;
        private System.Windows.Forms.Button GreenButton;
        private System.Windows.Forms.Button RedButton;
    }
}