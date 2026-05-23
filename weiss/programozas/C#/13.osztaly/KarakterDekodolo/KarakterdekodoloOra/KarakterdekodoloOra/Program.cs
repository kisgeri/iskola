using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KarakterdekodoloOra
{
    internal class Program
    {
        static List<Karakter> adatok = new List<Karakter>();
        static List<Karakter> szavak = new List<Karakter>();
        static string be;
        static void Main(string[] args)
        {
            adatbeolvasa();
            feladat6();
            feladat7();
            felafat8();
            feladat9();



            Console.ReadKey();
        }

        private static void feladat9()
        {
            Console.WriteLine("9.feladatt dekódolás");

            
            foreach (var szo in szavak)
            {
                int i = 0;
                while (i < adatok.Count && !Karakter.Felismer(adatok[i], szo))
                {
                    i++;
                }

                if (i<adatok.Count)
                {
                    //talált egyezést
                    Console.Write(adatok[i].karakter);
                }
                else
                {
                    Console.Write("?");
                }

            }
        }

        private static void felafat8()
        {
            Console.WriteLine(  );
            StreamReader olvasocsatorna = new StreamReader("dekodol.txt");
            string matrix;
            string karakter;
            string sor;

            while (!olvasocsatorna.EndOfStream)
            {
                matrix = "";
                karakter = olvasocsatorna.ReadLine();


                for (int i = 0; i < 7; i++)
                {
                    sor = olvasocsatorna.ReadLine();
                    matrix += sor;
                }

                Karakter szo = new Karakter(karakter, matrix);
                szavak.Add(szo);

            }

            olvasocsatorna.Close();

            foreach (var szo in szavak)
            {
                Console.WriteLine(szo.karakter + " " + szo.matrix);
            }

        }

        private static void feladat7()
        {
            Console.WriteLine("7. feladat");

            bool van_e = false;
            int i = 0;

            while (!van_e && i < adatok.Count)
            {
                if (be == adatok[i].karakter)
                {
                    Karakter.kiir(adatok[i]);
                    van_e = true;
                }

                i++;
            }

            if (!van_e)
            {
                Console.WriteLine("nincs ilyen karakter a bankban");
            }

        }

        private static void feladat6()
        {
            Console.WriteLine("6. feladat");
            List<string> abc = new List<string>();
            for (char i = 'A'; i <= 'Z'; i++)
            {
                abc.Add(i.ToString());
            }

            while (!abc.Contains(be))
            {
                Console.Write("Adj meg egy angol nagybetűt: ");
                be = Console.ReadLine();
            }


        }

        private static void adatbeolvasa()
        {
            Console.WriteLine("fajlbeolvasas");

            StreamReader olvasocsatorna = new StreamReader("bank.txt");
            string matrix;
            string karakter;
            string sor;

            while(!olvasocsatorna.EndOfStream)
            {
                matrix = "";
                karakter = olvasocsatorna.ReadLine();
                

                for (int i = 0; i < 7; i++)
                {
                    sor = olvasocsatorna.ReadLine();
                    matrix += sor;
                }

                Karakter adat = new Karakter(karakter,matrix);
                adatok.Add(adat);
                
            }

            olvasocsatorna.Close();

            Console.WriteLine($"5. feladat: Karakterek száma: {adatok.Count}");

            





            foreach (var adat in adatok)
            {
                Console.WriteLine(adat.karakter + " "+ adat.matrix);
            }
        }
    }
}
