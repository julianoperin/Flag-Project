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

        private void picfinlandflag_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Finland";
        }

        private void picFranceflag_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "France";
        }

        private void picGermanyFlag_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "Germany";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblCountry.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblCountry.BackColor = Color.Yellow;
        }

        private void lblCountry_Click(object sender, EventArgs e)
        {

        }

        private void btnChangeLabelColortoDefault_Click(object sender, EventArgs e)
        {
            lblCountry.BackColor = DefaultBackColor;
        }

        private void ChangeFormColortoGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnChangeFormColortoDefault_Click(object sender, EventArgs e)
        {
            this.BackColor = DefaultBackColor;
        }

        private void btnHideFlags_Click(object sender, EventArgs e)
        {
            picfinlandflag.Visible = false;
            picFranceflag.Visible = false;
            picGermanyFlag.Visible = false;
        }

        private void btnShowFlags_Click(object sender, EventArgs e)
        {
            picfinlandflag.Visible = true;
            picFranceflag.Visible = true;
            picGermanyFlag.Visible = true;
        }
    }
}
