/**************************************************************************Abhisek Hazra, 31.12.2013********************************************************************************/
/* The filter moves each pixel of a source image in random direction within a window of specified radius.
The filter accepts 8 bpp grayscale images and 24/32 color images for processing.*/
/***********************************************************************************************************************************************************************************/
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
    public partial class Jittering : Form
    {
        private int jittering_threshold;
        public void SetValue(int str)
        {
            this.jittering_threshold = str;
        }
        public int getValue()
        {
            return jittering_threshold; 
        }
        public Jittering()
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
                jittering_threshold = Convert.ToInt32(comboBox1.Text);
                this.Close();
            }
            else
                MessageBox.Show("Select a threshold limit for Jittering", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
