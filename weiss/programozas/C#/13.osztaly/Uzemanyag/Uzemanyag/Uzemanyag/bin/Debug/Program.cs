using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Uzemanyag
{
    class Program
    {//24
        struct uzemanyagstruktura
        {
            public string datum;
            public double benzin;
            public double gazolaj;
        }

        static List<uzemanyagstruktura> uzemanyag = new List<uzemanyagstruktura>();
        static void Main(string[] args)
        {
            feladat2();
            feladat3();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();
            feladat10();

            Console.ReadKey();
        }

        private static void feladat2()
        {
            StreamReader olvasocsatorna = new StreamReader(@"uzemanyag.txt");

            string sor;
            int sorszam = 0;
            string[] darabol;


            while(!olvasocsatorna.EndOfStream && sorszam < 1000)
            {
                sorszam++;
                sor = olvasocsatorna.ReadLine();
                darabol = sor.Split(';');
                uzemanyagstruktura adatok = new uzemanyagstruktura();

                adatok.datum = darabol[0];
                adatok.benzin = double.Parse(darabol[1]);
                adatok.gazolaj = double.Parse(darabol[2]);

                uzemanyag.Add(adatok);                
            }
            
        }

        private static void feladat3()
        {

            Console.WriteLine("3.feladat: Változások száma: "+ uzemanyag.Count());
        }

        private static void feladat4()
        {
            double legkisebbkulonbseg = 1000;
            double kulonbseg = 0; 

            for (int i = 1; i < uzemanyag.Count(); i++)
            {
                if((uzemanyag[i].benzin - uzemanyag[i].gazolaj) < 0)
                {
                    kulonbseg =  uzemanyag[i].benzin - uzemanyag[i].gazolaj * (-1);
                    
                }
                else
                {
                    kulonbseg = uzemanyag[i].benzin - uzemanyag[i].gazolaj;
                }


                if (legkisebbkulonbseg >= kulonbseg)
                {
                    
                    legkisebbkulonbseg = kulonbseg;
                }
 
            }

            Console.WriteLine("4.feladat: A legkisebb különbség: " + legkisebbkulonbseg);
        }

        private static void feladat5()
        {
            double legkisebbkulonbseg = 1000;
            double kulonbseg = 0;
            int legkisebbkulonbsegelofordulas = 0;

            for (int i = 1; i < uzemanyag.Count(); i++)
            {
                if ((uzemanyag[i].benzin - uzemanyag[i].gazolaj) < 0)
                {
                    kulonbseg = uzemanyag[i].benzin - uzemanyag[i].gazolaj * (-1);

                }
                else
                {
                    kulonbseg = uzemanyag[i].benzin - uzemanyag[i].gazolaj;
                }


                if (legkisebbkulonbseg >= kulonbseg)
                {

                    legkisebbkulonbseg = kulonbseg;
                }

            }

            for (int i = 0; i < uzemanyag.Count(); i++)
            {
                if ((uzemanyag[i].benzin - uzemanyag[i].gazolaj) < 0)
                {
                    kulonbseg = uzemanyag[i].benzin - uzemanyag[i].gazolaj * (-1);

                }
                else
                {
                    kulonbseg = uzemanyag[i].benzin - uzemanyag[i].gazolaj;
                }


                if (legkisebbkulonbseg == kulonbseg)
                {

                    legkisebbkulonbsegelofordulas++;
                }

            }


            Console.WriteLine("5.feladat: A legkisebb különbség előfordulása: " + legkisebbkulonbsegelofordulas);
        }

        private static void feladat6()
        {
            bool volt_valtozas_szokonapon = false;
            int ev;
            int honap;
            int nap;
            string[] darabol;

            int i = 0;
            while (volt_valtozas_szokonapon == false && i < uzemanyag.Count())
            {
                darabol = uzemanyag[i].datum.Split('.');
                ev = int.Parse(darabol[0]);
                honap = int.Parse(darabol[1]);
                nap = int.Parse(darabol[2]);

                if((ev % 4 == 0)&&(honap==2)&&(nap==24))
                {
                    
                    if(uzemanyag[i].gazolaj != uzemanyag[i].benzin)
                    {
                        volt_valtozas_szokonapon = true;
                    }

                }

                i++;
            }

            if(volt_valtozas_szokonapon)
            {
                Console.WriteLine("6.feladat: Volt változás szökőnapon!");
            }
            else
            {
                Console.WriteLine("6.feladat: Nem volt változás szökőnapon!");
            }
        }

        private static void feladat7()
        {
            StreamWriter irocsatorna = new StreamWriter(@"euro.txt");

            for (int i = 0; i < uzemanyag.Count(); i++)
            {
                irocsatorna.WriteLine($"{uzemanyag[i].datum};{Math.Round(uzemanyag[i].benzin/307.7,2)};{Math.Round(uzemanyag[i].gazolaj / 307.7, 2)}"); 

            }

            irocsatorna.Close();
        }

        private static void feladat8()
        {
            int ev_szam=0;
            while(ev_szam < 2011 || ev_szam > 2016)
            {
                Console.Write("8. feladat: Kérem adja meg az évszámot [2011..2016]: ");
                ev_szam = int.Parse(Console.ReadLine());
            }


        }


        private static void feladat10()
        {
            egyemastkovetonapok();
            
        }

        static int egyemastkovetonapok()
        {
            int napokszama = 0;

            return napokszama;
        }
    }
}
