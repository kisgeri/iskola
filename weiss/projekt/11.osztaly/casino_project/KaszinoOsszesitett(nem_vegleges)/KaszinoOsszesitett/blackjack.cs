using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KaszinoOsszesitett
{
    public partial class blackjack : Form
    {
        public blackjack()
        {
            InitializeComponent();
        }

        bool game_progress = false;
        static List<string> jatekos_kartya = new List<string>();
        private List<PictureBox> pictureBoxList_jatekos = new List<PictureBox>();
        string[] card_type = new string[4] { "clubs", "diamonds", "hearts", "spades" };
        Random rnd = new Random();
        private void start_Click(object sender, EventArgs e)
        {
            start.Visible = false;
            double_btn.Enabled = true;
            get_btn.Enabled = true;
            tartas_btn.Enabled = true;
            game_progress = true;
            round_start();
        }

        private void round_start()
        {

        }

        private void card_add(int type)
        {
            int random_type = rnd.Next(0, 4);
            int random_number = rnd.Next(1, 14);
        }
        int tick;

        private void timer1_Tick(object sender, EventArgs e)
        {
            tick++;
        }
    }
}
