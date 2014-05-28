using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging.Textures;

namespace Accord_Test
{
    public partial class Texture : Form
    {
        private double [] filt_preserve_level = new double[2]; 
        private string texture;
        public Texture()
        {
            InitializeComponent();
        }
        public double[] GetDouble()
        {
            return filt_preserve_level;
        }
        public string GetString()
        {
            return texture;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            if ((comboBox1.Text == null) || (comboBox2.Text == null) || (comboBox3.Text == null))
            {
                MessageBox.Show("Select All Texturing Parameters", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Refresh();
            }
            else
            {
                this.filt_preserve_level[0] = Convert.ToDouble(comboBox1.Text);
                this.filt_preserve_level[1] = Convert.ToDouble(comboBox2.Text);
                this.texture = comboBox3.Text;
                this.Close();
            }
        }                    
    }
}
