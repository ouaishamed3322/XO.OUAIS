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
   
    public partial class Form1 : Form
    {   string play1;
        string play2;
        Button[,] btns = new Button[3, 3];
        bool[,] click = new bool[3, 3];
        int p1 = 0;
        int p2 = 0;
        int d = 0;
        enum GameType { x,o};
        GameType currentGame=GameType.x;
        int count = 0;

        public object isWIn { get; private set; }

        public Form1(string play1,string play2)
        {
            InitializeComponent();
            btns[0, 0] = b1;
            btns[0, 1] = b2;
            btns[0, 2] = b3;
            btns[1, 0] = b4;
            btns[1, 1] = b5;
            btns[1, 2] = b6;
            btns[2, 0] = b7;
            btns[2, 1] = b8;
            btns[2, 2] = b9;

            this.play1 = play1;
            this.play2 = play2;
            clearAll();
        }

        private void clearAll()
        {
            foreach (Button b in btns)
            { b.Text = "";
                b.Enabled = true;
            }
           
            count = 0;
            currentGame = GameType.x;
        }

        private void b5_Click(object sender, EventArgs e)
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameplayer1.Text = play1;
            nameplayer2.Text = play2;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;
            if (btn.Enabled==true)
            {
                btn.Text = currentGame.ToString();
                count++;
                btn.Enabled = false;
                if(isWin())
                {
                 

                    if (currentGame == GameType.x)
                    {
                        p1++;
                        player1.Text = p1.ToString();
                        MessageBox.Show("نقطة ل "+play1);
                    }
                    else
                    {
                        p2++;
                        player2.Text = p2.ToString();
                        MessageBox.Show("نقطة ل " + play2);
                    }
                    clearAll();
                    return;
                }
                if (count == 9)
                {
                    MessageBox.Show("تعادل");
                    d++;
                    draw.Text = d.ToString();
                    clearAll();
                }
                switchGame();
            }
        }
        private void restart()
        {
            p1 = 0;
            p2 = 0;
            d = 0;
            player1.Text = p1.ToString();
            player2.Text = p2.ToString();
            draw.Text = d.ToString();

        }
        private bool isWin()
        {
            for (int i = 0; i <= 2; i++)
            {
                int sameGame = 0;
                for (int j = 0; j <= 2; j++)
                {
                    if (btns[i, j].Text == currentGame.ToString())
                        sameGame++;  
                }
                if (sameGame == 3)
                    return true;
            }
            for (int i = 0; i <= 2; i++)
            {
                int sameGame = 0;
                for (int j = 0; j <= 2; j++)
                {
                    if (btns[j, i].Text == currentGame.ToString())
                        sameGame++;
                }
                if (sameGame == 3)
                    return true;
            }
            if (btns[0, 0].Text == currentGame.ToString() &&
               btns[1, 1].Text == currentGame.ToString() &&
               btns[2, 2].Text == currentGame.ToString())
                return true;
            if (btns[0, 2].Text == currentGame.ToString() &&
               btns[1, 1].Text == currentGame.ToString() &&
               btns[2, 0].Text == currentGame.ToString())
                return true;
            return false;

        }
        private void switchGame()
        {
            if (currentGame == GameType.x)
                currentGame = GameType.o;
            else
                currentGame = GameType.x;
        }

    

        private void btn_hover(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Enabled == true)
            {

               b.Text = currentGame.ToString();
            }
            else
                return;
        }

        private void btn_leave(object sender, EventArgs e)
        {
            Button b = sender as Button;
            if (b.Enabled == true)
                b.Text = "";
            else
                return;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clearAll();
          
        }

        private void kill_Click(object sender, EventArgs e)
        {
            restart();

        }

        private void back_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Close();
        }

        private void player2_Click(object sender, EventArgs e)
        {

        }

        private void draw_Click(object sender, EventArgs e)
        {

        }
    }
}
