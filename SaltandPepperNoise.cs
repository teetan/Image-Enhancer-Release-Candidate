/************************************************************Abhisek Hazra, 31.12.2013*************************************************************/
/* The filter adds random salt and pepper noise - sets maximum or minimum values to randomly selected pixels.
The filter accepts 8 bpp grayscale images and 24/32 bpp color images for processing */
/**************************************************************************************************************************************************/
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
    public partial class SaltandPepperNoise : Form
    {
        private double noise_threshold;
        public SaltandPepperNoise()
        {
            InitializeComponent();
        }
        public double GetValue()
        {
            return noise_threshold;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value >= 0)
            {
                this.noise_threshold = Convert.ToDouble(numericUpDown1.Value);
                this.Close();
            }
            else
                MessageBox.Show("Please select a proper threshold for Salt & Pepper", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }        
    }
}
