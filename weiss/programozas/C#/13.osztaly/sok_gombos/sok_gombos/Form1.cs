using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sok_gombos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void eltunes_MouseEnter(object sender, EventArgs e)
        {
            eltunes.Visible= false;

        }

        private void eltunes_MouseLeave(object sender, EventArgs e)
        {
            eltunes.Visible = true;
        }

        private void lathatatlan_Click(object sender, EventArgs e)
        {
            if(inaktiv.Visible)
            {
                inaktiv.Visible = false;
            }
            else
            {
                inaktiv.Visible = true;
            }
            
        }

        private void inaktiv_Click(object sender, EventArgs e)
        {
            if (lathatatlan.Enabled)
            {
                lathatatlan.Enabled = false;
            }
            else
            {
                lathatatlan.Enabled = true ;
            }
            
        }

        private void kilepes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ugras_Click(object sender, EventArgs e)
        {
            if(ugras.Location == new Point(0,0))
            {
                ugras.Location = new Point(330, 62);

                
                MessageBox.Show("Sikerült","Ügyes vagy",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                ugras.Location = new Point(0, 0);
            }
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            eger_pozicio.Text = "Egér pozíciója:\n\n" +
                "X :"+ Cursor.Position.X.ToString()+" Y: " + Cursor.Position.X.ToString();
        }
    }
}
