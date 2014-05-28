/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The filter operates in RGB color space and adjusts pixels' brightness by increasing every pixel's RGB values by the specified adjust value.
 * The filter is based on LevelsLinear filter and simply sets all input ranges to (0, 255-AdjustValue) and all output range to (AdjustValue, 255) in the case if the adjust value is positive.
 * If the adjust value is negative, then all input ranges are set to (-AdjustValue, 255 ) and all output ranges are set to ( 0, 255+AdjustValue). */
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
    public partial class Brightnesscorrection : Form
    {
        private int brightness_threshold;
        public void SetValue(int str)
        {
            this.brightness_threshold = str;
        }
        public int getValue()
        {
            return brightness_threshold;
        }
        public Brightnesscorrection()
        {
            InitializeComponent();
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(comboBox1.Text);
                brightness_threshold = Convert.ToInt32(comboBox1.Text);
                this.Close();
            }
            else
                MessageBox.Show("Select a threshold for brightness correction", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        
    }
}
