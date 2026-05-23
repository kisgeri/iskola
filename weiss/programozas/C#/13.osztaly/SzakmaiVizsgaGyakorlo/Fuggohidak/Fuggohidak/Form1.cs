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

namespace Fuggohidak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. Példányosítjuk a második formot, és átadjuk neki a listát
            Form2 kf = new Form2(adatok);

            // 2. Elrejtjük a főformot (6. feladat előírása)
            this.Hide();

            // 3. Megnyitjuk a másodikat "Modal" ablaként (megvárja, amíg bezárod)
            kf.ShowDialog();

            // 4. Miután a KeresesForm bezárult, újra megjelenítjük a főformot
            this.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        static List<Fuggohid> adatok = new List<Fuggohid>();
        private void megnyitásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV fájl|*.csv";//ez nem muszály, csak szűr a keresett fájl típusra
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader olvasocsatorna = new StreamReader(ofd.FileName);
                string sor = olvasocsatorna.ReadLine();

                while (!olvasocsatorna.EndOfStream)
                {
                    sor = olvasocsatorna.ReadLine();
                    Fuggohid adat = new Fuggohid(sor);

                    adatok.Add(adat);
                }

                for (int i = 0; i < adatok.Count; i++)
                {
                    hidakNeveiLb.Items.Add(adatok[i].hid);
                }
            }
        }

        private void hidakNeveiLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            helyTxt.Text = adatok[hidakNeveiLb.SelectedIndex].hely;
            orszagTxt.Text = adatok[hidakNeveiLb.SelectedIndex].orszag;
            hosszTxt.Text = adatok[hidakNeveiLb.SelectedIndex].hossz.ToString();
            evTxt.Text = adatok[hidakNeveiLb.SelectedIndex].ev.ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;

                int ketezerelottDb = 0;
                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].ev<2000)
                    {
                        ketezerelottDb++;
                    }
                }

                darabTxt.Text = ketezerelottDb.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;

                int ketezerutaniDb = 0;
                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].ev >= 2000)
                    {
                        ketezerutaniDb++;
                    }
                }

                darabTxt.Text = ketezerutaniDb.ToString();
            }
        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
