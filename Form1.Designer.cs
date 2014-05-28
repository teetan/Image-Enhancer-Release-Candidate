namespace ImageEnhancer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Binarize = new System.Windows.Forms.Button();
            this.Invert = new System.Windows.Forms.Button();
            this.Blur = new System.Windows.Forms.Button();
            this.ContrastCorrection = new System.Windows.Forms.Button();
            this.ContrastStretching = new System.Windows.Forms.Button();
            this.OilPainting = new System.Windows.Forms.Button();
            this.SimpleEdgeDetect = new System.Windows.Forms.Button();
            this.HistogramEqualize = new System.Windows.Forms.Button();
            this.Pixellation = new System.Windows.Forms.Button();
            this.CannyEdgeDetection = new System.Windows.Forms.Button();
            this.SobelEdgeDetection = new System.Windows.Forms.Button();
            this.SimpleSkeleton = new System.Windows.Forms.Button();
            this.SimplePosterization = new System.Windows.Forms.Button();
            this.SierraDither = new System.Windows.Forms.Button();
            this.Jittering = new System.Windows.Forms.Button();
            this.BurkesDithering = new System.Windows.Forms.Button();
            this.BayerDithering = new System.Windows.Forms.Button();
            this.RotateRGBChannel = new System.Windows.Forms.Button();
            this.RotateNeighbour = new System.Windows.Forms.Button();
            this.SaltandPepperNoise = new System.Windows.Forms.Button();
            this.SaturationCorrection = new System.Windows.Forms.Button();
            this.Sepia = new System.Windows.Forms.Button();
            this.Sharpen = new System.Windows.Forms.Button();
            this.Texture = new System.Windows.Forms.Button();
            this.ExtractChannel = new System.Windows.Forms.Button();
            this.GammaCorrection = new System.Windows.Forms.Button();
            this.BrightnessCorrection = new System.Windows.Forms.Button();
            this.Convolution = new System.Windows.Forms.Button();
            this.FloydSteinbergDithering = new System.Windows.Forms.Button();
            this.GaussianSharpen = new System.Windows.Forms.Button();
            this.ColorRemap = new System.Windows.Forms.Button();
            this.DifferenceEdgeDetector = new System.Windows.Forms.Button();
            this.GaussianBlur = new System.Windows.Forms.Button();
            this.HomogeneityEdgeDetector = new System.Windows.Forms.Button();
            this.AdaptiveSmoothing = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.ImageOpen = new System.Windows.Forms.Button();
            this.Grayscale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(343, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Enhancer  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(779, 462);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 45);
            this.label2.TabIndex = 40;
            this.label2.Text = "Developer:- Abhisek Hazra, GNU LGPL License\r\nSupport E-mail:- opensource@abhisek-" +
    "hazra.in\r\nLibrary :- AForge.NET(http://www.aforgenet.com)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picImage
            // 
            this.picImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picImage.BackColor = System.Drawing.Color.Transparent;
            this.picImage.InitialImage = null;
            this.picImage.Location = new System.Drawing.Point(7, 21);
            this.picImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(605, 396);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 3;
            this.picImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.picImage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 26);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(618, 425);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Frame";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(758, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 21);
            this.label3.TabIndex = 49;
            this.label3.Text = "Basic Imaging Filters";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Binarize
            // 
            this.Binarize.Location = new System.Drawing.Point(638, 28);
            this.Binarize.Name = "Binarize";
            this.Binarize.Size = new System.Drawing.Size(93, 45);
            this.Binarize.TabIndex = 50;
            this.Binarize.Text = "Binarize";
            this.Binarize.UseVisualStyleBackColor = true;
            this.Binarize.Click += new System.EventHandler(this.Binarize_Click);
            // 
            // Invert
            // 
            this.Invert.Location = new System.Drawing.Point(638, 73);
            this.Invert.Name = "Invert";
            this.Invert.Size = new System.Drawing.Size(93, 46);
            this.Invert.TabIndex = 51;
            this.Invert.Text = "Invert";
            this.Invert.UseVisualStyleBackColor = true;
            this.Invert.Click += new System.EventHandler(this.Invert_Click);
            // 
            // Blur
            // 
            this.Blur.Location = new System.Drawing.Point(638, 119);
            this.Blur.Name = "Blur";
            this.Blur.Size = new System.Drawing.Size(93, 45);
            this.Blur.TabIndex = 52;
            this.Blur.Text = "Blur";
            this.Blur.UseVisualStyleBackColor = true;
            this.Blur.Click += new System.EventHandler(this.Blur_Click);
            // 
            // ContrastCorrection
            // 
            this.ContrastCorrection.Location = new System.Drawing.Point(638, 163);
            this.ContrastCorrection.Name = "ContrastCorrection";
            this.ContrastCorrection.Size = new System.Drawing.Size(93, 45);
            this.ContrastCorrection.TabIndex = 53;
            this.ContrastCorrection.Text = "Contrast Correction";
            this.ContrastCorrection.UseVisualStyleBackColor = true;
            this.ContrastCorrection.Click += new System.EventHandler(this.ContrastCorrection_Click);
            // 
            // ContrastStretching
            // 
            this.ContrastStretching.Location = new System.Drawing.Point(638, 209);
            this.ContrastStretching.Name = "ContrastStretching";
            this.ContrastStretching.Size = new System.Drawing.Size(93, 45);
            this.ContrastStretching.TabIndex = 54;
            this.ContrastStretching.Text = "Contrast Stretching";
            this.ContrastStretching.UseVisualStyleBackColor = true;
            this.ContrastStretching.Click += new System.EventHandler(this.ContrastStretching_Click);
            // 
            // OilPainting
            // 
            this.OilPainting.Location = new System.Drawing.Point(638, 258);
            this.OilPainting.Name = "OilPainting";
            this.OilPainting.Size = new System.Drawing.Size(93, 45);
            this.OilPainting.TabIndex = 55;
            this.OilPainting.Text = "Oil Painting";
            this.OilPainting.UseVisualStyleBackColor = true;
            this.OilPainting.Click += new System.EventHandler(this.OilPainting_Click);
            // 
            // SimpleEdgeDetect
            // 
            this.SimpleEdgeDetect.Location = new System.Drawing.Point(639, 306);
            this.SimpleEdgeDetect.Name = "SimpleEdgeDetect";
            this.SimpleEdgeDetect.Size = new System.Drawing.Size(92, 45);
            this.SimpleEdgeDetect.TabIndex = 56;
            this.SimpleEdgeDetect.Text = "Simple Edge Detecetor";
            this.SimpleEdgeDetect.UseVisualStyleBackColor = true;
            this.SimpleEdgeDetect.Click += new System.EventHandler(this.SimpleEdgeDetect_Click);
            // 
            // HistogramEqualize
            // 
            this.HistogramEqualize.Location = new System.Drawing.Point(639, 356);
            this.HistogramEqualize.Name = "HistogramEqualize";
            this.HistogramEqualize.Size = new System.Drawing.Size(92, 45);
            this.HistogramEqualize.TabIndex = 57;
            this.HistogramEqualize.Text = "Histogram Equalization";
            this.HistogramEqualize.UseVisualStyleBackColor = true;
            this.HistogramEqualize.Click += new System.EventHandler(this.HistogramEqualize_Click);
            // 
            // Pixellation
            // 
            this.Pixellation.Location = new System.Drawing.Point(639, 405);
            this.Pixellation.Name = "Pixellation";
            this.Pixellation.Size = new System.Drawing.Size(92, 45);
            this.Pixellation.TabIndex = 58;
            this.Pixellation.Text = "Pixellate";
            this.Pixellation.UseVisualStyleBackColor = true;
            this.Pixellation.Click += new System.EventHandler(this.Pixellation_Click);
            // 
            // CannyEdgeDetection
            // 
            this.CannyEdgeDetection.Location = new System.Drawing.Point(737, 28);
            this.CannyEdgeDetection.Name = "CannyEdgeDetection";
            this.CannyEdgeDetection.Size = new System.Drawing.Size(93, 45);
            this.CannyEdgeDetection.TabIndex = 59;
            this.CannyEdgeDetection.Text = "Canny Edge Detection";
            this.CannyEdgeDetection.UseVisualStyleBackColor = true;
            this.CannyEdgeDetection.Click += new System.EventHandler(this.CannyEdgeDetection_Click);
            // 
            // SobelEdgeDetection
            // 
            this.SobelEdgeDetection.Location = new System.Drawing.Point(737, 74);
            this.SobelEdgeDetection.Name = "SobelEdgeDetection";
            this.SobelEdgeDetection.Size = new System.Drawing.Size(93, 45);
            this.SobelEdgeDetection.TabIndex = 60;
            this.SobelEdgeDetection.Text = "Sobel Edge Detection";
            this.SobelEdgeDetection.UseVisualStyleBackColor = true;
            this.SobelEdgeDetection.Click += new System.EventHandler(this.SobelEdgeDetection_Click);
            // 
            // SimpleSkeleton
            // 
            this.SimpleSkeleton.Location = new System.Drawing.Point(737, 163);
            this.SimpleSkeleton.Name = "SimpleSkeleton";
            this.SimpleSkeleton.Size = new System.Drawing.Size(93, 45);
            this.SimpleSkeleton.TabIndex = 62;
            this.SimpleSkeleton.Text = "Simple Skeleton";
            this.SimpleSkeleton.UseVisualStyleBackColor = true;
            this.SimpleSkeleton.Click += new System.EventHandler(this.SimpleSkeleton_Click);
            // 
            // SimplePosterization
            // 
            this.SimplePosterization.Location = new System.Drawing.Point(737, 209);
            this.SimplePosterization.Name = "SimplePosterization";
            this.SimplePosterization.Size = new System.Drawing.Size(93, 45);
            this.SimplePosterization.TabIndex = 63;
            this.SimplePosterization.Text = "Simple Posterization";
            this.SimplePosterization.UseVisualStyleBackColor = true;
            this.SimplePosterization.Click += new System.EventHandler(this.SimplePosterization_Click);
            // 
            // SierraDither
            // 
            this.SierraDither.Location = new System.Drawing.Point(737, 258);
            this.SierraDither.Name = "SierraDither";
            this.SierraDither.Size = new System.Drawing.Size(93, 45);
            this.SierraDither.TabIndex = 64;
            this.SierraDither.Text = "Sierra Dithering";
            this.SierraDither.UseVisualStyleBackColor = true;
            this.SierraDither.Click += new System.EventHandler(this.SierraDither_Click);
            // 
            // Jittering
            // 
            this.Jittering.Location = new System.Drawing.Point(737, 306);
            this.Jittering.Name = "Jittering";
            this.Jittering.Size = new System.Drawing.Size(93, 45);
            this.Jittering.TabIndex = 65;
            this.Jittering.Text = "Jittering";
            this.Jittering.UseVisualStyleBackColor = true;
            this.Jittering.Click += new System.EventHandler(this.Jittering_Click);
            // 
            // BurkesDithering
            // 
            this.BurkesDithering.Location = new System.Drawing.Point(737, 356);
            this.BurkesDithering.Name = "BurkesDithering";
            this.BurkesDithering.Size = new System.Drawing.Size(93, 45);
            this.BurkesDithering.TabIndex = 66;
            this.BurkesDithering.Text = "Burkes Dithering";
            this.BurkesDithering.UseVisualStyleBackColor = true;
            this.BurkesDithering.Click += new System.EventHandler(this.BurkesDithering_Click);
            // 
            // BayerDithering
            // 
            this.BayerDithering.Location = new System.Drawing.Point(737, 405);
            this.BayerDithering.Name = "BayerDithering";
            this.BayerDithering.Size = new System.Drawing.Size(93, 45);
            this.BayerDithering.TabIndex = 67;
            this.BayerDithering.Text = "Bayer Dithering";
            this.BayerDithering.UseVisualStyleBackColor = true;
            this.BayerDithering.Click += new System.EventHandler(this.BayerDithering_Click);
            // 
            // RotateRGBChannel
            // 
            this.RotateRGBChannel.BackColor = System.Drawing.Color.Transparent;
            this.RotateRGBChannel.Location = new System.Drawing.Point(836, 28);
            this.RotateRGBChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RotateRGBChannel.Name = "RotateRGBChannel";
            this.RotateRGBChannel.Size = new System.Drawing.Size(93, 45);
            this.RotateRGBChannel.TabIndex = 68;
            this.RotateRGBChannel.Text = "Rotate RGB Channel";
            this.RotateRGBChannel.UseVisualStyleBackColor = false;
            this.RotateRGBChannel.Click += new System.EventHandler(this.RotateRGBChannel_Click);
            // 
            // RotateNeighbour
            // 
            this.RotateNeighbour.BackColor = System.Drawing.Color.Transparent;
            this.RotateNeighbour.Location = new System.Drawing.Point(836, 73);
            this.RotateNeighbour.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RotateNeighbour.Name = "RotateNeighbour";
            this.RotateNeighbour.Size = new System.Drawing.Size(93, 45);
            this.RotateNeighbour.TabIndex = 69;
            this.RotateNeighbour.Text = "Rotate Neighbor";
            this.RotateNeighbour.UseVisualStyleBackColor = false;
            this.RotateNeighbour.Click += new System.EventHandler(this.RotateNeighbour_Click);
            // 
            // SaltandPepperNoise
            // 
            this.SaltandPepperNoise.BackColor = System.Drawing.Color.Transparent;
            this.SaltandPepperNoise.Location = new System.Drawing.Point(836, 119);
            this.SaltandPepperNoise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaltandPepperNoise.Name = "SaltandPepperNoise";
            this.SaltandPepperNoise.Size = new System.Drawing.Size(93, 45);
            this.SaltandPepperNoise.TabIndex = 70;
            this.SaltandPepperNoise.Text = "Salt and Pepper Noise";
            this.SaltandPepperNoise.UseVisualStyleBackColor = false;
            this.SaltandPepperNoise.Click += new System.EventHandler(this.SaltandPepperNoise_Click);
            // 
            // SaturationCorrection
            // 
            this.SaturationCorrection.BackColor = System.Drawing.Color.Transparent;
            this.SaturationCorrection.Location = new System.Drawing.Point(836, 163);
            this.SaturationCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaturationCorrection.Name = "SaturationCorrection";
            this.SaturationCorrection.Size = new System.Drawing.Size(93, 45);
            this.SaturationCorrection.TabIndex = 71;
            this.SaturationCorrection.Text = "Saturation Correction";
            this.SaturationCorrection.UseVisualStyleBackColor = false;
            this.SaturationCorrection.Click += new System.EventHandler(this.SaturationCorrection_Click);
            // 
            // Sepia
            // 
            this.Sepia.BackColor = System.Drawing.Color.Transparent;
            this.Sepia.Location = new System.Drawing.Point(836, 209);
            this.Sepia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sepia.Name = "Sepia";
            this.Sepia.Size = new System.Drawing.Size(93, 45);
            this.Sepia.TabIndex = 72;
            this.Sepia.Text = "Sepia";
            this.Sepia.UseVisualStyleBackColor = false;
            this.Sepia.Click += new System.EventHandler(this.Sepia_Click);
            // 
            // Sharpen
            // 
            this.Sharpen.BackColor = System.Drawing.Color.Transparent;
            this.Sharpen.Location = new System.Drawing.Point(836, 258);
            this.Sharpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sharpen.Name = "Sharpen";
            this.Sharpen.Size = new System.Drawing.Size(93, 45);
            this.Sharpen.TabIndex = 73;
            this.Sharpen.Text = "Sharpen";
            this.Sharpen.UseVisualStyleBackColor = false;
            this.Sharpen.Click += new System.EventHandler(this.Sharpen_Click);
            // 
            // Texture
            // 
            this.Texture.BackColor = System.Drawing.Color.Transparent;
            this.Texture.Location = new System.Drawing.Point(836, 306);
            this.Texture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Texture.Name = "Texture";
            this.Texture.Size = new System.Drawing.Size(93, 45);
            this.Texture.TabIndex = 74;
            this.Texture.Text = "Texture";
            this.Texture.UseVisualStyleBackColor = false;
            this.Texture.Click += new System.EventHandler(this.Texture_Click);
            // 
            // ExtractChannel
            // 
            this.ExtractChannel.BackColor = System.Drawing.Color.Transparent;
            this.ExtractChannel.Location = new System.Drawing.Point(836, 356);
            this.ExtractChannel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ExtractChannel.Name = "ExtractChannel";
            this.ExtractChannel.Size = new System.Drawing.Size(93, 45);
            this.ExtractChannel.TabIndex = 75;
            this.ExtractChannel.Text = "Extract Channel";
            this.ExtractChannel.UseVisualStyleBackColor = false;
            this.ExtractChannel.Click += new System.EventHandler(this.ExtractChannel_Click);
            // 
            // GammaCorrection
            // 
            this.GammaCorrection.BackColor = System.Drawing.Color.Transparent;
            this.GammaCorrection.Location = new System.Drawing.Point(836, 405);
            this.GammaCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GammaCorrection.Name = "GammaCorrection";
            this.GammaCorrection.Size = new System.Drawing.Size(93, 45);
            this.GammaCorrection.TabIndex = 76;
            this.GammaCorrection.Text = "Gamma Correction";
            this.GammaCorrection.UseVisualStyleBackColor = false;
            this.GammaCorrection.Click += new System.EventHandler(this.GammaCorrection_Click);
            // 
            // BrightnessCorrection
            // 
            this.BrightnessCorrection.BackColor = System.Drawing.Color.Transparent;
            this.BrightnessCorrection.Location = new System.Drawing.Point(935, 28);
            this.BrightnessCorrection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BrightnessCorrection.Name = "BrightnessCorrection";
            this.BrightnessCorrection.Size = new System.Drawing.Size(93, 45);
            this.BrightnessCorrection.TabIndex = 77;
            this.BrightnessCorrection.Text = "Brightness Correction";
            this.BrightnessCorrection.UseVisualStyleBackColor = false;
            this.BrightnessCorrection.Click += new System.EventHandler(this.BrightnessCorrection_Click);
            // 
            // Convolution
            // 
            this.Convolution.BackColor = System.Drawing.Color.Transparent;
            this.Convolution.Location = new System.Drawing.Point(936, 74);
            this.Convolution.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Convolution.Name = "Convolution";
            this.Convolution.Size = new System.Drawing.Size(93, 45);
            this.Convolution.TabIndex = 78;
            this.Convolution.Text = "Convolution";
            this.Convolution.UseVisualStyleBackColor = false;
            this.Convolution.Click += new System.EventHandler(this.Convolution_Click);
            // 
            // FloydSteinbergDithering
            // 
            this.FloydSteinbergDithering.BackColor = System.Drawing.Color.Transparent;
            this.FloydSteinbergDithering.Location = new System.Drawing.Point(936, 119);
            this.FloydSteinbergDithering.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FloydSteinbergDithering.Name = "FloydSteinbergDithering";
            this.FloydSteinbergDithering.Size = new System.Drawing.Size(93, 45);
            this.FloydSteinbergDithering.TabIndex = 79;
            this.FloydSteinbergDithering.Text = "Floyd Dithering";
            this.FloydSteinbergDithering.UseVisualStyleBackColor = false;
            this.FloydSteinbergDithering.Click += new System.EventHandler(this.FloydSteinbergDithering_Click);
            // 
            // GaussianSharpen
            // 
            this.GaussianSharpen.BackColor = System.Drawing.Color.Transparent;
            this.GaussianSharpen.Location = new System.Drawing.Point(936, 163);
            this.GaussianSharpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GaussianSharpen.Name = "GaussianSharpen";
            this.GaussianSharpen.Size = new System.Drawing.Size(93, 45);
            this.GaussianSharpen.TabIndex = 80;
            this.GaussianSharpen.Text = "Gaussian Sharpen";
            this.GaussianSharpen.UseVisualStyleBackColor = false;
            this.GaussianSharpen.Click += new System.EventHandler(this.GaussianSharpen_Click);
            // 
            // ColorRemap
            // 
            this.ColorRemap.BackColor = System.Drawing.Color.Transparent;
            this.ColorRemap.Location = new System.Drawing.Point(935, 209);
            this.ColorRemap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColorRemap.Name = "ColorRemap";
            this.ColorRemap.Size = new System.Drawing.Size(93, 45);
            this.ColorRemap.TabIndex = 81;
            this.ColorRemap.Text = "Color Remap";
            this.ColorRemap.UseVisualStyleBackColor = false;
            this.ColorRemap.Click += new System.EventHandler(this.ColorRemap_Click);
            // 
            // DifferenceEdgeDetector
            // 
            this.DifferenceEdgeDetector.BackColor = System.Drawing.Color.Transparent;
            this.DifferenceEdgeDetector.Location = new System.Drawing.Point(936, 258);
            this.DifferenceEdgeDetector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DifferenceEdgeDetector.Name = "DifferenceEdgeDetector";
            this.DifferenceEdgeDetector.Size = new System.Drawing.Size(93, 45);
            this.DifferenceEdgeDetector.TabIndex = 82;
            this.DifferenceEdgeDetector.Text = "Edge Detect\r\n(Type 1)";
            this.DifferenceEdgeDetector.UseVisualStyleBackColor = false;
            this.DifferenceEdgeDetector.Click += new System.EventHandler(this.DifferenceEdgeDetector_Click);
            // 
            // GaussianBlur
            // 
            this.GaussianBlur.BackColor = System.Drawing.Color.Transparent;
            this.GaussianBlur.Location = new System.Drawing.Point(936, 306);
            this.GaussianBlur.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GaussianBlur.Name = "GaussianBlur";
            this.GaussianBlur.Size = new System.Drawing.Size(93, 45);
            this.GaussianBlur.TabIndex = 83;
            this.GaussianBlur.Text = "Gaussian Blur";
            this.GaussianBlur.UseVisualStyleBackColor = false;
            this.GaussianBlur.Click += new System.EventHandler(this.GaussianBlur_Click);
            // 
            // HomogeneityEdgeDetector
            // 
            this.HomogeneityEdgeDetector.BackColor = System.Drawing.Color.Transparent;
            this.HomogeneityEdgeDetector.Location = new System.Drawing.Point(935, 356);
            this.HomogeneityEdgeDetector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomogeneityEdgeDetector.Name = "HomogeneityEdgeDetector";
            this.HomogeneityEdgeDetector.Size = new System.Drawing.Size(94, 45);
            this.HomogeneityEdgeDetector.TabIndex = 84;
            this.HomogeneityEdgeDetector.Text = "Edge Detect\r\n(Type 2)";
            this.HomogeneityEdgeDetector.UseVisualStyleBackColor = false;
            this.HomogeneityEdgeDetector.Click += new System.EventHandler(this.HomogeneityEdgeDetector_Click);
            // 
            // AdaptiveSmoothing
            // 
            this.AdaptiveSmoothing.BackColor = System.Drawing.Color.Transparent;
            this.AdaptiveSmoothing.Location = new System.Drawing.Point(936, 405);
            this.AdaptiveSmoothing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdaptiveSmoothing.Name = "AdaptiveSmoothing";
            this.AdaptiveSmoothing.Size = new System.Drawing.Size(92, 45);
            this.AdaptiveSmoothing.TabIndex = 85;
            this.AdaptiveSmoothing.Text = "Adaptive Smoothing";
            this.AdaptiveSmoothing.UseVisualStyleBackColor = false;
            this.AdaptiveSmoothing.Click += new System.EventHandler(this.AdaptiveSmoothing_Click);
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(14, 458);
            this.Refresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(100, 45);
            this.Refresh.TabIndex = 86;
            this.Refresh.Text = "&Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(171, 458);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 45);
            this.Save.TabIndex = 87;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(343, 458);
            this.Next.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 45);
            this.Next.TabIndex = 88;
            this.Next.Text = "&Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // ImageOpen
            // 
            this.ImageOpen.BackColor = System.Drawing.Color.Transparent;
            this.ImageOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImageOpen.Location = new System.Drawing.Point(532, 458);
            this.ImageOpen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ImageOpen.Name = "ImageOpen";
            this.ImageOpen.Size = new System.Drawing.Size(100, 45);
            this.ImageOpen.TabIndex = 89;
            this.ImageOpen.Text = "&Open Image";
            this.ImageOpen.UseVisualStyleBackColor = false;
            this.ImageOpen.Click += new System.EventHandler(this.ImageOpen_Click);
            // 
            // Grayscale
            // 
            this.Grayscale.Location = new System.Drawing.Point(737, 119);
            this.Grayscale.Name = "Grayscale";
            this.Grayscale.Size = new System.Drawing.Size(93, 45);
            this.Grayscale.TabIndex = 90;
            this.Grayscale.Text = "Grayscale ";
            this.Grayscale.UseVisualStyleBackColor = true;
            this.Grayscale.Click += new System.EventHandler(this.Grayscale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1041, 512);
            this.Controls.Add(this.Grayscale);
            this.Controls.Add(this.ImageOpen);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.AdaptiveSmoothing);
            this.Controls.Add(this.HomogeneityEdgeDetector);
            this.Controls.Add(this.GaussianBlur);
            this.Controls.Add(this.DifferenceEdgeDetector);
            this.Controls.Add(this.ColorRemap);
            this.Controls.Add(this.GaussianSharpen);
            this.Controls.Add(this.FloydSteinbergDithering);
            this.Controls.Add(this.Convolution);
            this.Controls.Add(this.BrightnessCorrection);
            this.Controls.Add(this.GammaCorrection);
            this.Controls.Add(this.ExtractChannel);
            this.Controls.Add(this.Texture);
            this.Controls.Add(this.Sharpen);
            this.Controls.Add(this.Sepia);
            this.Controls.Add(this.SaturationCorrection);
            this.Controls.Add(this.SaltandPepperNoise);
            this.Controls.Add(this.RotateNeighbour);
            this.Controls.Add(this.RotateRGBChannel);
            this.Controls.Add(this.BayerDithering);
            this.Controls.Add(this.BurkesDithering);
            this.Controls.Add(this.Jittering);
            this.Controls.Add(this.SierraDither);
            this.Controls.Add(this.SimplePosterization);
            this.Controls.Add(this.SimpleSkeleton);
            this.Controls.Add(this.SobelEdgeDetection);
            this.Controls.Add(this.CannyEdgeDetection);
            this.Controls.Add(this.Pixellation);
            this.Controls.Add(this.HistogramEqualize);
            this.Controls.Add(this.SimpleEdgeDetect);
            this.Controls.Add(this.OilPainting);
            this.Controls.Add(this.ContrastStretching);
            this.Controls.Add(this.ContrastCorrection);
            this.Controls.Add(this.Blur);
            this.Controls.Add(this.Invert);
            this.Controls.Add(this.Binarize);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image  Enhancer 1.0.0  Release Candidate";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Binarize;
        private System.Windows.Forms.Button Invert;
        private System.Windows.Forms.Button Blur;
        private System.Windows.Forms.Button ContrastCorrection;
        private System.Windows.Forms.Button ContrastStretching;
        private System.Windows.Forms.Button OilPainting;
        private System.Windows.Forms.Button SimpleEdgeDetect;
        private System.Windows.Forms.Button HistogramEqualize;
        private System.Windows.Forms.Button Pixellation;
        private System.Windows.Forms.Button CannyEdgeDetection;
        private System.Windows.Forms.Button SobelEdgeDetection;
        private System.Windows.Forms.Button SimpleSkeleton;
        private System.Windows.Forms.Button SimplePosterization;
        private System.Windows.Forms.Button SierraDither;
        private System.Windows.Forms.Button Jittering;
        private System.Windows.Forms.Button BurkesDithering;
        private System.Windows.Forms.Button BayerDithering;
        private System.Windows.Forms.Button RotateRGBChannel;
        private System.Windows.Forms.Button RotateNeighbour;
        private System.Windows.Forms.Button SaltandPepperNoise;
        private System.Windows.Forms.Button SaturationCorrection;
        private System.Windows.Forms.Button Sepia;
        private System.Windows.Forms.Button Sharpen;
        private System.Windows.Forms.Button Texture;
        private System.Windows.Forms.Button ExtractChannel;
        private System.Windows.Forms.Button GammaCorrection;
        private System.Windows.Forms.Button BrightnessCorrection;
        private System.Windows.Forms.Button Convolution;
        private System.Windows.Forms.Button FloydSteinbergDithering;
        private System.Windows.Forms.Button GaussianSharpen;
        private System.Windows.Forms.Button ColorRemap;
        private System.Windows.Forms.Button DifferenceEdgeDetector;
        private System.Windows.Forms.Button GaussianBlur;
        private System.Windows.Forms.Button HomogeneityEdgeDetector;
        private System.Windows.Forms.Button AdaptiveSmoothing;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button ImageOpen;
        private System.Windows.Forms.Button Grayscale;


    }
}

