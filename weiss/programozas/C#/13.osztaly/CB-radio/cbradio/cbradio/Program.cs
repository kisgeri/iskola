using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cbradio
{
    class Program
    {

        struct cbradio
        {
            public int ora;
            public int perc;
            public int adasdb;
            public string nev;

        }
        static List<cbradio> adasok = new List<cbradio>();

        static void Main(string[] args)
        {
            feladat2();
            feladat3();
            feladat4();
            feladat5();

            //feladat7();
            feladat8();
            feladat9();

            Console.ReadKey();
        }

        private static void feladat2()
        {
            StreamReader fajlolvaso = new StreamReader(@"F:\CB-radio\cb.txt");
            string elsosor = fajlolvaso.ReadLine();

            string sor;
            string[] darabok;

            while(!fajlolvaso.EndOfStream)
            {
                sor = fajlolvaso.ReadLine();
                darabok = sor.Split(';');

                cbradio adatok = new cbradio();

                adatok.ora = int.Parse(darabok[0]);
                adatok.perc = int.Parse(darabok[1]);
                adatok.adasdb = int.Parse(darabok[2]);
                adatok.nev = darabok[3];

                adasok.Add(adatok);
            }
        }

        private static void feladat3()
        {
            int bejegyzesek_szama = 0;
            for(int i = 0; i<adasok.Count(); i++)
            {
                bejegyzesek_szama++;
            }

            Console.WriteLine("3. feladat: Bejegyzések száma: {0} db\n",bejegyzesek_szama);
        }

        private static void feladat4()
        {
            bool egy_percbe_4adas = false;
            int i = 0;

            while (!egy_percbe_4adas && i < adasok.Count())
            {
                if(adasok[i].adasdb == 4 )
                {
                    egy_percbe_4adas = true;
                }

                i++;
            }

            if(egy_percbe_4adas)
            {
                Console.WriteLine("4. feladat: Volt négy adást indító söfőr.\n");
            }
            else
            {
                Console.WriteLine("4. feladat: Nem volt négy adást indító söfőr.\n");
            }
        }

        private static void feladat5()
        {
            int inditott_adasok_szama = 0;
            string megadottnev;

            Console.Write("5. feladat: Kérek egy nevet: ");
            megadottnev = Console.ReadLine();

            for (int i = 0; i < adasok.Count(); i++)
            {
                if (adasok[i].nev.ToLower() == megadottnev.ToLower())
                {
                    inditott_adasok_szama+= adasok[i].adasdb;
                }
            }

            if (inditott_adasok_szama > 0)
            {
                Console.WriteLine("\t{0} {1}x használta a CB-rádiót.\n",megadottnev, inditott_adasok_szama);
            }
            else
            {
                Console.WriteLine("\tNincs ilyen nevű sofőr!\n");
            }

        }

        //6.feladat
        static int AtszamolPercre(int ora, int perc)
        {

            return (ora*60)+perc;
        }

        private static void feladat7()
        {
            StreamWriter irocsatorna = new StreamWriter(@"F:\CB-radio\cb2.txt");
            irocsatorna.WriteLine("Kezdes;Nev;Adasdb");

            for (int i = 0; i < adasok.Count(); i++)
            {
                irocsatorna.WriteLine($"{AtszamolPercre(adasok[i].ora, adasok[i].perc)};{adasok[i].nev};{adasok[i].adasdb}");
            }

            irocsatorna.Close();
        }

        private static void feladat8()
        {
            List<string> nevek = new List<string>();
            bool mar_volt;

            nevek.Add(adasok[0].nev);

            for (int i = 0; i < adasok.Count(); i++)
            {
                mar_volt = false;


                for (int j = 0; j < nevek.Count(); j++)
                {
                    if(nevek[j] == adasok[i].nev)
                    {
                        mar_volt = true;
                    }
                    
                }

                if(!mar_volt)
                {
                    nevek.Add(adasok[i].nev);
                }
            }

            Console.WriteLine("8. feladat: Sofőrok száma: {0} fő",nevek.Count());
        }

        private static void feladat9()
        {
            List<string> nevek = new List<string>();
            bool mar_volt;

            nevek.Add(adasok[0].nev);

            for (int i = 0; i < adasok.Count(); i++)
            {
                mar_volt = false;


                for (int j = 0; j < nevek.Count(); j++)
                {
                    if (nevek[j] == adasok[i].nev)
                    {
                        mar_volt = true;
                    }

                }

                if (!mar_volt)
                {
                    nevek.Add(adasok[i].nev);
                }
            }

            int legtobb_inditas = 0;
            string legtobbet_indito_nev = "";
            int inditott_adasok_szama = 0;

            for (int i = 0; i < nevek.Count(); i++)
            {
                inditott_adasok_szama = 0;
                for (int j = 0; j < adasok.Count(); j++)
                {
                    if (adasok[j].nev == nevek[i])
                    {
                        inditott_adasok_szama += adasok[j].adasdb;
                    }
                }

                if(legtobb_inditas < inditott_adasok_szama)
                {
                    legtobb_inditas = inditott_adasok_szama;
                    legtobbet_indito_nev = nevek[i];
                }
            }

            Console.WriteLine("9. feladat: legtöbb adást indító sofőr\n\tNév: {0}\n\tAdások száma: {1} alkalom",legtobbet_indito_nev,legtobb_inditas);

        }
    }
}
