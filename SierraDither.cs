﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accord_Test
{
    public partial class SierraDither : Form
    {
        private byte threshold;
        public SierraDither()
        {
            InitializeComponent();
        }
        public byte GetByte()
        {
            return threshold;
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.threshold = Convert.ToByte(numericUpDown1.Value);
            this.Close();
        }
    }
}
