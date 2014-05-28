using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accord_Test
{
    public partial class AdaptiveSmooth : Form
    {
        private double factor;
        public AdaptiveSmooth()
        {            
            InitializeComponent();
        }
        public double GetDouble()
        {
            return factor;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
                this.factor = Convert.ToDouble(numericUpDown1.Value);
            else
                this.factor = 3; // default factor value for Adaptive Smoothing
                this.Close();
        }
    }
}
