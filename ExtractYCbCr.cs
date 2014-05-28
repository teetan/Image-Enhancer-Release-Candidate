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
    public partial class ExtractYCbCr : Form
    {        
        private string choice;
        public ExtractYCbCr()
        {
            InitializeComponent();
        }
        public string GetString()
        {
            return choice;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                this.choice = "cbindex";
            }
            else if (radioButton2.Checked)
            {
                this.choice = "crindex";
            }
            else if (radioButton3.Checked)
            {
                this.choice = "yindex";
            }
            else
                this.choice = "yindex";    // default value for the channel 
            this.Close();
        }
    }
}
