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

namespace RealEstateGUI
{
    public partial class hirdetesekForm : Form
    {
        static List<hirdetesek> adatok = new List<hirdetesek>();
        public hirdetesekForm()
        {
            InitializeComponent();

            StreamReader olvasocsatorna = new StreamReader("realestates.csv");
            string sor = olvasocsatorna.ReadLine();

            while (!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();

                hirdetesek adat = new hirdetesek(sor);
                adatok.Add(adat);
            }
            olvasocsatorna.Close();
        }

        private void bezárásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void hirdetesekForm_Load(object sender, EventArgs e)
        {
            foreach (var adat in adatok)
            {
                nevCb.Items.Add(adat.nev);
            }
        }

        private void EmletTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void nevCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            telefonTxt.Text = adatok[nevCb.SelectedIndex].telefonSzam;
            KetegoriaTxt.Text = adatok[nevCb.SelectedIndex].kategoria;
            szobakTxt.Text = adatok[nevCb.SelectedIndex].szobak.ToString();
            alapterTxt.Text = adatok[nevCb.SelectedIndex].alapterulet.ToString();
            EmletTxt.Text = adatok[nevCb.SelectedIndex].emelet.ToString();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kereses from = new kereses(adatok);
            if (from.ShowDialog() == DialogResult.OK)
            {

            }
            /*
            this.Hide();
            from.ShowDialog();
            this.Show();
            */

        }
    }
}
