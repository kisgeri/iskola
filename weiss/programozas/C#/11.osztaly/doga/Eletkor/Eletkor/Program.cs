using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eletkor
{
    class Program
    {
        static void Main(string[] args)
        {

            Eletkor_fel();
            Console.ReadKey();
        }

        private static void Eletkor_fel()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t\t\t\t************************************");
            Console.WriteLine("\t\t\t\t*Életkor feladat (Kis Gergely Jenő)*");
            Console.WriteLine("\t\t\t\t************************************");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("//A program be kér egy születési évet," +
                "teszteli hogy egész szám e amit meg adott majd teszteli nem e túl nagy az érték" +
                "ha ezeknek megfelell akkor kiszámolja az élet korát \n\n");
            Console.ForegroundColor = ConsoleColor.White;
            //léterhoztam a változókat
            int szulEv; 

            int aktualEv = DateTime.Now.Year;// aktuális év
            
            int eletkor ;
            /*ciklust és bool változót hoztam létre*/
            bool siker = false;
            while(siker == false)
            {
                //bekéri a születési évet
                Console.Write("Kérlek ad meg a születési éved: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                if (int.TryParse(Console.ReadLine(), out szulEv))//-megptóbálja intre alakítani 
                {
                    if (szulEv > 2024 || szulEv < 1900)/*--ha egész számott ír a felhasználó
                                                        teszteli hogy nem tul magas vagy túl alacsony 
                                                        az érték*/
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\ta megadott érték lehetetlen vagy túl alacsony(1900 allat) vagy túl magas(2024 felett)! kérem próbálja újra: ");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                    }

                    /*--ha ez is sikerül a siker változó true lesz ezzel meg áll a ciklus
                     és kiszámolja a felhasználó korát majd ki írja azt.*/
                    else
                    {
                        
                        siker = true;
                        eletkor = aktualEv - szulEv;
                        //ki számolja a korodat a születési évből és az aktuális évből
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\tAktuális életkorod: "+eletkor+ "\n\n\n\n\n\n\n\n\n");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("***");
                    }
                }
                else//-ha nem sikerül intre alakítani ki írja az alábi üzenett
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\ta megadott érték nem egész szám! kérem próbálja újra:");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    Console.WriteLine();
                }
            }
        }
    }
}
