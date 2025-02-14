using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szövegkez
{
    class Program
    {
        static void Main(string[] args)
        {
           
            feladat01();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat02();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat03();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat04();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat05();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat06();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat07();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat08();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat09();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat10();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat11();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");

            feladat12();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat13();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
             
            feladat14();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat15();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat16();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat17();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
            feladat18();
            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine("\n\n\n");
            
        }


        private static void feladat01()
        {
            Console.WriteLine("1. KARAKTERSZÁM\n\n");

            string mondat;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("A mondatod "+mondat.Length+ " karakter hosszú.");
        }
        private static void feladat02()
        {
            Console.WriteLine("2. RITKÍTOTT\n\n");

            string mondat;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            Console.WriteLine();

            for (int i= 0; i!=mondat.Length; i++)
            {
                Console.Write(mondat[i]+" ");
            }
        }

        private static void feladat03()
        {
            Console.WriteLine("3. NAGYBETŰS\n\n");

            string mondat;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine(mondat.ToUpper());
        }

        private static void feladat04()
        {
            Console.WriteLine("4. RITKÍTOTT NAGYBETŰS\n\n");

            string mondat;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            Console.WriteLine();

            mondat = mondat.ToUpper();

            for (int i = 0; i != mondat.Length; i++)
            {
                Console.Write(mondat[i] + " ");
                //Console.Write((mondat[i])ToString().ToUpper() + " ");
            }
        }

        private static void feladat05()
        {
            Console.WriteLine("5. ASCII KÓD -> KARAKTER\n\n");

            Console.WriteLine("Az ASCII karakterek:");

            char ascii;

            for (int i = 0; i <= 255; i++)
            {
                ascii = Convert.ToChar(i);
                Console.Write(ascii + " ");
            }
            
        }

        private static void feladat06()
        {
            Console.WriteLine("6. KARAKTER -> ASCII KÓD\n\n");

            char asciichar;
            char a;
            int A;
            int asciicharkod;
            Console.Write("kérek egy karaktert: ");
            a = 'A';
            asciichar = char.Parse(Console.ReadLine());
            Console.WriteLine();

            A = Convert.ToInt32(a);
            asciicharkod = Convert.ToInt32(asciichar);

            Console.WriteLine("Az A karakter Asccii kódja:" + A);
            Console.WriteLine("Az "+asciichar+" karakter Asccii kódja:" + asciicharkod);

        }

        private static void feladat07()
        {
            Console.WriteLine("7. FÜGGŐLEGES\n\n");

            string keresztnev;
            Console.Write("Írj be egy keresztnevet: ");
            keresztnev = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i != keresztnev.Length; i++)
            {
                Console.WriteLine(keresztnev[i]);
            }


        }

        private static void feladat08()
        {
            Console.WriteLine("8. VISSZAFELÉ\n\n");

            string mondat;
            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            Console.WriteLine();

            for (int i = (mondat.Length-1); i >= 0; i--)
            {
                Console.Write(mondat[i]);
            }
        }

        private static void feladat09()
        {
            Console.WriteLine("9. KARAKTERNÉGYZET\n\n");

            int darabszam;
            char CHAR;
            Console.Write("Ad meg menyi karakterből áljon a NÉGYZET? ");
            darabszam = int.Parse(Console.ReadLine());
            Console.Write("Milyen karakterből álljon a négyzet? ");
            CHAR = char.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i <= darabszam; i++)
            {
                for (int i2 = 1; i2 <= darabszam; i2++)
                {
                    Console.Write(CHAR);
                }
                Console.WriteLine();
            }
        }

        private static void feladat10()
        {
            Console.WriteLine("10. VOLT-E NAGYBETŰ\n\n");

            Console.Write("Írj be egy mondatott: ");
            string mondat = Console.ReadLine();
            bool nagybetu = false;
            string nagymondat = mondat.ToUpper();

            Console.WriteLine();
            /*
            for (int i = 0; i < mondat.Length; i++)//feltételes ciklusba jobb lenne
            {
                
                if (mondat[i] == nagymondat[i] && nagymondat[i] != '0' && nagymondat[i] != '1' &&
                    nagymondat[i] != '2' && nagymondat[i] != '3' && nagymondat[i] != '4'
                    && nagymondat[i] != '5' && nagymondat[i] != '6' && nagymondat[i] != '7'
                    && nagymondat[i] != '8' && nagymondat[i] != '9' && nagymondat[i] != ' ')
                {
                    nagybetu = true;
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine("Volt nagybetü");
            }
            


            for (int i = 0; i != mondat.Length; i++)
            {
                if(char.IsUpper(mondat[i]))
                {
                    nagybetu = true;
                }
            }
            if(nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine("Volt nagybetü");
            }
            */


            //(ez is jó)
            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i] >= 'A' && mondat[i] <= 'Z')
                {
                    nagybetu = true;
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine("Volt nagybetü");
            }
            


        }

        private static void feladat11()
        {
            Console.WriteLine("11. NAGYBETŰK SZÁMA\n\n");

            string mondat;
            bool nagybetu;
            int nagybetuszama;
            string nagymondat;

            
            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            nagybetu = false;
            nagybetuszama = 0;
            nagymondat = mondat.ToUpper();
            Console.WriteLine();
            /*
            for (int i = 0; i != mondat.Length; i++)
            {
                if (char.IsUpper(mondat[i]))
                {
                    nagybetu = true;
                    nagybetuszama = nagybetuszama + 1;
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine(nagybetuszama+" nagybetü volt");
            }
            


            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i] >= 'A' && mondat[i] <= 'Z')
                {
                    nagybetu = true;
                    nagybetuszama = nagybetuszama + 1;
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine(nagybetuszama + " nagybetü volt");
            }
            */


            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i] == nagymondat[i] && nagymondat[i] != '0' && nagymondat[i] != '1' &&
                    nagymondat[i] != '2' && nagymondat[i] != '3' && nagymondat[i] != '4'
                    && nagymondat[i] != '5' && nagymondat[i] != '6' && nagymondat[i] != '7'
                    && nagymondat[i] != '8' && nagymondat[i] != '9' && nagymondat[i] != ' ')
                {
                    nagybetu = true;
                    nagybetuszama = nagybetuszama + 1;
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine(nagybetuszama + " nagybetü volt");
            }


        }

        private static void feladat12()
        {
            Console.WriteLine("12. NAGYBETŰK FELSOROLÁSA\n\n");

            string mondat;
            bool nagybetu;
            string nagybetuk;
            string nagymondat;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            nagybetu = false;
            nagybetuk = "";
            nagymondat = mondat.ToUpper();
            Console.WriteLine();
            
            for (int i = 0; i != mondat.Length; i++)
            {
                if (char.IsUpper(mondat[i]))
                {
                    nagybetu = true;
                    nagybetuk = nagybetuk + mondat[i] +" ";
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine("ezek a nagybetük volt: " + nagybetuk);
            }


            /*
            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i] >= 'A' && mondat[i] <= 'Z')
                {
                    nagybetu = true;
                    nagybetuk = nagybetuk + mondat[i] + " ";
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine("ezek a nagybetük volt: " + nagybetuk);
            }


           
            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i] == nagymondat[i] && nagymondat[i] != '0' && nagymondat[i] != '1' &&
                    nagymondat[i] != '2' && nagymondat[i] != '3' && nagymondat[i] != '4'
                    && nagymondat[i] != '5' && nagymondat[i] != '6' && nagymondat[i] != '7'
                    && nagymondat[i] != '8' && nagymondat[i] != '9' && nagymondat[i] != ' ')
                {
                    nagybetu = true;
                    nagybetuk = nagybetuk + mondat[i] + " ";
                }
            }
            if (nagybetu == false)
            {
                Console.WriteLine("nem volt nagybetű");
            }
            else
            {
                Console.WriteLine("ezek a nagybetük volt: " + nagybetuk);
            }*/
        }

        private static void feladat13()
        {
            Console.WriteLine("13. SZÓKÖZÖK SZÁMA\n\n");

            string mondat;
            int szokozokszama;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            szokozokszama = 0;
            Console.WriteLine();

            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i] == Convert.ToChar(32))
                {
                    szokozokszama = szokozokszama + 1;
                }
            }

            Console.WriteLine(szokozokszama + "db szóköz volt");
            
        }

        private static void feladat14()
        {
            Console.WriteLine("14. SZÓKÖZ NÉLKÜL\n\n");

            string mondat;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            Console.WriteLine();

            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i] != Convert.ToChar(32))
                {
                    Console.Write(mondat[i]);
                }
            }

            
        }

        private static void feladat15()
        {
            Console.WriteLine("15. NÉV-KOMBINÁCIÓK\n\n");

            string vnev;
            string vnev2;
            string knev;
            string knev2;

            Console.Write("Az első vezetéknév: ");
            vnev = Console.ReadLine();
            Console.Write("A második vezetéknév: ");
            vnev2 = Console.ReadLine();
            Console.Write("Az első keresztnév: ");
            knev = Console.ReadLine();
            Console.Write("Az második keresztnév: ");
            knev2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("A lehetséges név kombinációk: ");
            Console.WriteLine(vnev +" "+knev);
            Console.WriteLine(vnev + " " + knev2);
            Console.WriteLine(vnev2 + " " + knev);
            Console.WriteLine(vnev2 + " " + knev2);
        }

        private static void feladat16()
        {
            Console.WriteLine("16. NÉV SZÉTBONTÁSA\n\n");

            string teljesnev;
            int space;

            Console.Write("A meg a teljes neved: ");
            teljesnev = Console.ReadLine();
            Console.WriteLine();

            space = teljesnev.IndexOf(' ');
            if( space > 0)
            {
                Console.WriteLine("A vezetéknév: " + teljesnev.Substring(0, space));
                Console.WriteLine("A keresztnév: " + teljesnev.Substring(space + 1, teljesnev.Length - (space + 1)));
            }
            else
            {
                Console.WriteLine("A név nem bontható fel.");
            }
            

        }

        private static void feladat17()
        {
            Console.WriteLine("17. KIS-NAGYBETŰ PÁR\n\n");

            string karakter;
            string nagykarakter;

            Console.Write("Adj meg egy karaktert: ");
            karakter = Console.ReadLine();
            nagykarakter = karakter.ToUpper();
            
            if(karakter != nagykarakter)
            {
                Console.WriteLine("A beirt karakter kisbetü volt, párja: "+karakter+" - "+nagykarakter);
            }
            else
            {
                Console.WriteLine("A beirt karakter nagybetü volt, párja: " + karakter.ToLower() + " - " + nagykarakter);
            }
        }

        private static void feladat18()
        {
            Console.WriteLine("18. BETŰKERESŐ\n\n");

            
            string mondat;
            string karakter;
            bool van;
            int karakterszama;
            string hely;

            Console.Write("Írj be egy mondatott: ");
            mondat = Console.ReadLine();
            Console.Write("keresendő karakter: ");
            karakter = Console.ReadLine();
            van = false;
            karakterszama = 0;
            hely = "";
            Console.WriteLine();
            /*
            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i].ToString() == karakter)
                {
                    van = true;
                    karakterszama = karakterszama + 1;
                    hely = hely + (i+1) + ", ";
                }
            }

            if(van == true)
            {
                Console.WriteLine("A mondatban {1} db {0} karakter található. helye {2} karakter",karakter, karakterszama,hely);
            }
            else
            {
                Console.WriteLine("A"+karakter+"karakter nincs benne mondatba");
            }
            */



            for (int i = 0; i != mondat.Length; i++)
            {
                if (mondat[i].ToString() == karakter|| mondat[i].ToString() == karakter.ToLower() || mondat[i].ToString() == karakter.ToUpper())
                {
                    van = true;
                    karakterszama = karakterszama + 1;
                    hely = hely + (i + 1) + ", ";
                }
            }

            if (van == true)
            {
                Console.WriteLine("A mondatban {1} db {0} karakter található. helye {2} karakter", karakter, karakterszama, hely);
            }
            else
            {
                Console.WriteLine("A " + karakter + " karakter nincs benne mondatba");
            }
        }


    }
}
