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
            this.picboxPlanets = new System.Windows.Forms.PictureBox();
            this.lblzVenus = new System.Windows.Forms.Label();
            this.lblzEarth = new System.Windows.Forms.Label();
            this.lblzMars = new System.Windows.Forms.Label();
            this.lblzJupiter = new System.Windows.Forms.Label();
            this.lblzMercury = new System.Windows.Forms.Label();
            this.lblzUranus = new System.Windows.Forms.Label();
            this.lblzNeptune = new System.Windows.Forms.Label();
            this.lblzSaturn = new System.Windows.Forms.Label();
            this.lblzPlanetName = new System.Windows.Forms.Label();
            this.lblActivities = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlanets)).BeginInit();
            this.SuspendLayout();
            // 
            // clbActivities
            // 
            this.clbActivities.CheckOnClick = true;
            this.clbActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbActivities.FormattingEnabled = true;
            this.clbActivities.Location = new System.Drawing.Point(12, 344);
            this.clbActivities.Name = "clbActivities";
            this.clbActivities.Size = new System.Drawing.Size(321, 89);
            this.clbActivities.TabIndex = 6;
            // 
            // cboxInsurance
            // 
            this.cboxInsurance.AutoSize = true;
            this.cboxInsurance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxInsurance.Location = new System.Drawing.Point(40, 439);
            this.cboxInsurance.Name = "cboxInsurance";
            this.cboxInsurance.Size = new System.Drawing.Size(92, 20);
            this.cboxInsurance.TabIndex = 7;
            this.cboxInsurance.Text = "Insurance?";
            this.cboxInsurance.UseVisualStyleBackColor = true;
            // 
            // btnPlanTrip
            // 
            this.btnPlanTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlanTrip.Location = new System.Drawing.Point(192, 591);
            this.btnPlanTrip.Name = "btnPlanTrip";
            this.btnPlanTrip.Size = new System.Drawing.Size(125, 28);
            this.btnPlanTrip.TabIndex = 8;
            this.btnPlanTrip.Text = "Plan My Trip!";
            this.btnPlanTrip.UseVisualStyleBackColor = true;
            this.btnPlanTrip.Click += new System.EventHandler(this.btnPlanTrip_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(341, 591);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 28);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // lblInfoDisplay
            // 
            this.lblInfoDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDisplay.Location = new System.Drawing.Point(368, 320);
            this.lblInfoDisplay.Name = "lblInfoDisplay";
            this.lblInfoDisplay.Size = new System.Drawing.Size(218, 220);
            this.lblInfoDisplay.TabIndex = 10;
            this.lblInfoDisplay.Visible = false;
            // 
            // picboxPlanets
            // 
            this.picboxPlanets.Image = global::WindowsFormsApplication1.Properties.Resources.planets;
            this.picboxPlanets.Location = new System.Drawing.Point(73, 12);
            this.picboxPlanets.Name = "picboxPlanets";
            this.picboxPlanets.Size = new System.Drawing.Size(470, 297);
            this.picboxPlanets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxPlanets.TabIndex = 11;
            this.picboxPlanets.TabStop = false;
            this.picboxPlanets.MouseLeave += new System.EventHandler(this.ClearMouseMove);
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
            // lblActivities
            // 
            this.lblActivities.BackColor = System.Drawing.SystemColors.Control;
            this.lblActivities.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActivities.Location = new System.Drawing.Point(26, 318);
            this.lblActivities.Name = "lblActivities";
            this.lblActivities.Size = new System.Drawing.Size(205, 23);
            this.lblActivities.TabIndex = 21;
            // 
            // dateStart
            // 
            this.dateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Location = new System.Drawing.Point(102, 482);
            this.dateStart.MinDate = new System.DateTime(2016, 11, 12, 0, 0, 0, 0);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(222, 22);
            this.dateStart.TabIndex = 22;
            // 
            // dateEnd
            // 
            this.dateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnd.Location = new System.Drawing.Point(102, 521);
            this.dateEnd.MinDate = new System.DateTime(2016, 11, 12, 0, 0, 0, 0);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(222, 22);
            this.dateEnd.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Start Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 523);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "End Date:";
            // 
            // frmPlanetTravels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.Astronaut_Chilling_On_The_Moon_With_Beer_Wallpaper_1920x12001;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(617, 633);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblActivities);
            this.Controls.Add(this.lblzPlanetName);
            this.Controls.Add(this.lblzSaturn);
            this.Controls.Add(this.lblzNeptune);
            this.Controls.Add(this.lblzUranus);
            this.Controls.Add(this.lblzMercury);
            this.Controls.Add(this.lblzJupiter);
            this.Controls.Add(this.lblzMars);
            this.Controls.Add(this.lblzEarth);
            this.Controls.Add(this.lblzVenus);
            this.Controls.Add(this.picboxPlanets);
            this.Controls.Add(this.lblInfoDisplay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPlanTrip);
            this.Controls.Add(this.cboxInsurance);
            this.Controls.Add(this.clbActivities);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPlanetTravels";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intergalactic Travels";
            ((System.ComponentModel.ISupportInitialize)(this.picboxPlanets)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox clbActivities;
        private System.Windows.Forms.CheckBox cboxInsurance;
        private System.Windows.Forms.Button btnPlanTrip;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblInfoDisplay;
        private System.Windows.Forms.PictureBox picboxPlanets;
        private System.Windows.Forms.Label lblzVenus;
        private System.Windows.Forms.Label lblzEarth;
        private System.Windows.Forms.Label lblzMars;
        private System.Windows.Forms.Label lblzJupiter;
        private System.Windows.Forms.Label lblzMercury;
        private System.Windows.Forms.Label lblzUranus;
        private System.Windows.Forms.Label lblzNeptune;
        private System.Windows.Forms.Label lblzSaturn;
        private System.Windows.Forms.Label lblzPlanetName;
        private System.Windows.Forms.Label lblActivities;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

