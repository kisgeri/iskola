using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ablak_ugri
{
    public partial class Form1 : Form
    {
        static int deskHeight = Screen.PrimaryScreen.Bounds.Height;
        static int deskWidth = Screen.PrimaryScreen.Bounds.Width;
        public Form1()
        {
            InitializeComponent();

        }

        private void kozep_Click(object sender, EventArgs e)
        {

            Location = new Point((deskWidth - this.Width) / 2, (deskHeight - this.Height) / 2);
        }
        private void jobbfent_Click(object sender, EventArgs e)
        {
            //bal fent
            Location = new Point(deskWidth - deskWidth, deskHeight- deskHeight);
        }

        private void jobblent_Click(object sender, EventArgs e)
        {//bal lent
            Location = new Point((deskWidth - deskWidth), (deskHeight - this.Height));
        }

        private void balfent_Click(object sender, EventArgs e)
        {//jobb fent
            Location = new Point(deskWidth - this.Width, deskHeight - deskHeight);
        }

        private void button2_Click(object sender, EventArgs e)
        {//jobb lent

            Location = new Point((deskWidth - this.Width), (deskHeight - this.Height));
        }
    }
}
