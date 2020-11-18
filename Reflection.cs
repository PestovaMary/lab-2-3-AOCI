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
    public partial class Reflection : Form
    {
        public event EventHandler<ReflEventArgs> ReflSelected;

        public class ReflEventArgs : EventArgs
        {
            public int qX { get; set; }
            public int qY { get; set; }
        }

        public Reflection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           ReflSelected?.Invoke(this, new ReflEventArgs { qX = -1, qY = -1 });
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReflSelected?.Invoke(this, new ReflEventArgs { qX = -1, qY = 1 });
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReflSelected?.Invoke(this, new ReflEventArgs { qX = 1, qY = -1 });
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ReflSelected?.Invoke(this, new ReflEventArgs { qX = 1, qY = 1 });
            this.Close();
        }
    }
}
