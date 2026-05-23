using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstateGUI
{
    public partial class kereses : Form
    {
        static List<hirdetesek> adatok = new List<hirdetesek>();
        public kereses(List<hirdetesek> lista)
        {
            InitializeComponent();

            foreach (var adat in lista)
            {
                adatok.Add(adat);
            }
        }

        private void kereses_Load(object sender, EventArgs e)
        {

        }

        private void nagyobRb_CheckedChanged(object sender, EventArgs e)
        {
            if (nagyobRb.Checked)
            {
                kisebbRb.Checked = false;
            }
        }

        private void kisebbRb_CheckedChanged(object sender, EventArgs e)
        {
            if (kisebbRb.Checked)
            {
                nagyobRb.Checked = false;
            }
        }

        private void keresesBtn_Click(object sender, EventArgs e)
        {
            int darab = 0;

            if (nagyobRb.Checked)
            {
                foreach (var adat in adatok)
                {
                    if(adat.alapterulet > 50)
                    {
                        darab++;
                    }
                }
            }
        }
    }
}
