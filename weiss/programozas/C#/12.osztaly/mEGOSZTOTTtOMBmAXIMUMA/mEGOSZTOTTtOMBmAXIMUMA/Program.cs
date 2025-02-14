using System;

namespace mEGOSZTOTTtOMBmAXIMUMA
{
    class Program
    {
        static int[] tomb = new int[10];
        static int max = tomb[0];
        static void Main(string[] args)
        {
            Programfek();
            maximumkereses();
            eredmenykiiras();
        }

        private static void eredmenykiiras()
        {
            Console.WriteLine("A legnagyobb érték "+ max);
        }

        private static void maximumkereses()
        {
            for (int i = 1; i < tomb.Length; i++)
            {
                if(max < tomb[i])
                {
                    max = tomb[i];
                }
            }
        }

        private static void Programfek()
        {
            Console.WriteLine("2. MEGOSZTOTT TÖMB MAXIMUMA");

            int velszam;
            Random rnd;
            rnd = new Random();


            for(int i = 0; i< tomb.Length;i++)
            {
                velszam = rnd.Next(1, 11);

                tomb[i] = velszam;
            }
        }
    }
}
