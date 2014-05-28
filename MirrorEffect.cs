/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
  /* The filter mirrors image around X and/or Y axis (horizontal and vertical mirroring).
     The filter accepts 8 bpp grayscale images and 24 bpp color images for processing */
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
    public partial class MirrorEffect : Form
    {
        private bool horizontal, vertical;    // these instance variables are used to set values for horizontal and vertical mirror filtering schemes
        public MirrorEffect()
        {
            InitializeComponent();
        }
        public string getHorzValue()
        {
            return (Convert.ToString(horizontal));    // getHorzValue() is called in case of of horizontal mirror filetering scheme is selected
        }
        public string getVertValue()
        {
            return (Convert.ToString(vertical));      // getVertValue() is called in case of vertical mirror filtering scheme is selected
        }
       
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Text != null)
            {
                horizontal = true;
                vertical = false;
            }
            else
            {
                vertical = true;
                horizontal = false;
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Text != null)
            {
                horizontal = false;
                vertical = true;
            }
            else
            {
                vertical = false;
                horizontal = true;
            }
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked) || (radioButton2.Checked))
            {
                this.Close();
            }
            else
                MessageBox.Show("Select a Mirror Filtering Scheme", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }        
    }
}
