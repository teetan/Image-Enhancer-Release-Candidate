/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* Extracts specified channel of color image and returns it as grayscale image.
The filter accepts 24, 32, 48 and 64 bpp color images and produces 8 (if source is 24 or 32 bpp image) or 16 (if source is 48 or 64 bpp image) bpp grayscale image. */
/**********************************************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging;

namespace Accord_Test
{    
    public partial class ExtractionOfChannel : Form
    {
        private Int16 channel;
        public ExtractionOfChannel()
        {
            InitializeComponent();
        }
        public Int16 GetInt()
        {
            return channel;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                this.channel = RGB.R;
            else if (radioButton2.Checked)
                this.channel = RGB.G;
            else if (radioButton3.Checked)
                this.channel = RGB.B;
            else
                this.channel = RGB.R;
                this.Close();
        }        
    }
}
