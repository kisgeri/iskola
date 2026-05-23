using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void redScrollBarred_Scroll(object sender, ScrollEventArgs e)
        {
            szinPnl.BackColor = Color.FromArgb(redHSb.Value,greenHSb.Value,blueHSb.Value);
            textBoxred.Text = redHSb.Value.ToString();
        }

        private void greenHSb_Scroll(object sender, ScrollEventArgs e)
        {
            szinPnl.BackColor = Color.FromArgb(redHSb.Value, greenHSb.Value, blueHSb.Value);
            textBoxgreen.Text = greenHSb.Value.ToString();
        }

        private void blueHSb_Scroll(object sender, ScrollEventArgs e)
        {
            szinPnl.BackColor = Color.FromArgb(redHSb.Value, greenHSb.Value, blueHSb.Value);
            textBoxblue.Text = blueHSb.Value.ToString();
        }

        private void textBoxred_TextChanged(object sender, EventArgs e)
        {
            if(!int.TryParse(textBoxred.Text, out int szam))
            {
                textBoxred.Text = "0";
            }
            else
            {

                if (int.Parse(textBoxred.Text) < 0)
                {
                    textBoxred.Text = "0";
                }

                if (int.Parse(textBoxred.Text) > 255)
                {
                    textBoxred.Text = "255";
                }
            }

            redHSb.Value = int.Parse(textBoxred.Text);

            szinPnl.BackColor = Color.FromArgb(redHSb.Value, greenHSb.Value, blueHSb.Value);
        }

        private void textBoxgreen_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxgreen.Text, out int szam))
            {
                textBoxgreen.Text = "0";
            }
            else
            {

                if (int.Parse(textBoxgreen.Text) < 0)
                {
                    textBoxgreen.Text = "0";
                }

                if (int.Parse(textBoxgreen.Text) > 255)
                {
                    textBoxgreen.Text = "255";
                }
            }

            greenHSb.Value = int.Parse(textBoxgreen.Text);

            szinPnl.BackColor = Color.FromArgb(redHSb.Value, greenHSb.Value, blueHSb.Value);
        }

        private void textBoxblue_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(textBoxblue.Text, out int szam))
            {
                textBoxblue.Text = "0";
            }
            else
            {

                if (int.Parse(textBoxblue.Text) < 0)
                {
                    textBoxblue.Text = "0";
                }

                if (int.Parse(textBoxblue.Text) > 255)
                {
                    textBoxblue.Text = "255";
                }
            }

            blueHSb.Value = int.Parse(textBoxblue.Text);

            szinPnl.BackColor = Color.FromArgb(redHSb.Value, greenHSb.Value, blueHSb.Value);
        }

        private void mutasdBtn_Click(object sender, EventArgs e)
        {
            kepPb.ImageLocation = utvonaltxt.Text;
        }
    }
}
