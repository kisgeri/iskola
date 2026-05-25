using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuggohidak
{
    public partial class Keresés : Form
    {
        static List<Fuggohid> adatok = new List<Fuggohid>();
        static HashSet<string> orszagok = new HashSet<string>();
        public Keresés( List<Fuggohid> hidak)
        {
            InitializeComponent();

            foreach (var adat in hidak)
            {
                orszagok.Add(adat.orszag);
                adatok.Add(adat);
            }

            foreach (var orszag in orszagok)
            {
                orszagcB.Items.Add(orszag);
            }

        }

        private void hidaklb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bezarasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kerseBtn_Click(object sender, EventArgs e)
        {
            kereseslb.Items.Clear();

            if (orszagcB.Text != "")
            {
                if (egykmnelhosszabb.Checked)
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {
                        if (adatok[i].orszag == orszagcB.Text && adatok[i].hossz > 1000)
                        {
                            kereseslb.Items.Add(adatok[i].nev);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {
                        if (adatok[i].orszag == orszagcB.Text)
                        {
                            kereseslb.Items.Add(adatok[i].nev);
                        }
                    }
                }
            }
            else
            {
                if (egykmnelhosszabb.Checked)
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {
                        if (adatok[i].hossz > 1000)
                        {
                            kereseslb.Items.Add(adatok[i].nev);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {

                        kereseslb.Items.Add(adatok[i].nev);

                    }
                }
            }
        }
        }
    }
