using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiiratasIsmetles
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.feladat
            Console.WriteLine("Kis  Gergely Jenő\n");
            Console.WriteLine("Kis Gergely");
            Console.WriteLine("@".PadLeft(5));
            Console.WriteLine("@@@".PadLeft(6));
            Console.WriteLine("@@@@@".PadLeft(7));
            Console.WriteLine("@@@@@@@".PadLeft(8));
            Console.WriteLine("@@@@@@@@@");
            Console.ReadKey();
            Console.WriteLine();

            //2 feladat
            Console.WriteLine("-----------");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 37 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 42 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.WriteLine("-----------");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 23 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 76 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.WriteLine("-----------");
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 14 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("|");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" 98 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("|");
            Console.WriteLine("-----------");
            Console.WriteLine("***************************************************************");
            Console.WriteLine("A folytatáshoz üss le egy billentyűt!");
            Console.ReadKey();
            Console.WriteLine();

            //3. feladat 
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.ReadKey();
            Console.WriteLine();

            //4. feladat 
            Console.WriteLine(9 % 2);
            Console.WriteLine(8 / 4);
            Console.WriteLine((((264 / 44) * 8)/(9+3))/(11-9));

            Console.ReadKey();
            Console.WriteLine();

            //5. feladat 
            Console.WriteLine(String.Format("{0}  \t{1} {2,6}", 1 ,"alma", 500));
            Console.WriteLine(String.Format("{0}  \t{1} {2,4}", 2, "szilva", 700));
            Console.WriteLine(String.Format("{0}  \t{1} {2,4}", 3, "barack", 850));
            Console.WriteLine(String.Format("{0}  \t{1} {2,5}", 4, "körte", 370));
            Console.ReadKey();
            Console.WriteLine();

            //6. feladat
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(" {0,5} | {1,-11} | {2,10}", "Szs","Név", "Rendelés");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine(String.Format(" {0,5} | {1,-11} | {2,10}", 1, "Edina", 51));
            Console.WriteLine(String.Format(" {0,5} | {1,-11} | {2,10}", 29, "Éva", 1104));
            Console.WriteLine(String.Format(" {0,5} | {1,-11} | {2,10}", 345, "Richárd", 440));
            Console.WriteLine("--------------------------------------");



            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
