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
        }

        private void rdoClick(object sender, EventArgs e)
        {

            checkedListBox1.Items.Clear();
            label1.Visible = true;
            string description = "";
            string insurance = "";
            if (sender == radioButton1 || sender == pictureBox1)
            {
                description = "";
                checkedListBox1.Items.Add("Volcano Bath");
                checkedListBox1.Items.Add("Tanning");
                checkedListBox1.Items.Add("Hoverboard Heatwave Surfing");
                insurance = "Volanco";
            }
            else if(sender == radioButton2 || sender == pictureBox2)
            {
                description = "";
                checkedListBox1.Items.Add("Ice skating rings");
                checkedListBox1.Items.Add("Ring Toss");
                checkedListBox1.Items.Add("Yeti Limbo");
                insurance = "Frostbite";
            }
            else if(sender == radioButton3 || sender == pictureBox3)
            {
                description = "";
                checkedListBox1.Items.Add("Storm Chasing");
                checkedListBox1.Items.Add("'Great Red Spot' Shooting Gallery");
                checkedListBox1.Items.Add("High Gravity Crossfit");
                insurance = "Gravity Crushing";
            }
            label1.Text = description;
            checkBox1.Text = insurance + " Insurance?";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
