using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.VELETLENTOMBISMETLESNELKUL_FUGGVENYEK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("16. VÉLETLEN TÖMB ISMÉTLÉS NÉLKÜL - FÜGGVÉNYEK");

            int tol = 1;
            int ig = 11;

            int[] tomb = new int[10];
            

            kiiras(VeletlenTombIsmetlesNelkulFv(tol, ig, tomb));

            Console.WriteLine();
            Console.ReadKey();
           
        }
        //tanárnő megoldása
        private static void kiiras(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] + ", ");
            }
        }

        private static bool letezik_efv(int KeresettElem, int[] tomb)
        {

            int index = 0;

            while (index < tomb.Length)
            {

                if (KeresettElem == tomb[index])
                {
                    return true;
                }

                index++;

            }
            return false;
        }

        private static int[] VeletlenTombIsmetlesNelkulFv(int tol, int ig,int[] tomb)
        {
            Random rnd = new Random();
            int veletlen = rnd.Next(tol, ig);

            tomb[0] = veletlen;

            for(int i = 1; i < tomb.Length; i++)
            {
                do
                {
                    veletlen = rnd.Next(tol, ig);

                } while (letezik_efv(veletlen, tomb) != false);

                tomb[i] = veletlen;

            }
            return tomb;
        }
        /*
         //én megoldásom
        private static void kiiras(int[] tomb)
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+", ");
            }
        }

        private static bool letezik_efv(int szam, int[] tomb)
        {
          
            int index = 0;

            while (index < tomb.Length)
            {


                if (szam == tomb[index])
                {
                    return true;
                }


                index++;


            }
            return false;
        }

        private static int[] VeletlenTombIsmetlesNelkulFv(int tol, int ig)
        {
            int[] tomb = new int[ig-1];
            Random rnd = new Random();

            int beszam;

            int index = 0;
            

            while (index < tomb.Length)
            {
                

                beszam = rnd.Next(tol,ig);

                if (letezik_efv(beszam,tomb) == false)
                {
                    tomb[index] = beszam;
                    index++;

                }
                
            }
            return tomb;
        }*/
    }
}
