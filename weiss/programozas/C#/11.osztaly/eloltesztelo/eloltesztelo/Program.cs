using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eloltesztelo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            feladat01();
            Console.WriteLine();
            Console.ReadKey();

            feladat02();
            Console.WriteLine();
            Console.ReadKey();

            feladat03();
            Console.WriteLine();
            Console.ReadKey();

            feladat04();
            Console.WriteLine();
            Console.ReadKey();

            feladat05();
            Console.WriteLine();
            Console.ReadKey();

            feladat06();
            Console.WriteLine();
            Console.ReadKey();

            feladat07();
            Console.WriteLine();
            Console.ReadKey();

            feladat08();
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void feladat01()
        {

            Console.WriteLine("1. POZITÍV SZÁM BEKÉRÉSE");
            int a;
            a = 0;
            while (a <= 0)  //amíg negatív vagy nulla addig kérdezi újra és újra

           {
                Console.Write("adj meg egy pozitív egész számott: ");
                a = int.Parse(Console.ReadLine());

           }
  
            Console.WriteLine("szám kétszere " + a * 2);
        }

        private static void feladat02()
        {
            Console.WriteLine("2. SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR (1)");
            int a;
            a = 0;
            while (a < 10)
            {
                a = a + 1;
                Console.WriteLine(a + " jó reggelt");


            }
            
        }

        private static void feladat03()
        {
            Console.WriteLine("3. SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR (2)");
            int a;
            a = 0;
            while (a < 10)
            {
                a = a + 1;
                Console.WriteLine((10 - a) + " van hátra "+"jó reggelt ");


            }
        }

        private static void feladat04()
        {
            Console.WriteLine("4. ADATBEKÉRÉS VÉGJELIG");
            int a;
            a = 1;
            while (a != 0)
            {
                Console.Write("adj meg egész számokat ha nem akarsz többet írj be nullát: ");
                a = int.Parse(Console.ReadLine());

            }
        }

        private static void feladat05()
        {
            Console.WriteLine("5. VOLT-E PÁROS");
            int a;
            bool paros;
            paros = false;
            a = 1;
            while (a != 0)
            {
                Console.Write("adj meg egész számokat ha nem akarsz többet írj be nullát: ");
                a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    paros = true;
                }

            }
            if (paros == true)
            {
                Console.WriteLine("volt páros szám");
            }
        }

        private static void feladat06()
        {
            Console.WriteLine("6. KILÉPÉSI JELSZÓ");
            string a;
            a = "nem";
            while (a != "vége")
            {
                Console.Write("Kérem a kilépési jelszót!: ");
                a = Console.ReadLine();


            }
            Console.WriteLine("Rendben!");

        }

        private static void feladat07()
        {
            Console.WriteLine("7. EGÉSZ SZÁM BEKÉRÉSE");
            double a;
            a = 1.5;
            while (a % 1 != 0)
            {
                Console.Write("Adj meg egy egész számott: ");
                a = double.Parse(Console.ReadLine());
                if (a % 1 != 0)
                {
                    Console.WriteLine("hiba nem egész számott adtál meg");
                }


            }
            Console.WriteLine("Rendben!");

            Console.WriteLine("7b. EGÉSZ SZÁM BEKÉRÉSE(hiba kezelés)");
            int b2;
            bool siker;
            siker = false;
            while (siker == false)
            {
                Console.Write("Adj meg egy egész számott: ");
                if (int.TryParse(Console.ReadLine(), out b2))
                /*meg próbálja egész számra alakítani a bekért adatott
                 ha sikerül neki tovább megy ha nem sikerül újra kezdi*/
                {
                    siker = true;
                    Console.WriteLine("jó");
                }
                else
                {
                    Console.WriteLine("nem jó");
                }


            }
            
            Console.WriteLine("Rendben!");

        




    }

        private static void feladat08()
        {
            Console.WriteLine("8. ADOTT INTERVALLUMBA ESŐ EGÉSZ SZÁM BEKÉRÉSE");
            double a;
            a = 101.2;
            while (true)
            {
                Console.Write("Adj meg egy egész számott 0 és 100 között: ");
                a = double.Parse(Console.ReadLine());
                if (a % 1 != 0)
                {
                    Console.WriteLine("hiba nem egész számott adtál meg");
                }
                if (a < 0 || a > 100)
                {
                    Console.WriteLine("a szám nem 0 és száz között van");
                }

                if (a % 1 == 0 && a > 0 && a < 100)
                {
                    break;

                }


            }
            Console.WriteLine("Rendben!");



            Console.WriteLine("8. ADOTT INTERVALLUMBA ESŐ EGÉSZ SZÁM BEKÉRÉSE");
            int a2;
            bool bennevane2;
            bennevane2 = false;

            while (bennevane2 == false)
            {
                Console.Write("Adj meg egy egész számott 0 és 100 között: ");
                Console.Write("Adj meg egy egész számott: ");
                if (int.TryParse(Console.ReadLine(), out a2))
                {

                    if (a2 < 0 || a2 > 100)
                    {
                        Console.WriteLine("a szám nem 0 és száz között van");
                    }
                    else
                    {
                        bennevane2 = true;
                    }

                }
                else
                {
                    Console.WriteLine("hiba nem egész számott adtál meg");
                }






            }
            
            Console.WriteLine("Rendben!");

        }
    }
}

