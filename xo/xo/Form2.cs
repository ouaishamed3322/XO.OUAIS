using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace xo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            pvc.Visible = false;
            pvp.Visible = false;
            rtm.Visible = false;
        }

        private void play_Click(object sender, EventArgs e)
        {
            play.Visible = false;
            exit.Visible = false;
            pvc.Visible = true;
            pvp.Visible = true;
            rtm.Visible = true;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rtm_Click(object sender, EventArgs e)
        {
            play.Visible = true;
            exit.Visible = true;
            pvc.Visible = false;
            pvp.Visible = false;
            rtm.Visible = false;
        }

        private void pvc_Click(object sender, EventArgs e)
        {
            this.Hide();
            names n = new names(false);
            n.Show();
        }

        private void pvp_Click(object sender, EventArgs e)
        {
            this.Hide();
            names n = new names(true);

            n.Show();

        }
    }
}
