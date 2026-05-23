using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pars2012ora;

namespace Pars2012GUIora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string utvonal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Selejtezo2012");
        }

        static List<Versenyzo> adatok = new List<Versenyzo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader olvasocsatotna = new StreamReader("Selejtezo2012.txt");
            string sor = olvasocsatotna.ReadLine();

            int i = 0;
            int parsindex = 0;
            while (!olvasocsatotna.EndOfStream)
            {
                sor = olvasocsatotna.ReadLine();
                Versenyzo adat = new Versenyzo(sor);
                adatok.Add(adat);
                versenyzoCb.Items.Add(adat.nev);
                if(adat.nev == "Pars Krisztián")
                {
                    parsindex = i;
                }
                i++;
            }

            olvasocsatotna.Close();

            //ez is meg keresi a pars krisztánt
            var parKrisztian = adatok.Find(k=>k.nev == "Pars Krisztián");

            versenyzoCb.SelectedItem = parKrisztian.nev;

            //versenyzoCb.SelectedIndex = parsindex;
        }

        private void versenyzoCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            csoportLbl.Text = Convert.ToString(adatok[versenyzoCb.SelectedIndex].csoport);
            nemzetLbl.Text = adatok[versenyzoCb.SelectedIndex].Nemzet;
            nemzetKodLbl.Text = adatok[versenyzoCb.SelectedIndex].Kod;
            sorozatLbl.Text = adatok[versenyzoCb.SelectedIndex].sorozat;
            eredmenyLbl.Text = Convert.ToString(adatok[versenyzoCb.SelectedIndex].Eredmeny);
            zaszlopb.ImageLocation = "../../Images/" + adatok[versenyzoCb.SelectedIndex].Kod + ".png";

        }
    }
}
