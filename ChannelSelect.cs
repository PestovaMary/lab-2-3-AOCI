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
    public partial class ChannelSelect : Form
    {
        public event EventHandler<ColorChannelEventArgs> ChannelSelected;

        public class ColorChannelEventArgs : EventArgs
        {
            public byte Channel { get; set; } 
        }

        public ChannelSelect()
        {
            InitializeComponent();
        }

        private void BlueButton_Click(object sender, EventArgs e)
        {
            ChannelSelected?.Invoke(this, new ColorChannelEventArgs { Channel = 0 });
            this.Close();
        }

        private void GreenButton_Click(object sender, EventArgs e)
        {
            ChannelSelected?.Invoke(this, new ColorChannelEventArgs { Channel = 1 });
            this.Close();
        }

        private void RedButton_Click(object sender, EventArgs e)
        {
            ChannelSelected?.Invoke(this, new ColorChannelEventArgs { Channel = 2 });
            this.Close();
        }
    }
}
