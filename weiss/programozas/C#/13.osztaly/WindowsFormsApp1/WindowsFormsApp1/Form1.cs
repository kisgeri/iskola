using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        struct autok
        {
            public string rendszam;
            public string marka;
            public string tipus;
            public int hengerurtartalom;
            public int evjarat;
            public string uzemanyag;
        }

        const int maxelem = 100;

        autok[] tautok = new autok[maxelem];
        
        public int n = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void hSB_Scroll(object sender, ScrollEventArgs e)
        {
            meretPnl.Width = hSB.Value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Width = this.ClientSize.Width;
            tabControl1.Height = this.ClientSize.Height;

            hSB.Width = tabControl1.Width-100;
            vSB.Height = tabControl1.Height -100;
            hSB.Maximum = tabControl1.Width -100;
            vSB.Maximum = tabControl1.Height -100;
        }

        private void vSB_Scroll(object sender, ScrollEventArgs e)
        {
            meretPnl.Height = vSB.Value;
        }

        int vx = 2;
        int vy = 2;

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            int ujx = mozgoPtb.Left + vx;
            int ujy = mozgoPtb.Top + vy;
            Random rnd = new Random();

            
            if (ujx + mozgoPtb.Width > mozgokep.Right)
            {
                
                ujx = mozgokep.Right - mozgoPtb.Width;
                mozgokep.BackColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255));
                vx = -(vx + 2);  
            }
            else if (ujx < mozgokep.Left)
            {
                
                ujx = mozgokep.Left;
                mozgokep.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                vx = -(vx) + 2;       
            }

            
            if (ujy + mozgoPtb.Height > mozgokep.Bottom)
            {
                
                ujy = mozgokep.Bottom - mozgoPtb.Height;
                mozgokep.BackColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                vy = -(vy + 2);
            }
            else if (ujy < mozgokep.Top)
            {
                
                ujy = mozgokep.Top;
                mozgokep.BackColor = Color.FromArgb(rnd.Next(0,255), rnd.Next(0, 255), rnd.Next(0, 255));
                vy = -(vy) + 2;       
            }

            mozgoPtb.Location = new Point(ujx, ujy);



            /*
            //eredeti gyorsító
            if (mozgoPtb.Right >= mozgokep.Right)
            {
                vx = -(vx + 2);
            }
            else if (mozgoPtb.Left < mozgokep.Left)
            {
                vx = vx + 2;
            }

            if (mozgoPtb.Bottom >= mozgokep.Bottom)
            {
                vy = -(vy + 2);
            }

            else if (mozgoPtb.Top <= mozgokep.Top)
            {
                vy = vy + 2;
            }

            int ujx = mozgoPtb.Left + vx;
            int ujy = mozgoPtb.Top + vy;
            mozgoPtb.Location = new Point(ujx, ujy);

            //eredeti
            if (mozgoPtb.Right >= mozgokep.Right)
            {
                vx = -2;
            }
            else if (mozgoPtb.Left < mozgokep.Left)
            {
                vx = vx + 2;
            }

            if (mozgoPtb.Bottom >= mozgokep.Bottom)
            {
                vy = -2;
            }

            else if (mozgoPtb.Top <= mozgokep.Top)
            {
                vy = vy + 2;
            }

            int ujx = mozgoPtb.Left + vx;
            int ujy = mozgoPtb.Top + vy;
            mozgoPtb.Location = new Point(ujx, ujy);
            */

        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            tabControl1.Width = this.ClientSize.Width;
            tabControl1.Height = this.ClientSize.Height;

            hSB.Width = tabControl1.Width - 100;
            vSB.Height = tabControl1.Height - 100;
            hSB.Maximum = tabControl1.Width - 100;
            vSB.Maximum = tabControl1.Height - 100;

        }

        int ujSzam = 0;
        private void kivonBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(szamTxt.Text) > 4)
            {
                ujSzam = int.Parse(szamTxt.Text) - 1;
                szamTxt.Text = Convert.ToString(ujSzam);
            }
        }

        private void hozzaadBtn_Click(object sender, EventArgs e)
        {
            if (int.Parse(szamTxt.Text) < 9)
            {
                ujSzam = int.Parse(szamTxt.Text) + 1;
                szamTxt.Text = Convert.ToString(ujSzam);
            }
        }

        private void kezdoalapotTxt_TextChanged(object sender, EventArgs e)
        {
            hosszLbl.Text = "hossz: " + kezdoalapotTxt.TextLength; 
        }

        private void ellenorBtn_Click(object sender, EventArgs e)
        {
            if(kezdoalapotTxt.TextLength < (int.Parse(szamTxt.Text) * int.Parse(szamTxt.Text)))
            {
                int hianyzoSzam = (int.Parse(szamTxt.Text) * int.Parse(szamTxt.Text)) - kezdoalapotTxt.TextLength;
                MessageBox.Show("A feladvány rövid: kell még " + hianyzoSzam + " számjegy!","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else if(kezdoalapotTxt.TextLength > (int.Parse(szamTxt.Text) * int.Parse(szamTxt.Text)))
            {
                int tobbSzam = (int.Parse(szamTxt.Text) * int.Parse(szamTxt.Text)) - kezdoalapotTxt.TextLength;
                tobbSzam = -(tobbSzam);
                MessageBox.Show("A feladvány hosszú: törlendő " + tobbSzam + " számjegy!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("A feladvány megfelelő hosszúságú!", "jó", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ListBtn_Click(object sender, EventArgs e)
        {
            if(listTxt.Text != "")
            {
                listBox1.Items.Add(listTxt.Text);
                listTxt.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void deleteallBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void listTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listTxt.Text != "")
                {
                    listBox1.Items.Add(listTxt.Text);
                    listTxt.Text = "";
                }
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        public int visszakuldesDb = 0;
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (comboBox1.Text != "")
                {
                    visszakuldesDb += 1;
                    listBox2.Items.Add(visszakuldesDb + ". visszaküldés. Oka:"+comboBox1.Text);
                    comboBox1.Text = "";
                }
            }
        }

        private void visszaBtn_Click(object sender, EventArgs e)
        {

                if (comboBox1.Text != "")
                {
                    visszakuldesDb += 1;
                    listBox2.Items.Add(visszakuldesDb + ". visszaküldés. Oka:" + comboBox1.Text);
                    comboBox1.Text = "";
                }
            
        }


        
        private void felveszBtn_Click(object sender, EventArgs e)
        {
            if(filmTxt.Text != "")
            {
                topMoziLb.Items.Add(filmTxt.Text);
                helyNud.Maximum = topMoziLb.Items.Count;
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            helyNud.Maximum = topMoziLb.Items.Count;
        }

        private void beszurBtn_Click(object sender, EventArgs e)
        {
            if (filmTxt.Text != "" && Convert.ToInt16(helyNud.Value) != 0)
            {   
                topMoziLb.Items.Insert(Convert.ToInt16(helyNud.Value)-1, filmTxt.Text);
                helyNud.Maximum = topMoziLb.Items.Count;
            }
        }

        private void torolBtn_Click(object sender, EventArgs e)
        {
            if(topMoziLb.SelectedIndex != -1)
            {
                topMoziLb.Items.Remove(topMoziLb.SelectedItem);
                helyNud.Maximum = topMoziLb.Items.Count;
            }

        }

        private void torolMindBtn_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan mindent törölni szeretne ?","Minden Törlése",MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(valasz == DialogResult.Yes)
            {
                topMoziLb.Items.Clear();
                helyNud.Maximum = topMoziLb.Items.Count;
            }

        }

        private void atmasolBtn_Click(object sender, EventArgs e)
        {
            if(topMoziLb.SelectedItem != null)
            {
                moziLatottLb.Items.Add(topMoziLb.SelectedItem);
            }
            
        }

        private void atmozgatBtn_Click(object sender, EventArgs e)
        {
            if (topMoziLb.SelectedItem != null)
            {
                moziLatottLb.Items.Add(topMoziLb.SelectedItem);
                topMoziLb.Items.Remove(topMoziLb.SelectedItem);
                helyNud.Maximum = topMoziLb.Items.Count;
            }
        }

        private void keresBtn_Click(object sender, EventArgs e)
        {
            
            if (filmTxt.Text != "")
            {
                int index = topMoziLb.FindString(filmTxt.Text);
                if (index != -1)
                {
                    topMoziLb.SetSelected(index, true);
                }
                    
            }
        }

        private void helyNud_ValueChanged(object sender, EventArgs e)
        {
            if(helyNud.Maximum > topMoziLb.Items.Count)
            {
                helyNud.Maximum = topMoziLb.Items.Count;
            }


        }

        private void ugrasBtn_Click(object sender, EventArgs e)
        {
            bongeszoWB.Navigate(urlCB.Text);
            urlCB.Items.Add(urlCB.Text);
        }

        private void felvesz1Btn_Click(object sender, EventArgs e)
        {
            

            if(n <= maxelem )
            {
                tautok[n].rendszam = rendszamTxt.Text;
                tautok[n].marka = markaCB.Text;
                tautok[n].tipus = tipusTxt.Text;
                tautok[n].hengerurtartalom = int.Parse(hengerUrtartalomTxt.Text);
                tautok[n].evjarat = Convert.ToInt32(EvjaratNUD.Value);
                tautok[n].uzemanyag = uzemanyagCB.Text;
                n++;
            }
            else
            {
                MessageBox.Show("A lista megtelt");
            }

            rendszamTxt.Text = "";
            markaCB.Text = "";
            tipusTxt.Text = "";
            hengerUrtartalomTxt.Text = "";
            uzemanyagCB.Text = "";

            /*
            public string rendszam;
            public string marka;
            public string tipus;
            public int hengerurtartalom;
            public int evjarat;
            public string uzemanyag;
             */
        }

        private void listazBtn_Click(object sender, EventArgs e)
        {
            autolistLB.Items.Clear();
            for (int i = 0; i < n; i++)
            {
                autolistLB.Items.Add(tautok[i].rendszam+", "+ tautok[i].marka + ", " + tautok[i].tipus + ", " + tautok[i].evjarat + ", " + tautok[i].hengerurtartalom + " cm3, " + tautok[i].uzemanyag);
            }
            
        }
    }
}
