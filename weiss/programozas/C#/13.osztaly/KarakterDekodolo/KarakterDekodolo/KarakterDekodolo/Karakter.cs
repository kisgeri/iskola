using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterDekodolo
{
    internal class Karakter
    {
        public string karakter;
        public string matrix;

        public Karakter(string karakter, string matrix)
        {
            this.karakter = karakter;
            this.matrix = matrix;
        }

        public static void kiir(Karakter valami)
        {
            int j = 0;
            foreach(var i in valami.matrix)
            {
                if(i=='1')
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
                j++;
                if(j%4==0)
                {
                    Console.WriteLine();
                }
            }


        }

        public static bool felismer(Karakter kod, Karakter kodolando)
        {
            bool ismer = false;
            if (kod.matrix==kodolando.matrix)
            {
                ismer = true;
            }
            return ismer;
        }
    }
}
