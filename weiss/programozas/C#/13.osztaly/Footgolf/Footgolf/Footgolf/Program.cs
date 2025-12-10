using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Footgolf
{
    class Program
    {
     //1.feladat
        struct footgolfstruct
        {
            public string nev;
            public string kategoria;
            public string egyesulett;

            //public static List<int> pontok = new List<int>();

            public byte[] pontok;

        }

        static List<footgolfstruct> versenyzok = new List<footgolfstruct>();
        static void Main(string[] args)
        {
            feladat2();
            feladat3();
            feladat4();
            
            feladat6();
            feladat7();
            feladat8();

            Console.ReadKey();
        }

        private static void feladat2()
        {
            StreamReader fajlolvaso = new StreamReader(@"fob2016.txt");

            string sor;
            int sorok_szama=0;
            string[] darabok;

            while (!fajlolvaso.EndOfStream && sorok_szama!=500)
            {
                sor = fajlolvaso.ReadLine();
                darabok = sor.Split(';');

                footgolfstruct adatok = new footgolfstruct();

                adatok.nev = darabok[0];
                adatok.kategoria = darabok[1];
                adatok.egyesulett = darabok[2];

                adatok.pontok = new byte[8];

                for(int i = 0; i<adatok.pontok.Length;i++)
                {
                    adatok.pontok[i] = Convert.ToByte(darabok[i+3]);
                    
                }

                versenyzok.Add(adatok);

                sorok_szama++;
            }
        }

        private static void feladat3()
        {

            Console.WriteLine("3. feladat: Versenyzők száma: "+ versenyzok.Count);
        }

        private static void feladat4()
        {
            double noi_versenyzok_szama = 0;
            double noi_versenyzok_aranya;

            for(int i = 0; i<versenyzok.Count();i++)
            {
                if(versenyzok[i].kategoria == "Noi")
                {
                    noi_versenyzok_szama++;
                }

            }

            noi_versenyzok_aranya = Math.Round((noi_versenyzok_szama / versenyzok.Count())*100,2);


            Console.WriteLine("4. feladat: A női versenyzők aránya: {0}%", noi_versenyzok_aranya);
        }

        //feladat 5
        static int osszpont_szamito(byte[] pontszamok)
        {
            int osszpont = 0;
            int legkisebb = pontszamok[0];
            int masodik_legkisebb = pontszamok[1];
            int legkisebb_index = 0;
            int masodik_legkisebb_index = 1;

            for (int i = 1; i < pontszamok.Length; i++)
            {
                if (pontszamok[i] < legkisebb)
                {
                    masodik_legkisebb = legkisebb;
                    masodik_legkisebb_index = legkisebb_index;

                    legkisebb = pontszamok[i];
                    legkisebb_index = i;
                }
                else if (pontszamok[i] < masodik_legkisebb)
                {
                    masodik_legkisebb = pontszamok[i];
                    masodik_legkisebb_index = i;
                }
            }

            if (pontszamok[legkisebb_index]!=0)
            {
                pontszamok[legkisebb_index] = 10;
            }

            if (pontszamok[masodik_legkisebb_index] != 0)
            {
                pontszamok[masodik_legkisebb_index] = 10;
            }

            for (int i = 0; i < pontszamok.Length; i++)
            {
                osszpont += pontszamok[i];
            }


                return osszpont;

        }

        private static void feladat6()
        {
            string nev = versenyzok[0].nev;
            string egyesulet = versenyzok[0].egyesulett;
            int legjobb_osszpont = osszpont_szamito(versenyzok[0].pontok);

            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (osszpont_szamito(versenyzok[i].pontok) > legjobb_osszpont && versenyzok[i].kategoria == "Noi")
                {
                    legjobb_osszpont = osszpont_szamito(versenyzok[i].pontok);
                    nev = versenyzok[i].nev;
                    egyesulet = versenyzok[i].egyesulett;
                }
            }

            Console.WriteLine($"6. Feladat: A bajnok női versenyző\n\tNév: {nev}\n\tEgyesület: {egyesulet}\n\tÖsszpont: {legjobb_osszpont}");
        }

        private static void feladat7()
        {
            StreamWriter irocsatorna = new StreamWriter("osszpontFF.txt");

            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzok[i].kategoria == "Felnott ferfi")
                {
                    irocsatorna.WriteLine($"{versenyzok[i].nev};{osszpont_szamito(versenyzok[i].pontok)}");
                }
            }

            irocsatorna.Close();
        }

        private static void feladat8()
        {
            List<string> egyesuletek = new List<string>();
            List<int> tagok_szama = new List<int>();
            bool uj_egyesulet = false;

            for (int i = 0; i < versenyzok.Count(); i++)
            {
                uj_egyesulet = true;

                for (int j = 0; j < egyesuletek.Count(); j++)
                {
                    if (versenyzok[i].egyesulett == egyesuletek[j] && versenyzok[i].egyesulett != "n.a.")
                    {
                        uj_egyesulet = false;
                        tagok_szama[j] += 1;
                    }
                }

                if (uj_egyesulet)
                {
                    egyesuletek.Add(versenyzok[i].egyesulett);
                    tagok_szama.Add(1);
                }
            }

            Console.WriteLine("8. Feladat: Egyesület statisztika");
            for (int i = 0; i < egyesuletek.Count(); i++)
            {
                if (tagok_szama[i] >= 3)
                {
                    Console.WriteLine($"\t{egyesuletek[i]} - {tagok_szama[i]} fő");
                }
            }
        }
    }
}
