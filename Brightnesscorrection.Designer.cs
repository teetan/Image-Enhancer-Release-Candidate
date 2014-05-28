namespace Accord_Test
{
    partial class Brightnesscorrection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Brightnesscorrection));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select Brightness Correction Value";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-255",
            "-250",
            "-245",
            "-240",
            "-235",
            "-230",
            "-225",
            "-220",
            "-215",
            "-210",
            "-205",
            "-200",
            "-195",
            "-190",
            "-185",
            "-180",
            "-175",
            "-170",
            "-165",
            "-160",
            "-155",
            "-150",
            "-145",
            "-140",
            "-135",
            "-130",
            "-125",
            "-120",
            "-115",
            "-110",
            "-105",
            "-100",
            "-95",
            "-90",
            "-85",
            "-80",
            "-75",
            "-70",
            "-65",
            "-60",
            "-55",
            "-50",
            "-45",
            "-40",
            "-35",
            "-30",
            "-25",
            "-20",
            "-15",
            "-10",
            "-5",
            "0",
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60",
            "65",
            "70",
            "75",
            "80",
            "85",
            "90",
            "95",
            "100",
            "105",
            "110",
            "115",
            "120",
            "125",
            "130",
            "135",
            "140",
            "145",
            "150",
            "155",
            "160",
            "165",
            "170",
            "175",
            "180",
            "185",
            "190",
            "195",
            "200",
            "205",
            "210",
            "215",
            "220",
            "225",
            "230",
            "235",
            "240",
            "245",
            "250",
            "255                                                                              " +
                ""});
            this.comboBox1.Location = new System.Drawing.Point(91, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(105, 74);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(60, 26);
            this.OkButton.TabIndex = 5;
            this.OkButton.Text = "&Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // Brightnesscorrection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(270, 110);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Brightnesscorrection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Brightness  Correction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button OkButton;
    }
}