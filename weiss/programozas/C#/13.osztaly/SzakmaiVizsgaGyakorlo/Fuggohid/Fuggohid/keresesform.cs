using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuggohid
{
    public partial class Keresés : Form
    {
        List<Fuggohid> adatok = new List<Fuggohid>();
        public Keresés(List<Fuggohid> lista)
        {
            InitializeComponent();

            foreach (Fuggohid adat in lista)
            {
                adatok.Add(adat);
            }

            HashSet<string> orszagok = new HashSet<string>();

            for (int i = 0; i < adatok.Count; i++)
            {
                orszagok.Add(adatok[i].orszag);
            }

            foreach (var orszag in orszagok)
            {
                orszagCB.Items.Add(orszag);
            }
        }

        private void bezarasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void keresesBtn_Click(object sender, EventArgs e)
        {
            hidakNevLb.Items.Clear();

            if(orszagCB.Text != "")
            {
                if (egykmHCKB.Checked)
                {
                    for (int i = 0; i < adatok.Count; i++)
                    {
                        if (adatok[i].hossz > 1000 && adatok[i].orszag == orszagCB.Text)
                        {
                            hidakNevLb.Items.Add(adatok[i].nev);
                        }

                    }
                }
                else
                {
                    for (int i = 0; i < adatok.Count; i++)
                    {
                        if (adatok[i].orszag == orszagCB.Text)
                        {
                            hidakNevLb.Items.Add(adatok[i].nev);
                        }

                    }
                }
            }
            else
            {
                if (egykmHCKB.Checked)
                {
                    for (int i = 0; i < adatok.Count; i++)
                    {
                        if(adatok[i].hossz > 1000)
                        {
                            hidakNevLb.Items.Add(adatok[i].nev);
                        }
                        
                    }
                }
                else
                {
                    for (int i = 0; i < adatok.Count; i++)
                    {
                        hidakNevLb.Items.Add(adatok[i].nev);
                    }
                }
            }
        }
    }
}
