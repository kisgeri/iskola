using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shellsor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("17. SHELL RENDEZÉS - KÓDOLÁS");

            int[] t = new int[10] {63,54,33,45,23,99,43,10,35,87};


            ShellRendezes(t);

            for(int i = 0; i<10;i++)
            {
                Console.WriteLine(t[i]);
            }

            Console.ReadKey();

        }

        private static void ShellRendezes(int[] a)
        {   
            Int32 gap, n, i, j, x, y;

            gap = 1;
            n = a.Length;

            while(gap*2 <= n)
            {
                gap = gap * 2;
            }

            gap = gap - 1;

            do
            {
                i = 0;

                while((i<=gap) && (i+gap <n))
                {
                    j = i + gap;

                    while(j < n)
                    {
                        x = a[j];
                        y = j - gap;

                        while((y>-1)&&(x<a[y]))
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
