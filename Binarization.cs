/****************************************************************Abhisek Hazra, 31.12.2013*****************************************************************************************/
                                              /* The filter does image binarization using specified threshold value */
                               /* All pixels with intensities equal or higher than threshold value are converted to white pixels. */
                                   /* All other pixels with intensities below threshold value are converted to black pixels */
                                               /* The filter accepts 8 and 16 bpp grayscale images for processing */
        /* In the case of 8 bpp images the threshold value is in the [0, 255] range, but in the case of 16 bpp images the threshold value is in the [0, 65535] range. */
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
    public partial class Binarization : Form
    {
        private string threshold;               // threshold value for binarization within the range[0-255] for 8 bit image
        public void SetValue(string str)
        {
            this.threshold = str;
        }
        public string getValue()
        {
            return threshold;                  // method returns the binarization threshold
        }
        public Binarization()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
                if ((Convert.ToInt32(comboBox1.Text) > 0) || (Convert.ToInt32(comboBox1.Text) < 255))
                {
                comboBox1.Items.Add(comboBox1.Text);
                threshold = comboBox1.Text;
                this.Close();
                }              
                else
                MessageBox.Show("Please Select a Threshold Limit For Binarization", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }       
     }
}
        
    

