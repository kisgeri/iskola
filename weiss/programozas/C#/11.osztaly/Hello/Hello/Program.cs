using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elsoprogram
{
    class hellovilag
    {
        static void Main(string[] args)
        {
            //ez egy példa befezető program
            //program fejléc meg rajzolása
            Console.ForegroundColor = ConsoleColor.Yellow;//betü szin állitása
            Console.WriteLine("********************************************************************************");
            Console.Write("***************************   ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Hello_világ! program");//ki ír sor törés nélkül
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("   ***************************");
            Console.WriteLine("********************************************************************************\n\n\n");
            //program fejléc vége

            //program tényleges kezdete
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello világ\n"); //ki ír külön sorba a végén só törésel
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("várakozás 5 mp-ig...");

            System.Threading.Thread.Sleep(5000);//várakozás 5 másodpercig 
            Console.WriteLine("váraközás vége\n");
            Console.ForegroundColor = ConsoleColor.Red;
            System.Threading.Thread.Sleep(1000);
            Console.Write("várakozás bármely billentyű leütésére ");
            Console.ReadKey();//vár bármelyik billentyű lenyomására
            Console.WriteLine();
            Console.WriteLine("várakozás enter billentyű leütésére ");
            Console.ReadLine();//entere bezárja

            /*
             * ez egy több
             * sorros 
             * comment
             */

        }
    }
}
