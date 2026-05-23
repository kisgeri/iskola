using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterdekodoloOra
{
    internal class Karakter
    {
		public string karakter;
		public string matrix;


        public Karakter(string karakter, string matrix)//ctor vagy Ctrl + .
        {
            this.karakter = karakter;
            this.matrix = matrix;
        }

        public static void kiir(Karakter kiirom)
        {
            int j = 0;
            foreach (char kar in kiirom.matrix)
            {
                
                if(kar == '1')
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(" ");
                }
                if(j%4==0)
                {
                    Console.WriteLine();
                }
                j++;
            }

        }

        public static bool Felismer(Karakter kod,Karakter kodolando)
        {
            bool talal = false;

            if (kod.matrix == kodolando.matrix)
            {
                talal = true;
            }

            return talal;
        }
	}
}
