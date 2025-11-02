using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes
{
    public class Sportolo
    {
        public string Helyezes { get; set; }
        public double Eredmeny { get; set; }
        public string Nev { get; set; }
        public string Orszag { get; set; }
        public string Helyszin { get; set; }
        public string Datum { get; set; }
        
        public Sportolo(string sor)
        {
            string[] reszek = sor.Split(';');
            Helyezes = reszek[0];
            Eredmeny = Convert.ToDouble(reszek[1]);
            Nev = reszek[2];
            Orszag = reszek[3];
            Helyszin = reszek[4];
            Datum = reszek[5];
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Sportolo> lista = new List<Sportolo>();
            StreamReader sr = new StreamReader("kalapacsvetes.txt");
            string elsosor = sr.ReadLine();
            while (!sr.EndOfStream)
            {
                Sportolo sor = new Sportolo(sr.ReadLine());
                lista.Add(sor);
            }
            sr.Close();

            //4. feladat
            Console.WriteLine($"4. feladat: {lista.Count} dobás eredménye található.");
            Console.ReadKey();
        }
    }
}
