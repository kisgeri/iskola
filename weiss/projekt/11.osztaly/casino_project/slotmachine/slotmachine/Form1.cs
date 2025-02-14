using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace slotmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("1.png");
            pictureBox2.Image = Image.FromFile("2.png");
            pictureBox6.Image = Image.FromFile("3.png");

        }

        Random rnd = new Random();


        int szam1, szam2, szam3, move;

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Visible = false;
            label1.Visible = false;

        }//https://stackoverflow.com/questions/77984684/im-trying-to-have-a-picture-box-switch-between-4-images-to-simulate-a-spinning

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            move++;
            if(move<30)
            {
                szam1 = rnd.Next(1, 7);
                szam2 = rnd.Next(1, 7);
                szam3 = rnd.Next(1, 7);

                pictureBox1.Image = Image.FromFile(szam1.ToString() + ".png");
                pictureBox2.Image = Image.FromFile(szam2.ToString() + ".png");
                pictureBox6.Image = Image.FromFile(szam3.ToString() + ".png");
            }
            else
            {
                timer1.Enabled = false;
                move = 0;
                label1.Visible = true;
                if(szam1 == 1 && szam2 == 1 && szam3 == 1)
                {
                    label1.Text = "szilva";
                }
                else if (szam1 == 2 && szam2 == 2 && szam3 == 2)
                {
                    label1.Text = "narancs";
                }
                else if (szam1 == 3 && szam2 == 3 && szam3 == 3)
                {
                    label1.Text = "cseresznye";
                }
                else if (szam1 == 4 && szam2 == 4 && szam3 == 4)
                {
                    label1.Text = "csengő";
                }
                else if (szam1 == 5 && szam2 == 5 && szam3 == 5)
                {
                    label1.Text = "bar";
                }
                else if (szam1 == 6 && szam2 == 6 && szam3 == 6)
                {
                    label1.Text = "jackpot";
                }
                else
                { label1.Text = "nem nyertél :("; }

                button1.Visible = true;
            }

        }
        //https://www.youtube.com/watch?v=E9t3l10swkw&t=1149s
    }
}
