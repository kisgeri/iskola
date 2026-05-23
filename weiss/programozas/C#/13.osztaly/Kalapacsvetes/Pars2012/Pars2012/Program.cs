using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012
{
    internal class Program
    {
        static List<Versenyző> adatok = new List<Versenyző>();
        static void Main(string[] args)
        {
            StreamReader olvasocsatorna = new StreamReader("Selejtezo2012.txt");
            string sor;
            sor = olvasocsatorna.ReadLine();

            while (!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();

                Versenyző adat = new Versenyző(sor);
                adatok.Add(adat);

            }

            olvasocsatorna.Close();

            feladat1();
            feladat2();
            feladat9();
            feladat10();

            Console.ReadKey();
        }

        private static void feladat10()
        {
            StreamWriter irocsatorna = new StreamWriter("Dontos2012.txt");
            irocsatorna.WriteLine("Helyezés;Név;Csoport;Nemzet;NemzetKód;Sorozat;Eredmény");

            for (int i = 0; i < 12; i++)
            {
                Versenyző legjobb = adatok[0];

                for (int j = 0; j < adatok.Count; j++)
                {
                    if (legjobb.Eredmeny() < adatok[j].Eredmeny())
                    {
                        legjobb = adatok[j];
                    }

                }
                irocsatorna.WriteLine($"{i+1};{legjobb.nev};{legjobb.csoport};{legjobb.Nemzet()};{legjobb.Kod()};{legjobb.d1};{legjobb.d2};{legjobb.d3};{legjobb.Eredmeny()}");
                adatok.Remove(legjobb);

            }

            irocsatorna.Close();
        }

        private static void feladat9()
        {
            Versenyző legjobb = adatok[0];
            
            for (int i = 0; i < adatok.Count; i++)
            {
                if (legjobb.Eredmeny() < adatok[i].Eredmeny())
                {
                    legjobb = adatok[i];
                }
            }

            Console.WriteLine("9. feladat: A selejtező nyertese:");
            Console.WriteLine("\t Név: "+legjobb.nev);
            Console.WriteLine("\t Csoport: "+legjobb.csoport);
            Console.WriteLine("\t Nemzet: "+legjobb.Nemzet());
            Console.WriteLine("\t Nemzet kód:"+legjobb.Kod());
            Console.WriteLine($"\t Sorozat: {legjobb.d1};{legjobb.d2};{legjobb.d3}");
            Console.WriteLine("\t Eredmény: "+ legjobb.Eredmeny());
        }

        private static void feladat2()
        {
            int biztos_tovab = 0;

            //itt valszeg forech kelett volna de azt nem teljesen értem
            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].d1 > 78 || adatok[i].d2 > 78)
                {
                    biztos_tovab++;
                }
            }

            Console.WriteLine($"6. feladat: 78,00 méter feletti eredménnyel továbbjutott: {biztos_tovab} fő");
        }

        private static void feladat1()
        {
            Console.WriteLine($"5. feladat: Versenyzők száma a selejtezőben: {adatok.Count} fő");
        }
    }
}
