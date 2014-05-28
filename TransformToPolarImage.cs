/*************************************************************************Abhisek Hazra, 31.12.2013************************************************/
                            /* The image processing routine does transformation of the source image into circle (polar transformation).
                                          * The produced effect is similar to GIMP's "Polar Coordinates" distortion filter.
                                           The filter accepts 8 bpp grayscale and 24/32 bpp color images for processing.*/
/**************************************************************************************************************************************************/
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
    public partial class TransformToPolarImage : Form
    {
        private double circularity_coefficient,offset_angle;
        private string fillcolor;        
        private bool direction_mapping,map_from_top,use_original_image_size;
        private int width, height;
        private double[] double_arr=new double[2];  // storing double values
        private bool[] bool_arr = new bool[3]; //storing boolean values
        private int[] int_arr = new int[2];  // storing int values
        public TransformToPolarImage()
        {
            InitializeComponent();
        }
        /* this method is returning circularity coefficient and offset angle values to the caller form */
        public double[] GetDouble()
        {
            return double_arr;
        }
        /* this method is returning 'mapping direction', 'mapping from top', 'and use original image size or not' values to the caller form */
        public bool[] GetBool()
        {
            return bool_arr;
        }
        /* this method is returning 'image width' and 'image height' values to the caller form*/
        public int[] GetInt()
        {
            return int_arr;
        }
        public string GetString()
        {
            return fillcolor;
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
        }       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.circularity_coefficient = Convert.ToDouble(comboBox2.SelectedItem); // circularity coefficient of the mapping
            this.offset_angle = Convert.ToDouble(numericUpDown3.Value); // The property specifies offset angle, which can be used to shift mapping in counter clockwise direction
            this.fillcolor = Convert.ToString(comboBox1.SelectedItem); // The property specifies fill color, which is used to fill unprocessed areas. 
            if (radioButton1.Checked)
                this.direction_mapping = false; //The property specifies direction of mapping source image's X axis.
            else if (radioButton2.Checked) ////If the property is set to falseFalsefalsefalse (False in Visual Basic), the image is mapped in clockwise direction; otherwise in counter clockwise direction.
                this.direction_mapping = true;
            else
                this.direction_mapping = false;

            if (radioButton3.Checked)
                this.map_from_top = true; // The property specifies position of the source image's top line in the destination image. 
            else if (radioButton4.Checked) // If the property is set to true, then it goes to the center of the result image; otherwise it goes to the edge.
                this.map_from_top = false;
            else this.map_from_top = true;

            this.width = Convert.ToInt32(numericUpDown1.Value);  //The property specifies size of result image produced by this image processing routine
            this.height = Convert.ToInt32(numericUpDown2.Value);

            this.offset_angle = Convert.ToDouble(numericUpDown3.Value); //The property specifies offset angle, which can be used to shift mapping in counter clockwise direction
            if (radioButton5.Checked)
                this.use_original_image_size = true;
            else if (radioButton6.Checked)
                this.use_original_image_size = false;
            else
                this.use_original_image_size = true;  // The property specifies if the image processing routine should create destination image of the same size as original image or of the size specified by NewSize property

            /* values are stored into the arrays for passing to the caller form */
            double_arr[0] = circularity_coefficient;
            double_arr[1] = offset_angle;

            bool_arr[0] = direction_mapping;
            bool_arr[1] = map_from_top;
            bool_arr[2] = use_original_image_size;

            int_arr[0] = width;
            int_arr[1] = height;
            this.Close();
        }
    }
}
