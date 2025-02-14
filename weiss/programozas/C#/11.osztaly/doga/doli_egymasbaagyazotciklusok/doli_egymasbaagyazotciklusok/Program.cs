using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doli_egymasbaagyazotciklusok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Egymásba ágyazott ciklusok doga\n\n\n");

            
            feladat01();
            Console.WriteLine("\n");
            Console.ReadKey();

            feladat02();
            Console.WriteLine("\n\n");
            Console.ReadKey();
            
            feladat03();
            Console.WriteLine("\n\n");
            Console.ReadKey();

            feladat04();
            Console.WriteLine("\n\n");
            Console.ReadKey();

            feladat05();
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        private static void feladat01()
        {
            Console.WriteLine("Feladat01: első n szám szorzat\n");

            int szam;
            int szorzat;

            Console.Write("adj meg egy egész számott: ");
            szam = int.Parse(Console.ReadLine());
            szorzat = 1;

            for(int i = 1; i <= szam; i++ )
            {
                
                szorzat = szorzat * i;
            }
            Console.WriteLine();
            Console.WriteLine(szorzat);
        }



        private static void feladat02()
        {
            Console.WriteLine("Feladat02: hány darab páros szám van n-is\n");

            int szam;
            int parosszamokdb;

            Console.Write("adj meg egy egész számott: ");
            szam = int.Parse(Console.ReadLine());
            parosszamokdb = 0;

            for (int i = 1; i <= szam; i++)
            {
                if(i % 2 == 0)
                {
                    parosszamokdb = parosszamokdb + 1;
                }
            }
            Console.WriteLine();
            Console.WriteLine(parosszamokdb);
        }




        private static void feladat03()
        {
            Console.WriteLine("Feladat03: MxN o téglalap\n");

            int szeleseg;
            int magasag;

            Console.Write("ad meg hány darab o-ból áljon egy sor: ");
            szeleseg = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("ad meg hány darab oszlop legyen: ");
            magasag = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= magasag; i++)
            {
                for (int i2 = 1; i2 <= szeleseg; i2++)
                {
                    Console.Write("0");
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
        }




        private static void feladat04()
        {
            Console.WriteLine("Feladat04: n beirt öszege\n");

            int szam;
            double szam1;
            double összeg;


            Console.Write("adj meg egy hogy menyi számott akarsz meg adni: ");
            szam = int.Parse(Console.ReadLine());
            összeg = 0;
            Console.WriteLine();


            for (int i = 1; i <= szam; i++)
            {
                Console.Write(i);
                Console.Write(" adj meg egy számot: ");
                szam1 = double.Parse(Console.ReadLine());
                összeg = összeg + szam1;
            }
            Console.WriteLine();
            Console.WriteLine(összeg);
        }



        private static void feladat05()
        {
            Console.WriteLine("Feladat05: n beirt szöveg\n");

            int szam;
            string szovegresz;
            string szoveg;


            Console.Write("adj meg egy hogy menyi szövegrészt akarsz meg adni: ");
            szam = int.Parse(Console.ReadLine());
            szoveg = "";
            Console.WriteLine();
            


            for (int i = 1; i <= szam; i++)
            {
                Console.Write(i);
                Console.Write(" adj meg egy szöveg részt: ");
                szovegresz = Console.ReadLine();


                if(i > 1)
                {
                    szoveg = szoveg + ", " + szovegresz;
                }
                else
                {
                    szoveg = szoveg +  szovegresz;
                }
                
            }
            Console.WriteLine();
            Console.WriteLine(szoveg);
        }

        
    }
}
