using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valtozok
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("írd le a neved");
            string nev;
            nev = Console.ReadLine();
            Console.WriteLine("hello kedves {0}!",nev);
            Console.ReadKey();
            Console.WriteLine("\n");

            Console.Write("kérem a számot: ");
            string x=Console.ReadLine();
            Console.Write("a szám 2 szerese:{0}", Convert.ToInt16(x)*2);
            Console.ReadKey();
            Console.WriteLine("\n");

            Console.Write("mond meg a család neved:");
            string csnev = Console.ReadLine();
            
            Console.Write("mond meg a kereszt neved:");
            string knev = Console.ReadLine();
            Console.WriteLine("viszlát kedves {0} {1}.",csnev,knev);
            Console.ReadKey();
            Console.WriteLine("\n");
            */
            /*A program minden esetben elsőként a feladat sorszámát és nevét írja a képernyőre.
            Minden feladatnak külön eljárást készíts, az eljárásokat a főprogramból a feladatok lenti sorrendje 
            alapján hívd meg.
            A deklarációs rész mindig a program elején legyen, jól különüljön el a program többi részétől.
             A fontosabb programrészeket rövid megjegyzéssel magyarázd (pl. legyen megjegyzés a deklaráció 
            előtt, a beolvasások előtt, stb.).
            A számítási műveleteket ne a C.WL parancsban végezd; vegyél fel változókat, és abba helyezd el az 
            eredményt
            */
            /*
            feladat1();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat2();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat3();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat4();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat5();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat6();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat7();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat8();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat9();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat10();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat11();
            Console.ReadKey();
            Console.WriteLine("\n");
            */

            feladat12();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat13();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat14();
            Console.ReadKey();
            Console.WriteLine("\n");


        }


        private static void feladat1()
        {
            Console.WriteLine("1.feladat: szorzás");
            /*
             kiszámilja a 35 kétszeresének és a 47 kétszeresének
            öszegét
             */

            Console.WriteLine("\t Kis Gergely Jenő");

            int szam = 35;
            int szam2 = 47;
            int szor = szam * 2;
            int szor2 = szam2 * 2;
            int oszadas = szor + szor2;
            Console.WriteLine("\t végeredmény: {0}",oszadas);
            
        }

        private static void feladat2()
        {
            Console.WriteLine("2.feladat: név");
            //meg kell adni a neved külön változóba

            string vnev = "Kis";
            string knev = "Gergely";
            Console.WriteLine("\t{0} {1}", vnev,knev);

        }

        private static void feladat3()
        {
            Console.WriteLine("3.feladat: összeg");
            //a háromváltozónak öszegét ki számolja

            double a = 3.7;
            double b = 4.8;
            double c = 2.4;

            Console.WriteLine("\t{0}+{1}+{2}={3} öszeg fele {4}", a,b,c,a+b+c,(a + b + c)/2);
        }

        private static void feladat4()
        {
            Console.WriteLine("4.feladat: HÁROMSZÖG");
            //háromszög terület

            int aoldal = 2;
            int magasag = 10;
            int terület = (aoldal * magasag) / 2;
            Console.WriteLine("\ta háromszög területe {0}",terület);


        }

        private static void feladat5()
        {
            Console.WriteLine("5.feladat: csere");
            //megcseréli a 2 változót egy segéd változóval

            Console.WriteLine("Kis Gergely Jenő");

            int a = 35;
            int b = 27;
            int a2 = a;
            a = b;
            b = a2;
            
            
            Console.WriteLine("a={0} b={1}",a,b);
        }

        private static void feladat6()
        {
            Console.WriteLine("6.feladat: farm");
            /*tehenek számát megszorzuk a költségel majd 365-el
             * 
             */

            int tehen = 300;
            int költseg_1tehenre = 3000;
            int ösz_tehen = tehen * költseg_1tehenre;
            int ösz_teh_1ev = ösz_tehen * 365;

            Console.WriteLine("az öszes tehének 1 évre jutó költsége: {0}",ösz_teh_1ev);
        }

        private static void feladat7()
        {
            Console.WriteLine("7.feladat: típusok");
            //ilyen adat típusokat kell használni

            int kockadob = 3;
            double fizetes = 100000.3;
            char karakter = 'a';

            Console.WriteLine("kockadobás:{0} ,fizetés:{1} ,karakter:{2}",kockadob,fizetes,karakter);

        }
        //bekérés
        private static void feladat8()
        {
            //Adott egy kör alakú telek. A telek felének gyepesítését nekünk kell megoldani.
            Console.WriteLine("8.feladat: gyepesítés");

            int egynegzetmar = 2500;
            Console.Write("add meg a kör sugarát: ");
            double atmero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double r = atmero / 2;
            double gyepterulet = ((r*r) * 3.14159)/2;
            double ar = gyepterulet * egynegzetmar;

            Console.WriteLine("{0} négyzetméter gyeptégla kell ami {1} ftbe kerül",gyepterulet,ar);
            


        }

        private static void feladat9()
        {
            Console.WriteLine("9.feladat: autó");
            //kiszámoljaaz autó költségét 1km-re

            Console.Write("add hogy menyi adót fizetsz: ");
            double ado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("add meg a javitási költségedet: ");
            double javitas = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("add meg menyit fizetsz a benzin ért: ");
            double benzin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("add meg a hány kilómétert tettél meg ");
            double megtettkm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double egy_megtett_km = (ado + javitas + benzin) / megtettkm;
            Console.WriteLine("{0} Ft-be kerül az autó fentartása 1km-re", egy_megtett_km);
        }

        private static void feladat10()
        {
            Console.WriteLine("10.feladat: fordítva");

            Console.WriteLine("adj meg négy egész számot");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            int szam2 = Convert.ToInt32(Console.ReadLine());
            int szam3 = Convert.ToInt32(Console.ReadLine());
            int szam4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("{0} {1} {2} {3}",szam4,szam3,szam2,szam1);
        }

        private static void feladat11()
        {
            Console.WriteLine("11.feladat: háromszög2");

            Console.Write("\tad meg az egyyik oldal hoszát: ");
            double aoldal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("\tad meg a az oldalra eső magaságot: ");
            double magasag = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            double terület = (aoldal * magasag) / 2;
            Console.WriteLine("\ta háromszög területe {0}", terület);
        }

        private static void feladat12()
        {
            Console.WriteLine("12.feladat: ÁTVÁLTÁS: LÁB-MÉTER");
            
            Console.Write("adj meg láb-ban egy hoszt ");
            double lab = Convert.ToDouble(Console.ReadLine());
            double meter = lab * 0.3048;
            Console.WriteLine("{0} láb az {1} méter",lab,meter);
        }

        private static void feladat13()
        {
            Console.WriteLine("13.feladat: ÁTVÁLTÁS: INCH-CM");

            Console.Write("adj meg cm-ben egy hoszt ");
            double cm = Convert.ToDouble(Console.ReadLine());
            double inch = cm/2.54;
            Console.WriteLine("{0} cm az {1} inch", cm, inch);
        }

        private static void feladat14()
        {
            Console.WriteLine("14.feladat: KÖZÉPÉRTÉKEK");

            Console.Write("ad meg a b-t ");
            double b =  Convert.ToDouble(Console.ReadLine());
            Console.Write("ad meg az a-t ");
            double a= Convert.ToDouble(Console.ReadLine());

            double szmatni_köz = (a+b) /2;
            double mertani_köz = Math.Sqrt(a * b);

            Console.WriteLine("számtani {0} mértani {1}", szmatni_köz, mertani_köz);

        }
    }
}
