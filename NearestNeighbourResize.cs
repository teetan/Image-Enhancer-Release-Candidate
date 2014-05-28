/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
 /* The class implements image resizing filter using nearest neighbor algorithm, which does not assume any interpolation.
    The filter accepts 8 and 16 bpp grayscale images and 24, 32, 48 and 64 bpp color images for processing */
/*********************************************************************************************************************************************************************************/
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
    public partial class NearestNeighbourResize : Form
    {
        private decimal height, width;   // for taking user input of height and width of the image using Nearest Neighbour Resizing Method
        public NearestNeighbourResize()
        {
            InitializeComponent();
        }
        public decimal GetHeight()
        {
            return height;
        }
        public decimal GetWidth()
        {
            return width;
        }
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.height = numericUpDown1.Value;
            this.width = numericUpDown2.Value;
            if ((numericUpDown1.Value >= 0) && (numericUpDown2.Value >= 0))
            {
                this.Close();
            }
            else
                MessageBox.Show("Select proper values for Image height and width", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }       
    }
}
