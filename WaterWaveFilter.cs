/*************************************************************************Abhisek Hazra, 31.12.2013************************************************************************/
/* The image processing filter implements simple water wave effect. Using properties of the class,
 * it is possible to set number of vertical/horizontal waves, as well as their amplitude.
   Bilinear interpolation is used to create smooth effect.
   The filter accepts 8 bpp grayscale images and 24/32 color images for processing */
/**************************************************************************************************************************************************************************/
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
    public partial class WaterWaveFilter : Form
    {
        int[] thresh_waterwave = new int[4];  //contains all the thresholds for water wave filter
        public WaterWaveFilter()
        {
            InitializeComponent();
        }
        public int[] getValue()
        {
            return thresh_waterwave;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value >= 0) && (numericUpDown2.Value >= 1) && (numericUpDown3.Value >= 0) && (numericUpDown4.Value >= 1))
            {
                this.thresh_waterwave[0] = Convert.ToInt32(numericUpDown1.Value);
                this.thresh_waterwave[1] = Convert.ToInt32(numericUpDown2.Value);
                this.thresh_waterwave[2] = Convert.ToInt32(numericUpDown3.Value);
                this.thresh_waterwave[3] = Convert.ToInt32(numericUpDown4.Value);
                this.Close();
            }
        }        
    }
}
