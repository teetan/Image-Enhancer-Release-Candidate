/*************************************************************************Abhisek Hazra, 31.12.2013***********************************************************************/
                                  /* The CanvasCrop filter fills areas outside of specified region using the specified color */
                                  /* The CanvasCrop filter accepts 8bpp grayscale and 24/32 bpp color images for processing  */
/* image width and height values are passed frpm the calling form to CropCanvas.cs to set the max width and height of the canvas for a particular image
   as different images canhave different resolutions */
/************************************************************************************************************************************************************************/
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
    public partial class CropCanvas : Form
    {
        int[] canvas = new int[4];    // xcord, ycord, width, height; size specification for the rectangle structure
        string canvas_color;         //  represents the canvas of the colour
        //int height, width;           //  this height and width = image size loaded in main form; we make an object of the CropCanvas.cs and pass the image size value here
                                     // these height and width values are set to max property of image height and width in CropCanvas.cs
        public int[] GetCanvas()
        {
            return canvas;               // this method returns the size of the rectangle structure
        }
        public string GetColor()
        {
            return canvas_color;         // this method returns the color of the canvas
        }
        public CropCanvas()
        {
            InitializeComponent();
        }
        /* parameterised constructor to set  the canvas width and height for individual images */
        //public CropCanvas(int w,int h)
        //{
        //    this.width = w;    // image width value will be set which is passed from the calling form
        //    this.height = h;   // image height value will be set which is passed from the calling form
        //}
        
        // This event stub executed when CropCanvas form is called from the second form 
        private void CropCanvas_Load(object sender, EventArgs e)
        {
            //numericUpDown3.Maximum = width;  //  maximum canvas width is set to the width of the  image 
            //numericUpDown4.Maximum = height; // maximum canvas height is set to the height of the image
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            this.canvas[0] = Convert.ToInt32(numericUpDown1.Value);   //  x coordinate of the recatngle structure                
            this.canvas[1] = Convert.ToInt32(numericUpDown2.Value);   //  y coordinate of the recatngle structure                
            this.canvas[2] = Convert.ToInt32(numericUpDown3.Value);   //  width of the rectangle structure                
            this.canvas[3] = Convert.ToInt32(numericUpDown4.Value);   //  height of the recatngle structure                
            this.canvas_color = comboBox1.Text;     // color of the canvas
            this.Close();           
        }       
    }
}
