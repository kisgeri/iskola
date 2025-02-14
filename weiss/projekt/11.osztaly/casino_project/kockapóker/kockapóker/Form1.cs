using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kockapóker
{
    
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        /*int szam1, szam2, szam3, szam4, szam5;*/
        int bet,credit;
        public Form1()
        {
            credit = 1000;
            
            InitializeComponent();
            label4.Text = Convert.ToString(credit);
            label5.Visible = true;
            label6.Visible = false;
        }
        



            private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox1.Text != "0")
            {
                if (int.TryParse(textBox1.Text, out bet))
                {
                    bet = int.Parse(textBox1.Text);
                    if (bet < 1)
                    {
                        label5.Visible = true;
                    }
                    else
                    {
                        label5.Visible = false;
                    }
                }
                else { label5.Visible = true; }

            }
            else { label5.Visible = true; }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text != "" && bet >= 1)
            {
                if(credit >= bet)
                {
                    credit = credit - bet;
                    label4.Text = Convert.ToString(credit);
                    label6.Visible = true;
                    /*
                    szam1 = rnd.Next(1, 6);
                    szam2 = rnd.Next(1, 6);
                    szam3 = rnd.Next(1, 6);
                    szam4 = rnd.Next(1, 6);
                    szam5 = rnd.Next(1, 6);
                    */
                    int[] tömb = new int[6];
                    bool kissor = true;
                    bool nagysor = true;
                    Dictionary<int, int> mergedParts = new Dictionary<int, int>();
                    for (int i = 1; i < tömb.Length; i++)
                    {
                        tömb[i] = rnd.Next(1, 7);
                        if (i == 1) { pictureBox1.Image = Image.FromFile(tömb[i].ToString() + ".png"); }
                        if (i == 2)
                        {
                            pictureBox2.Image = Image.FromFile(tömb[i].ToString() + ".png");
                        }
                        if (i == 3)
                        {
                            pictureBox3.Image = Image.FromFile(tömb[i].ToString() + ".png");
                        }
                        if (i == 4)
                        {
                            pictureBox4.Image = Image.FromFile(tömb[i].ToString() + ".png");
                        }
                        if (i == 5)
                        {
                            pictureBox5.Image = Image.FromFile(tömb[i].ToString() + ".png");
                        }
                        if (tömb[i] != i + 1)
                        {
                            kissor = false;
                        }
                        if (tömb[i] != i + 2)
                        {
                            nagysor = false;
                        }
                    }
               
                    
                    
                    for (int i = 0; i < tömb.Length; i++)
                    {
                        if (mergedParts.ContainsKey(tömb[i]))
                        {
                            mergedParts[tömb[i]] += 1;
                        }
                        else
                        {
                            mergedParts[tömb[i]] = 1;
                        }
                    }

                    int count = 0;
                    bool harmas_par = false;
                    bool par = false;
                    bool poker = false;
                    bool royalpoker = false;
                    bool full = false;
                    foreach (var item in mergedParts)
                    {
                        if (item.Value == 2)
                        {
                            
                            count += 1;
                            if (count <= 2)
                            {
                                
                                label6.Text = count + " pár";
                                par = true;
                            }




                        }
                        
                        


                        if (item.Value == 3)
                        {
                            label6.Text = "DRILL";
                            harmas_par = true;
                            
                        }
                        if (par && harmas_par)
                        {
                            par = false;
                            harmas_par = false;
                            full = true;
                            label6.Text = "FULL";
                            bet = bet + 300;
                            credit = credit + bet;
                            label4.Text = Convert.ToString(credit);
                        }
                        if (item.Value == 4)
                        {
                            poker = true;
                            label6.Text = "POKER";
                            bet = bet + 400;
                            credit = credit + bet;
                            label4.Text = Convert.ToString(credit);
                            
                        }
                        if (item.Value == 5)
                        {
                            royalpoker = true;
                            label6.Text = "ROYAL POKER";
                            bet = bet + 500;
                            credit = credit + bet;
                            label4.Text = Convert.ToString(credit);

                        }
                        if (par == false && harmas_par==false&&poker==false&&royalpoker==false&& full == false)
                        {
                            label6.Text = "nem nyertél";

                        }
                        
                    }
                    if (kissor)
                    {
                        label6.Text = "Kissor";
                        bet = bet + 700;
                        credit = credit + bet;
                        label4.Text = Convert.ToString(credit);
                    }
                    else if (nagysor)
                    {
                        label6.Text = "Nagysor";
                        bet = bet + 700;
                        credit = credit + bet;
                        label4.Text = Convert.ToString(credit);
                    }

                    

                    if (harmas_par==true)
                    {
                        bet = bet + 150;
                        credit = credit + bet;
                        label4.Text = Convert.ToString(credit);
                    }

                    if (par == true && count >= 2)
                    {
                        label6.Text = "dupla pár";
                        bet = bet + 100;
                        credit = credit + bet;
                        label4.Text = Convert.ToString(credit);
                    }
                    else if(par == true)
                    {

                        bet = bet + 50;
                        credit = credit + bet;
                        label4.Text = Convert.ToString(credit);
                    }


                    /*
                    if (par==true)
                    {
                        bet = bet + 50;
                        credit = credit + bet;
                        label4.Text = Convert.ToString(credit);
                    }
                    */
                    /*
                    pictureBox1.Image = Image.FromFile(szam1.ToString() + ".png");
                    pictureBox2.Image = Image.FromFile(szam2.ToString() + ".png");
                    pictureBox3.Image = Image.FromFile(szam3.ToString() + ".png");
                    pictureBox4.Image = Image.FromFile(szam4.ToString() + ".png");
                    pictureBox5.Image = Image.FromFile(szam5.ToString() + ".png");
                    */

                }



                bet = 0;
                textBox1.Text = "";
            }
            else { label5.Visible = true; }
            

        }
        
    }
}
