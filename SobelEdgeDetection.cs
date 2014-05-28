/************************************************************Abhisek Hazra, 31.12.2013*************************************************************/
/* The filter searches for objects' edges by applying Sobel operator.
   Each pixel of the result image is calculated as approximated absolute gradient magnitude for corresponding pixel of the source image */
/**************************************************************************************************************************************************/
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
    public partial class SobelEdgeDetection : Form
    {
        private bool scaleintensity;
        public SobelEdgeDetection()
        {
            InitializeComponent();
        }
        public bool GetBool()
        {
            return scaleintensity;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                this.scaleintensity = true;
            else if (radioButton2.Checked)
                this.scaleintensity = false;
            else
                this.scaleintensity = true;
                this.Close();
        }       
    }
}
