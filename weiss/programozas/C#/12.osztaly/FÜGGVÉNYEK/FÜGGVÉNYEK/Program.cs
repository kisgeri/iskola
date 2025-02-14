using System;

namespace FÜGGVÉNYEK
{
    class Program
    {

        static int[] tomb = new int[10];
        

        static void Main(string[] args)
        {

            
            Console.WriteLine("6.feladat TÖMB FELTÖLTÉSE");
            tomb=tombfeltoltese();
            
            Console.WriteLine("3.feladat ÖSSZEGZÉS");
            Console.WriteLine("Az elemek összege: " + Osszegzes() + "\n");

            Console.WriteLine("4.feladat MAXIMUMKERESÉS");
            Console.WriteLine("A legnagyobb elem: " + Maximumkereses() + "\n");

            Console.WriteLine("5.feladat ÉRTÉKKERESÉS");
            if (ErtekKereses())
            {
                Console.WriteLine("A keresett érték szerepel a tömbben");
            }
            else
            {
                Console.WriteLine("A keresett érték nem szerepel a tömbben");
            }
            Console.WriteLine();

            Console.WriteLine("7.feladat OSZTHATÓSÁG");
            Console.WriteLine("A tömbben {0} olyan szám van ami osztható 3-mal de 5-el nem", oszthatosag());
            Console.WriteLine();
            
            Console.WriteLine("PARAMÉTERES ELJÁRÁSOK ÉS FÜGGVÉNYEK:");

            Console.WriteLine("8.feladat MELYIK A NAGYOBB? - ELJÁRÁS");
            melyikangyaobb(3,2);
            Console.WriteLine();

            Console.WriteLine("9.feladat MELYIK A NAGYOBB? – ELJÁRÁS 2\n");

            Console.WriteLine("ad meg a kért számokat");

            Console.Write("1. szám: ");
            double szame1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. szám: ");
            double szame2 = Convert.ToInt32(Console.ReadLine());
            melyikangyaobb(szame1, szame2);
            Console.WriteLine();

            Console.WriteLine("10.feladat MELYIK A NAGYOBB? - FÜGGVÉNY");

            Console.Write("1. szám: ");
            double szamf1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. szám: ");
            double szamf2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("nagyobbik szám {0}", melyikangyaobbfüggveny(szamf1, szamf2));

            Console.WriteLine();

            Console.WriteLine("11.feladat DUPLÁZÓ - FÜGGVÉNY");

            double szam = 2;

            Console.WriteLine("A {0} duplája {1}", szam, duplazo(szam)) ;
            
            Console.WriteLine("12.feladat HATVÁNY - FÜGGVÉNY");

            double hatvanyalap = 0;
            byte hatvanykitevo = 0;


            Console.Write("hatványalap: ");
            hatvanyalap = Convert.ToDouble(Console.ReadLine());

            Console.Write("hatványkitevő: ");
            hatvanykitevo = Convert.ToByte(Console.ReadLine());

                Console.WriteLine();
            

            Console.WriteLine("{0}^{1}={2}", hatvanyalap, hatvanykitevo ,hatvanyozo(hatvanyalap, hatvanykitevo));
            Console.WriteLine();

            Console.WriteLine("13.feladat KARAKTERTÉGLALAP - ELJÁRÁS");
            Console.WriteLine();

            byte oszlop = 0;
            byte sor = 0;


            
            Console.Write("oszlop: ");
            oszlop = Convert.ToByte(Console.ReadLine());

            Console.Write("sor: ");
            sor = Convert.ToByte(Console.ReadLine());

            Console.WriteLine();
            

            karakterreglalap(oszlop,sor,'*');
            Console.WriteLine();
            
            Console.WriteLine("14.feladat LEGHOSSZABB EGYENLŐ - ELJÁRÁS");
            // int[] tomb = new int [10] {1,1,1,2,5,1,5,8,6,3};
            leguszabbegyenloelj(tomb);
            Console.WriteLine();

            Console.WriteLine("15.feladat LEGHOSSZABB EGYENLŐ - FÜGGVÉNY");
            Console.WriteLine("a leghosszabb egyenlő elemekből álló szakasz hossza {0} elem", leguszabbegyenlofug(tomb));
            Console.WriteLine();
        }

        private static int leguszabbegyenlofug(int[] tomb)
        {
            int szakaszhosz = 1;
            int leghoszszakasz = 1;


            for (int i = 1; i < tomb.Length; i++)
            {

                if (tomb[i] == tomb[i - 1])
                {
                    szakaszhosz++;
                }
                else
                {
                    if (szakaszhosz > leghoszszakasz)
                    {
                        leghoszszakasz = szakaszhosz;
                    }
                    szakaszhosz = 1;
                }
            
            }
            return leghoszszakasz;
        }

        private static void leguszabbegyenloelj(int[] tomb)
        {
            int szakaszhosz = 1;
            int leghoszszakasz = 1;


            for (int i = 1; i < tomb.Length; i++)
            {
                
                if (tomb[i] == tomb[i - 1])
                {
                    szakaszhosz++;
                }
                else
                {
                    if (szakaszhosz > leghoszszakasz)
                    {
                        leghoszszakasz = szakaszhosz;
                    }
                    szakaszhosz = 1;
                }
            
            }

            Console.WriteLine("a leghosszabb egyenlő elemekből álló szakasz hossza {0} elem", leghoszszakasz);
        }

        private static void karakterreglalap(byte oszlop, byte sor, char karakter)
        {
            for(int i = 0; i < oszlop; i++)
            {
                for(int j = 0; j < sor; j++)
                {
                    Console.Write(karakter);
                }
                Console.WriteLine();
            }
        }

        private static double hatvanyozo(double hatvanyalap, double hatvanykitevo)
        {
            double hatvanyertek = hatvanyalap;

            for(int i = 0; i < hatvanykitevo-1; i++)
            {
                hatvanyertek *= hatvanyalap;
            }
            return hatvanyertek;
        }

        private static double duplazo(double dupla)
        {
            dupla = dupla * 2;

            return dupla;
        }

        private static double melyikangyaobbfüggveny(double szam, double szam2)
        {
            if (szam < szam2)
            {
                return szam2;
            }
            else
            {
                return szam;
            }
        }

        private static void melyikangyaobb(double szam, double szam2)
        {
            if (szam < szam2)
            {
                Console.WriteLine(szam2);
            }
            else 
            {
                Console.WriteLine(szam);
            }


        }
        

       



        private static bool ErtekKereses()
        {
            Console.Write("Kérlek ad meg a keresett étéket: ");

            int KeresetErtek = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < tomb.Length; i++)
            {
                if (KeresetErtek == tomb[i])
                {
                    return true;
                }
            }
            return false;
        }

        private static int oszthatosag()
        {

            int oszhatok = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 ==0 && tomb[i] % 5 != 0)
                {
                    oszhatok++;
                }
            }

            return oszhatok;
        }


        private static int Maximumkereses()
        {
            


            int max = tomb[1];

            for (int i = 1; i < tomb.Length; i++)
            {
                if (max < tomb[i])
                {
                    max = tomb[i];
                }
            }

            return max;
        }

        private static int[] tombfeltoltese()
        {
            int[] tomb2 = new int[10];

            Console.WriteLine("kérlek ad meg a tömb elemeit:");

            for (int i = 0; i < tomb2.Length; i++)
            {
                Console.Write(i+": ");
                tomb2[i]=int.Parse(Console.ReadLine());
                
            }
            return tomb2;

            
        }

        private static int Osszegzes()
        {
           

            int osszeg = 0;

            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i]; 
            }

            return osszeg;
        }
    }
}
