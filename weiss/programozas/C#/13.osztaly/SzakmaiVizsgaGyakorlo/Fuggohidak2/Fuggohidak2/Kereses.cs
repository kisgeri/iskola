using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuggohidak2
{
    public partial class Kereses : Form
    {
        static List<Fuggohid> adatok = new List<Fuggohid>();

        public Kereses(List<Fuggohid> lista)
        {
            InitializeComponent();

            HashSet<string> orszagok = new HashSet<string>();

            foreach (var adat in lista)
            {
                adatok.Add(adat);
                orszagok.Add(adat.orszag);
            }

            foreach (var orszag in orszagok)
            {
                orszagokCb.Items.Add(orszag);
            }
        }

        private void kersesBtn_Click(object sender, EventArgs e)
        {
            hidnevLb.Items.Clear();

            if (orszagokCb.Text != "")
            {
                if (egykmnelhoszCkb.Checked)
                {
                    foreach (var adat in adatok)
                    {
                        if (adat.hossz>1000&&adat.orszag == orszagokCb.Text)
                        {
                            hidnevLb.Items.Add(adat.nev);
                        }
                    }
                }
                else
                {
                    foreach (var adat in adatok)
                    {
                        if (adat.orszag == orszagokCb.Text)
                        {
                            hidnevLb.Items.Add(adat.nev);
                        }
                    }
                }
            }
            else
            {
                if (egykmnelhoszCkb.Checked)
                {
                    foreach (var adat in adatok)
                    {
                        if (adat.hossz > 1000)
                        {
                            hidnevLb.Items.Add(adat.nev);
                        }
                    }
                }
                else
                {
                    foreach (var adat in adatok)
                    {

                        hidnevLb.Items.Add(adat.nev);
                        
                    }
                }
            }

        }

        private void bezarasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
