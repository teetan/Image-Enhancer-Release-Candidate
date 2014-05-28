/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The median filter is normally used to reduce noise in an image, somewhat like the mean filter.
 * However, it often does a better job than the mean filter of preserving useful detail in the image.
   Each pixel of the original source image is replaced with the median of neighboring pixel values. 
 * The median is calculated by first sorting all the pixel values from the surrounding neighborhood into numerical order
 * Then replacing the pixel being considered with the middle pixel value.
The filter accepts 8 bpp grayscale images and 24/32 bpp color images for processing */
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
    public partial class MedianFilter : Form
    {
        private int med_value;
        public MedianFilter()
        {
            InitializeComponent();
        }
        public int getValue()
        {
            return med_value;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(comboBox1.Text);
                this.med_value = Convert.ToInt32(comboBox1.Text);
                this.Close();
            }
            else
                MessageBox.Show("Select the Proper Value for threshold", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }        
    }
}
