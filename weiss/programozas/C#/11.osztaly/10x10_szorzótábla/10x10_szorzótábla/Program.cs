using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10x10_szorzótábla
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=1; i<=10; i++)
            {

                for (int i2 = 1; i2 <= 10; i2++)
                {
                    if (i * i2 < 10)
                    {
                        Console.Write(i * i2 + " ".PadLeft(5, ' '));
                    }
                    else if (i * i2 >= 90)
                    {
                        Console.Write(i * i2 + " ".PadLeft(3, ' '));
                    }
                    else
                    {
                        Console.Write(i * i2 + " ".PadLeft(4, ' '));
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
        
    }
}
