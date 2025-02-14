using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamkitalalos
{
    class Program
    {
        static void Main(string[] args)
        {
            szamkitalalas();
            Console.ReadKey();
        }

        private static void szamkitalalas()
        {
            Console.WriteLine("Találd ki a számott!(segítség: A szám 1 és 10 között lehett)\n");

            Random rnd = new Random();
            int szam = rnd.Next(1,11);
            int tip;
            Console.WriteLine(szam);

            do
            {
                Console.Write("ide írhatod a tipped: ");
                tip = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if(tip != szam)
                {
                    Console.WriteLine("Nem találtad ki a számott :(");

                    if(tip < szam)
                    {
                        Console.WriteLine("A tipp kisebb mint a gondolt szám\n");
                    }
                    else if(tip > szam)
                    {
                        Console.WriteLine("A tipp nagyobb mint a gondolt szám\n");
                    }
                }

            }
            while (tip != szam);

            Console.WriteLine("Ki találtad a gondolt számott :D\n");

            Console.WriteLine("Ez a játék vége köszönöm\n");

            Console.WriteLine();
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "-------------------".Length / 2) + "}", "-------------------");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#K#~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#####~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~##I##~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#######~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~###S###~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#########~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#####G#####~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|>>>>>>>>>#Kis Gergely#<<<<<<<<<|".Length / 2) + "}", "|~~~~~~~~~######E######~~~~~~~~~|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#####R#####~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~####G####~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#######~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~###E###~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#####~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~##L##~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#Y#~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "-------------------".Length / 2) + "}", "-------------------");
            Console.WriteLine();

        }
    }
}
