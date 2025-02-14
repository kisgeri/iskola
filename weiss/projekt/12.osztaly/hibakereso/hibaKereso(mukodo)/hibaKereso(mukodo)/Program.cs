using System;

namespace hibaKereso_mukodo_
{
    class Program
    {
        static void Main(string[] args)
        {
            kiiras();

        }

        private static void kiiras()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Feladatsor:");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("\nÁTLAG:");
            atlag();

            Console.WriteLine("\nELDÖNTÉS:");
            if (kereses())
            {
                Console.WriteLine("van a szövegben space");
            }
            else
            {
                Console.WriteLine("nincs a szövegbe space");
            }

            Console.WriteLine("\nKIVÁLASZTÁS:");
            int[] szamok;
            szamok = new int[] { -11, -7, 5, -1, 2, 5, 8, 11, 14, 17, -11, -7, 5, -1 };
            kivalasztas(szamok);
        }

        private static void kivalasztas(int[] szamok)
        {
            int i = 0;
            bool parosszam = false;
            int elsoparosszam=0;
            while (i < szamok.Length && parosszam==false)
            {
                if (szamok[i] % 2 == 0)
                {
                    elsoparosszam = szamok[i];
                    parosszam = true;
                    
                }
                i++;
            }

            Console.WriteLine("AZ első páros szám a "+elsoparosszam);
            
        }

        private static bool kereses()
        {
           
            string szoveg;
            char jel = ' ';

            Console.Write("írj be egy szöveget: ");
            szoveg = Console.ReadLine();
            Console.WriteLine();

            for(int i=0; i<szoveg.Length;i++)
            {


                if (szoveg[i] == jel)
                {
                    return true;
                }


            }
            return false;
            
        }

        private static void atlag()
        {

            int darab;
            double atlag;

            Console.Write("hány darab számnak akarod tudni az átlagát: ");
            darab = Convert.ToInt32(Console.ReadLine());

            atlag = 0;

            for (int i = 0; i < darab; i++)
            {

                Console.Write("ad meg a jegyeidet: ");
                atlag += Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine();
            atlag = (atlag / darab);
            atlag = Math.Round(atlag, 2);
            Console.WriteLine("jegyeid összátlaga: {0}",  atlag);
        }
    }
}
