using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Imaging;

namespace Accord_Test
{
    public partial class BayerFilt : Form
    {   
        
        private int [,]color_index = new int[2,2];  // to get the Bayer Pattern Property
        private bool IsDemosaicOrNot;               // to get the bayer pattern value : whether color demosaicing must be done or not
        public BayerFilt()
        {
            InitializeComponent();
        }        
        public int[,] GetColorIndex()
        {
            return color_index;
        }
        public bool GetBool()
        {
            return IsDemosaicOrNot;
        }        
        private void OkButton_Click(object sender, EventArgs e)
        {
            /* enter RGB value for the first row of the bayer pattern property */
            if (radioButton1.Checked)
            {
                if (radioButton7.Checked)
                {
                    color_index= new int[2,2]{{RGB.R,RGB.G},{RGB.R,RGB.G}};                             // {{red,green},{red,green}}
                }
                else if (radioButton8.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.G }, { RGB.G, RGB.R } };                // {{red,green},{green,red}} 
                }
                 else if (radioButton9.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.G }, { RGB.B, RGB.R } };               // {{red,green},{blue,red}}
                }  
                else if (radioButton10.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.G }, { RGB.R, RGB.B } };              // {{red,green},{red, blue}}
                }
                 else if (radioButton11.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.G }, { RGB.G, RGB.B } };              // {{red,green},{green,blue}}
                }
                else if (radioButton12.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.G }, { RGB.B, RGB.G } };              // {{red,green},{blue,green}}
                } 
                else
                    color_index = new int[2, 2] { { RGB.R, RGB.G }, { RGB.B, RGB.G } }; // default selection for the second row of Bayer Pattern if second color index not checked,// {{red,green},{blue,green}}
            }

            if (radioButton2.Checked)
            {
                if (radioButton7.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.R }, { RGB.R, RGB.G } };                // {{green,red},{red,green}}
                }
                else if (radioButton8.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.R }, { RGB.G, RGB.R } };                // {{green,red},{green,red}}
                }
                else if (radioButton9.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.R }, { RGB.B, RGB.R } };                // {{green,red},{blue,red}}
                }
                else if (radioButton10.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.R }, { RGB.R, RGB.B } };               // {{green,red},{red,blue}}
                }
                else if (radioButton11.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.R }, { RGB.G, RGB.B } };               // {{green,red},{green,blue}}
                }
                else if (radioButton12.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.R }, { RGB.B, RGB.G } };              // {{green,red},{blue,green}}
                }
                else
                    color_index = new int[2, 2] { { RGB.G, RGB.R }, { RGB.B, RGB.G } }; // default selection for the second row of Bayer Pattern if second color index not checked
            }

            if (radioButton3.Checked)
            {
                if (radioButton7.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.R }, { RGB.R, RGB.G } };      // {{blue,red},{red,green}}
                }
                else if (radioButton8.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.R }, { RGB.G, RGB.R } };      // {{blue,red},{green,red}}
                }
                else if (radioButton9.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.R }, { RGB.B, RGB.R } };     // {{blue,red},{blue,red}}
                }
                else if (radioButton10.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.R }, { RGB.R, RGB.B } };     // {{blue,red},{red,blue}}
                }
                else if (radioButton11.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.R }, { RGB.G, RGB.B } };     // {{blue,red},{green,blue}}
                }
                else if (radioButton12.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.R }, { RGB.B, RGB.G } };    // {{blue,red},{blue,green}}
                }
                else
                    color_index = new int[2, 2] { { RGB.B, RGB.R }, { RGB.B, RGB.G } }; // default selection for the second row of Bayer Pattern if second color index not checked,// {{blue,red},{blue,green}}
            }

            if (radioButton4.Checked)
            {
                if (radioButton7.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.B }, { RGB.R, RGB.G } };     // {{red,blue},{red,green}}
                }
                else if (radioButton8.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.B }, { RGB.G, RGB.R } };     // {{red,blue},{green,red}}
                }
                else if (radioButton9.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.B }, { RGB.B, RGB.R } };    // {{red,blue},{blue,red}}
                }
                else if (radioButton10.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.B }, { RGB.R, RGB.B } };    // {{red,blue},{red,blue}}
                }
                else if (radioButton11.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.B }, { RGB.G, RGB.B } };     // {{red,blue},{green,blue}}
                }
                else if (radioButton12.Checked)
                {
                    color_index = new int[2, 2] { { RGB.R, RGB.B }, { RGB.B, RGB.G } };     // {{red,blue},{green,red}}
                }
                else
                    color_index = new int[2, 2] { { RGB.R, RGB.B }, { RGB.B, RGB.G } }; // default selection for the second row of Bayer Pattern if second color index not checked,// {{red,blue},{blue,green}}
            }

            if (radioButton5.Checked)
            {
                if (radioButton7.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.B }, { RGB.R, RGB.G } };      // {{green,blue},{red,green}}
                }
                else if (radioButton8.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.B }, { RGB.G, RGB.R } };      // {{green,blue},{green,red}}
                }
                else if (radioButton9.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.B }, { RGB.B, RGB.R } };     // {{green,blue},{blue,red}} 
                }
                else if (radioButton10.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.B }, { RGB.R, RGB.B } };    // {{green,blue},{red,blue}}
                }
                else if (radioButton11.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.B }, { RGB.G, RGB.B } };    // {{green,blue},{green,blue}}
                }
                else if (radioButton12.Checked)
                {
                    color_index = new int[2, 2] { { RGB.G, RGB.B }, { RGB.B, RGB.G } };   // {{green,blue},{blue,green}}
                }
                else
                    color_index = new int[2, 2] { { RGB.G, RGB.B }, { RGB.B, RGB.G } }; // default selection for the second row of Bayer Pattern if second color index not checked,// {{green,blue},{blue,green}}
            }

            if (radioButton6.Checked)
            {
                if (radioButton7.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.G }, { RGB.R, RGB.G } };     // {{blue,green},{red,green}}
                }
                else if (radioButton8.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.G }, { RGB.G, RGB.R } };     // {{blue,green},{green,red}}
                }
                else if (radioButton9.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.G }, { RGB.B, RGB.R } };    // {{blue,green},{blue,red}}
                }
                else if (radioButton10.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.G }, { RGB.R, RGB.B } };    // {{blue,green},{red,blue}}
                }
                else if (radioButton11.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.G }, { RGB.G, RGB.B } };   // {{blue,green},{red,green}}
                }
                else if (radioButton12.Checked)
                {
                    color_index = new int[2, 2] { { RGB.B, RGB.G }, { RGB.B, RGB.G } };  // {{blue,green},{blue,green}}
                }
                else
                    color_index = new int[2, 2] { { RGB.B, RGB.G }, { RGB.B, RGB.G } }; // default selection for the second row of Bayer Pattern if second color index not checked,// {{blue,green},{blue,green}}
            }        

            /* accepting perform mosaicing property value */
            if (radioButton13.Checked)
                IsDemosaicOrNot = true;
            else if (radioButton14.Checked)
                IsDemosaicOrNot = false;
            else
                IsDemosaicOrNot = true;  // default value for PerformDemosaicing property for Bayer Pattern Class 

            this.Close();
        }
    }
}
