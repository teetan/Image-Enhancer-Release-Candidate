/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The filter implements conservative smoothing, which is a noise reduction technique that derives its name from the fact that it employs a simple, fast filtering algorithm
 * It sacrifices noise suppression power in order to preserve the high spatial frequency detail (e.g. sharp edges) in an image. 
 * It is explicitly designed to remove noise spikes - isolated pixels of exceptionally low or high pixel intensity */
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
    public partial class ConservativeSmooth : Form
    {
        private int sizekernel;
        public ConservativeSmooth()
        {
            InitializeComponent();
        }
        public int getValue()
        {
            return sizekernel;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {           
            sizekernel = Convert.ToInt32(numericUpDown1.Value);            
            this.Close();                    
        }                              
    }
}
