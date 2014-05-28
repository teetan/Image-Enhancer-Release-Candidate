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

namespace Accord_Test
{
    public partial class OilPaint : Form
    {
        private int brushsize;
        public OilPaint()
        {
            InitializeComponent();
        }
        public int GetInt()
        {
            return brushsize;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value != null)
            this.brushsize = trackBar1.Value;
            this.Close();
        }       
    }
}
