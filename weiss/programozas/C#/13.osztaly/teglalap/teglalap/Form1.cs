using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teglalap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void szamitosBtn_Click(object sender, EventArgs e)
        {
            //téglalap
            double terulet = double.Parse(aOldalTxt.Text) * double.Parse(bOldalTxt.Text);
            double kerulet = 2*(double.Parse(aOldalTxt.Text) + double.Parse(bOldalTxt.Text));
            teruletLbl.Text = terulet.ToString();

            MessageBox.Show($"kerület: {kerulet}", "kerület", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
