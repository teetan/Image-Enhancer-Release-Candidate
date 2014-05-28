/************************************************************Abhisek Hazra, 31.12.2013*************************************************************/
/* This filter changes each pixels' value to the value of pixel with the most frequent intensity within window of the specified size. 
 * Going through the window the filters finds which intensity of pixels is the most frequent */
/**************************************************************************************************************************************************/
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
    public partial class NormalizedExtraction : Form
    {
        private short channel;
        public NormalizedExtraction()
        {
            InitializeComponent();
        }
        public short GetShort()
        {
            return channel;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                channel = RGB.R;
            else if (radioButton2.Checked)
                channel = RGB.G;
            else if (radioButton3.Checked)
                channel = RGB.B;
            this.Close();
        }        
    }
}
