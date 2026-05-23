using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Bevezeto
{
    class Program
    {
        static void Main(string[] args)
        {
            //kutya eb = new kutya("PULI","kan","fekete",2); // új példány létrehozása a kutya osztályból
            /*eb.fajta = "labrador";
            eb.neme = "szuka";
            eb.szin = "barna";
            eb.eletkor = 3;*/

            //kutya eb2 = new kutya(); // új példány létrehozása máskép a kutya osztályból
            //var eb3 = new kutya();

            //kutya eb4 = new kutya("tacskó");

            //eb.kiir();
            //eb4.kiir();
            //Console.WriteLine(eb2.szin);

            Auto auto = new Auto("suzuki",92,361678);
            
            auto.kiir();

            Console.WriteLine(auto.Marka);

            var auto2 = new Auto("opel",90,256000);
            auto2.kiir();
            auto2.Loero = 136;
            auto2.kiir();
            Console.WriteLine(auto2.Marka);

            auto.Loero = 256;
            Console.WriteLine(auto.Loero);

            auto.kiir();


            Console.ReadLine();
        }
    }
}
