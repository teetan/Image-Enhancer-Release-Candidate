/*****************************************************************************Abhisek Hazra, 31.12.2013*****************************************************************************/
                                                  /* The class implements image rotation filter using bicubic interpolation algorithm */ 
                                                              /* Rotation is performed in counterclockwise direction */
                                                 /* The filter accepts 8 bpp grayscale images and 24 bpp color images for processing */
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
    public partial class BicubicRotation : Form
    {
        private double rot_angle;   // Rotation angle property within the range [0-360] degree.
        private bool size;          // Size property determines if source image's size will be kept as it is or not.
        public BicubicRotation()
        {
            InitializeComponent();
        }
        public double getAngle()
        {
            return rot_angle;       // method for returning rotation angle property value
        }
        public bool ImageSizeFixedOrNot()
        {
            return size;           // method for returning size property value
        }
       
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
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
                MessageBox.Show("Please Properly Select The Rotation Angle and Image Size Properties", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
