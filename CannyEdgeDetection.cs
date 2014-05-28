/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
                                                   /* The filter searches for objects' edges by applying Canny edge detector */
/* The implemented canny edge detector has one difference with the above linked algorithm. 
 * The difference is in hysteresis step, which is a bit simplified (getting faster as a result).
 * On the hysteresis step each pixel is compared with two threshold values: HighThreshold and LowThreshold */
/* The filter accepts 8 bpp grayscale images for processing */
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
    public partial class CannyEdgeDetection : Form
    {
        byte high_threshold;
        byte low_threshold;
        double sigma;
        public CannyEdgeDetection()
        {
            InitializeComponent();
        }
        public byte[] GetByte()
        {
            byte[] threshold = new byte[2];
            threshold[0]= high_threshold;
            threshold[1] = low_threshold;             // returning two threshold values for canny edge detection
            return threshold;
        }
        public double GetDouble()
        {
            return sigma;                            // returning gaussian sigma value for blurring
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value >= 0) && (numericUpDown1.Value <= 255))
                this.high_threshold = Convert.ToByte(numericUpDown1.Value);        // value accepting for higher threshold of canny edge detection
            if ((numericUpDown2.Value >= 0) && (numericUpDown2.Value <= 255))
                this.low_threshold = Convert.ToByte(numericUpDown2.Value);         // value accepting for lower threshold of canny edge detection
            if (comboBox1.SelectedItem != null)
                this.sigma = Convert.ToDouble(comboBox1.SelectedItem);             // value accepting for gaussian sigma value of blurring
            this.Close();
        }       
    }
}
