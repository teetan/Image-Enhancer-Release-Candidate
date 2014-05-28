/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/*The filter operates in RGB color space and adjusts pixels' contrast value by increasing RGB values of bright pixel and decreasing RGB values of dark pixels.
 * The filter is based on LevelsLinear filter and simply sets all input ranges to (Factor, 255-Factor) and all output range to (0, 255) in the case if the factor value is positive.
 * If the factor value is negative, then all input ranges are set to (0, 255 ) and all output ranges are set to (-Factor, 255_Factor). */

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
    public partial class ContrastCorrect : Form
    {
        private int adjust_factor;    // contrast adjusting factor
        public ContrastCorrect()
        {
            InitializeComponent();
        }
        public int GetInt()
        {
            return adjust_factor;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value != null)
            this.adjust_factor = trackBar1.Value;
            this.Close();
        }        
    }
}
