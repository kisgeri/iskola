using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ora
{
    public partial class Form1 : Form
    {

        DateTime startIdo;
        TimeSpan elteltido, tarolEltelttido;
      
        public Form1()
        {
            InitializeComponent();
        }

        private void ora_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ora.Text = DateTime.Now.ToString("HH:mm:ss:fff");
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            startbtn.Enabled = false;
        }

        private void stopbtn_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            startbtn.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            elteltido = DateTime.Now - startIdo + tarolEltelttido;

            stopper.Text = elteltido.ToString(@"hh\:mm\:ss\.fff");
        }

        private void stoptopper_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            starttopper.Enabled = true;
            pausetopper.Enabled = false;
            stoptopper.Enabled = false;
        }

        private void pausetopper_Click(object sender, EventArgs e)
        {
            if(pausetopper.Text == "pause")
            {
                pausetopper.Text = "continue";
                tarolEltelttido = elteltido;
                timer2.Enabled = false;
                
            }
            else
            {
                pausetopper.Text = "pause";
                startIdo = DateTime.Now;
                timer2.Enabled = true;
            }
            

        }

        int vx = 2;
        int vy = 2;

        private void timer3_Tick(object sender, EventArgs e)
        {
            

            if(mozgo_label.Right >= mozgoTpg.Right)
            {
                vx = -2;
            }
            else if (mozgo_label.Left < 0)
            {
                vx = 2;
            }

            if (mozgo_label.Bottom  >= mozgoTpg.Bottom - mozgo_label.Height - mozgo_label.Height)
            {
                vy = -2;
            }

            else if (mozgo_label.Top <= 0)
            {
                vy = 2;
            }

            int ujx = mozgo_label.Left + vx;
            int ujy = mozgo_label.Top + vy;
            mozgo_label.Location = new Point(ujx, ujy);

        }

        
        private void ugroBtn_MouseEnter(object sender, EventArgs e)
        {
            Random rnd = new Random();

            
            ugroBtn.Location = new Point(rnd.Next(0, UgrogombTbp.Right - ugroBtn.Width/2), rnd.Next(0, UgrogombTbp.Bottom - ugroBtn.Height ));   
        }

        private void starttopper_Click(object sender, EventArgs e)
        {

            
            startIdo = DateTime.Now;
            tarolEltelttido = TimeSpan.Zero;

            timer2.Enabled = true;
            pausetopper.Enabled = true;
            stoptopper.Enabled = true;

            if (pausetopper.Text == "continue")
            {
                pausetopper.Text = "pause";
            }
        }
    }
}
