/************************************************************************Abhisek Hazra, 15.02.2014*********************************************************************************/
/*The filter operates in YCbCr color space and filters pixels, which color is inside/outside of the specified YCbCr range
 * - it keeps pixels with colors inside/outside of the specified range and fills the rest with specified color.
The filter accepts 24 and 32 bpp color images for processing.
/**********************************************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;

namespace Accord_Test
{
    public partial class ColorYCbCr : Form
    {
        Range Cb, Cr;
        float CbMin, CbMax, CrMin, CrMax;
        public ColorYCbCr()
        {
            InitializeComponent();
        }
        public Range GetCb()
        {
            return Cb;
        }
        public Range GetCr()
        {
            return Cr;
        }        
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.CbMin = Single.Parse(Convert.ToString(numericUpDown1.Value));
            this.CbMax = Single.Parse(Convert.ToString(numericUpDown2.Value));
            this.CrMin = Single.Parse(Convert.ToString(numericUpDown3.Value));
            this.CrMax = Single.Parse(Convert.ToString(numericUpDown4.Value));
            if ((CbMin == CbMax) || (CbMin > CbMax) || (CrMin == CrMax) || (CrMin > CrMax))
            {
                MessageBox.Show("Insert a Valid Range (or) Minimum Must Be Lower Than Maximum Value,Default Threshold Values Will Be Chosen Now", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
            {
                Cb = new Range(CbMin, CbMax);
                Cr = new Range(CrMin, CrMax);
                this.Close();
            }
        }
    }
}
