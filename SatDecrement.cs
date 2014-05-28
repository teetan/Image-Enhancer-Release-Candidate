/************************************************************Abhisek Hazra, 31.12.2013*************************************************************/
/* The filter operates in HSL color space and adjusts pixels' saturation value, decreasing it specified percentage 
 The filter accepts 24 and 32 bpp color images for processing */
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
    public partial class SatDecrement : Form
    {
        private double satdec_threshold;
        public void SetValue(double str)
        {
            this.satdec_threshold = str;
        }
        public double getValue()
        {
            return satdec_threshold;
        }       
        public SatDecrement()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(comboBox1.Text);
                satdec_threshold = Convert.ToDouble(comboBox1.Text);
                this.Close();
            }
            else
                MessageBox.Show("Select a threshold for Saturation Decrement", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }             
    }
}
