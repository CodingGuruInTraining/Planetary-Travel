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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var cList = new List<Control>();
            foreach (Control ctrl in Controls)
            {
                cList.Add(ctrl);
            }

            foreach (Control ctrl in cList)
            {
                if (ctrl is Label && ctrl.Name.Contains("lblz"))
                {
                    // http://stackoverflow.com/questions/9387267/transparent-control-over-picturebox
                    var pos = this.PointToScreen(ctrl.Location);
                    pos = pictureBox4.PointToClient(pos);
                    ctrl.Parent = pictureBox4;
                    ctrl.Location = pos;
                    ctrl.BackColor = System.Drawing.Color.Transparent;
                }
            }
        }
        
        private void rdoClick(object sender, EventArgs e)
        {

            clbActivities.Items.Clear();
            label1.Visible = true;
            string description = "";
            string insurance = "";
            if (sender == radioButton1 || sender == pictureBox1)
            {
                description = "";
                clbActivities.Items.Add("Volcano Bath");
                clbActivities.Items.Add("Tanning");
                clbActivities.Items.Add("Hoverboard Heatwave Surfing");
                insurance = "Volanco";
            }
            else if(sender == radioButton2 || sender == pictureBox2)
            {
                description = "";
                clbActivities.Items.Add("Ice skating rings");
                clbActivities.Items.Add("Ring Toss");
                clbActivities.Items.Add("Yeti Limbo");
                insurance = "Frostbite";
            }
            else if(sender == radioButton3 || sender == pictureBox3)
            {
                description = "";
                clbActivities.Items.Add("Storm Chasing");
                clbActivities.Items.Add("'Great Red Spot' Shooting Gallery");
                clbActivities.Items.Add("High Gravity Crossfit");
                insurance = "Gravity Crushing";
            }
            label1.Text = description;
            checkBox1.Text = insurance + " Insurance?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Planets_MouseOver(object sender, EventArgs e)
        {
            if (sender == lblzMercury)
            {
                lblzPlanetName.Text = "Mercury";
            }


        }
    }
}
