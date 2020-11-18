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
    public partial class Filters : Form
    {
        public event EventHandler<FilterEventArgs> FilterSelected;

        public class FilterEventArgs
        {
            public byte Filter { get; set; }
        }

        public Filters()
        {
            InitializeComponent();
        }

        private void SharpenFilterButton_Click(object sender, EventArgs e)
        {
            FilterSelected?.Invoke(this, new FilterEventArgs { Filter = 0 });
            this.Close();
        }

        private void EmbosFilterButton_Click(object sender, EventArgs e)
        {
            FilterSelected?.Invoke(this, new FilterEventArgs { Filter = 1 });
            this.Close();
        }

        private void FacetsFilterButton_Click(object sender, EventArgs e)
        {
            FilterSelected?.Invoke(this, new FilterEventArgs { Filter = 2 });
            this.Close();
        }
    }
}
