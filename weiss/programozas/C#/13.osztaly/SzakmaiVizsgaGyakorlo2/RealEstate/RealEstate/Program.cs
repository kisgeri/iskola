using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RealEstate
{
    internal class Program
    {
        static List<hirdetesek> adatok = new List<hirdetesek>();
        static void Main(string[] args)
        {
            olvasas();

            Console.ReadKey();
        }

        private static void olvasas()
        {
            StreamReader olvasocsatorna = new StreamReader("realestates.csv");
            string sor = olvasocsatorna.ReadLine();

            while(!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();

                hirdetesek adat = new hirdetesek(sor);
                adatok.Add(adat);
            }

            Console.WriteLine($"{adatok[0].nev};{adatok[0].telefonSzam};{adatok[0].kategoria};{adatok[0].szobak};{adatok[0].alapterulet};{adatok[0].emelet};");
        }
    }
}
