using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace betuStilus
{
    public partial class betustilus : Form
    {
        public betustilus()
        {
            InitializeComponent();
        }

        private void piros_CheckedChanged(object sender, EventArgs e)
        {
            cimkelbl.ForeColor = Color.Red;
        }

        private void kek_CheckedChanged(object sender, EventArgs e)
        {
            cimkelbl.ForeColor = Color.FromArgb(0,0,255);
        }

        private void fekete_CheckedChanged(object sender, EventArgs e)
        {
            cimkelbl.ForeColor = Color.FromArgb(0, 0, 0);
        }

        private void betumeret10_CheckedChanged(object sender, EventArgs e)
        {
            float betuMeret = 10;
            cimkelbl.Font = new Font(cimkelbl.Font.Name, betuMeret, cimkelbl.Font.Style);
        }

        private void betumeret11_CheckedChanged(object sender, EventArgs e)
        {
            float betuMeret = 11;
            cimkelbl.Font = new Font(cimkelbl.Font.Name, betuMeret, cimkelbl.Font.Style);
        }

        private void betumeret12_CheckedChanged(object sender, EventArgs e)
        {
            float betuMeret = 12;
            cimkelbl.Font = new Font(cimkelbl.Font.Name, betuMeret, cimkelbl.Font.Style);
        }

        private void betumeret14_CheckedChanged(object sender, EventArgs e)
        {
            float betuMeret = 14;
            cimkelbl.Font = new Font(cimkelbl.Font.Name, betuMeret, cimkelbl.Font.Style);
        }

        private void betumeret16_CheckedChanged(object sender, EventArgs e)
        {
            float betuMeret = 16;
            cimkelbl.Font = new Font(cimkelbl.Font.Name, betuMeret, cimkelbl.Font.Style);
        }

        private void betumeret18_CheckedChanged(object sender, EventArgs e)
        {
            float betuMeret = 18;
            cimkelbl.Font = new Font(cimkelbl.Font.Name, betuMeret, cimkelbl.Font.Style);
        }

        private void felkover_CheckedChanged(object sender, EventArgs e)
        {
            

            if(!felkover.Checked)
            {
                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style ^ FontStyle.Bold);
            }
            else
            {
                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style | FontStyle.Bold);
            }

        }

        private void dolt_CheckedChanged(object sender, EventArgs e)
        {
            

            if (!dolt.Checked)
            {
                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style ^ FontStyle.Italic);
            }
            else
            {
                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style | FontStyle.Italic);
            }
        }

        private void alahuzott_CheckedChanged(object sender, EventArgs e)
        {

            if (!alahuzott.Checked)
            {
                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style ^ FontStyle.Underline);
            }
            else
            {
                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style | FontStyle.Underline);

            }
        }

        private void athuzott_CheckedChanged(object sender, EventArgs e)
        {

            if (!athuzott.Checked)
            {
                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style ^ FontStyle.Strikeout);
            }
            else
            {

                cimkelbl.Font = new Font(cimkelbl.Font, cimkelbl.Font.Style | FontStyle.Strikeout);
            }
        }
    }
}
