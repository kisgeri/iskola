using System.IO;
namespace Fuggohid
{
    public partial class Függõhidak : Form
    {
        public Függõhidak()
        {
            InitializeComponent();
        }

        static List<Fuggohid> adatok = new List<Fuggohid>();
        private void keresésToolStripMenuItem_Click(object sender, EventArgs e)
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
                    olvasocsatorna.Close();

                }

            }
            catch (Exception kivetel)
            {

                MessageBox.Show("nem jó\n" + kivetel.ToString());
            }


            if (adatok.Count > 0)
            {
                for (int i = 0; i < adatok.Count; i++)
                {
                    hidNevLb.Items.Add(adatok[i].nev);
                }
            }

        }

        private void keresésToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Keresés form = new Keresés(adatok);
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hidNevLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            helytxt.Text = adatok[hidNevLb.SelectedIndex].hely;
            orszagTxt.Text = adatok[hidNevLb.SelectedIndex].orszag;
            hosszTxt.Text = adatok[hidNevLb.SelectedIndex].hossz.ToString();
            evTxt.Text = adatok[hidNevLb.SelectedIndex].ev.ToString();

        }

        private void kilepesBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ketezereelottRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ketezereelottRb.Checked)
            {
                ketezereutaniRb.Checked = false;

                int ketezerelottdb = 0;

                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].ev < 2000)
                    {
                        ketezerelottdb++;
                    }
                }

                darabTxt.Text = ketezerelottdb.ToString();
            }
        }

        private void ketezereutaniRb_CheckedChanged(object sender, EventArgs e)
        {
            if (ketezereutaniRb.Checked)
            {
                ketezereelottRb.Checked = false;

                int ketezereutanidb = 0;

                for (int i = 0; i < adatok.Count; i++)
                {
                    if (adatok[i].ev >= 2000)
                    {
                        ketezereutanidb++;
                    }
                }

                darabTxt.Text = ketezereutanidb.ToString();
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
