namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.SourceImageBox = new Emgu.CV.UI.ImageBox();
            this.FinalImageBox = new Emgu.CV.UI.ImageBox();
            this.LoadImageButton = new System.Windows.Forms.Button();
            this.ColorChannelButton = new System.Windows.Forms.Button();
            this.GrayConvertButton = new System.Windows.Forms.Button();
            this.SepiaConvertButton = new System.Windows.Forms.Button();
            this.ConAndBrButton = new System.Windows.Forms.Button();
            this.HsvConvertButton = new System.Windows.Forms.Button();
            this.AdditionButton = new System.Windows.Forms.Button();
            this.CrossingButton = new System.Windows.Forms.Button();
            this.MedianBlurButton = new System.Windows.Forms.Button();
            this.WindowFiltersButton = new System.Windows.Forms.Button();
            this.WatercolorFilterButton = new System.Windows.Forms.Button();
            this.CartoonFilterButton = new System.Windows.Forms.Button();
            this.ExceptionButton = new System.Windows.Forms.Button();
            this.Scale = new System.Windows.Forms.Button();
            this.Shearing = new System.Windows.Forms.Button();
            this.Rotation = new System.Windows.Forms.Button();
            this.Homography = new System.Windows.Forms.Button();
            this.Reflection = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SourceImageBox
            // 
            this.SourceImageBox.Location = new System.Drawing.Point(134, 81);
            this.SourceImageBox.Name = "SourceImageBox";
            this.SourceImageBox.Size = new System.Drawing.Size(320, 470);
            this.SourceImageBox.TabIndex = 2;
            this.SourceImageBox.TabStop = false;
            this.SourceImageBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SourceImageBox_Click);
            // 
            // FinalImageBox
            // 
            this.FinalImageBox.Location = new System.Drawing.Point(490, 81);
            this.FinalImageBox.Name = "FinalImageBox";
            this.FinalImageBox.Size = new System.Drawing.Size(320, 470);
            this.FinalImageBox.TabIndex = 2;
            this.FinalImageBox.TabStop = false;
            // 
            // LoadImageButton
            // 
            this.LoadImageButton.BackColor = System.Drawing.Color.DimGray;
            this.LoadImageButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadImageButton.ForeColor = System.Drawing.Color.PeachPuff;
            this.LoadImageButton.Location = new System.Drawing.Point(12, 12);
            this.LoadImageButton.Name = "LoadImageButton";
            this.LoadImageButton.Size = new System.Drawing.Size(140, 56);
            this.LoadImageButton.TabIndex = 3;
            this.LoadImageButton.Text = "Load Image";
            this.LoadImageButton.UseVisualStyleBackColor = false;
            this.LoadImageButton.Click += new System.EventHandler(this.LoadImageButton_Click);
            // 
            // ColorChannelButton
            // 
            this.ColorChannelButton.BackColor = System.Drawing.Color.DimGray;
            this.ColorChannelButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColorChannelButton.ForeColor = System.Drawing.Color.Wheat;
            this.ColorChannelButton.Location = new System.Drawing.Point(12, 514);
            this.ColorChannelButton.Name = "ColorChannelButton";
            this.ColorChannelButton.Size = new System.Drawing.Size(100, 40);
            this.ColorChannelButton.TabIndex = 5;
            this.ColorChannelButton.Text = "Channel";
            this.ColorChannelButton.UseVisualStyleBackColor = false;
            this.ColorChannelButton.Click += new System.EventHandler(this.ColorChannelButton_Click);
            // 
            // GrayConvertButton
            // 
            this.GrayConvertButton.BackColor = System.Drawing.Color.DimGray;
            this.GrayConvertButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrayConvertButton.ForeColor = System.Drawing.Color.Wheat;
            this.GrayConvertButton.Location = new System.Drawing.Point(12, 114);
            this.GrayConvertButton.Name = "GrayConvertButton";
            this.GrayConvertButton.Size = new System.Drawing.Size(100, 40);
            this.GrayConvertButton.TabIndex = 6;
            this.GrayConvertButton.Text = "Gray";
            this.GrayConvertButton.UseVisualStyleBackColor = false;
            this.GrayConvertButton.Click += new System.EventHandler(this.GrayConvertButton_Click);
            // 
            // SepiaConvertButton
            // 
            this.SepiaConvertButton.BackColor = System.Drawing.Color.DimGray;
            this.SepiaConvertButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SepiaConvertButton.ForeColor = System.Drawing.Color.Wheat;
            this.SepiaConvertButton.Location = new System.Drawing.Point(12, 154);
            this.SepiaConvertButton.Name = "SepiaConvertButton";
            this.SepiaConvertButton.Size = new System.Drawing.Size(100, 40);
            this.SepiaConvertButton.TabIndex = 7;
            this.SepiaConvertButton.Text = "Sepia";
            this.SepiaConvertButton.UseVisualStyleBackColor = false;
            this.SepiaConvertButton.Click += new System.EventHandler(this.SepiaConvertButton_Click);
            // 
            // ConAndBrButton
            // 
            this.ConAndBrButton.BackColor = System.Drawing.Color.DimGray;
            this.ConAndBrButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConAndBrButton.ForeColor = System.Drawing.Color.Wheat;
            this.ConAndBrButton.Location = new System.Drawing.Point(12, 194);
            this.ConAndBrButton.Name = "ConAndBrButton";
            this.ConAndBrButton.Size = new System.Drawing.Size(100, 40);
            this.ConAndBrButton.TabIndex = 8;
            this.ConAndBrButton.Text = "Con and br";
            this.ConAndBrButton.UseVisualStyleBackColor = false;
            this.ConAndBrButton.Click += new System.EventHandler(this.ConAndBrButton_Click);
            // 
            // HsvConvertButton
            // 
            this.HsvConvertButton.BackColor = System.Drawing.Color.DimGray;
            this.HsvConvertButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HsvConvertButton.ForeColor = System.Drawing.Color.Wheat;
            this.HsvConvertButton.Location = new System.Drawing.Point(12, 234);
            this.HsvConvertButton.Name = "HsvConvertButton";
            this.HsvConvertButton.Size = new System.Drawing.Size(100, 40);
            this.HsvConvertButton.TabIndex = 9;
            this.HsvConvertButton.Text = "Hsv";
            this.HsvConvertButton.UseVisualStyleBackColor = false;
            this.HsvConvertButton.Click += new System.EventHandler(this.HsvConvertButton_Click);
            // 
            // AdditionButton
            // 
            this.AdditionButton.BackColor = System.Drawing.Color.DimGray;
            this.AdditionButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionButton.ForeColor = System.Drawing.Color.Wheat;
            this.AdditionButton.Location = new System.Drawing.Point(12, 274);
            this.AdditionButton.Name = "AdditionButton";
            this.AdditionButton.Size = new System.Drawing.Size(100, 40);
            this.AdditionButton.TabIndex = 10;
            this.AdditionButton.Text = "Addition";
            this.AdditionButton.UseVisualStyleBackColor = false;
            this.AdditionButton.Click += new System.EventHandler(this.AdditionButton_Click);
            // 
            // CrossingButton
            // 
            this.CrossingButton.BackColor = System.Drawing.Color.DimGray;
            this.CrossingButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrossingButton.ForeColor = System.Drawing.Color.Wheat;
            this.CrossingButton.Location = new System.Drawing.Point(12, 354);
            this.CrossingButton.Name = "CrossingButton";
            this.CrossingButton.Size = new System.Drawing.Size(100, 40);
            this.CrossingButton.TabIndex = 11;
            this.CrossingButton.Text = "Crossing";
            this.CrossingButton.UseVisualStyleBackColor = false;
            this.CrossingButton.Click += new System.EventHandler(this.CrossingButton_Click);
            // 
            // MedianBlurButton
            // 
            this.MedianBlurButton.BackColor = System.Drawing.Color.DimGray;
            this.MedianBlurButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedianBlurButton.ForeColor = System.Drawing.Color.Wheat;
            this.MedianBlurButton.Location = new System.Drawing.Point(12, 394);
            this.MedianBlurButton.Name = "MedianBlurButton";
            this.MedianBlurButton.Size = new System.Drawing.Size(100, 40);
            this.MedianBlurButton.TabIndex = 12;
            this.MedianBlurButton.Text = "Median";
            this.MedianBlurButton.UseVisualStyleBackColor = false;
            this.MedianBlurButton.Click += new System.EventHandler(this.MedianBlurButton_Click);
            // 
            // WindowFiltersButton
            // 
            this.WindowFiltersButton.BackColor = System.Drawing.Color.DimGray;
            this.WindowFiltersButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WindowFiltersButton.ForeColor = System.Drawing.Color.Wheat;
            this.WindowFiltersButton.Location = new System.Drawing.Point(12, 434);
            this.WindowFiltersButton.Name = "WindowFiltersButton";
            this.WindowFiltersButton.Size = new System.Drawing.Size(100, 40);
            this.WindowFiltersButton.TabIndex = 13;
            this.WindowFiltersButton.Text = "Filters";
            this.WindowFiltersButton.UseVisualStyleBackColor = false;
            this.WindowFiltersButton.Click += new System.EventHandler(this.WindowFiltersButton_Click);
            // 
            // WatercolorFilterButton
            // 
            this.WatercolorFilterButton.BackColor = System.Drawing.Color.DimGray;
            this.WatercolorFilterButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WatercolorFilterButton.ForeColor = System.Drawing.Color.Wheat;
            this.WatercolorFilterButton.Location = new System.Drawing.Point(12, 474);
            this.WatercolorFilterButton.Name = "WatercolorFilterButton";
            this.WatercolorFilterButton.Size = new System.Drawing.Size(100, 40);
            this.WatercolorFilterButton.TabIndex = 14;
            this.WatercolorFilterButton.Text = "Watercolor";
            this.WatercolorFilterButton.UseVisualStyleBackColor = false;
            this.WatercolorFilterButton.Click += new System.EventHandler(this.WatercolorFilterButton_Click);
            // 
            // CartoonFilterButton
            // 
            this.CartoonFilterButton.BackColor = System.Drawing.Color.DimGray;
            this.CartoonFilterButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CartoonFilterButton.ForeColor = System.Drawing.Color.Wheat;
            this.CartoonFilterButton.Location = new System.Drawing.Point(12, 74);
            this.CartoonFilterButton.Name = "CartoonFilterButton";
            this.CartoonFilterButton.Size = new System.Drawing.Size(100, 40);
            this.CartoonFilterButton.TabIndex = 15;
            this.CartoonFilterButton.Text = "Cartoon";
            this.CartoonFilterButton.UseVisualStyleBackColor = false;
            this.CartoonFilterButton.Click += new System.EventHandler(this.CartoonFilterButton_Click);
            // 
            // ExceptionButton
            // 
            this.ExceptionButton.BackColor = System.Drawing.Color.DimGray;
            this.ExceptionButton.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExceptionButton.ForeColor = System.Drawing.Color.Wheat;
            this.ExceptionButton.Location = new System.Drawing.Point(12, 314);
            this.ExceptionButton.Name = "ExceptionButton";
            this.ExceptionButton.Size = new System.Drawing.Size(100, 40);
            this.ExceptionButton.TabIndex = 16;
            this.ExceptionButton.Text = "Exception";
            this.ExceptionButton.UseVisualStyleBackColor = false;
            this.ExceptionButton.Click += new System.EventHandler(this.ExceptionButton_Click);
            // 
            // Scale
            // 
            this.Scale.BackColor = System.Drawing.Color.DimGray;
            this.Scale.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scale.ForeColor = System.Drawing.Color.Wheat;
            this.Scale.Location = new System.Drawing.Point(831, 74);
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(100, 40);
            this.Scale.TabIndex = 17;
            this.Scale.Text = "Scale";
            this.Scale.UseVisualStyleBackColor = false;
            this.Scale.Click += new System.EventHandler(this.Scale_Click);
            // 
            // Shearing
            // 
            this.Shearing.BackColor = System.Drawing.Color.DimGray;
            this.Shearing.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Shearing.ForeColor = System.Drawing.Color.Wheat;
            this.Shearing.Location = new System.Drawing.Point(831, 130);
            this.Shearing.Name = "Shearing";
            this.Shearing.Size = new System.Drawing.Size(100, 40);
            this.Shearing.TabIndex = 18;
            this.Shearing.Text = "Shearing";
            this.Shearing.UseVisualStyleBackColor = false;
            this.Shearing.Click += new System.EventHandler(this.Shearing_Click);
            // 
            // Rotation
            // 
            this.Rotation.BackColor = System.Drawing.Color.DimGray;
            this.Rotation.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rotation.ForeColor = System.Drawing.Color.Wheat;
            this.Rotation.Location = new System.Drawing.Point(831, 194);
            this.Rotation.Name = "Rotation";
            this.Rotation.Size = new System.Drawing.Size(100, 40);
            this.Rotation.TabIndex = 19;
            this.Rotation.Text = "Rotation";
            this.Rotation.UseVisualStyleBackColor = false;
            this.Rotation.Click += new System.EventHandler(this.Rotation_Click);
            // 
            // Homography
            // 
            this.Homography.BackColor = System.Drawing.Color.DimGray;
            this.Homography.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Homography.ForeColor = System.Drawing.Color.Wheat;
            this.Homography.Location = new System.Drawing.Point(831, 251);
            this.Homography.Name = "Homography";
            this.Homography.Size = new System.Drawing.Size(100, 40);
            this.Homography.TabIndex = 20;
            this.Homography.Text = "Homography";
            this.Homography.UseVisualStyleBackColor = false;
            this.Homography.Click += new System.EventHandler(this.Homography_Click);
            // 
            // Reflection
            // 
            this.Reflection.BackColor = System.Drawing.Color.DimGray;
            this.Reflection.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reflection.ForeColor = System.Drawing.Color.Wheat;
            this.Reflection.Location = new System.Drawing.Point(831, 314);
            this.Reflection.Name = "Reflection";
            this.Reflection.Size = new System.Drawing.Size(100, 40);
            this.Reflection.TabIndex = 21;
            this.Reflection.Text = "Reflection";
            this.Reflection.UseVisualStyleBackColor = false;
            this.Reflection.Click += new System.EventHandler(this.Reflection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(964, 628);
            this.Controls.Add(this.Reflection);
            this.Controls.Add(this.Homography);
            this.Controls.Add(this.Rotation);
            this.Controls.Add(this.Shearing);
            this.Controls.Add(this.Scale);
            this.Controls.Add(this.ExceptionButton);
            this.Controls.Add(this.CartoonFilterButton);
            this.Controls.Add(this.WatercolorFilterButton);
            this.Controls.Add(this.WindowFiltersButton);
            this.Controls.Add(this.MedianBlurButton);
            this.Controls.Add(this.CrossingButton);
            this.Controls.Add(this.AdditionButton);
            this.Controls.Add(this.HsvConvertButton);
            this.Controls.Add(this.ConAndBrButton);
            this.Controls.Add(this.SepiaConvertButton);
            this.Controls.Add(this.GrayConvertButton);
            this.Controls.Add(this.ColorChannelButton);
            this.Controls.Add(this.LoadImageButton);
            this.Controls.Add(this.FinalImageBox);
            this.Controls.Add(this.SourceImageBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.SourceImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FinalImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Emgu.CV.UI.ImageBox SourceImageBox;
        private Emgu.CV.UI.ImageBox FinalImageBox;
        private System.Windows.Forms.Button LoadImageButton;
        private System.Windows.Forms.Button ColorChannelButton;
        private System.Windows.Forms.Button GrayConvertButton;
        private System.Windows.Forms.Button SepiaConvertButton;
        private System.Windows.Forms.Button ConAndBrButton;
        private System.Windows.Forms.Button HsvConvertButton;
        private System.Windows.Forms.Button AdditionButton;
        private System.Windows.Forms.Button CrossingButton;
        private System.Windows.Forms.Button MedianBlurButton;
        private System.Windows.Forms.Button WindowFiltersButton;
        private System.Windows.Forms.Button WatercolorFilterButton;
        private System.Windows.Forms.Button CartoonFilterButton;
        private System.Windows.Forms.Button ExceptionButton;
        private System.Windows.Forms.Button Scale;
        private System.Windows.Forms.Button Shearing;
        private System.Windows.Forms.Button Rotation;
        private System.Windows.Forms.Button Homography;
        private System.Windows.Forms.Button Reflection;
    }
}

