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
    public partial class Form3 : Form
    {
        string name;
          public Form3(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        public Form3(string palyer1,string player2)
        {
            InitializeComponent();
         
        }

      
        enum gameType { x,o}
        gameType currentGame = gameType.x;
        string x = "x";
        string o = "O";
        int p = 0;
        int c = 0;
        int d = 0;
        public void Write_O()
        {
            Random random = new Random();

            bool flag = true;

            do
            {
                int random_Buttom = random.Next(1, 9);

                if(b1.Text=="x"&&b2.Text=="x"&&b3.Enabled==true)
                {
                    b3.Text = o;
                    b3.Enabled = false;
                    currentGame = gameType.x;
                    flag = false;
                    check();
                }
                else

                if (b9.Text == "x" && b8.Text == "x" && b7.Enabled == true)
                {
                    b7.Text = o;
                    b7.Enabled = false;
                    currentGame = gameType.x;
                    flag = false;
                    check();
                }
                else

                if (b6.Text == "x" && b5.Text == "x" && b4.Enabled == true)
                {
                    b4.Text = o;
                    b4.Enabled = false;
                    currentGame = gameType.x;
                    flag = false;
                    check();
                }
                else

                if (b3.Text == "x" && b2.Text == "x" && b1.Enabled == true)
                {
                    b1.Text = o;
                    b1.Enabled = false;
                    currentGame = gameType.x;
                    flag = false;
                    check();
                }
                else
                  if (b4.Text == "x" && b5.Text == "x" && b6.Enabled == true)
                {
                    b6.Text = o;
                    b6.Enabled = false;
                    flag = false;
                    currentGame = gameType.x;
                    check();
                }
                else
                  if (b7.Text == "x" && b8.Text == "x" && b9.Enabled == true)
                {
                    b9.Text = o;
                    flag = false;
                    b9.Enabled = false;
                    currentGame = gameType.x;
                    check();
                }
                else
                  if (b1.Text == "x" && b2.Enabled ==true  && b3.Text=="x")
                {
                    b2.Text = o;
                    flag = false;
                    b2.Enabled = false;
                    currentGame = gameType.x;
                    check();
                }
                else
                    if (b4.Text == "x" && b5.Enabled == true && b6.Text == "x")
                {
                    flag = false;
                    b5.Text = o;
                    b5.Enabled = false;
                    currentGame = gameType.x;
                    check();
                }
                else
                    if (b7.Text == "x" && b8.Enabled == true && b9.Text == "x")
                {
                    flag = false;
                    b8.Text = o;
                    b8.Enabled = false;
                    currentGame = gameType.x;
                    check();
                }
                else
                  if (b3.Text == "x" && b2.Text == "x" && b1.Enabled == true)
                {
                    flag = false;
                    b1.Text = o;
                    b1.Enabled = false;
                    currentGame = gameType.x;
                    check();
                }
             
                else
                if (random_Buttom == 1 && b1.Enabled == true)
                {
                 
                    b1.Text = "O";
                    currentGame = gameType.x;
                    flag = false;
                    b1.Enabled = false;
                    check();
                }
                else
                    if (random_Buttom == 2 && b2.Enabled == true)
                {
                    b2.Text = "O";
                    currentGame = gameType.x;
                    flag = false;
                    b2.Enabled = false;
                    check();
                }
                else
                        if (random_Buttom == 3 && b3.Enabled == true)
                {

                    b3.Text = "O";
                    currentGame = gameType.x;
                    flag = false;
                    b3.Enabled = false;
                    check();
                }
                else
                            if (random_Buttom == 4 && b4.Enabled == true)
                {

                    b4.Text = "O";
                    currentGame = gameType.x;
                    b4.Enabled = false;
                    flag = false;
                    b4.Enabled = false;
                    check();
                }
                else
                                if (random_Buttom == 5 && b5.Enabled == true)
                {
                    b5.Enabled = false;
                    currentGame = gameType.x;
                    b5.Text = "O";
                    flag = false;
                    b5.Enabled = false;
                    check();
                }
                else
                                    if (random_Buttom == 6 && b6.Enabled == true)
                {
                    b6.Enabled = false;
                    currentGame = gameType.x;
                    b6.Text = "O";
                    flag = false;
                    b6.Enabled = false;
                    check();
                }
                else
                      if (random_Buttom == 7 && b7.Enabled == true)
                {
                    b7.Enabled = false;
                    currentGame = gameType.x;
                    b7.Text = "O";

                    flag = false;
                    b7.Enabled = false;
                    check();
                }
                else
                    if (random_Buttom == 8 && b8.Enabled == true)
                {
                    b8.Enabled = false;
                    currentGame = gameType.x;
                    b8.Text = "O";

                    flag = false;
                    b8.Enabled = false;
                    check();
                }
                else
                   if (random_Buttom == 9 && b9.Enabled == true)
                {
                    b9.Enabled = false;
                    currentGame = gameType.x;
                    b9.Text = "O";

                    flag = false;
                    b9.Enabled = false;
                    check();
                }


            } while (flag);

            } 
        

        public void rest()
        {
            b1.Text = "";
            b2.Text = "";
            b3.Text = "";
            b4.Text = "";
            b5.Text = "";
            b6.Text = "";
            b7.Text = "";
            b8.Text = "";
            b9.Text = "";
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
            

        }

        public void check()
        {
      
            if ((b1.Text == x && b2.Text == x && b3.Text == x) ||
            (b1.Text == x && b4.Text == x && b7.Text == x) ||
            (b2.Text == x && b5.Text == x && b8.Text == x) ||
            (b3.Text == x && b6.Text == x && b9.Text == x) ||
            (b1.Text == x && b5.Text == x && b9.Text == x) ||
            (b3.Text == x && b5.Text == x && b7.Text == x) ||
            (  b4.Text == x && b5.Text == x && b6.Text == x) ||
             ( b7.Text == x && b8.Text == x && b9.Text == x)
              )
            {
                p++;
                player.Text = p.ToString();
                MessageBox.Show("نقطة ل "+ name);
                rest();

            }
            else
                if (
                (b1.Text == o && b2.Text == o && b3.Text == o) ||
                (b4.Text == o && b5.Text == o && b6.Text == o) ||
                (b1.Text == o && b4.Text == o && b7.Text == o) ||
                (b2.Text == o && b5.Text == o && b8.Text == o) ||
                 (b3.Text == o && b6.Text == o && b9.Text == o) ||
                  (b1.Text == o && b5.Text == o && b9.Text == o) ||
                  (b3.Text == o && b6.Text == o && b9.Text == o) ||
                  (b3.Text == o && b5.Text == o && b7.Text == o) ||
                (  b7.Text == o && b8.Text == o && b9.Text == o)
              )
            {
                c++;
                computer.Text = c.ToString();
                MessageBox.Show("نقطة للكمبيوتر");
                rest();
            }
            else
            {
                if (b1.Enabled==false &&
                    b2.Enabled == false &&
                   b3.Enabled == false &&
                    b4.Enabled == false &&
                    b5.Enabled == false &&
                   b6.Enabled == false &&
                  b7.Enabled == false &&
                  b8.Enabled == false &&
                  b9.Enabled == false )
                {
                    d++;
                    draw.Text = d.ToString();
                    MessageBox.Show("تعادل");
                    rest();
                }

            }

        }


        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = name;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            b.Text = "x";
            b.Enabled = false;
            currentGame = gameType.o;
            check();
            Write_O();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }
    }
}
