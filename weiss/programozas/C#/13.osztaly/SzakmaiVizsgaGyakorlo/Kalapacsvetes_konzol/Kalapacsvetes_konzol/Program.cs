using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kalapacsvetes_konzol
{
    internal class Program
    {
        static List<Sportolo> adatok = new List<Sportolo>();
        static void Main(string[] args)
        {
            olvasas();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();

            Console.ReadKey();
        }

        private static void feladat8()
        {
            StreamWriter irocsatorna = new StreamWriter("magyarok.txt");

            for (int i = 0; i < adatok.Count; i++)
            {

                if (adatok[i].orszagkod == "HUN")
                {
                    irocsatorna.WriteLine(adatok[i].eredmeny);
                }

            }

            irocsatorna.Close();
        }

        private static void feladat7()
        {
            List<string> nemzetek = new List<string>();

            nemzetek.Add(adatok[0].orszagkod);

            for (int i = 1; i < adatok.Count; i++)
            {
                bool bennevan = false;

                int j = 0;
                while (!bennevan && j < nemzetek.Count)
                {
                    if (nemzetek[j] == adatok[i].orszagkod)
                    {
                        bennevan |= true;
                    }
                    j++;
                }
                if (!bennevan)
                {
                    nemzetek.Add(adatok[i].orszagkod);
                }

            }

            Console.WriteLine($"7. feladat: Statisztika");

            
            for (int i = 0; i < nemzetek.Count; i++)
            {
                int darab = 0;
                for (int j = 0; j < adatok.Count; j++)
                {
                    if (nemzetek[i] == adatok[j].orszagkod)
                    {
                        darab++;
                    }
                }
                Console.WriteLine($"\t {nemzetek[i]} - {darab} dobás");
            }
        }

        private static void feladat6()
        {
            List<Sportolo> dobasok = new List<Sportolo>();

            Console.WriteLine($"6. feladat: Adjon meg egy évszámot:");

            string evszam = Console.ReadLine();

            for (int i = 0; i < adatok.Count; i++)
            {
                string[] darabol = adatok[i].datum.Split('.');
                string ev = darabol[0];

                if (ev == evszam)
                {
                    dobasok.Add(adatok[i]);
                }

            }

            if(dobasok.Count > 0)
            {
                Console.WriteLine($"\t{dobasok.Count} darab dobás került be ebben az évben");
                for (int i = 0; i < dobasok.Count; i++)
                {
                    Console.WriteLine("\t" + dobasok[i].nev);
                }
            }
            else
            {
                Console.WriteLine("Egy dobás sem került be ebben az évben");
            }
            

        }

        private static void feladat5()
        {
            double atlag = 0;

            double hunDarab = 0;
            double hunossz = 0;

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].orszagkod == "HUN")
                {
                    hunossz += adatok[i].eredmeny;
                    hunDarab++;
                }

            }

            atlag = hunossz / hunDarab;

            //ez LINQ adatbázis szerü le kérés
            /*
            double magyaratlag =
                (from adat in adatok
                 where adat.orszagkod == "HUN"
                 select adat.eredmeny).Average();
                 */

            Console.WriteLine($"5. feladat: A magyar sportolók átlagosan {atlag} métert dobtak.");
        }

        private static void feladat4()
        {
            Console.WriteLine($"4. feladat: {adatok.Count} dobás eredménye található.");
        }

        private static void olvasas()
        {
            StreamReader olvasocstorna = new StreamReader("kalapacsvetes.txt");
            string sor = olvasocstorna.ReadLine();

            while (!olvasocstorna.EndOfStream)
            {
                sor = olvasocstorna.ReadLine();
                Sportolo adat = new Sportolo(sor);
                adatok.Add(adat);
            }

            olvasocstorna.Close();
        }
    }
}
