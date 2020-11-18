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
    public partial class Addition : Form
    {
        public event EventHandler<ParamsEventArgs> ImageParam;

        public class ParamsEventArgs
        {
            public double FirstParam;

            public double SecondParam;
        }

        public Addition()
        {
            InitializeComponent();
        }

        private void FirstParamTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageParam?.Invoke(this, new ParamsEventArgs { FirstParam = FirstParamTrackBar.Value * 0.1, SecondParam = SecondParamTrackBar.Value * 0.1} );
        }

        private void SecondParamTrackBar_Scroll(object sender, EventArgs e)
        {
            ImageParam?.Invoke(this, new ParamsEventArgs { FirstParam = FirstParamTrackBar.Value * 0.1, SecondParam = SecondParamTrackBar.Value * 0.1 });
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
