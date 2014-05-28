/**************************************************************************Abhisek Hazra, 31.12.2013*******************************************************************************/
/* The filter operates in HSL color space and filters pixels, which color is inside/outside of the specified HSL range - 
 * it keeps pixels with colors inside/outside of the specified range and fills the rest with specified color.
The filter accepts 24 and 32 bpp color images for processing.*/
/**********************************************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge;
namespace Accord_Test
{
    public partial class HSLFilter : Form
    {
        private int min_hue, max_hue;
        private float min_lum, max_lum, min_sat, max_sat;
        private bool update_hue, update_lum, update_sat;
        public HSLFilter()
        {
            InitializeComponent();
        }
        public int[] GetHue()
        {
            //IntRange ir = new IntRange(min_hue, max_hue);
            int[] hue = new int[2];
            hue[0] = this.min_hue;
            hue[1] = this.max_hue;
            return hue;  
        }
        public float[] GetLuminance()
        {
            float[] lum = new float[2];
            lum[0] = this.min_lum;
            lum[1] = this.max_lum;
            return lum;
        }
        public float[] GetSaturation()
        {
            float[] sat = new float[2];
            sat[0] = this.min_sat;
            sat[1] = this.max_sat;
            return sat;
        }
        public bool[] GetBool()
        {
            bool[] update = new bool[3]; // for sending the updatable values for Hue, Luminance and Saturation
            update[0] = update_hue;
            update[1] = update_lum;
            update[2] = update_sat;
            return update;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((numericUpDown1.Value >= 0) && (numericUpDown1.Value <= 359))
                this.min_hue = Convert.ToInt32(numericUpDown1.Value);

            if ((numericUpDown2.Value >= 0) && (numericUpDown2.Value <= 359))
                this.max_hue = Convert.ToInt32(numericUpDown2.Value);
            if (comboBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(comboBox1.Text);
                this.min_lum = float.Parse(comboBox1.Text);
            }
            if (comboBox2.SelectedItem != null)
            {
                comboBox2.Items.Add(comboBox2.Text);
                this.max_lum = float.Parse(comboBox2.Text);
            }
            if (comboBox3.SelectedItem != null)
            {
                comboBox3.Items.Add(comboBox3.Text);
                this.min_sat = float.Parse(comboBox3.Text);
            }
            if (comboBox4.SelectedItem != null)
            {
                comboBox4.Items.Add(comboBox4.Text);
                this.max_sat = float.Parse(comboBox4.Text);
            }
            if (radioButton1.Checked)
                this.update_hue = true;
            else if (radioButton2.Checked)     // getting 'Hue' value  
                this.update_hue = false;
            else
                this.update_hue = true;


            if (radioButton3.Checked)
                this.update_lum = true;
            else if (radioButton4.Checked)     // getting 'Luminance' value
                this.update_lum = false;
            else
                this.update_lum = true;


            if (radioButton5.Checked)
                this.update_sat = true;
            else if (radioButton6.Checked)    // getting 'Saturation' value
                this.update_sat = false;
            else
                this.update_sat = true;

            this.Close();     // closes cuurent dialogue          
        }                       
    }
}
