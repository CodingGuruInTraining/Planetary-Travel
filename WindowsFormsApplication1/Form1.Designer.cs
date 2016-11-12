namespace WindowsFormsApplication1
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.clbActivities = new System.Windows.Forms.CheckedListBox();
            this.cboxInsurance = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblInfoDisplay = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblzVenus = new System.Windows.Forms.Label();
            this.lblzEarth = new System.Windows.Forms.Label();
            this.lblzMars = new System.Windows.Forms.Label();
            this.lblzJupiter = new System.Windows.Forms.Label();
            this.lblzMercury = new System.Windows.Forms.Label();
            this.lblzUranus = new System.Windows.Forms.Label();
            this.lblzNeptune = new System.Windows.Forms.Label();
            this.lblzSaturn = new System.Windows.Forms.Label();
            this.lblzPlanetName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(53, 424);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.picClick);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(249, 424);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.picClick);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(426, 424);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(85, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.picClick);
            // 
            // clbActivities
            // 
            this.clbActivities.CheckOnClick = true;
            this.clbActivities.FormattingEnabled = true;
            this.clbActivities.Location = new System.Drawing.Point(53, 458);
            this.clbActivities.Name = "clbActivities";
            this.clbActivities.Size = new System.Drawing.Size(321, 94);
            this.clbActivities.TabIndex = 6;
            // 
            // checkBox1
            // 
            this.cboxInsurance.AutoSize = true;
            this.cboxInsurance.Location = new System.Drawing.Point(116, 581);
            this.cboxInsurance.Name = "checkBox1";
            this.cboxInsurance.Size = new System.Drawing.Size(79, 17);
            this.cboxInsurance.TabIndex = 7;
            this.cboxInsurance.Text = "Insurance?";
            this.cboxInsurance.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Plan My Trip!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(278, 598);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.lblInfoDisplay.Location = new System.Drawing.Point(392, 519);
            this.lblInfoDisplay.Name = "label1";
            this.lblInfoDisplay.Size = new System.Drawing.Size(162, 105);
            this.lblInfoDisplay.TabIndex = 10;
            this.lblInfoDisplay.Text = "label1";
            this.lblInfoDisplay.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.planets;
            this.pictureBox4.Location = new System.Drawing.Point(53, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(470, 297);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WindowsFormsApplication1.Properties.Resources.jupitermain;
            this.pictureBox3.Location = new System.Drawing.Point(411, 327);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 77);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.picClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication1.Properties.Resources.saturnmain;
            this.pictureBox2.Location = new System.Drawing.Point(234, 327);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.picClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication1.Properties.Resources.venusmain;
            this.pictureBox1.Location = new System.Drawing.Point(38, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.picClick);
            // 
            // lblzVenus
            // 
            this.lblzVenus.BackColor = System.Drawing.Color.Transparent;
            this.lblzVenus.Location = new System.Drawing.Point(106, 55);
            this.lblzVenus.Name = "lblzVenus";
            this.lblzVenus.Size = new System.Drawing.Size(77, 75);
            this.lblzVenus.TabIndex = 12;
            this.lblzVenus.Click += new System.EventHandler(this.picClick);
            this.lblzVenus.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzEarth
            // 
            this.lblzEarth.BackColor = System.Drawing.Color.Transparent;
            this.lblzEarth.Location = new System.Drawing.Point(196, 23);
            this.lblzEarth.Name = "lblzEarth";
            this.lblzEarth.Size = new System.Drawing.Size(77, 75);
            this.lblzEarth.TabIndex = 13;
            this.lblzEarth.Click += new System.EventHandler(this.picClick);
            this.lblzEarth.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzMars
            // 
            this.lblzMars.BackColor = System.Drawing.Color.Transparent;
            this.lblzMars.Location = new System.Drawing.Point(289, 23);
            this.lblzMars.Name = "lblzMars";
            this.lblzMars.Size = new System.Drawing.Size(77, 75);
            this.lblzMars.TabIndex = 14;
            this.lblzMars.Click += new System.EventHandler(this.picClick);
            this.lblzMars.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzJupiter
            // 
            this.lblzJupiter.BackColor = System.Drawing.Color.Transparent;
            this.lblzJupiter.Location = new System.Drawing.Point(377, 63);
            this.lblzJupiter.Name = "lblzJupiter";
            this.lblzJupiter.Size = new System.Drawing.Size(77, 75);
            this.lblzJupiter.TabIndex = 15;
            this.lblzJupiter.Click += new System.EventHandler(this.picClick);
            this.lblzJupiter.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzMercury
            // 
            this.lblzMercury.BackColor = System.Drawing.Color.Transparent;
            this.lblzMercury.Location = new System.Drawing.Point(79, 151);
            this.lblzMercury.Name = "lblzMercury";
            this.lblzMercury.Size = new System.Drawing.Size(77, 75);
            this.lblzMercury.TabIndex = 16;
            this.lblzMercury.Click += new System.EventHandler(this.picClick);
            this.lblzMercury.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzUranus
            // 
            this.lblzUranus.BackColor = System.Drawing.Color.Transparent;
            this.lblzUranus.Location = new System.Drawing.Point(168, 200);
            this.lblzUranus.Name = "lblzUranus";
            this.lblzUranus.Size = new System.Drawing.Size(77, 75);
            this.lblzUranus.TabIndex = 17;
            this.lblzUranus.Click += new System.EventHandler(this.picClick);
            this.lblzUranus.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzNeptune
            // 
            this.lblzNeptune.BackColor = System.Drawing.Color.Transparent;
            this.lblzNeptune.Location = new System.Drawing.Point(282, 216);
            this.lblzNeptune.Name = "lblzNeptune";
            this.lblzNeptune.Size = new System.Drawing.Size(77, 75);
            this.lblzNeptune.TabIndex = 18;
            this.lblzNeptune.Click += new System.EventHandler(this.picClick);
            this.lblzNeptune.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzSaturn
            // 
            this.lblzSaturn.BackColor = System.Drawing.Color.Transparent;
            this.lblzSaturn.Location = new System.Drawing.Point(377, 169);
            this.lblzSaturn.Name = "lblzSaturn";
            this.lblzSaturn.Size = new System.Drawing.Size(77, 75);
            this.lblzSaturn.TabIndex = 19;
            this.lblzSaturn.Click += new System.EventHandler(this.picClick);
            this.lblzSaturn.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzPlanetName
            // 
            this.lblzPlanetName.BackColor = System.Drawing.Color.Transparent;
            this.lblzPlanetName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblzPlanetName.ForeColor = System.Drawing.Color.Aqua;
            this.lblzPlanetName.Location = new System.Drawing.Point(228, 129);
            this.lblzPlanetName.Name = "lblzPlanetName";
            this.lblzPlanetName.Size = new System.Drawing.Size(100, 50);
            this.lblzPlanetName.TabIndex = 20;
            this.lblzPlanetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(617, 633);
            this.Controls.Add(this.lblzPlanetName);
            this.Controls.Add(this.lblzSaturn);
            this.Controls.Add(this.lblzNeptune);
            this.Controls.Add(this.lblzUranus);
            this.Controls.Add(this.lblzMercury);
            this.Controls.Add(this.lblzJupiter);
            this.Controls.Add(this.lblzMars);
            this.Controls.Add(this.lblzEarth);
            this.Controls.Add(this.lblzVenus);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblInfoDisplay);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboxInsurance);
            this.Controls.Add(this.clbActivities);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form1";
            this.Text = "Intergalatic Travels";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckedListBox clbActivities;
        private System.Windows.Forms.CheckBox cboxInsurance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblInfoDisplay;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblzVenus;
        private System.Windows.Forms.Label lblzEarth;
        private System.Windows.Forms.Label lblzMars;
        private System.Windows.Forms.Label lblzJupiter;
        private System.Windows.Forms.Label lblzMercury;
        private System.Windows.Forms.Label lblzUranus;
        private System.Windows.Forms.Label lblzNeptune;
        private System.Windows.Forms.Label lblzSaturn;
        private System.Windows.Forms.Label lblzPlanetName;
    }
}

