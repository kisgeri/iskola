using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GombHopp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hoppBtn_Click(object sender, EventArgs e)
        {
            if(int.Parse(xKoordTxt.Text) > this.ClientSize.Width- hoppBtn.Width || int.Parse(yKoordTxt.Text) > this.ClientSize.Height-hoppBtn.Height)
            {
                MessageBox.Show("Az x vagy az y kordínáta túl nyúl az abalakon", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                hoppBtn.Location = new Point(int.Parse(xKoordTxt.Text), int.Parse(yKoordTxt.Text));
            }
           
            
        }
    }
}
