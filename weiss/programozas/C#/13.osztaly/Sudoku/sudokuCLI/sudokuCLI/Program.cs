using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace sudokuCLI
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = Convert.ToInt32(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            feladat3();



            Console.ReadKey();
        }


        private static void feladat3()
        {
            /*fasza fájl be olvasás
             nyomj jobb oldalt a fajloknál jobb klikett.
             ott add item azon belül add exsisting item.
             és kiválasztod a fájlt.
             utána rá nyomsz a fájlra és propertinél benyomod a never copyt, always copy ra*/
            StreamReader olvasoCsatorna = new StreamReader("feladvanyok.txt");

            string sor;
            List<string> feladatok = new List<string>();
            int darabszam = 0;


            while (!olvasoCsatorna.EndOfStream)
            {

                sor = olvasoCsatorna.ReadLine();

                feladatok.Add(sor);
                darabszam++;
            }

            Console.WriteLine("3. feladat: Beolvasva {0} feladvány\n", darabszam );

            int intervalum = 0;

            while (intervalum < 4 || intervalum > 9)
            {
                Console.Write("4. feladat: Kérem a feladvány méretét [4..9]: ");
                intervalum = int.Parse(Console.ReadLine());
                
            }

            List<string> megfelelok = new List<string>();
            StreamWriter irocsatorna = new StreamWriter("sudoku4.txt");

            int intervaolumDarab = 0;
            for (int i = 0; i <= feladatok.Count-1; i++)
            {
                
                if(feladatok[i].Length == intervalum * intervalum)
                {
                    megfelelok.Add(feladatok[i]);
                    irocsatorna.WriteLine(feladatok[i]);
                    intervaolumDarab++;

                }
            }

            irocsatorna.Close();

            

            

            Console.WriteLine("{0}x{0} méretű feladványból {1} darab van tárolva", intervalum, intervaolumDarab);
            Console.WriteLine();

            Random rnd = new Random();
            string kivalasztott = megfelelok[rnd.Next(0, megfelelok.Count)];

            Console.WriteLine("5. feladat: A kiválasztott feladvány: \n{0}\n", kivalasztott);

            double kitoltott = 0;


            for(int i = 0; i <= kivalasztott.Length-1; i++)
            {
                if(kivalasztott[i] != '0')
                {
                    kitoltott++;
                }
            }
            double szazalek = (kitoltott / kivalasztott.Length) *100;

            Console.WriteLine("6. feladat: A feladvány kitöltöttsége: {0}%\n", Math.Round(szazalek,1));

            Console.WriteLine("7. feladat: A feladvány kirajzolva:");

            for (int i = 0; i < kivalasztott.Length; i++)
            {
                if (kivalasztott[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(kivalasztott[i]);
                }
                if (i % intervalum == intervalum - 1)
                {
                    Console.WriteLine();
                }
            }

            Console.WriteLine("\n8. feladat: sudoku4.txt állomány {0} darab feladvánnyal létrehozva", intervaolumDarab);
        }
    }
}
