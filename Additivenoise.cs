/*************************************************************************Abhisek Hazra, 31.12.2013********************************************************************************/
 /* Additive Noise Class adds random value to each pixel of the source image.The distribution of random values can be specified by random generator */
                             /* Linear Congruential Generator based algorithm is used here for Random Number generation */
                                /* This filter accepts 8 bpp grayscale images and 24 bpp color images for processing */
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
    public partial class Additivenoise : Form
    {
        private int seed;
        private int[] max_min_val = new int[2];    // This array contains the minimum and maximum values (range) required for random number generation algorithm  
        
        public int[] GetValue() 
        {
            return max_min_val;     // method for passing the range for the Linear Congruencial Generator(LCG) based random number generator
        }
        public int GetSeed()
        {
            return seed;            // Seed value for the LCG based random number generator 
        }
        public Additivenoise()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value != null) && (numericUpDown2.Value != null) && (numericUpDown3.Value != null))
            {
                this.max_min_val[0] = Convert.ToInt32(numericUpDown1.Value);   //  min value for random number generator
                this.max_min_val[1] = Convert.ToInt32(numericUpDown2.Value);   // max value for random number generator
                this.seed = Convert.ToInt32(numericUpDown3.Value);             // seed value for random number generator
                this.Close();
            }
            else
            {
                MessageBox.Show("Select all parameters for Random Number Generator", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }  
        
    }
}
