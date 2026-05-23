using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pars2012GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static List<versenyzo> adatok = new List<versenyzo>();
        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader olvasocsatorna = new StreamReader("Selejtezo2012.txt");
            string sor;
            sor = olvasocsatorna.ReadLine();

            while (!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();

                versenyzo adat = new versenyzo(sor);
                adatok.Add(adat);

            }

            olvasocsatorna.Close();

            int pars_index=0;
            for (int i = 0; i < adatok.Count; i++)
            {
                if(adatok[i].nev == "Pars Krisztián")
                {
                    pars_index = i;
                }
                versenyzokCB.Items.Add(adatok[i].nev);
            }

            versenyzokCB.SelectedIndex = pars_index;


        }

        private void versenyzokCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            csoportLbl.Text = "Csoport: ";
            nemzetLbl.Text = "Nemzet: ";
            nemzetKodLbl.Text = "Nemzet kód: ";
            sorozatLbl.Text = "Sorozat: ";
            eredmenyLbl.Text = "Eredmény: ";

            csoportLbl.Text = csoportLbl.Text + adatok[versenyzokCB.SelectedIndex].csoport;
            nemzetLbl.Text = nemzetLbl.Text + adatok[versenyzokCB.SelectedIndex].Nemzet();
            nemzetKodLbl.Text = nemzetKodLbl.Text + adatok[versenyzokCB.SelectedIndex].Kod();
            sorozatLbl.Text = sorozatLbl.Text + adatok[versenyzokCB.SelectedIndex].sorozat;
            eredmenyLbl.Text = eredmenyLbl.Text + adatok[versenyzokCB.SelectedIndex].Eredmeny();

            PictureBoxZászló.ImageLocation = "E:/iskola/weiss/programozas/c#/13.osztaly/Kalapacsvetes/Pars2012GUI/Pars2012GUI/Images/" + adatok[versenyzokCB.SelectedIndex].Kod() + ".png";

        }
    }
}
