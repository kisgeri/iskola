using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ultrabalaton
{
    /*
     39
         */
    class Program
    {
        //2. Feladat struktúra fájl tárolás
        struct BalatonStruktura
        {
            public string Versenyzo;
            public int Rajtszam;
            public string Kategoria;
            public string Versenyido;
            public int TavSzazalek;
        }
        static void Main(string[] args)
        {
            feladatok();
            Console.ReadKey();
        }

        private static void feladatok()
        {
            StreamReader olvasocsatorna = new StreamReader(@"D:\Ultrabalaton\Ultrabalaton\Ultrabalaton\Ultrabalaton\ub2017egyeni.txt");

            string elsosor = olvasocsatorna.ReadLine();
            string sorok;

            List<BalatonStruktura> versenyzok = new List<BalatonStruktura>();
            string[] darabol;

            while (!olvasocsatorna.EndOfStream)
            {
                sorok = olvasocsatorna.ReadLine();
                darabol = sorok.Split(';');

                BalatonStruktura balaton = new BalatonStruktura();

                balaton.Versenyzo = darabol[0];
                balaton.Rajtszam = int.Parse(darabol[1]);
                balaton.Kategoria = darabol[2];
                balaton.Versenyido = darabol[3];
                balaton.TavSzazalek = int.Parse(darabol[4]);

                versenyzok.Add(balaton);
            }

            
            Console.WriteLine("3. Feladat: Egyéni indulók: {0} fő", versenyzok.Count());

            
            int teljesito_nok_szama = 0;
            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzok[i].Kategoria.ToLower() == "noi" && versenyzok[i].TavSzazalek == 100)
                {
                    teljesito_nok_szama++;
                }
            }
            Console.WriteLine("\n4. Feladat: Célba érkező női sportolók: {0} fő", teljesito_nok_szama);

            
            Console.Write("\n5. Feladat: Kérem a sportoló nevét: ");
            string versenyzo_nev = Console.ReadLine();
            bool indult = false;
            bool teljesitete = false;
            //while legyen
            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzo_nev.ToLower() == versenyzok[i].Versenyzo.ToLower())
                {
                    indult = true;
                }
                if (versenyzo_nev == versenyzok[i].Versenyzo && versenyzok[i].TavSzazalek == 100)
                {
                    teljesitete = true;
                }
            }

            if (indult == true)
            {
                Console.WriteLine("\tIndult egyéniben a sportoló? Igen");
                if (teljesitete == true)
                {
                    Console.WriteLine("\tTeljesítette a teljes távot? Igen");
                }
                else
                {
                    Console.WriteLine("\tTeljesítette a teljes távot? Nem");
                }
            }
            else
            {
                Console.WriteLine("\tIndult egyéniben a sportoló? Nem");
            }

            
            double oszes_ido = 0;
            int ferfiak_szama = 0;

            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzok[i].Kategoria.ToLower() == "ferfi" && versenyzok[i].TavSzazalek == 100)
                {
                    oszes_ido += IdoOraban(versenyzok[i].Versenyido);
                    ferfiak_szama += 1;
                }
            }
            Console.WriteLine("\n7. Feladat: Átlagos idő: {0} óra", oszes_ido / ferfiak_szama);

            
            Console.WriteLine("\n8. Feladat: Verseny győztesei");

            double noi_legjobb_ido = double.MaxValue;
            double ferfi_legjobb_ido = double.MaxValue;
            double aktualis_ido;

            string noi_gyoztes_adatok = "";
            string ferfi_gyoztes_adatok = "";

            for (int i = 0; i < versenyzok.Count(); i++)
            {
                if (versenyzok[i].TavSzazalek == 100)
                {
                    aktualis_ido = IdoOraban(versenyzok[i].Versenyido);
                    if (versenyzok[i].Kategoria.ToLower() == "noi" && aktualis_ido < noi_legjobb_ido)
                    {
                        noi_legjobb_ido = aktualis_ido;
                        noi_gyoztes_adatok = $"\tNők: {versenyzok[i].Versenyzo} ({versenyzok[i].Rajtszam}.) - {versenyzok[i].Versenyido}";
                    }
                    if (versenyzok[i].Kategoria.ToLower() == "ferfi" && aktualis_ido < ferfi_legjobb_ido)
                    {
                        ferfi_legjobb_ido = aktualis_ido;
                        ferfi_gyoztes_adatok = $"\n\tFérfiak: {versenyzok[i].Versenyzo} ({versenyzok[i].Rajtszam}.) - {versenyzok[i].Versenyido}";
                    }
                }
            }

            Console.WriteLine(noi_gyoztes_adatok+ ferfi_gyoztes_adatok);
        }

        // 6. Feladathoz
        static double IdoOraban(string verseny_ido)
        {
            string[] ido_darabol = verseny_ido.Split(':');
            double ora = double.Parse(ido_darabol[0]);
            double perc = double.Parse(ido_darabol[1]);
            double masodperc = double.Parse(ido_darabol[2]);

            return ora + (perc / 60.0) + (masodperc / 3600.0);
        }
    }
}
