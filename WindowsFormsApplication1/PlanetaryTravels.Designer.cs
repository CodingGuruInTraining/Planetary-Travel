namespace WindowsFormsApplication1
{
    partial class frmPlanetTravels
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
            this.clbActivities = new System.Windows.Forms.CheckedListBox();
            this.cboxInsurance = new System.Windows.Forms.CheckBox();
            this.btnPlanTrip = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblInfoDisplay = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
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
            this.SuspendLayout();
            // 
            // clbActivities
            // 
            this.clbActivities.CheckOnClick = true;
            this.clbActivities.FormattingEnabled = true;
            this.clbActivities.Location = new System.Drawing.Point(7, 457);
            this.clbActivities.Name = "clbActivities";
            this.clbActivities.Size = new System.Drawing.Size(321, 94);
            this.clbActivities.TabIndex = 6;
            // 
            // cboxInsurance
            // 
            this.cboxInsurance.AutoSize = true;
            this.cboxInsurance.Location = new System.Drawing.Point(116, 581);
            this.cboxInsurance.Name = "cboxInsurance";
            this.cboxInsurance.Size = new System.Drawing.Size(79, 17);
            this.cboxInsurance.TabIndex = 7;
            this.cboxInsurance.Text = "Insurance?";
            this.cboxInsurance.UseVisualStyleBackColor = true;
            // 
            // btnPlanTrip
            // 
            this.btnPlanTrip.Location = new System.Drawing.Point(148, 598);
            this.btnPlanTrip.Name = "btnPlanTrip";
            this.btnPlanTrip.Size = new System.Drawing.Size(97, 23);
            this.btnPlanTrip.TabIndex = 8;
            this.btnPlanTrip.Text = "Plan My Trip!";
            this.btnPlanTrip.UseVisualStyleBackColor = true;
            this.btnPlanTrip.Click += new System.EventHandler(this.btnPlanTrip_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(278, 598);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lblInfoDisplay
            // 
            this.lblInfoDisplay.Location = new System.Drawing.Point(392, 519);
            this.lblInfoDisplay.Name = "lblInfoDisplay";
            this.lblInfoDisplay.Size = new System.Drawing.Size(162, 105);
            this.lblInfoDisplay.TabIndex = 10;
            this.lblInfoDisplay.Text = "label1";
            this.lblInfoDisplay.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WindowsFormsApplication1.Properties.Resources.planets;
            this.pictureBox4.Location = new System.Drawing.Point(73, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(470, 297);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // lblzVenus
            // 
            this.lblzVenus.BackColor = System.Drawing.Color.Transparent;
            this.lblzVenus.Location = new System.Drawing.Point(126, 55);
            this.lblzVenus.Name = "lblzVenus";
            this.lblzVenus.Size = new System.Drawing.Size(77, 75);
            this.lblzVenus.TabIndex = 12;
            this.lblzVenus.Click += new System.EventHandler(this.picClick);
            this.lblzVenus.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzEarth
            // 
            this.lblzEarth.BackColor = System.Drawing.Color.Transparent;
            this.lblzEarth.Location = new System.Drawing.Point(216, 23);
            this.lblzEarth.Name = "lblzEarth";
            this.lblzEarth.Size = new System.Drawing.Size(77, 75);
            this.lblzEarth.TabIndex = 13;
            this.lblzEarth.Click += new System.EventHandler(this.picClick);
            this.lblzEarth.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzMars
            // 
            this.lblzMars.BackColor = System.Drawing.Color.Transparent;
            this.lblzMars.Location = new System.Drawing.Point(309, 23);
            this.lblzMars.Name = "lblzMars";
            this.lblzMars.Size = new System.Drawing.Size(77, 75);
            this.lblzMars.TabIndex = 14;
            this.lblzMars.Click += new System.EventHandler(this.picClick);
            this.lblzMars.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzJupiter
            // 
            this.lblzJupiter.BackColor = System.Drawing.Color.Transparent;
            this.lblzJupiter.Location = new System.Drawing.Point(397, 63);
            this.lblzJupiter.Name = "lblzJupiter";
            this.lblzJupiter.Size = new System.Drawing.Size(77, 75);
            this.lblzJupiter.TabIndex = 15;
            this.lblzJupiter.Click += new System.EventHandler(this.picClick);
            this.lblzJupiter.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzMercury
            // 
            this.lblzMercury.BackColor = System.Drawing.Color.Transparent;
            this.lblzMercury.Location = new System.Drawing.Point(99, 151);
            this.lblzMercury.Name = "lblzMercury";
            this.lblzMercury.Size = new System.Drawing.Size(77, 75);
            this.lblzMercury.TabIndex = 16;
            this.lblzMercury.Click += new System.EventHandler(this.picClick);
            this.lblzMercury.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzUranus
            // 
            this.lblzUranus.BackColor = System.Drawing.Color.Transparent;
            this.lblzUranus.Location = new System.Drawing.Point(188, 200);
            this.lblzUranus.Name = "lblzUranus";
            this.lblzUranus.Size = new System.Drawing.Size(77, 75);
            this.lblzUranus.TabIndex = 17;
            this.lblzUranus.Click += new System.EventHandler(this.picClick);
            this.lblzUranus.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzNeptune
            // 
            this.lblzNeptune.BackColor = System.Drawing.Color.Transparent;
            this.lblzNeptune.Location = new System.Drawing.Point(302, 216);
            this.lblzNeptune.Name = "lblzNeptune";
            this.lblzNeptune.Size = new System.Drawing.Size(77, 75);
            this.lblzNeptune.TabIndex = 18;
            this.lblzNeptune.Click += new System.EventHandler(this.picClick);
            this.lblzNeptune.MouseEnter += new System.EventHandler(this.Planets_MouseOver);
            // 
            // lblzSaturn
            // 
            this.lblzSaturn.BackColor = System.Drawing.Color.Transparent;
            this.lblzSaturn.Location = new System.Drawing.Point(397, 169);
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
            this.lblzPlanetName.Location = new System.Drawing.Point(248, 129);
            this.lblzPlanetName.Name = "lblzPlanetName";
            this.lblzPlanetName.Size = new System.Drawing.Size(100, 50);
            this.lblzPlanetName.TabIndex = 20;
            this.lblzPlanetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPlanetTravels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
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
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlanTrip);
            this.Controls.Add(this.cboxInsurance);
            this.Controls.Add(this.clbActivities);
            this.Name = "frmPlanetTravels";
            this.Text = "Intergalactic Travels";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbActivities;
        private System.Windows.Forms.CheckBox cboxInsurance;
        private System.Windows.Forms.Button btnPlanTrip;
        private System.Windows.Forms.Button btnCancel;
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

