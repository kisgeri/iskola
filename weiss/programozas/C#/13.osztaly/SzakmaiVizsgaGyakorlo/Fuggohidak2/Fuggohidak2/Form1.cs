using System.IO;

namespace Fuggohidak2
{
    public partial class FuggohidakForm : Form
    {
        public FuggohidakForm()
        {
            InitializeComponent();
        }

        static List<Fuggohid> adatok = new List<Fuggohid>();
        private void fájlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            try
            {
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

                    foreach (var adat in adatok)
                    {
                        hidnevekLb.Items.Add(adat.nev);
                    }
                }
            }
            catch (Exception kivetel)
            {
                MessageBox.Show("nem jó :(\n" + kivetel);
            }
        }

        private void hidnevekLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            helxtxt.Text = adatok[hidnevekLb.SelectedIndex].hely;
            orszagTxt.Text = adatok[hidnevekLb.SelectedIndex].orszag;
            hosszTxt.Text = adatok[hidnevekLb.SelectedIndex].hossz.ToString();
            evTxt.Text = adatok[hidnevekLb.SelectedIndex].ev.ToString();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ketezerelottRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ketezerelottRb.Checked)
            {
                ketezerutanRB.Checked = false;

                int darab = 0;
                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].ev < 2000)
                    {
                        darab++;
                    }
                }

                darabTxt.Text = darab.ToString();
            }
        }

        private void ketezerutanRB_CheckedChanged(object sender, EventArgs e)
        {
            if (ketezerutanRB.Checked)
            {
                ketezerelottRb.Checked = false;

                int darab = 0;
                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].ev >= 2000)
                    {
                        darab++;
                    }
                }

                darabTxt.Text = darab.ToString();
            }
        }

        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kereses form = new Kereses(adatok);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
