using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Fuggohidak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<Fuggohid> adatok = new List<Fuggohid>();

        private void fájlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog()==DialogResult.OK)
            {
                StreamReader olvasocsatorna = new StreamReader(ofd.FileName);
                string sor = olvasocsatorna.ReadLine();

                while (!olvasocsatorna.EndOfStream)
                {
                    sor= olvasocsatorna.ReadLine();
                    Fuggohid adat = new Fuggohid(sor);
                    adatok.Add(adat);

                }

                foreach (var hidak in adatok)
                {
                    hidakLb.Items.Add(hidak.nev);
                }

            }


        }

        private void hidakLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            helytxt.Text = adatok[hidakLb.SelectedIndex].hely;
            orszagtxt.Text = adatok[hidakLb.SelectedIndex].orszag;
            hossztxt.Text = adatok[hidakLb.SelectedIndex].hossz.ToString();
            evtxt.Text = adatok[hidakLb.SelectedIndex].ev.ToString();

        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ketezerelot_CheckedChanged(object sender, EventArgs e)
        {
            if (ketezerelot.Checked)
            {
                int darab = 0;
                foreach (var adat in adatok)
                {
                    if (adat.ev < 2000)
                    {
                        darab++;
                    }
                }
                darabTxt.Text=darab.ToString();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                int darab = 0;
                foreach (var adat in adatok)
                {
                    if (adat.ev >= 2000)
                    {
                        darab++;
                    }
                }
                darabTxt.Text = darab.ToString();
            }
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Keresés kf = new Keresés(adatok);
            this.Hide();
            kf.ShowDialog();
            this.Show();
        }
    }
}
