using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciklus_ciklusba
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EGYMÁSBA ÁGYAZOTT CIKLUSOK\n\n\n");
            /*
            feladat01();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat02();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat03();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            
            feladat04();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat05();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat06();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            

            feladat07();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            
            feladat08();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            
            feladat09();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat10();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            
            feladat11();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat12();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            
            feladat13();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            
            feladat14();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            */
            

            feladat15();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat16();
            Console.ReadKey();
            Console.WriteLine("\n\n");

            feladat17();
            Console.ReadKey();
            Console.WriteLine("\n\n");
        }

        private static void feladat01()
        {
            Console.WriteLine("1.feladat CSILLAGOK:\n");
            int a;
            Console.Write("Ad meg menyi csilagot akarsz látni: ");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                Console.Write("*");
            }
        }

        private static void feladat02()
        {
            Console.WriteLine("2.feladat CSILLAGNÉGYZET:\n");

            int a;
            Console.Write("Ad meg menyi csilagot akarsz látni: ");
            a = int.Parse(Console.ReadLine());

            for (int i = 1; i <= a; i++)
            {
                for (int i2 = 1; i2 <= a; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void feladat03()
        {
            Console.WriteLine("3.feladat CSÖKKENŐ SZÁMSOROZAT:\n");

            int n;
            Console.Write("Ad meg N értékét: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = n; i >= 0; i--)
            {
                Console.Write(i+" ");
            }
        }

        private static void feladat04()
        {
            Console.WriteLine("4.feladat XO PROGRAM:\n");

            int n;
            Console.Write("Ad meg N értékét: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("XO");
            }
            Console.WriteLine();
        }

        private static void feladat05()
        {
            Console.WriteLine("5.feladat XO-OX:\n");

            int n;
            Console.Write("Ad meg N értékét: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("XO");
            }
            Console.WriteLine();
            for (int i = 1; i <= n; i++)
            {
                Console.Write("OX");
            }
            Console.WriteLine();
        }

        private static void feladat06()
        {
            Console.WriteLine("6.feladat XO-OX N-SZER:\n");

            int n;
            Console.Write("Ad meg N értékét: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int i2 = 1; i2 <= n; i2++)
                {
                    Console.Write("XO");
                }
                Console.WriteLine();
                for (int i3 = 1; i3 <= n; i3++)
                {
                    Console.Write("OX");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }

        private static void feladat07()
        {
            Console.WriteLine("7.feladat N SZÁM ÖSSZEGE:\n");
            Console.Write("Ad meg N értékét: ");
            int db;
            int összeg;
            int szam;
            összeg = 0;

            db = int.Parse(Console.ReadLine());

            for (int i = 1; i <= db; i = i + 1)
            {
                Console.Write("Adj meg egy pozitív egész számott: ");
                szam = int.Parse(Console.ReadLine());
                összeg = összeg + szam;
            }
            Console.WriteLine();
            Console.WriteLine("a szám összege "+ összeg);
        }

        private static void feladat08()
        {
            Console.WriteLine("8.feladat N FAKTORIÁLIS:\n");
            Console.Write("Ad meg N értékét: ");
            int n;
            int b;

            n = int.Parse(Console.ReadLine());
            b = n;
            for (int i = n-1; i >= 1; i = i - 1)
            {
                b = b * i;
            }
            Console.WriteLine();
            Console.WriteLine(n+"!= " + b);
        }

        private static void feladat09()
        {
            Console.WriteLine("9.feladat ÖSSZEG N-IG:\n");
            Console.Write("Ad meg N értékét: ");
            int n;
            int b;

            n = int.Parse(Console.ReadLine());
            b = 0;

            for (int i = 0; i <= n; i = i + 1)
            {
                b = b + i;
            }
            Console.WriteLine();
            Console.WriteLine("Az első "+n+" természetes szám összege " + b);
        }

        private static void feladat10()
        {
            Console.WriteLine("10.feladat PÁROS SZÁMOK ÖSSZEGE N-IG:\n");
            Console.Write("Ad meg N értékét: ");
            int n;
            int b;

            n = int.Parse(Console.ReadLine());
            b = 0;

            for (int i = 2; i <= n; i = i + 2)
            {
                b = b + i;
            }
            Console.WriteLine();
            Console.WriteLine("A páros számok összege " + n + "-ig = " + b);
        }

        private static void feladat11()
        {
            Console.WriteLine("11.feladat PÁRATLAN SZÁMOK ÖSSZEGE N-IG:\n");
            Console.Write("Ad meg N értékét: ");
            int n;
            int b;

            n = int.Parse(Console.ReadLine());
            b = 0;

            for (int i = 1; i <= n; i = i + 2)
            {
                b = b + i;
            }
            Console.WriteLine();
            Console.WriteLine("A páratlan számok összege " + n + "-ig = " + b);
        }

        private static void feladat12()
        {
            Console.WriteLine("12.feladat K·(K+1) PROGRAM:\n");
            Console.Write("Ad meg k értékét: ");
            int k;
            int b;
            int c;

            k = int.Parse(Console.ReadLine());
            b = 0;
            c = 0;

            for (int i = 1; i <= k; i = i + 1)
            {
                b = i * (i+1);
                c = c + b;
            }
            Console.WriteLine();
            Console.WriteLine("A A kiszámolt összeg " + k + "-ig = " + c);
        }

        private static void feladat13()
        {
            Console.WriteLine("13.feladat M X N CSILLAG\n");

            int a;
            Console.Write("Ad meg menyi csilagot akarsz látni egy sorba: ");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.Write("ad meg mennyi sort akarsz látni: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= b; i++)
            {
                for (int i2 = 1; i2 <= a; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void feladat14()
        {
            Console.WriteLine("14.feladatM PARALELOGRAMMA\n");

            int a;
            Console.Write("Ad meg menyi csilagot akarsz látni egy sorba: ");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.Write("ad meg mennyi sort akarsz látni: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();



            for (int i = 1; i <= b; i++)

            { /*
               * ez nem jó:
                for (int i3 = a; i3 >= 1; i3--)
                {
                    Console.Write(" ");
                }
                */
                for (int i3 = 1; i3 <= b - i; i3++)
                {
                    Console.Write(" ");
                }

                for (int i2 = 1; i2 <= a; i2++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }

        private static void feladat15()
        {
            Console.WriteLine("15.feladat HÁROMSZÖG:\n");

            int a;
            Console.Write("Ad meg menyi csilagot akarsz látni: ");
            a = int.Parse(Console.ReadLine());

            for (int i = 0; i <= a-1; i++)
            {
                for (int i3 = 0; i3 <= a - i; i3++)
                {
                    Console.Write(" ");
                }

                for (int i2 = 0; i2 <= i*2; i2=i2+1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void feladat16()
        {
            Console.WriteLine("16.feladat  FORDÍTOTT HÁROMSZÖG:\n");

            int a;
            Console.Write("Ad meg menyi csilagot akarsz látni: ");
            a = int.Parse(Console.ReadLine());

            for (int i = a - 1; i >= 0; i--)
            {
                for (int i3 = a - i; i3 >= 0; i3--)
                {
                    Console.Write(" ");
                }

                for (int i2 = (i * 2); i2 >=0; i2 = i2 - 1)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        private static void feladat17()
        {
            Console.WriteLine("17.feladat ÜRES TÉGLALAP\n");

            int a;
            Console.Write("Ad meg menyi csilagot akarsz látni egy sorban: ");
            a = int.Parse(Console.ReadLine());

            int b;
            Console.Write("ad meg mennyi sort akarsz látni: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine();



            for (int i = 0; i <= b-1; i++)
            {
                if(i == 0 || i==b-1)
                {
                    for (int i2 = 1; i2 <= a + 2; i2++)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    for (int i2 = 1; i2 <= a + 2; i2++)
                    {
                        if (i2 == 1 || i2 == a + 2)
                        { Console.Write("*"); }
                        else
                        { Console.Write(" "); }
                        
                    }
                }


                Console.WriteLine();
            }

        }


    }
}
