/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The filter performs convolution filter using the kernel, which is calculate with the help of Kernel2D(Int32) method and then converted to integer sharpening kernel.
 * First of all the integer kernel is calculated from Kernel2D(Int32) by dividing all elements by the element with the smallest value. */
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
    public partial class GaussSharpen : Form
    {
        private double gaussian_sigma;  // Gaussian Sigma Value to compute the kernel
        private int size;               // Size of Gaussain Kernel
        public GaussSharpen()
        {
            InitializeComponent();
        }
        public double GetDouble()
        {
            return gaussian_sigma;
        }
        public int GetInt()
        {
            return size;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
                this.gaussian_sigma = Convert.ToDouble(comboBox1.SelectedItem);
            else 
                this.gaussian_sigma = 1.4; //default value for gaussian sigma
            if ((numericUpDown1.Value >= 3) && (numericUpDown1.Value <= 21))
                this.size = Convert.ToInt32(numericUpDown1.Value);
            else
                this.size = 5; //default value for for the size of the gaussian kernel
                this.Close();
        }        
    }
}
