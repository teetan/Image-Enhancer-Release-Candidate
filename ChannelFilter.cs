/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The filter does color channels' filtering by clearing (filling with specified values) values, which are inside/outside of the specified value's range.
 * The filter allows to fill certain ranges of RGB color channels with specified value.
   The filter is similar to ColorFiltering, but operates with not entire pixels, but with their RGB values individually. 
 * This means that pixel itself may not be filtered (will be kept), but one of its RGB values may be filtered if they are inside/outside of specified range.
   The filter accepts 24 and 32 bpp color images for processing. */
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
    public partial class ChannelFilter : Form
    {
        //private int red_min,red_max, green_min,green_max, blue_min,blue_max;
        int []red=new int[2];
        int[] green = new int[2];
        int[] blue = new int[2];
        public ChannelFilter()
        {
            InitializeComponent();
        }
        public int[] getRed()
        {
            return red;
        }
        public int[] getGreen()
        {
            return green;  
        }
        public int[] getBlue()
        {
            return blue;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.red[0] = Convert.ToInt32(numericUpDown1.Value);
            this.red[1] = Convert.ToInt32(numericUpDown4.Value);
            this.green[0] = Convert.ToInt32(numericUpDown2.Value);
            this.green[1] = Convert.ToInt32(numericUpDown5.Value);
            this.blue[0] = Convert.ToInt32(numericUpDown3.Value);
            this.blue[1] = Convert.ToInt32(numericUpDown6.Value);
            if (((numericUpDown1.Value >= 0) && (numericUpDown4.Value <= 255)) && ((numericUpDown2.Value >= 0) && (numericUpDown5.Value <= 255)) && ((numericUpDown3.Value >= 0) && (numericUpDown6.Value <= 255)))
            {
                this.Close();
            }
            else
                MessageBox.Show("Select proper RGB Values", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }        
    }
}
