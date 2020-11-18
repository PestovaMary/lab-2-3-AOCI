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
    public partial class ContrastAndBrightness : Form
    {
        public event EventHandler<ContrastBrightnessEventArgs> ParametresChange;

        public class ContrastBrightnessEventArgs
        { 
            public int Contrast { get; set; }

            public int Brightness { get; set; }
        }

        public ContrastAndBrightness()
        {
            InitializeComponent();
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            ParametresChange?.Invoke(this, new ContrastBrightnessEventArgs { Contrast = ContrastTrackBar.Value, Brightness = BrightnessTrackBar.Value} );
        }

        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            ParametresChange?.Invoke(this, new ContrastBrightnessEventArgs { Contrast = ContrastTrackBar.Value, Brightness = BrightnessTrackBar.Value });
        }
    }
}
