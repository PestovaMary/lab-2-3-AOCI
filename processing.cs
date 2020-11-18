using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;

namespace Lab2
{
    class processing
    {
        public enum Channel : int
        {
            BLUE,
            GREEN,
            RED
        }

        public enum FilterName : int
        {
            SHARPEN,
            EMBOS,
            FACETS
        }

        public PointF[] pts { get; set; } = new PointF[4];

        private Image<Bgr, byte> sourceImage;

        private Image<Bgr, byte> tmpImage;

        public processing() { }

        public processing(Image<Bgr, byte> sourceImage)
        {
            this.sourceImage = sourceImage;
            tmpImage = sourceImage;
        }

        public Image<Bgr, byte> BgrChannel(Channel ch) //Вывод одного из каналов
        {
            Image<Gray, byte> channel;
            VectorOfMat vm = new VectorOfMat();
            Image<Bgr, byte> finalImage = sourceImage.CopyBlank();

            switch (ch)
            {
                case Channel.BLUE:
                    channel = sourceImage.Split()[(int)Channel.BLUE];

                    vm.Push(channel);
                    vm.Push(channel.CopyBlank());
                    vm.Push(channel.CopyBlank());

                    CvInvoke.Merge(vm, finalImage);
                    return finalImage;

                case Channel.GREEN:
                    channel = sourceImage.Split()[(int)Channel.GREEN];

                    vm.Push(channel.CopyBlank());
                    vm.Push(channel);
                    vm.Push(channel.CopyBlank());

                    CvInvoke.Merge(vm, finalImage);
                    return finalImage;

                case Channel.RED:
                    channel = sourceImage.Split()[(int)Channel.RED];

                    vm.Push(channel.CopyBlank());
                    vm.Push(channel.CopyBlank());
                    vm.Push(channel);

                    CvInvoke.Merge(vm, finalImage);
                    return finalImage;
            }

            return null;
        }

        public Image<Gray, byte> Bgr2Gray() //Перевод изображения из BGR в GRAY
        {
            Image<Gray, byte> finalImage = new Image<Gray, byte>(sourceImage.Size);

            for (int x = 0; x < sourceImage.Width; x++)
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    finalImage.Data[y, x, 0] = Convert.ToByte(0.299 * sourceImage.Data[y, x, 2] + 0.587 * sourceImage.Data[y, x, 1] + 0.114 * sourceImage.Data[y, x, 0]);
                }

            return finalImage;
        }

        public Image<Bgr, byte> Bgr2Sepia() //Перевод изображения из BGR в Sepia
        {
            var finalImage = sourceImage.CopyBlank();

            for (int x = 0; x < sourceImage.Width; x++)
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    finalImage.Data[y, x, 0] = Convert.ToByte(DoubleRound(0.272 * sourceImage.Data[y, x, 2] + 0.534 * sourceImage.Data[y, x, 1] + 0.131 * sourceImage.Data[y, x, 0]));
                    finalImage.Data[y, x, 1] = Convert.ToByte(DoubleRound(0.349 * sourceImage.Data[y, x, 2] + 0.686 * sourceImage.Data[y, x, 1] + 0.168 * sourceImage.Data[y, x, 0]));
                    finalImage.Data[y, x, 2] = Convert.ToByte(DoubleRound(0.393 * sourceImage.Data[y, x, 2] + 0.769 * sourceImage.Data[y, x, 1] + 0.189 * sourceImage.Data[y, x, 0]));
                }

            return finalImage;
        }

        private double DoubleRound(double number)
        {
            if (number < 0)
                number = 0.0;

            if (number > 255)
                number = 255.0;

            return number;
        }

        public Image<Bgr, byte> ContrastAndBrightness(int Contrast, int Brightness) //Регулировка контраста и яркости изображения
        {
            var finalImage = sourceImage.CopyBlank();
            double c = Contrast * 0.1;

            for (int x = 0; x < sourceImage.Width; x++)
                for (int y = 0; y < sourceImage.Height; y++)
                {
                    finalImage.Data[y, x, 0] = Convert.ToByte(DoubleRound(sourceImage.Data[y, x, 0] * c + Brightness));
                    finalImage.Data[y, x, 1] = Convert.ToByte(DoubleRound(sourceImage.Data[y, x, 1] * c + Brightness));
                    finalImage.Data[y, x, 2] = Convert.ToByte(DoubleRound(sourceImage.Data[y, x, 2] * c + Brightness));
                }

            return finalImage;
        }

        public Image<Hsv, byte> Bgr2Hsv(int Hue)
        {
            Image<Hsv, byte> finalImage = sourceImage.Convert<Hsv, byte>();

            for (int x = 0; x < finalImage.Width; x++)
                for (int y = 0; y < finalImage.Height; y++)
                {
                    finalImage.Data[y, x, 0] = (byte)(Hue);
                }

            return finalImage;
        }

        public Image<Bgr, byte> Addition(Image<Bgr, byte> SecondImage, double FirstParam, double SecondParam)
        {
            var tmp = sourceImage.Resize(320, 470, Inter.Linear);
            var sImg = SecondImage.Resize(320, 470, Inter.Linear);

            var finalImage = tmp.CopyBlank();

            for (int x = 0; x < tmp.Width; x++)
                for (int y = 0; y < tmp.Height; y++)
                {
                    finalImage.Data[y, x, 0] = (byte)DoubleRound(tmp.Data[y, x, 0] * FirstParam + sImg.Data[y, x, 0] * SecondParam);
                    finalImage.Data[y, x, 1] = (byte)DoubleRound(tmp.Data[y, x, 1] * FirstParam + sImg.Data[y, x, 1] * SecondParam);
                    finalImage.Data[y, x, 2] = (byte)DoubleRound(tmp.Data[y, x, 2] * FirstParam + sImg.Data[y, x, 2] * SecondParam);
                }

            return finalImage;
        }

        public Image<Bgr, byte> Exception(Image<Bgr, byte> Mask)
        {
            var finalImage = sourceImage.Resize(320, 470, Inter.Linear);
            var mImg = Mask.Resize(320, 470, Inter.Linear);

            for (int x = 0; x < mImg.Width; x++)
                for (int y = 0; y < mImg.Height; y++)
                {
                    if ((mImg.Data[y, x, 0] <= 100) || (mImg.Data[y, x, 1] <= 100) || (mImg.Data[y, x, 2] <= 100))
                    {
                        finalImage.Data[y, x, 0] = 0;
                        finalImage.Data[y, x, 1] = 0;
                        finalImage.Data[y, x, 2] = 0;
                    }
                }

            return finalImage;
        }

        public Image<Bgr, byte> Crossing(Image<Bgr, byte> Mask)
        {
            var finalImage = sourceImage.Resize(320, 470, Inter.Linear);
            var mImg = Mask.Resize(320, 470, Inter.Linear);

            for (int x = 0; x < mImg.Width; x++)
                for (int y = 0; y < mImg.Height; y++)
                {
                    if ((mImg.Data[y, x, 0] > 100) && (mImg.Data[y, x, 1] > 100) && (mImg.Data[y, x, 2] > 100))
                    {
                        finalImage.Data[y, x, 0] = 0;
                        finalImage.Data[y, x, 1] = 0;
                        finalImage.Data[y, x, 2] = 0;
                    }
                }

            return finalImage;
        }

        public Image<Bgr, byte> MedianBlur()
        {
            var finalImage = tmpImage.CopyBlank();
            List<int> median = new List<int>();

            for (int channel = 0; channel < 3; channel++)
                for (int x = 1; x < tmpImage.Width - 1; x++)
                    for (int y = 1; y < tmpImage.Height - 1; y++)
                    {
                        median.Clear();

                        median.Add(tmpImage.Data[y - 1, x - 1, channel]);
                        median.Add(tmpImage.Data[y - 1, x, channel]);
                        median.Add(tmpImage.Data[y - 1, x + 1, channel]);
                        median.Add(tmpImage.Data[y, x - 1, channel]);
                        median.Add(tmpImage.Data[y, x, channel]);
                        median.Add(tmpImage.Data[y, x + 1, channel]);
                        median.Add(tmpImage.Data[y + 1, x - 1, channel]);
                        median.Add(tmpImage.Data[y + 1, x, channel]);
                        median.Add(tmpImage.Data[y + 1, x + 1, channel]);

                        median.Sort();

                        int tmp = 0;

                        foreach (int n in median)
                        {
                            tmp += n;
                        }

                        tmp = tmp / median.Count;

                        finalImage.Data[y - 1, x - 1, channel] = (byte)tmp;
                        finalImage.Data[y - 1, x, channel] = (byte)tmp;
                        finalImage.Data[y - 1, x + 1, channel] = (byte)tmp;
                        finalImage.Data[y, x - 1, channel] = (byte)tmp;
                        finalImage.Data[y, x, channel] = (byte)tmp;
                        finalImage.Data[y, x + 1, channel] = (byte)tmp;
                        finalImage.Data[y + 1, x - 1, channel] = (byte)tmp;
                        finalImage.Data[y + 1, x, channel] = (byte)tmp;
                        finalImage.Data[y + 1, x + 1, channel] = (byte)tmp;
                    }

            return finalImage;
        }


        public Image<Bgr, byte> WindowFilter(FilterName filter)
        {
            switch (filter)
            {
                case FilterName.SHARPEN:
                    return Sharpen();

                case FilterName.EMBOS:
                    return Embos();

                case FilterName.FACETS:
                    return Facets();
            }

            return null;
        }

        private Image<Bgr, byte> Sharpen()
        {
            var finalImage = sourceImage.CopyBlank();

            for (int channel = 0; channel < 3; channel++)
                for (int x = 1; x < sourceImage.Width - 1; x++)
                    for (int y = 1; y < sourceImage.Height - 1; y++)
                    {
                        int q = 0;

                        q += sourceImage.Data[y - 1, x - 1, channel] * -1;
                        q += sourceImage.Data[y - 1, x, channel] * -1;
                        q += sourceImage.Data[y - 1, x + 1, channel] * -1;
                        q += sourceImage.Data[y, x - 1, channel] * -1;
                        q += sourceImage.Data[y, x, channel] * 9;
                        q += sourceImage.Data[y, x + 1, channel] * -1;
                        q += sourceImage.Data[y + 1, x - 1, channel] * -1;
                        q += sourceImage.Data[y + 1, x, channel] * -1;
                        q += sourceImage.Data[y + 1, x + 1, channel] * -1;

                        finalImage.Data[y, x, channel] = (byte)(DoubleRound(q / 1));
                    }

            return finalImage;
        }

        private Image<Bgr, byte> Embos()
        {
            var finalImage = sourceImage.CopyBlank();

            for (int channel = 0; channel < 3; channel++)
                for (int x = 1; x < sourceImage.Width - 1; x++)
                    for (int y = 1; y < sourceImage.Height - 1; y++)
                    {
                        int q = 0;

                        q += sourceImage.Data[y - 1, x - 1, channel] * -4;
                        q += sourceImage.Data[y - 1, x, channel] * -2;
                        q += sourceImage.Data[y - 1, x + 1, channel] * 0;
                        q += sourceImage.Data[y, x - 1, channel] * -2;
                        q += sourceImage.Data[y, x, channel] * 1;
                        q += sourceImage.Data[y, x + 1, channel] * 2;
                        q += sourceImage.Data[y + 1, x - 1, channel] * 0;
                        q += sourceImage.Data[y + 1, x, channel] * 2;
                        q += sourceImage.Data[y + 1, x + 1, channel] * 4;

                        finalImage.Data[y, x, channel] = (byte)(DoubleRound(q / 5));
                    }

            return finalImage;
        }

        private Image<Bgr, byte> Facets()
        {
            var finalImage = sourceImage.CopyBlank();

            for (int channel = 0; channel < 3; channel++)
                for (int x = 1; x < sourceImage.Width - 1; x++)
                    for (int y = 1; y < sourceImage.Height - 1; y++)
                    {
                        int q = 0;

                        q += sourceImage.Data[y - 1, x - 1, channel] * 0;
                        q += sourceImage.Data[y - 1, x, channel] * 0;
                        q += sourceImage.Data[y - 1, x + 1, channel] * 0;
                        q += sourceImage.Data[y, x - 1, channel] * -4;
                        q += sourceImage.Data[y, x, channel] * 4;
                        q += sourceImage.Data[y, x + 1, channel] * 0;
                        q += sourceImage.Data[y + 1, x - 1, channel] * 0;
                        q += sourceImage.Data[y + 1, x, channel] * 0;
                        q += sourceImage.Data[y + 1, x + 1, channel] * 0;

                        finalImage.Data[y, x, channel] = (byte)(DoubleRound(q / 1));
                    }

            return finalImage;
        }

        public Image<Bgr, byte> Watercolor(Image<Bgr, byte> Mask)
        {
            Image<Bgr, byte> finalImage = sourceImage.Copy();

            if (sourceImage != null)
            {
                tmpImage = Addition(Mask, 0.8, 0.2);
                finalImage = MedianBlur();
            }

            return finalImage;
        }

        public Image<Bgr, byte> CartoonFilter(int Color1, int Color2, int Color3, int Color4)
        {

            var GrayCopy = MedianBlur().Convert<Gray, byte>();
            GrayCopy = GrayCopy.ThresholdAdaptive(new Gray(100), AdaptiveThresholdType.MeanC, ThresholdType.Binary, 3, new Gray(0.03));

            for (int y = 0; y < GrayCopy.Height; y++)
                for (int x = 0; x < GrayCopy.Width; x++)
                {
                    if (GrayCopy.Data[y, x, 0] == 0)
                        GrayCopy.Data[y, x, 0] = 255;
                    else
                        GrayCopy.Data[y, x, 0] = 0;
                }

            var GrayCopyBGR = GrayCopy.Convert<Bgr, byte>();
            var finalImage = sourceImage.Sub(GrayCopyBGR);

            for (int channel = 0; channel < finalImage.NumberOfChannels; channel++)
                for (int x = 0; x < finalImage.Width; x++)
                    for (int y = 0; y < finalImage.Height; y++)
                    {
                        byte color = finalImage.Data[y, x, channel];
                        if (color <= 50)
                            color = (byte)Color1;
                        else if (color <= 100)
                            color = (byte)Color2;
                        else if (color <= 150)
                            color = (byte)Color3;
                        else if (color <= 200)
                            color = (byte)Color4;
                        else
                            color = 255;
                        finalImage.Data[y, x, channel] = color;
                    }

            return finalImage;
        }

        public Image<Bgr, byte> Zooming(double width, double height)
        {

            Image<Bgr, byte> finalImage = new Image<Bgr, byte>((int)(sourceImage.Width * width), (int)(sourceImage.Height * height));

            for (int i = 0; i < finalImage.Width - 1; i++)
            {
                for (int j = 0; j < finalImage.Height - 1; j++)
                {
                    double I = i / width;
                    double J = j / height;

                    double baseI = Math.Floor(I);
                    double baseJ = Math.Floor(J);

                    if (baseI >= sourceImage.Width - 1) continue;
                    if (baseJ >= sourceImage.Height - 1) continue;

                    double rI = I - baseI;
                    double rJ = J - baseJ;

                    double irI = 1 - rI;
                    double irJ = 1 - rJ;

                    Bgr c1 = new Bgr();
                    c1.Blue = sourceImage.Data[(int)baseJ, (int)baseI, 0] * irI + sourceImage.Data[(int)baseJ, (int)baseI + 1, 0] * rI;
                    c1.Green = sourceImage.Data[(int)baseJ, (int)baseI, 1] * irI + sourceImage.Data[(int)baseJ, (int)baseI + 1, 1] * rI;
                    c1.Red = sourceImage.Data[(int)baseJ, (int)baseI, 2] * irI + sourceImage.Data[(int)baseJ, (int)baseI + 1, 2] * rI;

                    Bgr c2 = new Bgr();
                    c2.Blue = sourceImage.Data[(int)baseJ + 1, (int)baseI, 0] * irI + sourceImage.Data[(int)baseJ + 1, (int)baseI + 1, 0] * rI;
                    c2.Green = sourceImage.Data[(int)baseJ + 1, (int)baseI, 1] * irI + sourceImage.Data[(int)baseJ + 1, (int)baseI + 1, 1] * rI;
                    c2.Red = sourceImage.Data[(int)baseJ + 1, (int)baseI, 2] * irI + sourceImage.Data[(int)baseJ + 1, (int)baseI + 1, 2] * rI;

                    Bgr c = new Bgr();
                    c.Blue = c1.Blue * irJ + c2.Blue * rJ;
                    c.Green = c1.Green * irJ + c2.Green * rJ;
                    c.Red = c1.Red * irJ + c2.Red * rJ;



                    finalImage[j, i] = c;
                }
            }

            return finalImage;
        }

        public Image<Bgr, byte> Shearing(int shift1)
        {
            double shift = ((double)shift1)/100;
            int newX=0; int newY=0;
            Image<Bgr, byte> finalImage = new Image<Bgr, byte>((int)(sourceImage.Width + sourceImage.Width * shift) + 1, (int)(sourceImage.Height));
            for (int i = 0; i < sourceImage.Width; i++)
                for (int j = 0; j < sourceImage.Height; j++)
                {
                    newX = (int)(i + shift * (sourceImage.Height - j));
                    newY = (int)(j);
                    if (newX <= sourceImage.Width)
                    {
                        finalImage[newY, newX] = sourceImage[j, i];
                        
                    }                  
                }
            return finalImage;
        }

        public Image<Bgr, byte> Rotation(double angle)
        {
            double rad = angle * (Math.PI / 180.0);
            Image<Bgr, byte> finalImage = new Image<Bgr, byte>((int)(sourceImage.Width), (int)(sourceImage.Height));
            for (int i = 0; i < sourceImage.Width - 1; i++)
                for (int j = 0; j < sourceImage.Height - 1; j++)
                {
                    int newX = (int)(Math.Cos(rad) * (i - sourceImage.Width / 2) - Math.Sin(rad) * (j - sourceImage.Height / 2) + sourceImage.Width / 2);
                    int newY = (int)(Math.Sin(rad) * (i - sourceImage.Width / 2) + Math.Cos(rad) * (j - sourceImage.Height / 2) + sourceImage.Height / 2);

                    if (newY > 0 && newX > 0 && newX < sourceImage.Width && newY < sourceImage.Height)
                    {
                        double baseI = Math.Floor((double)newX);
                        double baseJ = Math.Floor((double)newY);

                        if (baseI >= sourceImage.Width - 1) continue;
                        if (baseJ >= sourceImage.Height - 1) continue;

                        double rI = newX - baseI;
                        double rJ = newY - baseJ;

                        double irI = 1 - rI;
                        double irJ = 1 - rJ;

                        Bgr c = new Bgr();
                        Bgr c1 = new Bgr();
                        Bgr c2 = new Bgr();

                        c1.Blue = sourceImage.Data[(int)baseJ, (int)baseI, 0] * irI + sourceImage.Data[(int)baseJ, (int)baseI + 1, 0] * rI;
                        c1.Green = sourceImage.Data[(int)baseJ, (int)baseI, 1] * irI + sourceImage.Data[(int)baseJ, (int)baseI + 1, 1] * rI;
                        c1.Red = sourceImage.Data[(int)baseJ, (int)baseI, 2] * irI + sourceImage.Data[(int)baseJ, (int)baseI + 1, 2] * rI;


                        c2.Blue = sourceImage.Data[(int)baseJ + 1, (int)baseI, 0] * irI + sourceImage.Data[(int)baseJ + 1, (int)baseI + 1, 0] * rI;
                        c2.Green = sourceImage.Data[(int)baseJ + 1, (int)baseI, 1] * irI + sourceImage.Data[(int)baseJ + 1, (int)baseI + 1, 1] * rI;
                        c2.Red = sourceImage.Data[(int)baseJ + 1, (int)baseI, 2] * irI + sourceImage.Data[(int)baseJ + 1, (int)baseI + 1, 2] * rI;

                        c.Blue = c1.Blue * irJ + c2.Blue * rJ;
                        c.Green = c1.Green * irJ + c2.Green * rJ;
                        c.Red = c1.Red * irJ + c2.Red * rJ;

                       finalImage[j, i] = c;
                    }
                }
            return finalImage;
        }

        public Image<Bgr, byte> Homography(Image<Bgr, byte> copyImage)
        {
            var destPoints = new PointF[]
            {
                new PointF(0, 0),
                new PointF(0, copyImage.Height - 1),
                new PointF(copyImage.Width - 1, copyImage.Height - 1),
                new PointF(copyImage.Width - 1, 0)
            };

            var homographyMatrix = CvInvoke.GetPerspectiveTransform(pts, destPoints);
            var destImage = new Image<Bgr, byte>(copyImage.Size);
            CvInvoke.WarpPerspective(copyImage, destImage, homographyMatrix, destImage.Size);

            return destImage;
        }

        public Image<Bgr, byte> Reflection(int qX, int qY)
        {
            Image<Bgr, byte> reflectionImg = new Image<Bgr, byte>((int)(sourceImage.Width + sourceImage.Width), (int)(sourceImage.Height + sourceImage.Height));
            for (int i = 0; i < sourceImage.Width - 1; i++)
                for (int j = 0; j < sourceImage.Height - 1; j++)
                {
                    int newX = (int)(i * qX + sourceImage.Width);
                    int newY = (int)(j * qY + sourceImage.Height);
                    reflectionImg[newY, newX] = sourceImage[j, i];
                }

            return reflectionImg;
        }
    }
}
