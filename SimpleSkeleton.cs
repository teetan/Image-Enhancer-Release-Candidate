/************************************************************Abhisek Hazra, 31.12.2013*************************************************************/
/* The filter build simple objects' skeletons by thinning them until they have one pixel wide "bones" horizontally and vertically. 
 * The filter uses Background and Foreground colors to distinguish between object and background.
The filter accepts 8 bpp grayscale images for processing */
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
    public partial class SimpleSkeleton : Form
    {
        private byte[] value = new byte [2];  // for storing and passing background and foreground pixel colors
        public SimpleSkeleton()
        {
            InitializeComponent();
        }
        public byte[] GetByte()
        {
            return value;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.value[0] = Convert.ToByte(numericUpDown1.Value);  // contains background pixel value
            this.value[1] = Convert.ToByte(numericUpDown2.Value);  // contains foreground pixel value
            this.Close();
        }        
    }
}
