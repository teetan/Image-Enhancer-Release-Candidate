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
    public partial class BilateralSmooth : Form
    {        
        int[] param = new int[3]; // param is used to pass three parameters to caller form
        public BilateralSmooth()
        {
            InitializeComponent();
        }
        public int[] GetValue()
        {
            return param;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (((numericUpDown1.Value >= 0) || (numericUpDown1.Value <= 100)) && ((numericUpDown2.Value >= 0) || (numericUpDown2.Value <= 100)) && ((numericUpDown3.Value >= 3) && (numericUpDown3.Value <= 255)))
            {
                this.param[0] = Convert.ToInt32(numericUpDown1.Value);  // Spatial Factor
                this.param[1] = Convert.ToInt32(numericUpDown2.Value);  // Color Factor
                this.param[2] = Convert.ToInt32(numericUpDown3.Value);  // Kernel Size             
            }
            else
            {
                MessageBox.Show("Enter All Parameters for Bilateral Smoothing", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                this.Close();
        }
    }
}
