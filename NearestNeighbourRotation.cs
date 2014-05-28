/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The class implements image rotation filter using nearest neighbor algorithm, which does not assume any interpolation.
   The filter accepts 8/16 bpp grayscale images and 24/48 bpp color image for processing */
/**********************************************************************************************************************************************************************************/
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
    public partial class NearestNeighbourRotation : Form
    {
        private double rot_angle;
        private bool size;
        public NearestNeighbourRotation()
        {
            InitializeComponent();
        }
        public double getAngle()
        {
            return rot_angle;
        }
        public bool ImageSizeFixedOrNot()
        {
            return size;
        }       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Text != null)
                this.size = false;
            else
                this.size = true;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Text != null)
                this.size = true;
            else
                this.size = false;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (((radioButton1.Checked) || (radioButton2.Checked)) && (numericUpDown1.Value >= 0))
            {
                this.rot_angle = Convert.ToDouble(numericUpDown1.Value);
                this.Close();
            }
            else
                MessageBox.Show("Select Angle and Imagesize values properly", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }       
    }
}
