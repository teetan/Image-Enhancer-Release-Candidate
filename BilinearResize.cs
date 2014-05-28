/***************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
                                                  /* The class implements image resizing filter using bilinear interpolation algorithm */
                                                       /* The filter accepts 8 grayscale images and 24/32 bpp color images for processing */
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
    public partial class BilinearResize : Form
    {
        private decimal height, width;   // for taking user input of height and width of the image using BiLinear Resizing Method
        public BilinearResize()
        {
            InitializeComponent();
        }
        public decimal GetHeight()       // This method returns height of the output image
        {
            return height;
        }
        public decimal GetWidth()        // This method returns width of the output image
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
            this.height = numericUpDown1.Value;    // height of the image
            this.width = numericUpDown2.Value;     // width of the image
            if ((numericUpDown1.Value >= 0) && (numericUpDown2.Value >= 0))
            {
                this.Close();
            }
            else
                MessageBox.Show("Select proper values for Image height and width", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
