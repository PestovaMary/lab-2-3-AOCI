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
    public partial class Shearing : Form
    {

        public event EventHandler<ShiftParam> ShiftParametresChange;

        public class ShiftParam
        {
            public int shift { get; set; }
        }

        public Shearing()
        {
            InitializeComponent();

            ShiftTrackBarG.Maximum = 100;
            ShiftTrackBarG.Minimum = 0;
            ShiftTrackBarG.TickFrequency = 1;

        }

        private void ShiftTrackBarG_Scroll(object sender, EventArgs e)
        {
           ShiftParametresChange?.Invoke(this, new ShiftParam { shift = ShiftTrackBarG.Value });
        }
    }
}
