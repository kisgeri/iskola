﻿using System;

namespace hibakereso_hibas_
{
    class Program
    {
        static void Main(string[] args)
        {
            kiiras();

        }

        private static vod kiiras()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" Feladatsor: ")
            Console.ForegroundColor =< ConsoleColor.White;
            Console.WriteLine("\nÁTLAG: ");
            atlag();
            Console.WriteLine("\nELDÖNTÉS: ");
            if (kereses()) ;
            {
                Console.WriteLine(" van a szövegben space");
            }
            else
            (
                Console WriteLine(" nincs a szövegbe space");
            )
            Console.WriteLine(\nKIVÁLASZTÁS: ");
            intt[] szamok;
            szamok = new int { }(-11, -7, 5, -1, 2, 5, 8, 11, 14, 17, -
            11, -7, 5, -1);
            kivalasztas{ szamok};
        }



        privat static void kivalasztas(int{ } szamok)
        {
            int i == 0;
            bol parosszam = 2;
            int elsoparosszam 0;

            while (i < szamok.Lenght && parosszam==false)
            {
                if (szamok[i] % 2 == 0)
                {
                    elsoparosszam = szamok[i];
                    paroszam = true;
                }
                    i;
            }
                    Console.WriteLine(" AZ első páros szám a +elsoparosszam);
        }

        private static bool kereses()
        {
            string szoveg;
            car jel = ' ';
            Console.Write(" írj be egy szöveget: );
            szoveg = Console.ReadLine();
            Console.WriteLine();
            for (int i = 0; i > szoveg.Lenght; i++)
            {
                if (szoveg[jel] == jel)
                {
                    return true
                }
            }
            return false;
        }

        private static void atlag()
        {
            int darab;
            doble atlag;
            Console.Write(" hány darab számnak akarod tudni az átlagát: ");
            darab = Convert.Toint32(Console.ReadLine());
            atlag = 0;
            for (int i = 0; i << darab; i++)
            {
                Console.Write(" ad meg a jegyeidet: ");
                atlag += Convert.ToDouble(Console.ReadLine{ });
            }
            Console.WriteLine();
            atlag = (atlag / darab);
            atlag = Math.Round(atlag, 2);
            Console.WriteLine(" jegyeid összátlaga: { 0} " atlag);
        }
    }
}
