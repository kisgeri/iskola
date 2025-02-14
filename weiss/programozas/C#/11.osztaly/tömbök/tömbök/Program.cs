using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tömbök
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat_teszt();
            Console.ReadLine();
        }

        private static void feladat_teszt()
        {
            int[] tömb = new int[10];
                for(int i = 0; i < tömb.Length; i++)
                {
                    Console.Write("adj meg számott: ");
                    tömb[i] = int.Parse(Console.ReadLine());
                }

            Console.WriteLine("forditott ki iratás");
                for (int i2 = tömb.Length-1; i2 >= 0; i2--)
                {
                    Console.WriteLine(tömb[i2]);
                }
            Console.WriteLine("");


            Console.WriteLine("elemek összege");
            int osszeg;
            osszeg = 0;
                for (int i3 = 0; i3 < tömb.Length; i3++)
                {
                    osszeg=osszeg+tömb[i3];
                }
            Console.WriteLine(osszeg+"\n");


            Console.WriteLine("elemek átlaga");
            int atlag;
            int darab;
            darab = 0;
            atlag = 0;
            for (int i4 = 0; i4 < tömb.Length; i4++)
            {
                darab += 1;
            }
            atlag = osszeg / darab;
            Console.WriteLine(atlag+"\n");


            Console.WriteLine("páros elemek");
            for (int i5 = 0; i5 < tömb.Length; i5++)
            {
                if (tömb[i5] % 2 == 0)
                {
                    Console.WriteLine(tömb[i5]);
                }
            }
            Console.WriteLine();


            Console.WriteLine("két jegyü elemek száma");
            int ketjegyudb;
            ketjegyudb = 0;
            for (int i6 = 0; i6 < tömb.Length; i6++)
            {
                if (tömb[i6] >= 10 && tömb[i6] < 100 )
                {
                    ketjegyudb += 1;
                }
                else if (tömb[i6] <= -10 && tömb[i6] > -100)
                {
                    ketjegyudb += 1;
                }
                            
            }
            Console.WriteLine(ketjegyudb+"\n");


            Console.WriteLine("egyjegyü");
            for (int i7 = 0; i7 < tömb.Length; i7++)
            {
                if (tömb[i7] < 10 && tömb[i7] > -10)
                {
                    Console.WriteLine(tömb[i7]);
                }

            }
            Console.WriteLine();


            Console.WriteLine("páratlan számok összege");
            int paratlanoszeg;
            paratlanoszeg = 0;
            for (int i8 = 0; i8 < tömb.Length; i8++)
            {
                if (tömb[i8] % 2 != 0)
                {
                    paratlanoszeg += tömb[i8];
                }
            }
            Console.WriteLine(paratlanoszeg+"\n");

            
            Console.WriteLine("nullara vegzedo szamok");
            int nullaveguszam;
            string szam;
            nullaveguszam = 0;
            for (int i8 = 0; i8 < tömb.Length; i8++)
            {
                if (tömb[i8] % 10 == 0)
                {
                    nullaveguszam += 1;
                }
                /*
                szam = Convert.ToString(tömb[i8]);
                for(int j = 0; j < szam.Length; j++)
                {
                    if (j > 0 && szam[j] == 0)
                    {
                        nullaveguszam += 1;
                    }

                }*/
            }
            Console.WriteLine(nullaveguszam + "\n");
        }
    }
}
