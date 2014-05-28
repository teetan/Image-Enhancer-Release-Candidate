/**************************************************************************Abhisek Hazra, 31.12.2013********************************************************************************/
/* The filter operates in YCbCr color space and provides with the facility of linear correction of its channels
 * - mapping specified channels' input ranges to specified output ranges.
The filter accepts 24 and 32 bpp color images for processing.
/***********************************************************************************************************************************************************************************/
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
    public partial class LinearYCbCr : Form
    {
        Range Cb, Cr;
        float CbMin, CbMax, CrMin, CrMax;
        public LinearYCbCr()
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
                MessageBox.Show("Insert a Valid Range(or) Minimum must be lower than Maximum Values,Default Threshold Values Will be Chosen Now", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
