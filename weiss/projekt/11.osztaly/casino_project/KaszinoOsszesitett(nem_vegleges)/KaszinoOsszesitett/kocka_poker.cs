using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaszinooooo
{
    public partial class kocka_poker : Form
    {
        private Label[] numberLabels;
        public kocka_poker()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numberLabels = new Label[] { szam1, szam2, szam3, szam4, szam5 };

            Random rnd = new Random();
            int[] random_nums = new int[5] { 2, 2, 3, 3, 3 };
            Dictionary<int, int> mergedParts = new Dictionary<int, int>();
            bool kissor = true;
            bool nagysor = true;
            for (int i = 0; i < random_nums.Length; i++)
            {
                //random_nums[i] = rnd.Next(1, 7);
                numberLabels[i].Visible = true;
                numberLabels[i].Text = Convert.ToString(random_nums[i]);

                if (random_nums[i] != i + 1)
                {
                    kissor = false;
                }
                if (random_nums[i] != i + 2)
                {
                    nagysor = false;
                }
            }

            for (int i = 0; i < random_nums.Length; i++)
            {
                if (mergedParts.ContainsKey(random_nums[i]))
                {
                    mergedParts[random_nums[i]] += 1;
                }
                else
                {
                    mergedParts[random_nums[i]] = 1;
                }
            }
            int count = 0;
            bool harmas_par = false;
            foreach (var item in mergedParts)
            {
                if(item.Value == 2)
                {
                    count += 1;
                }
                if (count <= 2)
                {
                    parok_szama.Text = count + " pár";
                }
                if (item.Value == 3)
                {
                    parok_szama.Text = "DRILL";
                    harmas_par = true;
                }
                if(count == 1 && harmas_par)
                {
                    parok_szama.Text = "FULL";
                }
                if (item.Value == 4)
                {
                    parok_szama.Text = "POKER";
                }
                if (item.Value == 5)
                {
                    parok_szama.Text = "ROYAL POKER";
                }
            }
            if (kissor)
            {
                parok_szama.Text = "Kissor";
            }
            else if (nagysor)
            {
                parok_szama.Text = "Nagysor";
            }

        }
    }
}
