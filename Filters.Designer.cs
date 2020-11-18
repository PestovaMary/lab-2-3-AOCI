namespace Lab2
{
    partial class Filters
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
            this.SharpenFilterButton = new System.Windows.Forms.Button();
            this.EmbosFilterButton = new System.Windows.Forms.Button();
            this.FacetsFilterButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SharpenFilterButton
            // 
            this.SharpenFilterButton.BackColor = System.Drawing.Color.DimGray;
            this.SharpenFilterButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SharpenFilterButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.SharpenFilterButton.Location = new System.Drawing.Point(12, 12);
            this.SharpenFilterButton.Name = "SharpenFilterButton";
            this.SharpenFilterButton.Size = new System.Drawing.Size(75, 23);
            this.SharpenFilterButton.TabIndex = 0;
            this.SharpenFilterButton.Text = "Sharpen";
            this.SharpenFilterButton.UseVisualStyleBackColor = false;
            this.SharpenFilterButton.Click += new System.EventHandler(this.SharpenFilterButton_Click);
            // 
            // EmbosFilterButton
            // 
            this.EmbosFilterButton.BackColor = System.Drawing.Color.DimGray;
            this.EmbosFilterButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmbosFilterButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.EmbosFilterButton.Location = new System.Drawing.Point(93, 12);
            this.EmbosFilterButton.Name = "EmbosFilterButton";
            this.EmbosFilterButton.Size = new System.Drawing.Size(75, 23);
            this.EmbosFilterButton.TabIndex = 1;
            this.EmbosFilterButton.Text = "Embos";
            this.EmbosFilterButton.UseVisualStyleBackColor = false;
            this.EmbosFilterButton.Click += new System.EventHandler(this.EmbosFilterButton_Click);
            // 
            // FacetsFilterButton
            // 
            this.FacetsFilterButton.BackColor = System.Drawing.Color.DimGray;
            this.FacetsFilterButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FacetsFilterButton.ForeColor = System.Drawing.Color.NavajoWhite;
            this.FacetsFilterButton.Location = new System.Drawing.Point(174, 12);
            this.FacetsFilterButton.Name = "FacetsFilterButton";
            this.FacetsFilterButton.Size = new System.Drawing.Size(75, 23);
            this.FacetsFilterButton.TabIndex = 2;
            this.FacetsFilterButton.Text = "Facets";
            this.FacetsFilterButton.UseVisualStyleBackColor = false;
            this.FacetsFilterButton.Click += new System.EventHandler(this.FacetsFilterButton_Click);
            // 
            // Filters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(263, 50);
            this.Controls.Add(this.FacetsFilterButton);
            this.Controls.Add(this.EmbosFilterButton);
            this.Controls.Add(this.SharpenFilterButton);
            this.Name = "Filters";
            this.Text = "Filters";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SharpenFilterButton;
        private System.Windows.Forms.Button EmbosFilterButton;
        private System.Windows.Forms.Button FacetsFilterButton;
    }
}