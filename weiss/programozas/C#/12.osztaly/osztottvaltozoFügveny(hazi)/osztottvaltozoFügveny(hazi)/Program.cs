using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztottvaltozoFügveny_hazi_
{
    internal class Program
    {
        static int[] tomb = new int[10];
        static int osszeg = 0;
        
        static void Main(string[] args)
        {
            feltoltes();
            kiiras();
            osszegzes();
            Console.WriteLine("A tömb elemeinek összege: "+ osszeg);
            Console.ReadKey();
        }

        private static void osszegzes()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                osszeg += tomb[i];
            }
        }

        private static void kiiras()
        {
            Console.Write("A tömb elemei: ");

            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i] +"; ");
            }
            Console.WriteLine();
        }

        private static void feltoltes()
        {
            for(int i = 0; i<tomb.Length;i++)
            {
                Console.Write("ad meg a tomb {0}. elemét: ",i);

                tomb[i] = int.Parse(Console.ReadLine());

                Console.WriteLine();
            }
        }
    }
}
