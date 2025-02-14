using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otoslotto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ötöslottó program\n");

            Random rnd = new Random();
            int[] nyeroszamok = new int[5];
            int talalatok = 0;
            int[] tip = new int[5];

            Console.WriteLine("kérem adja meg a tippjeit:");

            nyeroszamok[0] = rnd.Next(1, 91);

            Console.Write(1 + ". szám tipp: ");
            tip[0] = int.Parse(Console.ReadLine());

            for (int i = 1; i<nyeroszamok.Length;i++)
            {

                do
                {
                    nyeroszamok[i] = rnd.Next(1, 91);
                } while (nyeroszamok[i-1] == nyeroszamok[i]);
                
            }

            for (int i = 1; i<tip.Length;i++)
            {
                do
                {
                    do
                    {
                        Console.Write((i + 1) + ". szám tipp: ");
                        tip[i] = int.Parse(Console.ReadLine());

                        if (tip[i] < 1 || tip[i] > 90)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("A megadott szám nem 1 és 90 közöt, kérlek adj meg másikat");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                    } while (tip[i] < 1 || tip[i] > 90);

                    if(tip[i - 1] == tip[i])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("A megadott szám egyezik egy korábival, kérlek adj meg másikat");
                        Console.ForegroundColor = ConsoleColor.White;
                    }

                } while (tip[i - 1] == tip[i]);
      
            }

            for (int i = 0; i< nyeroszamok.Length;i++)
            {
                
                for (int j = 0; j < tip.Length; j++)
                {
                    if (tip[j] == nyeroszamok[i])
                    {
                        talalatok++;
                    }
                }
            }

            ShellRendezes(nyeroszamok);

            Console.Write("\nA nyerő számok: ");
            for(int i = 0; i<nyeroszamok.Length;i++)
            {
                Console.Write(nyeroszamok[i]+"; ");
            }
            Console.WriteLine("\nA találataid száma: "+talalatok);

            Console.ReadKey();
        }

        private static void ShellRendezes(int[] a)
        {
            Int32 gap, n, i, j, x, y;

            gap = 1;
            n = a.Length;

            while (gap * 2 <= n)
            {
                gap = gap * 2;
            }

            gap = gap - 1;

            do
            {
                i = 0;

                while ((i <= gap) && (i + gap < n))
                {
                    j = i + gap;

                    while (j < n)
                    {
                        x = a[j];
                        y = j - gap;

                        while ((y > -1) && (x < a[y]))
                        {
                            a[y + gap] = a[y];
                            y = y - gap;
                        }
                        a[y + gap] = x;
                        j = j + gap;
                    }
                    i = i + 1;
                }
                gap = gap / 2;

            } while (gap > 0);

        }
    }
}
