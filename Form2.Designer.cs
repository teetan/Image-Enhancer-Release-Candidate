namespace ImageEnhancer
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.PicImageSecond = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.OpenImage = new System.Windows.Forms.Button();
            this.AdditiveNoise = new System.Windows.Forms.Button();
            this.BilateralSmoothing = new System.Windows.Forms.Button();
            this.CanvasCrop = new System.Windows.Forms.Button();
            this.BayerFilter = new System.Windows.Forms.Button();
            this.MeanFilter = new System.Windows.Forms.Button();
            this.WaterWave = new System.Windows.Forms.Button();
            this.HSLFilter = new System.Windows.Forms.Button();
            this.YCbCrColor = new System.Windows.Forms.Button();
            this.YCbCrExtract = new System.Windows.Forms.Button();
            this.TransformToPolar = new System.Windows.Forms.Button();
            this.TransformFromPolar = new System.Windows.Forms.Button();
            this.YCbCrLinear = new System.Windows.Forms.Button();
            this.StuckiDithering = new System.Windows.Forms.Button();
            this.SimpleSkeleton = new System.Windows.Forms.Button();
            this.ExtractNormalized = new System.Windows.Forms.Button();
            this.ChannelFiltering = new System.Windows.Forms.Button();
            this.ConservativeSmoothing = new System.Windows.Forms.Button();
            this.SusanCornerDetection = new System.Windows.Forms.Button();
            this.JarvisJudisNinkeDithering = new System.Windows.Forms.Button();
            this.MedianFilter = new System.Windows.Forms.Button();
            this.MirrorFilter = new System.Windows.Forms.Button();
            this.SaturationIncrement = new System.Windows.Forms.Button();
            this.SaturationDecrement = new System.Windows.Forms.Button();
            this.SISThreshold = new System.Windows.Forms.Button();
            this.ResizeBicubic = new System.Windows.Forms.Button();
            this.BilinearResize = new System.Windows.Forms.Button();
            this.NearestNeighbourResize = new System.Windows.Forms.Button();
            this.RotateBicubic = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PicImageSecond)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PicImageSecond
            // 
            this.PicImageSecond.BackColor = System.Drawing.Color.Transparent;
            this.PicImageSecond.Location = new System.Drawing.Point(7, 21);
            this.PicImageSecond.Name = "PicImageSecond";
            this.PicImageSecond.Size = new System.Drawing.Size(605, 396);
            this.PicImageSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicImageSecond.TabIndex = 42;
            this.PicImageSecond.TabStop = false;
            this.PicImageSecond.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(325, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 23);
            this.label1.TabIndex = 44;
            this.label1.Text = "Image Enhancer ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Goudy Old Style", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(762, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 48;
            this.label3.Text = "Complex Imaging Filters";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.PicImageSecond);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 427);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Frame";
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.Transparent;
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(16, 462);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(100, 45);
            this.Refresh.TabIndex = 81;
            this.Refresh.Text = "&Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.Location = new System.Drawing.Point(139, 462);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(100, 45);
            this.Save.TabIndex = 82;
            this.Save.Text = "&Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.Transparent;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(265, 462);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(100, 45);
            this.Back.TabIndex = 83;
            this.Back.Text = "&Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Next.Location = new System.Drawing.Point(396, 462);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(100, 45);
            this.Next.TabIndex = 84;
            this.Next.Text = "&Next";
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // OpenImage
            // 
            this.OpenImage.BackColor = System.Drawing.Color.Transparent;
            this.OpenImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenImage.Location = new System.Drawing.Point(528, 463);
            this.OpenImage.Name = "OpenImage";
            this.OpenImage.Size = new System.Drawing.Size(100, 45);
            this.OpenImage.TabIndex = 85;
            this.OpenImage.Text = "&Open Image";
            this.OpenImage.UseVisualStyleBackColor = false;
            this.OpenImage.Click += new System.EventHandler(this.OpenImage_Click);
            // 
            // AdditiveNoise
            // 
            this.AdditiveNoise.Location = new System.Drawing.Point(640, 74);
            this.AdditiveNoise.Name = "AdditiveNoise";
            this.AdditiveNoise.Size = new System.Drawing.Size(93, 45);
            this.AdditiveNoise.TabIndex = 86;
            this.AdditiveNoise.Text = "Additive Noise";
            this.AdditiveNoise.UseVisualStyleBackColor = true;
            this.AdditiveNoise.Click += new System.EventHandler(this.AdditiveNoise_Click);
            // 
            // BilateralSmoothing
            // 
            this.BilateralSmoothing.Location = new System.Drawing.Point(640, 125);
            this.BilateralSmoothing.Name = "BilateralSmoothing";
            this.BilateralSmoothing.Size = new System.Drawing.Size(93, 45);
            this.BilateralSmoothing.TabIndex = 87;
            this.BilateralSmoothing.Text = "Bilateral Smoothing";
            this.BilateralSmoothing.UseVisualStyleBackColor = true;
            this.BilateralSmoothing.Click += new System.EventHandler(this.BilateralSmoothing_Click);
            // 
            // CanvasCrop
            // 
            this.CanvasCrop.Location = new System.Drawing.Point(640, 176);
            this.CanvasCrop.Name = "CanvasCrop";
            this.CanvasCrop.Size = new System.Drawing.Size(93, 45);
            this.CanvasCrop.TabIndex = 88;
            this.CanvasCrop.Text = "Canvas Crop";
            this.CanvasCrop.UseVisualStyleBackColor = true;
            this.CanvasCrop.Click += new System.EventHandler(this.CanvasCrop_Click);
            // 
            // BayerFilter
            // 
            this.BayerFilter.Location = new System.Drawing.Point(640, 227);
            this.BayerFilter.Name = "BayerFilter";
            this.BayerFilter.Size = new System.Drawing.Size(93, 45);
            this.BayerFilter.TabIndex = 89;
            this.BayerFilter.Text = "Bayer Filter";
            this.BayerFilter.UseVisualStyleBackColor = true;
            this.BayerFilter.Click += new System.EventHandler(this.BayerFilter_Click);
            // 
            // MeanFilter
            // 
            this.MeanFilter.Location = new System.Drawing.Point(640, 278);
            this.MeanFilter.Name = "MeanFilter";
            this.MeanFilter.Size = new System.Drawing.Size(93, 45);
            this.MeanFilter.TabIndex = 90;
            this.MeanFilter.Text = "Mean Filter";
            this.MeanFilter.UseVisualStyleBackColor = true;
            this.MeanFilter.Click += new System.EventHandler(this.MeanFilter_Click);
            // 
            // WaterWave
            // 
            this.WaterWave.Location = new System.Drawing.Point(640, 329);
            this.WaterWave.Name = "WaterWave";
            this.WaterWave.Size = new System.Drawing.Size(93, 54);
            this.WaterWave.TabIndex = 91;
            this.WaterWave.Text = "Water Wave Filter";
            this.WaterWave.UseVisualStyleBackColor = true;
            this.WaterWave.Click += new System.EventHandler(this.WaterWave_Click);
            // 
            // HSLFilter
            // 
            this.HSLFilter.Location = new System.Drawing.Point(640, 389);
            this.HSLFilter.Name = "HSLFilter";
            this.HSLFilter.Size = new System.Drawing.Size(93, 45);
            this.HSLFilter.TabIndex = 92;
            this.HSLFilter.Text = "HSL Filter";
            this.HSLFilter.UseVisualStyleBackColor = true;
            this.HSLFilter.Click += new System.EventHandler(this.HSLFilter_Click);
            // 
            // YCbCrColor
            // 
            this.YCbCrColor.Location = new System.Drawing.Point(739, 74);
            this.YCbCrColor.Name = "YCbCrColor";
            this.YCbCrColor.Size = new System.Drawing.Size(93, 45);
            this.YCbCrColor.TabIndex = 93;
            this.YCbCrColor.Text = "Y Cb Cr Color Filter";
            this.YCbCrColor.UseVisualStyleBackColor = true;
            this.YCbCrColor.Click += new System.EventHandler(this.YCbCrColor_Click);
            // 
            // YCbCrExtract
            // 
            this.YCbCrExtract.Location = new System.Drawing.Point(739, 125);
            this.YCbCrExtract.Name = "YCbCrExtract";
            this.YCbCrExtract.Size = new System.Drawing.Size(93, 45);
            this.YCbCrExtract.TabIndex = 94;
            this.YCbCrExtract.Text = "Y Cb Cr Extract Filter";
            this.YCbCrExtract.UseVisualStyleBackColor = true;
            this.YCbCrExtract.Click += new System.EventHandler(this.YCbCrExtract_Click);
            // 
            // TransformToPolar
            // 
            this.TransformToPolar.Location = new System.Drawing.Point(739, 176);
            this.TransformToPolar.Name = "TransformToPolar";
            this.TransformToPolar.Size = new System.Drawing.Size(93, 45);
            this.TransformToPolar.TabIndex = 95;
            this.TransformToPolar.Text = "Transform to Polar Filter";
            this.TransformToPolar.UseVisualStyleBackColor = true;
            this.TransformToPolar.Click += new System.EventHandler(this.TransformToPolar_Click);
            // 
            // TransformFromPolar
            // 
            this.TransformFromPolar.Location = new System.Drawing.Point(739, 227);
            this.TransformFromPolar.Name = "TransformFromPolar";
            this.TransformFromPolar.Size = new System.Drawing.Size(93, 45);
            this.TransformFromPolar.TabIndex = 96;
            this.TransformFromPolar.Text = "Transform from Polar Filter";
            this.TransformFromPolar.UseVisualStyleBackColor = true;
            this.TransformFromPolar.Click += new System.EventHandler(this.TransformFromPolar_Click);
            // 
            // YCbCrLinear
            // 
            this.YCbCrLinear.Location = new System.Drawing.Point(739, 278);
            this.YCbCrLinear.Name = "YCbCrLinear";
            this.YCbCrLinear.Size = new System.Drawing.Size(93, 45);
            this.YCbCrLinear.TabIndex = 97;
            this.YCbCrLinear.Text = "YCbCr Linear Filter";
            this.YCbCrLinear.UseVisualStyleBackColor = true;
            this.YCbCrLinear.Click += new System.EventHandler(this.YCbCrLinear_Click);
            // 
            // StuckiDithering
            // 
            this.StuckiDithering.Location = new System.Drawing.Point(739, 329);
            this.StuckiDithering.Name = "StuckiDithering";
            this.StuckiDithering.Size = new System.Drawing.Size(93, 54);
            this.StuckiDithering.TabIndex = 98;
            this.StuckiDithering.Text = "Stucki Dithering";
            this.StuckiDithering.UseVisualStyleBackColor = true;
            this.StuckiDithering.Click += new System.EventHandler(this.StuckiDithering_Click);
            // 
            // SimpleSkeleton
            // 
            this.SimpleSkeleton.Location = new System.Drawing.Point(738, 389);
            this.SimpleSkeleton.Name = "SimpleSkeleton";
            this.SimpleSkeleton.Size = new System.Drawing.Size(93, 45);
            this.SimpleSkeleton.TabIndex = 99;
            this.SimpleSkeleton.Text = "Simple  Skeleton";
            this.SimpleSkeleton.UseVisualStyleBackColor = true;
            this.SimpleSkeleton.Click += new System.EventHandler(this.SimpleSkeleton_Click);
            // 
            // ExtractNormalized
            // 
            this.ExtractNormalized.Location = new System.Drawing.Point(837, 74);
            this.ExtractNormalized.Name = "ExtractNormalized";
            this.ExtractNormalized.Size = new System.Drawing.Size(93, 45);
            this.ExtractNormalized.TabIndex = 100;
            this.ExtractNormalized.Text = "Extract Normalized";
            this.ExtractNormalized.UseVisualStyleBackColor = true;
            this.ExtractNormalized.Click += new System.EventHandler(this.ExtractNormalized_Click);
            // 
            // ChannelFiltering
            // 
            this.ChannelFiltering.Location = new System.Drawing.Point(838, 125);
            this.ChannelFiltering.Name = "ChannelFiltering";
            this.ChannelFiltering.Size = new System.Drawing.Size(93, 45);
            this.ChannelFiltering.TabIndex = 101;
            this.ChannelFiltering.Text = "Channel Filtering";
            this.ChannelFiltering.UseVisualStyleBackColor = true;
            this.ChannelFiltering.Click += new System.EventHandler(this.ChannelFiltering_Click);
            // 
            // ConservativeSmoothing
            // 
            this.ConservativeSmoothing.Location = new System.Drawing.Point(838, 176);
            this.ConservativeSmoothing.Name = "ConservativeSmoothing";
            this.ConservativeSmoothing.Size = new System.Drawing.Size(93, 45);
            this.ConservativeSmoothing.TabIndex = 102;
            this.ConservativeSmoothing.Text = "Conservative Smoothing";
            this.ConservativeSmoothing.UseVisualStyleBackColor = true;
            this.ConservativeSmoothing.Click += new System.EventHandler(this.ConservativeSmoothing_Click);
            // 
            // SusanCornerDetection
            // 
            this.SusanCornerDetection.Location = new System.Drawing.Point(838, 227);
            this.SusanCornerDetection.Name = "SusanCornerDetection";
            this.SusanCornerDetection.Size = new System.Drawing.Size(93, 45);
            this.SusanCornerDetection.TabIndex = 103;
            this.SusanCornerDetection.Text = "Susan Corner Detection";
            this.SusanCornerDetection.UseVisualStyleBackColor = true;
            this.SusanCornerDetection.Click += new System.EventHandler(this.SusanCornerDetection_Click);
            // 
            // JarvisJudisNinkeDithering
            // 
            this.JarvisJudisNinkeDithering.Location = new System.Drawing.Point(838, 278);
            this.JarvisJudisNinkeDithering.Name = "JarvisJudisNinkeDithering";
            this.JarvisJudisNinkeDithering.Size = new System.Drawing.Size(93, 45);
            this.JarvisJudisNinkeDithering.TabIndex = 104;
            this.JarvisJudisNinkeDithering.Text = "JJN Dithering";
            this.JarvisJudisNinkeDithering.UseVisualStyleBackColor = true;
            this.JarvisJudisNinkeDithering.Click += new System.EventHandler(this.JarvisJudisNinkeDithering_Click);
            // 
            // MedianFilter
            // 
            this.MedianFilter.Location = new System.Drawing.Point(838, 329);
            this.MedianFilter.Name = "MedianFilter";
            this.MedianFilter.Size = new System.Drawing.Size(93, 54);
            this.MedianFilter.TabIndex = 105;
            this.MedianFilter.Text = "Median Filter";
            this.MedianFilter.UseVisualStyleBackColor = true;
            this.MedianFilter.Click += new System.EventHandler(this.MedianFilter_Click);
            // 
            // MirrorFilter
            // 
            this.MirrorFilter.Location = new System.Drawing.Point(837, 389);
            this.MirrorFilter.Name = "MirrorFilter";
            this.MirrorFilter.Size = new System.Drawing.Size(93, 45);
            this.MirrorFilter.TabIndex = 106;
            this.MirrorFilter.Text = "Mirror Filter";
            this.MirrorFilter.UseVisualStyleBackColor = true;
            this.MirrorFilter.Click += new System.EventHandler(this.MirrorFilter_Click);
            // 
            // SaturationIncrement
            // 
            this.SaturationIncrement.Location = new System.Drawing.Point(937, 74);
            this.SaturationIncrement.Name = "SaturationIncrement";
            this.SaturationIncrement.Size = new System.Drawing.Size(93, 45);
            this.SaturationIncrement.TabIndex = 107;
            this.SaturationIncrement.Text = "Saturaion Increment";
            this.SaturationIncrement.UseVisualStyleBackColor = true;
            this.SaturationIncrement.Click += new System.EventHandler(this.SaturationIncrement_Click);
            // 
            // SaturationDecrement
            // 
            this.SaturationDecrement.Location = new System.Drawing.Point(937, 125);
            this.SaturationDecrement.Name = "SaturationDecrement";
            this.SaturationDecrement.Size = new System.Drawing.Size(93, 45);
            this.SaturationDecrement.TabIndex = 108;
            this.SaturationDecrement.Text = "Saturaion Decrement";
            this.SaturationDecrement.UseVisualStyleBackColor = true;
            this.SaturationDecrement.Click += new System.EventHandler(this.SaturationDecrement_Click);
            // 
            // SISThreshold
            // 
            this.SISThreshold.Location = new System.Drawing.Point(937, 176);
            this.SISThreshold.Name = "SISThreshold";
            this.SISThreshold.Size = new System.Drawing.Size(93, 45);
            this.SISThreshold.TabIndex = 109;
            this.SISThreshold.Text = "SIS Threshold";
            this.SISThreshold.UseVisualStyleBackColor = true;
            this.SISThreshold.Click += new System.EventHandler(this.SISThreshold_Click);
            // 
            // ResizeBicubic
            // 
            this.ResizeBicubic.Location = new System.Drawing.Point(936, 227);
            this.ResizeBicubic.Name = "ResizeBicubic";
            this.ResizeBicubic.Size = new System.Drawing.Size(93, 45);
            this.ResizeBicubic.TabIndex = 110;
            this.ResizeBicubic.Text = "Bicubic Resize";
            this.ResizeBicubic.UseVisualStyleBackColor = true;
            this.ResizeBicubic.Click += new System.EventHandler(this.ResizeBicubic_Click);
            // 
            // BilinearResize
            // 
            this.BilinearResize.Location = new System.Drawing.Point(936, 278);
            this.BilinearResize.Name = "BilinearResize";
            this.BilinearResize.Size = new System.Drawing.Size(93, 45);
            this.BilinearResize.TabIndex = 111;
            this.BilinearResize.Text = "Bilinear Resize";
            this.BilinearResize.UseVisualStyleBackColor = true;
            this.BilinearResize.Click += new System.EventHandler(this.BilinearResize_Click);
            // 
            // NearestNeighbourResize
            // 
            this.NearestNeighbourResize.Location = new System.Drawing.Point(937, 329);
            this.NearestNeighbourResize.Name = "NearestNeighbourResize";
            this.NearestNeighbourResize.Size = new System.Drawing.Size(93, 54);
            this.NearestNeighbourResize.TabIndex = 112;
            this.NearestNeighbourResize.Text = "Nearest Neighbour Resize";
            this.NearestNeighbourResize.UseVisualStyleBackColor = true;
            this.NearestNeighbourResize.Click += new System.EventHandler(this.NearestNeighbourResize_Click);
            // 
            // RotateBicubic
            // 
            this.RotateBicubic.Location = new System.Drawing.Point(937, 389);
            this.RotateBicubic.Name = "RotateBicubic";
            this.RotateBicubic.Size = new System.Drawing.Size(93, 45);
            this.RotateBicubic.TabIndex = 113;
            this.RotateBicubic.Text = "Rotate Bicubic";
            this.RotateBicubic.UseVisualStyleBackColor = true;
            this.RotateBicubic.Click += new System.EventHandler(this.RotateBicubic_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(781, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 45);
            this.label2.TabIndex = 114;
            this.label2.Text = "Developer:- Abhisek Hazra, GNU LGPL License\r\nSupport E-mail:- opensource@abhisek-" +
    "hazra.in\r\nLibrary :- AForge.NET(http://www.aforgenet.com)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1041, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RotateBicubic);
            this.Controls.Add(this.NearestNeighbourResize);
            this.Controls.Add(this.BilinearResize);
            this.Controls.Add(this.ResizeBicubic);
            this.Controls.Add(this.SISThreshold);
            this.Controls.Add(this.SaturationDecrement);
            this.Controls.Add(this.SaturationIncrement);
            this.Controls.Add(this.MirrorFilter);
            this.Controls.Add(this.MedianFilter);
            this.Controls.Add(this.JarvisJudisNinkeDithering);
            this.Controls.Add(this.SusanCornerDetection);
            this.Controls.Add(this.ConservativeSmoothing);
            this.Controls.Add(this.ChannelFiltering);
            this.Controls.Add(this.ExtractNormalized);
            this.Controls.Add(this.SimpleSkeleton);
            this.Controls.Add(this.StuckiDithering);
            this.Controls.Add(this.YCbCrLinear);
            this.Controls.Add(this.TransformFromPolar);
            this.Controls.Add(this.TransformToPolar);
            this.Controls.Add(this.YCbCrExtract);
            this.Controls.Add(this.YCbCrColor);
            this.Controls.Add(this.HSLFilter);
            this.Controls.Add(this.WaterWave);
            this.Controls.Add(this.MeanFilter);
            this.Controls.Add(this.BayerFilter);
            this.Controls.Add(this.CanvasCrop);
            this.Controls.Add(this.BilateralSmoothing);
            this.Controls.Add(this.AdditiveNoise);
            this.Controls.Add(this.OpenImage);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Enhancer 1.0.0 Release Candidate";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicImageSecond)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PicImageSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button OpenImage;
        private System.Windows.Forms.Button AdditiveNoise;
        private System.Windows.Forms.Button BilateralSmoothing;
        private System.Windows.Forms.Button CanvasCrop;
        private System.Windows.Forms.Button BayerFilter;
        private System.Windows.Forms.Button MeanFilter;
        private System.Windows.Forms.Button WaterWave;
        private System.Windows.Forms.Button HSLFilter;
        private System.Windows.Forms.Button YCbCrColor;
        private System.Windows.Forms.Button YCbCrExtract;
        private System.Windows.Forms.Button TransformToPolar;
        private System.Windows.Forms.Button TransformFromPolar;
        private System.Windows.Forms.Button YCbCrLinear;
        private System.Windows.Forms.Button StuckiDithering;
        private System.Windows.Forms.Button SimpleSkeleton;
        private System.Windows.Forms.Button ExtractNormalized;
        private System.Windows.Forms.Button ChannelFiltering;
        private System.Windows.Forms.Button ConservativeSmoothing;
        private System.Windows.Forms.Button SusanCornerDetection;
        private System.Windows.Forms.Button JarvisJudisNinkeDithering;
        private System.Windows.Forms.Button MedianFilter;
        private System.Windows.Forms.Button MirrorFilter;
        private System.Windows.Forms.Button SaturationIncrement;
        private System.Windows.Forms.Button SaturationDecrement;
        private System.Windows.Forms.Button SISThreshold;
        private System.Windows.Forms.Button ResizeBicubic;
        private System.Windows.Forms.Button BilinearResize;
        private System.Windows.Forms.Button NearestNeighbourResize;
        private System.Windows.Forms.Button RotateBicubic;
        private System.Windows.Forms.Label label2;
    }
}