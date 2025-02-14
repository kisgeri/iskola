using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hatultesztelö
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hátúltesztelő ciklus\n");
            /*
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
            */
            /*+ doga tan (const nem lehet változtatni az értékét)
             és date time 
             */

            DateTime idomost = DateTime.Now;
            Console.WriteLine(idomost);
            //vagy
            string idomostki = idomost.ToString("yyyy.MM.dd");
            Console.WriteLine(idomostki);
            Console.WriteLine();
            Console.ReadKey();
            /*
             assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(év, hónap, nap, óra, perc, másodperc, időzóna pl.:(DateTimeKind.Utc));
             */
            DateTime ido = new DateTime(2016, 12, 31);
            DateTime ido2 = new DateTime(2006, 12, 31);
            /*time spanel tudunk az időhöz hozá adni és ki vonni az allábi formába
             (nem muszály mind az 5 mezőt ki tölteni)
             TimeSpan eltel = new TimeSpan(nap, óra, perc, másodperc, tized másod perc);*/
            TimeSpan eltel = new TimeSpan(10, 0, 0, 0);//legalább négyet meg kell adni hogy nap legyen az el ső
            Console.WriteLine(ido + eltel);
            Console.WriteLine(ido - eltel);

            Console.WriteLine();
            Console.ReadKey();




        }

        private static void feladat01()
        {
            Console.WriteLine("1. POZITÍV SZÁM BEKÉRÉSE");
            int a;
            do
            {
                Console.Write("adj meg egy pozitív egész számott: ");
                a = int.Parse(Console.ReadLine());

            } 
            while (a <= 0); //amíg negatív vagy nulla addig kérdezi újra és újra
            Console.WriteLine("szám kétszere " + a*2);
        }

        private static void feladat02()
        {
            Console.WriteLine("2. SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR (1)");
            int a;
            a = 0;
            do
            {
                a = a + 1;
                Console.WriteLine(a+" jó reggelt");


            }
            while (a < 10);
        }

        private static void feladat03()
        {
            Console.WriteLine("3. SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR (2)");
            int b;
            b = 0;
            do
            {
                b = b + 1;
                Console.WriteLine("jó reggelt " + (10-b) );
               

            }
            while (b < 10);


            Console.WriteLine("3b. SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR (2)");
            int a;
            a = 9;
            do
            {
                
                Console.WriteLine( "jó reggelt "+a + " van hátra");
                a = a - 1;

            }
            while (a > -1);
        }

        private static void feladat04()
        {
            Console.WriteLine("4. ADATBEKÉRÉS VÉGJELIG");
            int a;
            do
            {
                Console.Write("adj meg egész számokat ha nem akarsz többet írj be nullát: ");
                a = int.Parse(Console.ReadLine());

            }
            while (a != 0);
        }

        private static void feladat05()
        {
            Console.WriteLine("5. VOLT-E PÁROS");
            int a;
            bool vegevane;
            vegevane = false;
            bool paros;
            paros = false;
            do
            {
                Console.Write("adj meg egész számokat ha nem akarsz többet írj be nullát: ");
                a = int.Parse(Console.ReadLine());
                if (a != 0) /*a kilépési 0-át nem számoljuk párosnak*/
            {
                vegevane = false;
                    paros = false;
                }
                else if (a % 2 == 0)
                {
                    paros = true;
                }

            }
            while (vegevane == false);
            if (paros == true)
            {
                Console.WriteLine("volt páros szám");
            }
        }

        private static void feladat06()
        {
            Console.WriteLine("6. KILÉPÉSI JELSZÓ");
            string a;
            do
            {
                Console.Write("Kérem a kilépési jelszót!: ");
                a = Console.ReadLine();


            }
            while (a != "vége");
            Console.WriteLine("Rendben!");

        }

        private static void feladat07()
        {
            Console.WriteLine("7. EGÉSZ SZÁM BEKÉRÉSE");
            double a;
            do
            {
                Console.Write("Adj meg egy egész számott: ");
                a = double.Parse(Console.ReadLine());
                if (a % 1 != 0)
                {
                    Console.WriteLine("hiba nem egész számott adtál meg");
                }


            }
            while (a % 1 != 0);
            Console.WriteLine("Rendben!");

            Console.WriteLine("--------------------------------------------------------------------------------------------");

            Console.WriteLine("7b. EGÉSZ SZÁM BEKÉRÉSE(hiba kezelés)");
            int b2;
            bool siker;
            siker = false;
            do
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
            while (siker == false);
            Console.WriteLine("Rendben!");

        }

        private static void feladat08()
        {
            Console.WriteLine("8. ADOTT INTERVALLUMBA ESŐ EGÉSZ SZÁM BEKÉRÉSE");
            double a;
            bool bennevane;
            bennevane = false;
            do
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
                    bennevane = true;

                }




            }
            while (bennevane == false);
            Console.WriteLine("Rendben!");




            Console.WriteLine("8. ADOTT INTERVALLUMBA ESŐ EGÉSZ SZÁM BEKÉRÉSE");
            int a2;
            bool bennevane2;
            bennevane2 = false;

            do
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
            while (bennevane2 == false);
            Console.WriteLine("Rendben!");

        }
    }
}
