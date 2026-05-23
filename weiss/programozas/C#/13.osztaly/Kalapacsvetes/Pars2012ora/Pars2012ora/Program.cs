using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012ora
{
    internal class Program
    {
        static List<Versenyzo> adatok = new List<Versenyzo>();
        static void Main(string[] args)
        {
            olvasas();
            Console.WriteLine($"5.feladat: Versenyzpk száma a selejtezőben: { adatok.Count} fő");
            feladat6();
            feladat9();
            feladat10();

            Console.ReadKey();
        }

        private static void feladat10()
        {
            Console.WriteLine("10. Feladat: fájlba írás");
            StreamWriter irocsatorna = new StreamWriter("Dontos2012.txt");
            irocsatorna.WriteLine("Helyezés;Név;Csoport;Nemzet;NemzetKód;Sorozat;Eredmény");
            /*for (int i = 0; i < 12; i++)
            {
                Versenyzo legjobb = adatok[0];
                foreach (var adat in adatok)
                {
                    if (legjobb.Eredmeny < adat.Eredmeny)
                    {
                        legjobb = adat;
                    }
                }

                irocsatorna.WriteLine($"{i+1};{legjobb.nev};{legjobb.csoport};{legjobb.Nemzet};{legjobb.Kod};{legjobb.sorozat};{legjobb.Eredmeny}");
                adatok.Remove(legjobb);
            }*/

            // ez ilyen jó cuc
            var rendezet_adatok = adatok.OrderByDescending(k => k.Eredmeny).Take(12).ToList();
            int i = 0;
            foreach (var adat in rendezet_adatok)
            {
                irocsatorna.WriteLine($"{i + 1};{adat.nev};{adat.csoport};{adat.Nemzet};{adat.Kod};{adat.sorozat};{adat.Eredmeny}");
                i++;
            }
            //a k aktuális ellem izé, a take miatt csak az első 12, a .ToList() listává teszi 

            //sql szerű
            var rendezet_adatok2 = 
                (from k in adatok
                 orderby k.Eredmeny descending
                 select k).Take(12).ToList();

            i = 0;
            foreach (var adat in rendezet_adatok2)
            {
                irocsatorna.WriteLine($"{i + 1};{adat.nev};{adat.csoport};{adat.Nemzet};{adat.Kod};{adat.sorozat};{adat.Eredmeny}");
                i++;
            }

            irocsatorna.Close();
        }

        private static void feladat9()
        {
            Versenyzo legjobb = adatok[0];

            foreach (var adat in adatok)
            {
                if (legjobb.Eredmeny < adat.Eredmeny)
                {
                    legjobb = adat;
                }
            }

            Console.WriteLine("9. feladat: A selejtező nyertese:");
            Console.WriteLine($"\t Név: {legjobb.nev}");
            Console.WriteLine($"\t Csoport: {legjobb.csoport}");
            Console.WriteLine($"\t Nemzet: {legjobb.Nemzet}");
            Console.WriteLine($"\t Nemzet kód: {legjobb.Kod}");
            Console.WriteLine($"\t Sorozat: {legjobb.sorozat}");
            Console.WriteLine($"\t Eredmény: {legjobb.Eredmeny}");
        }

        private static void feladat6()
        {
            int biztos_tovab=0;

            foreach (var adat in adatok)
            {
                if(adat.d1 > 78 || adat.d2 > 78)
                {
                    biztos_tovab++;
                }
            }

            Console.WriteLine($"6.feladat: 78,00 méter feletti eredménnyel továbbjutott: {biztos_tovab} fő");
        }

        private static void olvasas()
        {
            StreamReader olvasocsatotna = new StreamReader("Selejtezo2012.txt");
            string sor = olvasocsatotna.ReadLine();


            while (!olvasocsatotna.EndOfStream)
            {
                sor = olvasocsatotna.ReadLine();
                Versenyzo adat = new Versenyzo(sor);
                adatok.Add(adat);
            }

            olvasocsatotna.Close();

            /*foreach (var adat in adatok)
            {
                adat.kiir();
            }*/
        }
    }
}
