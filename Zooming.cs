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
    public partial class Zooming : Form
    {
        public event EventHandler<ScaleParam> ZoomParametresChange;

        public class ScaleParam
        {
            public int width { get; set; }
            public int height { get; set; }
        }

        public Zooming()
        {
            InitializeComponent();
        }

        private void WidthTrackBar_Scroll(object sender, EventArgs e)
        {
            ZoomParametresChange?.Invoke(this, new ScaleParam {width = WidthTrackBar.Value, height = HeightTrackBar.Value });

        }

        private void HeightTrackBar_Scroll(object sender, EventArgs e)
        {
            ZoomParametresChange?.Invoke(this, new ScaleParam {width = WidthTrackBar.Value, height = HeightTrackBar.Value});
        }
    }
}
