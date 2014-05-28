/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
            /* The filter performs gamma correction of specified image in RGB color space. Each pixels' value is converted using the Vout=Ving equation, where g is gamma value.
               The filter accepts 8 bpp grayscale and 24 bpp color images for processing.*/
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
    public partial class GamaCorrect : Form
    {
        private double gamma;
        public GamaCorrect()
        {
            InitializeComponent();
        }
        public double GetDouble()
        {
            return gamma;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.gamma = Convert.ToDouble(comboBox1.SelectedItem);
            this.Close();
        }        
    }
}
