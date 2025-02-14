using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace talaldkiaszot
{
    class Program
    {
        static void Main(string[] args)
        {
            /*tömbökbe c# játék pár szót ki ír random fordítva ki kell találni a felhasználónak mi a szó (array)*/
            jatek();
        }

        private static void jatek()
        {
            Random rnd = new Random();
            string[] szavak = { "Kalandor", "Megbízható", "Kíváncsiság", "Különleges", "Érzékenység",
                                "Gyönyörűség", "Bizalomgerjesztő", "Környezetvédelem", "Átgondoltság", 
                                "Szeretetteljes","Szabadságszerető", "Alaposkodó", "Kitartás", 
                                "Felkészültség", "Örömteli", "Megbocsátás", "Hosszútávú", "Megértés", 
                                "Érdeklődés", "Elkötelezettség" };

            int mIndex = rnd.Next(szavak.Length);
            string szo = szavak[mIndex];
            string valasz;
            int szamlalo;
            int pontszam;

            szamlalo = 0;
            pontszam = 0;

            Console.WriteLine("A lentebb megjelenő szó fordítva van ki írva, találd ki mi az eredeti szó.");
            Console.WriteLine("3 lehetőséged van ki találni a szót ha nem sikerül véget ér a játék.");
            Console.WriteLine("FIGYELj! A játék megkülönbözteti a kis és nagy betűt\n");
            Console.Write("Kezdéshez nyomd meg az entert! ");
            Console.ReadKey();
            Console.WriteLine("\n");
            

            while (szamlalo < 3)
            {
                


                for (int i2 = szo.Length - 1; i2 >= 0; i2--)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.Write(szo[i2]);
                    

                    Console.ForegroundColor = ConsoleColor.Yellow;

                }


                Console.WriteLine("\n" +
                    "");
                Console.Write("Találd ki a szót: ");
                valasz = Console.ReadLine();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;

                if (valasz != szo)
                {
                    
                    szamlalo += 1;

                }
                else
                {
                    pontszam += 1;
                    mIndex = rnd.Next(szavak.Length);
                    szo = szavak[mIndex];
                    szamlalo = 0;
                }

                

            }
                Console.WriteLine("\n\n");

            

            Console.WriteLine("Vége a pontszámod "+pontszam);

            Console.ReadKey();
            
            
        }
    }
}
