using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmPlanetTravels : Form
    {
        public frmPlanetTravels()
        {
            InitializeComponent();
            // Creates List of all controls to loop through for specific ones.
            var cList = new List<Control>();
            foreach (Control ctrl in Controls)
                cList.Add(ctrl);
            
            // Loops through List for controls starting with "lblz" and makes
            // them invisible.
            foreach (Control ctrl in cList)
            {
                // Checks if control is label and name includes unique identifier, "lblz."
                if (ctrl is Label && ctrl.Name.Contains("lblz"))
                {
                    // Taken from: http://stackoverflow.com/questions/9387267/transparent-control-over-picturebox
                    var pos = this.PointToScreen(ctrl.Location);
                    pos = pictureBox4.PointToClient(pos);
                    ctrl.Parent = pictureBox4;
                    ctrl.Location = pos;
                    ctrl.BackColor = Color.Transparent;
                }
            }
        }
        
        private void picClick(object sender, EventArgs e)
        {   // Click event for selecting a destination planet.

            // Clears activities list and displays info label.
            clbActivities.Items.Clear();
            lblInfoDisplay.Visible = true;
            string description = "";
            // Checks if a specific label was clicked and populates specific information
            // about the planet selected.
            if (sender == lblzVenus)
            {
                description = "Venus is a small and hot planet. It’s the second planet from the sun (between Earth and Mercury). It Orbits the Sun in 224.5 of our Earth days. Venus is named after the Roman Goddess of love and fertility – great honeymoon spot! On Earth – Venus is the second brightest object in the sky after the Earth moon. Venus itself does not have a moon however. The surface of Venus is almost entirely formed by volcanic activity. The plant offers volcano baths, tanning and hover board heat wave surfing as it’s tourist activities.";
                destinationSelect(description, "Volcano Bath", "Tanning", "Hoverboard Heatwave Surfing", "Volcano", "Venus");
            }
            else if(sender == lblzSaturn)
            {
                description = "Saturn is a colder planet. It’s the 6th planet from the sun and rotates the sun every 10,759 Earth days (or about 29 1⁄2 years). Saturn is made up entirely of gas (hydrogen and helium) but may possibly have a solid core. The planet is surrounded by countless rings of frozen ice that provide it with the tourist’s attractions of ice skating and ice ring toss. Saturn also has over 60 moons and is named after the Roman God of agriculture.";
                destinationSelect(description, "Ice skating rings", "Ring Toss", "Yeti Limbo", "Frostbite", "Saturn");
            }
            else if(sender == lblzJupiter)
            {
                description = "Jupiter is by far the largest planet in the solar system – it’s 2.5 times larger than all the other planets combined. Its incredible mass gives it really dense gravity which is great for training. Jupiter is 5th from the sun. The planet’s atmosphere is incredibly hostile to life and features a Great Red Spot which is an anticyclone storm larger than Earth. There is plenty of storms to chase on the surface and colored objects can be shot from space to change the Great Red Spot to other colors.";
                destinationSelect(description, "Storm Chasing", "'Great Red Spot' Shooting Gallery", "High Gravity Crossfit", "Gravity Crushing", "Jupiter");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {   // Closes application.
            this.Close();
        }

        private void Planets_MouseOver(object sender, EventArgs e)
        {   // MouseOver event that displays the name of the planet as user mouses over.

            // Creates string variable with the name of the sender (selected label).
            string lblName = ((Label)sender).Name;
            // Removes "lblz" from string and adds to label.
            lblzPlanetName.Text = lblName.Remove(0,4);
        }

        private void btnPlanTrip_Click(object sender, EventArgs e)
        {

        }

        private void destinationSelect(string description, string item1, string item2, string item3, string insurance, string vname)
        {   // This function populates certain labels and listbox data based on received parameters.
            lblInfoDisplay.Text = description;
            cboxInsurance.Text = insurance + " Insurance?";
            clbActivities.Items.Add(item1);
            clbActivities.Items.Add(item2);
            clbActivities.Items.Add(item3);
            lblActivities.Text = "Things to do on " + vname;
        }
    }
}
