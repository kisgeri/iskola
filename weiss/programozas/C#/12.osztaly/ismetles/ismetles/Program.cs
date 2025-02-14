using System;

namespace ismetles
{
    class Program
    {
        static void Main(string[] args)
        {
            feladat1();
        }

        private static void feladat1()
        {
            //alapfeladatt random hosszu tömb és annyi szám be kérése
            Console.WriteLine("alapfeladatt random hosszu tömb és annyi szám be kérése");

            Random rnd;
            rnd = new Random();
            int random;

            random = rnd.Next(5, 15);

            Console.WriteLine("kérlek " + random + " számot írj be(minden szám után nyomj entert!)");

            int[] szamok = new int[random];

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.Write(i + ". szám: ");
                szamok[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
            Console.WriteLine();

            //1. feladat számok összege
            Console.WriteLine("1. feladat számok összege");

            int osszeg;
            osszeg = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                osszeg += szamok[i];
            }

            Console.WriteLine("A számok öszege: " + osszeg);
            Console.WriteLine();

            //2. feladat legnagyobb index és érték
            Console.WriteLine("2. feladat legnagyobb index és érték");

            int legnagyobb;
            int legnagyobb_index;
            legnagyobb = szamok[0];
            legnagyobb_index = 0;

            for (int i = 1; i < szamok.Length; i++)
            {
                if (szamok[i] > legnagyobb)
                {
                    legnagyobb = szamok[i];
                    legnagyobb_index = i;
                }
            }

            Console.WriteLine("a legnagyobb szám indexe: " + legnagyobb_index + ", értéke:" + legnagyobb);
            Console.WriteLine();

            //3.feladat negativ szam index
            Console.WriteLine("3.feladat negativ szam index");

            bool negativ = false;
            int index = 0;
            int negativszam = 0;


            while (negativ != true && index < szamok.Length)
            {

                if (szamok[index] < 0)
                {

                    negativ = true;
                    negativszam = szamok[index];

                }
                else
                {
                    index++;
                }


            }

            if (negativ == true)
            {
                Console.WriteLine("van benne negatív szám, aminek indexe: " + index + ", értéke: " + negativszam);
            }
            else { Console.WriteLine("nincs negatív"); }
            Console.WriteLine();

            //4.feladat mennyi páros szám van
            Console.WriteLine("4.feladat mennyi páros szám van");

            int parosak;
            parosak = 0;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] % 2 == 0)
                {
                    parosak++;
                }
            }

            Console.WriteLine(parosak + " darab páros szám van.");
            Console.WriteLine();


            //5.egyszámjegyűek kilistázása
            Console.WriteLine("5.egyszámjegyűek kilistázása");


            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] > -10 && szamok[i] < 10)
                {
                    Console.Write(szamok[i] + ", ");
                }
            }

        }
    }
}
