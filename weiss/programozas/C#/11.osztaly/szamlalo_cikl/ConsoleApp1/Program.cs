using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
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
            Console.WriteLine("1.Feladat: SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR(1)\n");
            for (int i = 1; i < 101; i = i + 1)
            {
                Console.WriteLine("Szeretem az informatikát!");
            }

        }

        private static void feladat02()
        {
            Console.WriteLine("2.Feladat: SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR(2)\n");
            for (int i = 1; i < 11; i = i + 1)
            {
                Console.WriteLine(i+" Jó reggelt!");
            }

        }

        private static void feladat03()
        {
            Console.WriteLine("3.Feladat: SZÖVEG KIÍRATÁSA ADOTT SZÁMSZOR(3)\n");
            for (int i = 9; i >= 0; i = i - 1)
            {
                Console.WriteLine(i + " Jó reggelt!");
            }

        }

        private static void feladat04()
        {
            Console.WriteLine("4.Feladat: SZÁMOLÁS 50-150-IG\n");
            for (int i = 50; i <= 150; i = i + 1)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();

        }
        

        private static void feladat05()
        {
            Console.WriteLine("5.Feladat: SZÁMOLÁS 0-TÓL -50-IG\n");
            for (int i = 0; i >= -50; i = i - 1)
            {
                Console.Write(i+",");
            }
            Console.WriteLine();

        }

        private static void feladat06()
        {
            Console.WriteLine("6.Feladat: SZÁMTANI SOROZATOK\n");

            Console.Write("a., ");
            for (int i = 1; i <= 10; i = i + 1)
            {
                Console.Write(i + ",");
            }
            Console.WriteLine();
            
            Console.Write("b., ");
            for (int i1 = 2; i1 <= 20; i1 = i1 + 2)
            {
                Console.Write(i1 + ",");
            }
            Console.WriteLine();
            
            Console.Write("c., ");
            for (int i2 = 5; i2 <= 70; i2 = i2 + 7)
            {
                Console.Write(i2 + ",");
            }
            Console.WriteLine();
            
            Console.Write("d., ");
            for (int i3 = 197; i3 >= 134; i3 = i3 - 7)
            {
                Console.Write(i3 + ",");
            }
            Console.WriteLine();
            
            Console.Write("e., ");
            for (int i4 = 100; i4 >= 10; i4 = i4 - 10)
            {
                Console.Write(i4 + ",");
            }
            Console.WriteLine();
            
        }

        private static void feladat07()
        {
            Console.WriteLine("7.Feladat: ADOTT SZÁMÚ ADAT BEKÉRÉSE\n");

            int a;
            int b;
            Console.Write("Adj meg egy pozitív egész számott: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 0; i <= a; i = i + 1)
            {
                Console.Write("Adj meg egy pozitív egész számott: ");
                b = int.Parse(Console.ReadLine());
            }

        }

        private static void feladat08()
        {
            Console.WriteLine("8.Feladat: VOLT-E PÁROS\n");

            int a;
            int b;
            bool paros;
            Console.Write("Adj meg egy pozitív egész számott: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            paros = false;
            for (int i = 0; i <= a; i = i + 1)
            {
                Console.Write("Adj meg egy pozitív egész számott: ");
                b = int.Parse(Console.ReadLine());
                if(b % 2 == 0)
                {
                    paros = true;
                }

            }
            Console.WriteLine();
            if (paros == true)
            {
                Console.WriteLine("A megadott számok közt volt páros!");
            }
            else
            {
                Console.WriteLine("A megadott számok közt nem volt páros");
            }

        }
    }
}
