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
    public partial class names : Form
    {
        bool ismultiplayer=false;
        public names(bool l)
        {
            InitializeComponent();
            this.ismultiplayer = l;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            if (ismultiplayer)
            {
                Form1 f = new Form1(player1.Text,player2.Text);
                f.Show();
                this.Hide();
            }
            else
            {
                Form3 f = new Form3(name.Text);
                f.Show();
                this.Hide();
            }
        }

      

        private void names_Load(object sender, EventArgs e)
        {
            if (ismultiplayer)
            {
                label1.Visible = false;
                name.Visible = false;
            }
            else
            {
                player1.Visible = false;
                player2.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
