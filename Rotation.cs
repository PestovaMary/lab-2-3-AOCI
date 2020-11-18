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
    public partial class Rotation : Form
    {
        public event EventHandler<RotationParam> RotationParametresChange;

        public class RotationParam
        {
            public int angle { get; set; }
        }
        public Rotation()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            RotationParametresChange?.Invoke(this, new RotationParam { angle = trackBar1.Value }) ;
        }
    }
}
