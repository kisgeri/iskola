using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rendeles_Click(object sender, EventArgs e)
        {
            string meret = "";
            string pluszfeltett = "";
            double ar = 0;

            if (kozepes.Checked)
            {
                meret = kozepes.Text;
                ar += 2000;
            }
            else
            {
                meret = csaladi.Text;
                ar += 2500;
            }

            if (kukorica.Checked)
            {
                pluszfeltett = pluszfeltett+kukorica.Text+",";
                ar += 250;
            }
            if (olivabogyo.Checked)
            {
                pluszfeltett = pluszfeltett + olivabogyo.Text + ",";
                ar += 250;
            }
            if (gomba.Checked)
            {
                pluszfeltett = pluszfeltett + gomba.Text + ",";
                ar += 250;
            }
            if (pepperoni.Checked)
            {
                pluszfeltett = pluszfeltett + pepperoni.Text + ",";
                ar += 250;
            }
            if (extrasajt.Checked)
            {
                pluszfeltett = pluszfeltett + extrasajt.Text + ",";
                ar += 250;
            }

            MessageBox.Show($"Ön egy {meret} pizzat rendelt\n extra feltétt: {pluszfeltett}\n Fizetendő összeg: {ar}Ft", "rendelés", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
