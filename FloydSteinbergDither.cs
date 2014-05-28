/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The filter represents binarization filter, which is based on error diffusion dithering with Floyd-Steinberg coefficients.
 * Error is diffused on 4 neighbor pixels with next coefficients */
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
    public partial class FloydSteinbergDither : Form
    {
        private byte thresh_value;
        public FloydSteinbergDither()
        {
            InitializeComponent();
        }
        public byte GetByte()
        {
            return thresh_value;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value >= 0) && (numericUpDown1.Value <= 255))
            this.thresh_value = Convert.ToByte(numericUpDown1.Value);
            this.Close();
        }       
    }
}
