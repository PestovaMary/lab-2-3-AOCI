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
    public partial class HSV : Form
    {
        public event EventHandler<HSVEventArgs> HSVParametresChange;

        public class HSVEventArgs
        { 
            public int Hue { get; set; }
        }

        public HSV()
        {
            InitializeComponent();
        }

        private void HueTrackBar_Scroll(object sender, EventArgs e)
        {
            HSVParametresChange?.Invoke(this, new HSVEventArgs { Hue = HueTrackBar.Value });
        }
    }
}
