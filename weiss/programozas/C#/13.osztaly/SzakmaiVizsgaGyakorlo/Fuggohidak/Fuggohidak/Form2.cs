using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fuggohidak
{
    public partial class Form2 : Form
    {
        static List<Fuggohid> adatok = new List<Fuggohid>();
        static List<string> orszagok = new List<string>();
        public Form2(List<Fuggohid> hidak)
        {
            InitializeComponent();
            for (int i = 0; i < hidak.Count; i++)
            {
                adatok.Add(hidak[i]);
            }

            if (adatok.Count > 0)
            {
                orszagok.Add(adatok[0].orszag);



                for (int i = 1; i < adatok.Count; i++)
                {
                    bool bennevan = false;

                    int j = 0;
                    while (!bennevan && j < orszagok.Count)
                    {
                        if (adatok[i].orszag == orszagok[j])
                        {
                            bennevan |= true;
                        }
                        j++;
                    }
                    if (!bennevan)
                    {
                        orszagok.Add(adatok[i].orszag);
                    }

                }
            }
            
            }
        

        private void bezarasBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < orszagok.Count; i++)
            {
                orszagCb.Items.Add(orszagok[i]);
            }
        }

        private void keresesBtn_Click(object sender, EventArgs e)
        {
            KeresetLb.Items.Clear();

            if (orszagCb.Text != "")
            {
                if (egykmHChb.Checked)
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {
                        if (adatok[i].orszag == orszagCb.Text && adatok[i].hossz > 1000)
                        {
                            KeresetLb.Items.Add(adatok[i].hid);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {
                        if (adatok[i].orszag == orszagCb.Text)
                        {
                            KeresetLb.Items.Add(adatok[i].hid);
                        }
                    }
                }
            }
            else
            {
                if (egykmHChb.Checked)
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {
                        if (adatok[i].hossz > 1000)
                        {
                            KeresetLb.Items.Add(adatok[i].hid);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < adatok.Count; i++)
                    {

                        KeresetLb.Items.Add(adatok[i].hid);
                        
                    }
                }
            }
        }
    }
}
