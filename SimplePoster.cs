/************************************************************Abhisek Hazra, 31.12.2013*************************************************************/
/* The class implements simple posterization of an image by splitting each color plane into adjacent areas of the specified size.
 * Posterization is a process in photograph development which converts normal photographs into an image consisting of distinct, 
 * but flat, areas of different tones or colors.
The filter accepts 8 bpp grayscale and 24/32 bpp color images */
/**************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging.Filters;

namespace Accord_Test
{
    public partial class SimplePoster : Form
    {
        SimplePosterization.PosterizationFillingType color_depth;
        public SimplePoster()
        {
            InitializeComponent();
        }
        public SimplePosterization.PosterizationFillingType GetColorDepth()
        {
            return color_depth;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                this.color_depth = SimplePosterization.PosterizationFillingType.Min;
            else if (radioButton2.Checked)
                this.color_depth = SimplePosterization.PosterizationFillingType.Average;
            else if (radioButton3.Checked)
                this.color_depth = SimplePosterization.PosterizationFillingType.Max;
            else
                this.color_depth = SimplePosterization.PosterizationFillingType.Average;
                this.Close();
        }        
    }
}
