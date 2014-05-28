/************************************************************Abhisek Hazra, 31.12.2013*************************************************************/
/* The filter processes an image creating the effect of an image with larger pixels - pixellated image.
 * The effect is achieved by filling image's rectangles of the specified size by the color, 
 * which is mean color value for the corresponding rectangle. The size of rectangles to process is set by PixelWidth and PixelHeight properties.
   The filter accepts 8 bpp grayscale images and 24 bpp color images for processing */
/**************************************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Pixellation form/dialogue is used for accepting threshold values(pixel height, pixel size and pixel width) for the Pixellation() filter */
namespace Accord_Test
{
    public partial class Pixellation : Form
    {
        int pix_height, pix_size, pix_width;  // instance variables for accepting three pixel properties(height,size,width)
        int[] total_param = new int[3];     // for storing pixel height,size and width threshold values and passing to main window(Form1.cs)
        
        public Pixellation()
        {
            InitializeComponent();      
        }
        public void SetValue(int height, int size, int width)   /* SetValue() method is required to set the values for the instance variables, not used here */
        {
            this.pix_height = height;
            this.pix_size = size;
            this.pix_width = width;           
        }
        public int[] getValue()
        {
            return total_param;   /* Returning three threshold values of height, size and width via total_param array to where it is called(main form(Form1.cs)) */          
        }

        /* This event occurs when the Pixellation form is loaded */
        /* The functionality of this event is to activate the button information for the user using tooltip */
        private void Pixellation_Load(object sender, EventArgs e)
        {
            ToolTip height = new ToolTip();
            height.ToolTipTitle = "Pixel Height";
            height.IsBalloon = true;                                            // Pixel Height tooltip for user input
            height.ToolTipIcon = ToolTipIcon.Info;
            height.SetToolTip(comboBox1, "Enter Pixel Height");

            ToolTip size = new ToolTip();
            size.ToolTipTitle = "Pixel Size";
            size.IsBalloon = true;                                            // Pixel Size tooltip for user input
            size.ToolTipIcon = ToolTipIcon.Info;
            size.SetToolTip(comboBox2, "Enter Pixel Size");

            ToolTip width = new ToolTip();
            width.ToolTipTitle = "Pixel Width";
            width.IsBalloon = true;                                            // Pixel Width tooltip for user input
            width.ToolTipIcon = ToolTipIcon.Info;
            width.SetToolTip(comboBox3, "Enter Pixel Width");            
            
        }

       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Stub for Combo box 1...value selection for pixel height */
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Stub for Combo box 1...value selection for pixel size */
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Stub for Combo box 1...value selection for pixel width */
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            /* Method stub for accepting threshold values for Pixellation filter */
            /* Pixellation dialogue accepts pixel height, pixel size and pixel width properties for the pixellation filter */
            /* pixel size threshold is not required here, Pixellatte() filter only accepts pixel height and width properties to work */
            if (comboBox1.SelectedItem != null)
            {
                comboBox1.Items.Add(comboBox1.Text);
                pix_height = Convert.ToInt32(comboBox1.Text);
                this.Close();
            }
            else
                MessageBox.Show("Select proper threshold for pixel height", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (comboBox2.SelectedItem != null)
            {
                comboBox2.Items.Add(comboBox2.Text);
                pix_size = Convert.ToInt32(comboBox2.Text);
                this.Close();
            }
            else
                MessageBox.Show("Select proper threshold for pixel size(optional)", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (comboBox3.SelectedItem != null)
            {
                comboBox3.Items.Add(comboBox3.Text);
                pix_width = Convert.ToInt32(comboBox3.Text);
                this.Close();
            }
            else
                MessageBox.Show("Select proper threshold for pixel width", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            /*  pixel height, size and width values are inesrted into the total_param array for passing */
            total_param[0] = pix_height;
            total_param[1] = pix_size;
            total_param[2] = pix_width;          
        }
    }
}
