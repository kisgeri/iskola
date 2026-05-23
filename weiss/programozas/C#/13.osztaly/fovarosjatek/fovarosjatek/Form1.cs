using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fovarosjatek
{
    public partial class fovarosFm : Form
    {
        public fovarosFm()
        {
            InitializeComponent();
        }


        struct OrszagFovarosStrc
        {
            public string Orszag;
            public string Fovaros;
        }

        struct EredmenyekStrc
        {
            public string nev;
            public int elertpont;
            public int kerdesszam;
        }

        public int pontszam;
        public int kerdesekszama;
        public int randomOrszagIndex;

        List<OrszagFovarosStrc> OrszagFovaros = new List<OrszagFovarosStrc>();
        List<EredmenyekStrc> Eredmenyek = new List<EredmenyekStrc>();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rulesBtn_Click(object sender, EventArgs e)
        {

            jatekStartBtn.Visible= false;
            leaderBoardBtn.Visible= false;
            rulesBtn.Visible= false;
            nameTxt.Visible= false;

            jatekStartBtn.Enabled=false;
            leaderBoardBtn.Enabled=false;
            rulesBtn.Enabled=false;
            nameTxt.Enabled=false;

            titleLbl.Text = "Szabályzat";
            label2.Text = "A játék kezdéséhez meg kell adni egy játékos nevet.\n\n" +
                "Minden országnál csak egy tipped van,\n" +
                "ha ezt a tipped le adtad jön a következő kérdés.\n\n" +
                "Minden helyesen eltalált főváros ért 1 pont jár.\n\n" +
                "A pontokatt csak a játék befejezésen után\n" +
                "az eredmények részben láthatod.\n\n" +
                "A játék befejezéséhez nyomd meg a 'játék befejezése' gombott.";
            ReturnBtn.Visible=true;
            ReturnBtn.Enabled = true;

        }

        private void fovarosFm_Load(object sender, EventArgs e)
        {


            country.Visible = false;
            CityCb.Visible = false;
            answerBtn.Visible = false;
            endBtn.Visible = false;
            ReturnBtn.Visible = false;
            scoreBoardLb.Visible = false;


            country.Enabled = false;
            CityCb.Enabled = false;
            answerBtn.Enabled = false;
            endBtn.Enabled = false;
            ReturnBtn.Enabled = false;
            scoreBoardLb.Enabled = false;

            StreamReader olvasocsatorna = new StreamReader("fovarosok.txt");
            string sor;
            string[] darabol;

            while (!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(';');

                OrszagFovarosStrc hely = new OrszagFovarosStrc();

                hely.Orszag = darabol[0];
                hely.Fovaros = darabol[1];

                OrszagFovaros.Add(hely);
            }

            olvasocsatorna.Close();





        }

        private void RRBtn_Click(object sender, EventArgs e)
        {


            jatekStartBtn.Visible = true;
            leaderBoardBtn.Visible = true;
            rulesBtn.Visible = true;
            label2.Visible = true;
            nameTxt.Visible = true;

            jatekStartBtn.Enabled = true;
            leaderBoardBtn.Enabled = true;
            rulesBtn.Enabled = true;
            label2.Enabled = true;
            nameTxt.Enabled = true;

            titleLbl.Text = "Ki tudod találni a fővárost ?";
            label2.Text = "Add meg a felhasználó neved:";
            ReturnBtn.Visible = false;
            ReturnBtn.Enabled = false;
            scoreBoardLb.Visible = false;
            

        }

        private void jatekStartBtn_Click(object sender, EventArgs e)
        {
            if(nameTxt.Text != "")
            {
                CityCb.Items.Clear();
                
                for (int i = 0; i < OrszagFovaros.Count(); i++)
                {
                    CityCb.Items.Add(OrszagFovaros[i].Fovaros);
                }

                pontszam = 0;
                Random rnd = new Random();
                randomOrszagIndex = rnd.Next(0, OrszagFovaros.Count);
                country.Text = OrszagFovaros[randomOrszagIndex].Orszag;


                kerdesekszama = 1;

                label2.Visible = false;
                label2.Enabled = false;

                jatekStartBtn.Visible = false;
                leaderBoardBtn.Visible = false;
                rulesBtn.Visible = false;
                nameTxt.Visible = false;

                jatekStartBtn.Enabled = false;
                leaderBoardBtn.Enabled = false;
                rulesBtn.Enabled = false;
                nameTxt.Enabled = false;

                titleLbl.Text = "Találd ki az ország fővárosátt.";
                country.Visible = true;
                country.Enabled = true;
                CityCb.Visible = true;
                CityCb.Enabled = true;
                answerBtn.Visible = true;
                answerBtn.Enabled = true;
                endBtn.Visible = true;
                endBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Adj meg egy felhasználó nevett","hiba",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            
        }

        private void leaderBoardBtn_Click(object sender, EventArgs e)
        {
            scoreBoardLb.Items.Clear();
            Eredmenyek.Clear();

            if (File.Exists("eredmenyek.txt"))
            {
                StreamReader olvasocsatorna2 = new StreamReader("eredmenyek.txt");
                string sor2;
                string[] darabol2;

                while (!olvasocsatorna2.EndOfStream)
                {
                    sor2 = olvasocsatorna2.ReadLine();
                    darabol2 = sor2.Split(';');

                    EredmenyekStrc jatekos = new EredmenyekStrc();

                    jatekos.nev = darabol2[0];
                    jatekos.elertpont = int.Parse(darabol2[1]);
                    jatekos.kerdesszam = int.Parse(darabol2[2]);

                    Eredmenyek.Add(jatekos);
                }

                olvasocsatorna2.Close();
            }

            if (Eredmenyek.Count > 0)
            {
                for (int i = 0; i < Eredmenyek.Count(); i++)
                {
                    scoreBoardLb.Items.Add($"név: {Eredmenyek[i].nev}, Pontszám: {Eredmenyek[i].elertpont}/{Eredmenyek[i].kerdesszam}");
                }
            }

            jatekStartBtn.Visible = false;
            leaderBoardBtn.Visible = false;
            rulesBtn.Visible = false;
            nameTxt.Visible = false;
            label2.Visible = false;

            jatekStartBtn.Enabled = false;
            leaderBoardBtn.Enabled = false;
            rulesBtn.Enabled = false;
            nameTxt.Enabled = false;
            label2.Enabled = false;

            titleLbl.Text = "Elért eredmények";

            scoreBoardLb.Visible = true;
            ReturnBtn.Visible = true;
            ReturnBtn.Enabled = true;
        }

        private void answerBtn_Click(object sender, EventArgs e)
        {
            if (CityCb.Text == OrszagFovaros[randomOrszagIndex].Fovaros)
            {
                pontszam++;
            }
            kerdesekszama++;

            CityCb.Text = "";
            Random rnd = new Random();
            randomOrszagIndex = rnd.Next(0, OrszagFovaros.Count);
            country.Text = OrszagFovaros[randomOrszagIndex].Orszag;

        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            if (CityCb.Text == OrszagFovaros[randomOrszagIndex].Fovaros)
            {
                pontszam++;
            }

            EredmenyekStrc ujJatekos = new EredmenyekStrc();
            ujJatekos.nev = nameTxt.Text;
            ujJatekos.elertpont = pontszam;
            ujJatekos.kerdesszam = kerdesekszama;
            Eredmenyek.Add(ujJatekos);


            StreamWriter irocsatorna = new StreamWriter("eredmenyek.txt");

            if (Eredmenyek.Count > 0)
            {
                for (int i = 0; i < Eredmenyek.Count(); i++)
                {
                    irocsatorna.WriteLine(Eredmenyek[i].nev + ";" + Eredmenyek[i].elertpont + ";" + Eredmenyek[i].kerdesszam);
                }
            }

            irocsatorna.Close();

            nameTxt.Text = "";
            titleLbl.Text = "Ki tudod találni a fővárost ?";
            label2.Text = "Add meg a felhasználó neved:";

            label2.Visible = true;
            label2.Enabled = true;

            jatekStartBtn.Visible = true;
            leaderBoardBtn.Visible = true;
            rulesBtn.Visible = true;
            nameTxt.Visible = true;

            jatekStartBtn.Enabled = true;
            leaderBoardBtn.Enabled = true;
            rulesBtn.Enabled = true;
            nameTxt.Enabled = true;

            country.Visible = false;
            country.Enabled = false;
            CityCb.Visible = false;
            CityCb.Enabled = false;
            answerBtn.Visible = false;
            answerBtn.Enabled = false;
            endBtn.Visible = false;
            endBtn.Enabled = false;

        }
    }
}
