/************************************************************************Abhisek Hazra, 31.12.2013*********************************************************************************/
                                              /* This class implements image resizing filter using bicubic interpolation algorithm */ 
                                              /* The filter accepts 8 grayscale images and 24 bpp color images for processing */
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
    public partial class BicubicResize : Form
    {
        private decimal height, width;        // these instance variables are used to define custom size for the output image
        public BicubicResize()
        {
            InitializeComponent();
        }
        public decimal GetHeight()            // This method returns height of the output image
        {
            return height;
        }
        public decimal GetWidth()             // This method returns width of the output image
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
            this.height = numericUpDown1.Value;      // height of the image
            this.width = numericUpDown2.Value;       // width of the image
            if ((numericUpDown1.Value >= 0) && (numericUpDown2.Value >= 0))
            {
                this.Close();
            }
            else
                MessageBox.Show("Select proper values for height and width", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        }        
    }

