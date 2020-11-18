using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;


namespace Lab2
{
    public partial class Form1 : Form
    {
        private Image<Bgr, byte> sourceImage;

        private Image<Bgr, byte> SecondImage;

        private processing ConvertedImage;
        int c = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void LoadImageButton_Click(object sender, EventArgs e)
        {
            FinalImageBox.Image = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            var result = openFileDialog.ShowDialog();

            try
            {
                if (result == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    sourceImage = new Image<Bgr, byte>(fileName);
                    SourceImageBox.Image = sourceImage.Resize(320, 470, Inter.Linear);
                    ConvertedImage = new processing(sourceImage);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Select an image");
            }
        }

        private void ColorChannelButton_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                ChannelSelect form = new ChannelSelect();
                form.ChannelSelected += Form_ChannelSelected;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }

        private void Form_ChannelSelected(object sender, ChannelSelect.ColorChannelEventArgs e)
        {
            if (e.Channel == 0)
                FinalImageBox.Image = ConvertedImage.BgrChannel(processing.Channel.BLUE).Resize(320, 470, Inter.Linear);

            if (e.Channel == 1)
                FinalImageBox.Image = ConvertedImage.BgrChannel(processing.Channel.GREEN).Resize(320, 470, Inter.Linear);

            if (e.Channel == 2)
                FinalImageBox.Image = ConvertedImage.BgrChannel(processing.Channel.RED).Resize(320, 470, Inter.Linear);
        }

        private void GrayConvertButton_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
                FinalImageBox.Image = ConvertedImage.Bgr2Gray().Resize(320, 470, Inter.Linear);
            else
                MessageBox.Show("Select an image");
        }

        private void SepiaConvertButton_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
                FinalImageBox.Image = ConvertedImage.Bgr2Sepia().Resize(320, 470, Inter.Linear);
            else
                MessageBox.Show("Select an image");
        }

        private void ConAndBrButton_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                ContrastAndBrightness form = new ContrastAndBrightness();
                form.ParametresChange += Form_ParametresChange;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }

        private void Form_ParametresChange(object sender, ContrastAndBrightness.ContrastBrightnessEventArgs e)
        {
            FinalImageBox.Image = ConvertedImage.ContrastAndBrightness(e.Contrast, e.Brightness).Resize(320, 470, Inter.Linear);
        }

        private void HsvConvertButton_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                HSV form = new HSV();
                form.HSVParametresChange += Form_HSVParametresChange;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }

        private void Form_HSVParametresChange(object sender, HSV.HSVEventArgs e)
        {
            FinalImageBox.Image = ConvertedImage.Bgr2Hsv(e.Hue).Resize(320, 470, Inter.Linear);
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {            
                if (ConvertedImage != null)
                {
                    FinalImageBox.Image = null;
                    OpenFileDialog openFileDialog = new OpenFileDialog();
                    openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                    var result = openFileDialog.ShowDialog();

                    try
                    {
                        if (result == DialogResult.OK)
                        {
                            string fileName = openFileDialog.FileName;
                            SecondImage = new Image<Bgr, byte>(fileName);

                            Addition form = new Addition();
                            form.ImageParam += Form_ImageParam;
                            form.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        MessageBox.Show("Select an image");
                    }
                }
        }

        private void Form_ImageParam(object sender, Addition.ParamsEventArgs e)
        {
            FinalImageBox.Image = ConvertedImage.Addition(SecondImage, e.FirstParam, e.SecondParam);
        }

        private void ExceptionButton_Click(object sender, EventArgs e)
        {
            if (ConvertedImage != null)
            {
                FinalImageBox.Image = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                var result = openFileDialog.ShowDialog();

                try
                {
                    if (result == DialogResult.OK)
                    {
                        string fileName = openFileDialog.FileName;
                        SecondImage = new Image<Bgr, byte>(fileName);

                        FinalImageBox.Image = ConvertedImage.Exception(SecondImage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Select an image");
                }
            }
        }

        private void CrossingButton_Click(object sender, EventArgs e)
        {
            if (ConvertedImage != null)
            {
                FinalImageBox.Image = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                var result = openFileDialog.ShowDialog();

                try
                {
                    if (result == DialogResult.OK)
                    {
                        string fileName = openFileDialog.FileName;
                        SecondImage = new Image<Bgr, byte>(fileName);

                        FinalImageBox.Image = ConvertedImage.Crossing(SecondImage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Select an image");
                }
            }
        }

        private void MedianBlurButton_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                FinalImageBox.Image = ConvertedImage.MedianBlur().Resize(320, 470, Inter.Linear);
            }
            else
                MessageBox.Show("Select an image");
        }

        private void WindowFiltersButton_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                Filters form = new Filters();
                form.FilterSelected += Form_FilterSelected;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }

        private void Form_FilterSelected(object sender, Filters.FilterEventArgs e)
        {
            if (e.Filter == 0)
                FinalImageBox.Image = ConvertedImage.WindowFilter(processing.FilterName.SHARPEN).Resize(320, 470, Inter.Linear);
            if (e.Filter == 1)
                FinalImageBox.Image = ConvertedImage.WindowFilter(processing.FilterName.EMBOS).Resize(320, 470, Inter.Linear);
            if (e.Filter == 2)
                FinalImageBox.Image = ConvertedImage.WindowFilter(processing.FilterName.FACETS).Resize(320, 470, Inter.Linear);
        }

        private void WatercolorFilterButton_Click(object sender, EventArgs e)
        {
            if (ConvertedImage != null)
            {
                FinalImageBox.Image = null;
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Файлы изображений (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
                var result = openFileDialog.ShowDialog();

                try
                {
                    if (result == DialogResult.OK)
                    {
                        string fileName = openFileDialog.FileName;
                        SecondImage = new Image<Bgr, byte>(fileName);

                        FinalImageBox.Image = ConvertedImage.Watercolor(SecondImage);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    MessageBox.Show("Select an image");
                }
            }
        }
        
        private void form_CartoonParametersChange(object sender, Cartoon.CannyColor e)
        {
            FinalImageBox.Image = ConvertedImage.CartoonFilter(e.Color1, e.Color2, e.Color3, e.Color4).Resize(320, 470, Inter.Linear);
        }

        private void CartoonFilterButton_Click(object sender, EventArgs e)
        {
            FinalImageBox.Image = null;
           
            if (SourceImageBox.Image != null)
            {
                Cartoon form = new Cartoon();
                form.CartoonParametresChange += form_CartoonParametersChange;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }

        private void form_ZoomParametersChange(object sender, Zooming.ScaleParam e)
        {
            FinalImageBox.Image = ConvertedImage.Zooming(e.width, e.height);
        }

        private void Scale_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                Zooming form = new Zooming();
                form.ZoomParametresChange += form_ZoomParametersChange;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }

        private void form_ShiftParametersChange(object sender, Shearing.ShiftParam e)
        {
            FinalImageBox.Image = ConvertedImage.Shearing(e.shift);
        }

        private void Shearing_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                Shearing form = new Shearing();
                form.ShiftParametresChange += form_ShiftParametersChange;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }


        private void form_RotationParametersChange(object sender, Rotation.RotationParam e)
        {
            FinalImageBox.Image = ConvertedImage.Rotation(e.angle);
        }
        private void Rotation_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                Rotation form = new Rotation();
                form.RotationParametresChange += form_RotationParametersChange;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }

        private void SourceImageBox_Click(object sender, MouseEventArgs e)
        {
            var copyImage = sourceImage.Copy();

            int x = (int)(e.Location.X / SourceImageBox.ZoomScale);
            int y = (int)(e.Location.Y / SourceImageBox.ZoomScale);

            ConvertedImage.pts[c] = new Point(x, y);
            c++;
            if (c >= 4)
                c = 0;

            //Point center = new Point(x, y);
            int radius = 2;
            int thickness = 2;
            var color = new Bgr(Color.Blue).MCvScalar;

            for (int i = 0; i < 4; i++)
                CvInvoke.Circle(copyImage, new Point((int)ConvertedImage.pts[i].X, (int)ConvertedImage.pts[i].Y), radius, color, thickness);

            SourceImageBox.Image = copyImage;
        }

        private void Homography_Click(object sender, EventArgs e)
        {
            var copyImage = sourceImage.Copy();
            FinalImageBox.Image = ConvertedImage.Homography(copyImage);
        }

        private void form_ReflectionParametersChange(object sender, Reflection.ReflEventArgs e)
        {
            FinalImageBox.Image = ConvertedImage.Reflection(e.qX, e.qY);
        }
        private void Reflection_Click(object sender, EventArgs e)
        {
            if (SourceImageBox.Image != null)
            {
                Reflection form = new Reflection();
                form.ReflSelected += form_ReflectionParametersChange;
                form.Show();
            }
            else
                MessageBox.Show("Select an image");
        }
    }
}

