using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Cartoon : Form
    {

        public event EventHandler<CannyColor> CartoonParametresChange;

        public class CannyColor
        {


            public int Color1 { get; set; }
            public int Color2 { get; set; }
            public int Color3 { get; set; }
            public int Color4 { get; set; }
        }

        public Cartoon()
        {
            InitializeComponent();



            trackBar3.Maximum = 50;
            trackBar3.Minimum = 0;
            trackBar3.TickFrequency = 1;

            trackBar4.Maximum = 100;
            trackBar4.Minimum = 50;
            trackBar4.TickFrequency = 1;

            trackBar5.Maximum = 150;
            trackBar5.Minimum = 100;
            trackBar5.TickFrequency = 1;

            trackBar6.Maximum = 200;
            trackBar6.Minimum = 150;
            trackBar6.TickFrequency = 1;
        }

       

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            CartoonParametresChange?.Invoke(this, new CannyColor { Color1 = trackBar3.Value, Color2 = trackBar4.Value, Color3 = trackBar5.Value, Color4 = trackBar6.Value });
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            CartoonParametresChange?.Invoke(this, new CannyColor { Color1 = trackBar3.Value, Color2 = trackBar4.Value, Color3 = trackBar5.Value, Color4 = trackBar6.Value });
        }

        private void trackBar5_Scroll(object sender, EventArgs e)
        {
            CartoonParametresChange?.Invoke(this, new CannyColor { Color1 = trackBar3.Value, Color2 = trackBar4.Value, Color3 = trackBar5.Value, Color4 = trackBar6.Value });
        }

        private void trackBar6_Scroll(object sender, EventArgs e)
        {
            CartoonParametresChange?.Invoke(this, new CannyColor { Color1 = trackBar3.Value, Color2 = trackBar4.Value, Color3 = trackBar5.Value, Color4 = trackBar6.Value });
        }
    }
}
