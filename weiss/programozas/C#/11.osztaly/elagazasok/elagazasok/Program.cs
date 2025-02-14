using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elagazasok
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("elágazás gyakorlás");
            Console.WriteLine("\n");
            /*
            feladat01();
            Console.ReadKey();
            Console.WriteLine("\n");


            feladat02();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat03();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat04();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat05();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat06();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat07();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat08();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat09();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat10();
            Console.ReadKey();
            Console.WriteLine("\n");
           
            feladat11();
            Console.ReadKey();
            Console.WriteLine("\n");
             
            feladat12();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat13();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat14();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat15();
            Console.ReadKey();
            Console.WriteLine("\n");
            
            feladat16();
            Console.ReadKey();
            Console.WriteLine("\n");
            

            feladat17();
            Console.ReadKey();
            Console.WriteLine("\n");


            feladat18();
            Console.ReadKey();
            Console.WriteLine("\n");
            */
            feladat19();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat20();
            Console.ReadKey();
            Console.WriteLine("\n");

            feladat21();
            Console.ReadKey();
            Console.WriteLine("\n");

        }



        private static void feladat01()
        {
            Console.WriteLine("1.feladat, betü \n");

            Console.Write("írj be valamit (jobb esetbe betütt): ");
            string b = (Console.ReadLine());
            char a = Convert.ToChar(b);

            Console.WriteLine();

            //elenörzi hogy a karakter betü e
            if (Char.IsLetter(a) )
            {
                Console.WriteLine("az {0} egy betü.",a);
            }
            Console.WriteLine();
        }

        private static void feladat02()
        {
            Console.WriteLine("2.feladat, köszönjön e? \n");

            Console.Write("köszönjek ?  i/n : ");
            string felhasznalo = Console.ReadLine();

            if (felhasznalo == "i")
            {
                Console.WriteLine("viszontlátásra");
            }
            Console.WriteLine();

        }

        private static void feladat03()
        {
            Console.WriteLine("3. feladat szóköz \n");

            Console.Write("írj be egy szöveget: ");
            string szoveg = Console.ReadLine();

            //tartalmaz e valmit jelen esetben szóközt
            if (szoveg.Contains(" "))
            {
                Console.WriteLine("a beírt szöveg több szóbol áll.");
                Console.WriteLine("a beírt szöveg hossza: {0}",szoveg.Length);//megnézi hogy az adott szöveg hány karakterből ál

            }
        }
        private static void feladat04()
        {
            Console.WriteLine("4.feladat oszthatóság \n");

            Console.Write("írj be egy számott: ");
            string a = Console.ReadLine();
            int szam = Convert.ToInt32(a);

            if (szam%3==0)
            {
                Console.WriteLine("a szám osztható 3-al");
            }

            if (szam % 4 == 0)
            {
                Console.WriteLine("a szám osztható 4-el");
            }

            if (szam % 9 == 0)
            {
                Console.WriteLine("a szám osztható 9-el");
            }

           
        }

        private static void feladat05()
        {
            Console.WriteLine("5.feladat kitalálós");

            Console.WriteLine("szam = int");
            Console.WriteLine("szam = be: szám");
            Console.WriteLine("ha szam maradékos osztás 2 == 0");
            Console.WriteLine("\t akkor ki: osztható 2-vel");
            Console.WriteLine("\t különben ki: nem osztható 2-vel");

            int szam;
            //.Parse átalakítja a bekért adatott elé kell írni mire akarod alakítani
            szam = int.Parse(Console.ReadLine());

            if (szam % 2 == 0)
            {
                Console.WriteLine("a szám páros");
            }
            else 
            {
                Console.WriteLine("a szám páratlan");
            }
        }

        private static void feladat06()
        {
            Console.WriteLine("6.felatt melyik szám nagyobb");

            Console.WriteLine("adj meg 2 számot");
            Console.Write("első: ");
            string a = Console.ReadLine();
            int szam = int.Parse(a);
            Console.Write("második: ");
            string b = Console.ReadLine();
            int szam2 = int.Parse(b);

            if (szam > szam2)
            { Console.WriteLine("az első szám nagyobb"); }
            else
            { Console.WriteLine("a második szám nagyobb"); }
        }

        private static void feladat07()
        {
            Console.WriteLine("7.kiskorú");

            Console.Write("ad meg az életkorod: ");
            string a = Console.ReadLine();
            int kor = int.Parse(a);
            if (kor >= 18)
            { Console.WriteLine("megnézheted a piros karikás filmet"); }
            else
            { Console.WriteLine("nem nézheted a piros karikás filmet"); }
        }

        private static void feladat08()
        {
            Console.WriteLine("8.előjel");

            Console.Write("ad meg egy számott: ");
            string a = Console.ReadLine();
            int szam = int.Parse(a);

            if (szam >= 0)
            { Console.WriteLine("A szám pozitív"); }
            else
            { Console.WriteLine("a szám negatív"); }
        }

        private static void feladat09()
        {
            Console.WriteLine("9.nagyobb vagy egyenlő");

            Console.Write("ad meg egy számott: ");
            int szam = int.Parse(Console.ReadLine());

            if (szam > 50)
            { Console.WriteLine("A szám nagyobb mint 50"); }
            else if (szam < 50)
            { Console.WriteLine("A szám kiseb mint 50"); }
            else
            { Console.WriteLine("a szám 50"); }
        }

        private static void feladat10()
        {
            Console.WriteLine("10.között");

            Console.Write("ad meg egy számott: ");
            string a = Console.ReadLine();
            int szam = int.Parse(a);

            if (szam < 50 && szam > -50)
            { Console.WriteLine("A szám 50 és -50 közé esik"); }
            else
            { Console.WriteLine("a szám nem esik 50 és -50 közé"); }
        }

        private static void feladat11()
        {
            Console.WriteLine("11. CSELEKVŐKÉPES");

            Console.Write("ad meg a korod: ");
            int kor = int.Parse(Console.ReadLine());

            if (kor >= 18)
            { Console.WriteLine(" nagykorú "); }
            else if (kor <= 14)
            { Console.WriteLine(" cselekvőképtelen "); }
            else
            { Console.WriteLine(" korlátozottan cselekvőképes "); }
        }

        private static void feladat12()
        {
            Console.WriteLine("12. KISEBB-NAGYOBB-EGYENLŐ");

            Console.WriteLine("adj meg két számott: ");
            int szam;
            int szam2;
            Console.Write("\t első: ");
            szam = int.Parse(Console.ReadLine());
            Console.Write("\t második: ");
            szam2 = int.Parse(Console.ReadLine());

            if (szam > szam2)
            { Console.WriteLine("{0} nagyobb mint {1}",szam,szam2); }
            else if (szam < szam2)
            { Console.WriteLine("{0} kisebb mint {1}", szam, szam2); }
            else
            { Console.WriteLine("{0} egyenlő {1}", szam, szam2); }
        }

        private static void feladat13()
        {
            Console.WriteLine("13. VÍZ HALMAZÁLLAPOTA");

            Console.Write("ad meg a víz hőfokát: ");
            double homerseklet;
            homerseklet = double.Parse(Console.ReadLine());

            if (homerseklet >= 100)
            { Console.WriteLine("a víz gőz hallmaz álapotú"); }
            else if (homerseklet <= 0)
            { Console.WriteLine("a víz jég hallmaz álapotú"); }
            else
            { Console.WriteLine("a víz folyékony hallmaz álapotú"); }
        }

        private static void feladat14()
        {
            Console.WriteLine("14. POZITÍV-NEGATÍV-NULLA");

            Console.Write("adj meg egy számott: ");
            int szam;
            szam = int.Parse(Console.ReadLine()) ;

            if (szam <= 0)
            { Console.WriteLine("A szám negatív"); }
            else if (szam >= 0)
            { Console.WriteLine("A szám pozitív"); }
            else
            { Console.WriteLine("a szám 0"); }
        }

        private static void feladat15()
        {
            Console.WriteLine("15. BALATON VÍZMÉLYSÉGE");

            Console.Write("ad meg hány méter mély a balaton: ");
            double melyseg;
            melyseg = double.Parse(Console.ReadLine());

            if (melyseg < 1)
            { Console.WriteLine("pancsolunk"); }
            else if (melyseg > 2)
            { Console.WriteLine("nem megyünk belle"); }
            else
            { Console.WriteLine("akkor úszúnk"); }
        }

        private static void feladat16()
        {
            Console.WriteLine("16. HÁNY JEGYŰ?");

            Console.Write("adj meg egy számott max 2 milliárdig: ");
            string szam;
            szam = Console.ReadLine();
            int szamhosz = szam.Length;

            switch(szamhosz)
            {
                case 1:
                    Console.WriteLine("a szám egy jegyü");
                    break;

                case 2:
                    Console.WriteLine("a szám két jegyü");
                    break;

                case 3:
                    Console.WriteLine("a szám három jegyü");
                    break;

                case 4:
                    Console.WriteLine("a szám négy jegyü");
                    break;

                case 5:
                    Console.WriteLine("a szám öt jegyü");
                    break;

                case 6:
                    Console.WriteLine("a szám hat jegyü");
                    break;

                case 7:
                    Console.WriteLine("a szám hét jegyü");
                    break;

                case 8:
                    Console.WriteLine("a szám nyolc jegyü");
                    break;

                default:
                    Console.WriteLine("A szám 8, vagy annál többjegyű!");
                    break;
            }




        }

        private static void feladat17()
        {
            Console.WriteLine("17. AZ ÉV HÓNAPJAI");

            Console.Write("ad meg az egyik hónap számátt: ");
            int szam;
            szam = int.Parse(Console.ReadLine());
            

            switch (szam)
            {
                case 1:
                    Console.WriteLine("Január");
                    break;

                case 2:
                    Console.WriteLine("Február");
                    break;

                case 3:
                    Console.WriteLine("Március");
                    break;

                case 4:
                    Console.WriteLine("Április");
                    break;

                case 5:
                    Console.WriteLine("Május");
                    break;

                case 6:
                    Console.WriteLine("Június");
                    break;

                case 7:
                    Console.WriteLine("Július");
                    break;

                case 8:
                    Console.WriteLine("Augusztus");
                    break;


                case 9:
                    Console.WriteLine("Szeptember");
                    break;


                case 10:
                    Console.WriteLine("október");
                    break;

                case 11:
                    Console.WriteLine("November");
                    break;

                case 12:
                    Console.WriteLine("December");
                    break;

                default:
                    Console.WriteLine("nincs ilyen hónap");
                    break;
            }




        }


        private static void feladat18()
        {
            Console.WriteLine("18. ÉVSZAKOK");

            Console.Write("ad meg az egyik hónap számátt: ");
            int szam;
            szam = int.Parse(Console.ReadLine());


            switch (szam)
            {
                case 1:
                case 2:
                case 12:

                    Console.WriteLine("tél");
                    break;

                case 3:
                case 4:
                case 5:

                    Console.WriteLine("tavasz");
                    break;

                case 6:
                case 7:
                case 8:

                    Console.WriteLine("nyár");
                    break;

                case 9:
                case 10:
                case 11:

                    Console.WriteLine("ősz");
                    break;



                default:
                    Console.WriteLine("nincs ilyen hónap");
                    break;
            }




        }

        private static void feladat19()
        {
            Console.WriteLine("19. CELSIUS  KELVIN ÁTVÁLTÓ");

            Console.Write("adj meg egy számott: ");
            double szam;
            szam = double.Parse(Console.ReadLine());
            Console.Write("válasz:(1) C°-->K° vagy (2) k°-->C°: ");
            int valasz;
            valasz = int.Parse(Console.ReadLine());


            switch (valasz)
            {
                case 1:
                    double kelvin;
                    kelvin = szam + 273.15;
                    Console.WriteLine("{0} C° = {1} K°",szam,kelvin);
                    break;

                case 2:
                    double celsius;
                    celsius = szam - 273.15;
                    Console.WriteLine("{0} C° = {1} K°",szam,celsius);
                    break;

                default:
                    Console.WriteLine("ilyen opció nincs");
                    break;
            }




        }

        private static void feladat20()
        {
            Console.WriteLine("20. ÁTMENT VAGY MEGBUKOTT?");

            Console.Write("ad meg milyen jegyet kapott a tanuló: ");
            Byte szam;
            szam = byte.Parse(Console.ReadLine());


            switch (szam)
            {
                case 1:
                   
                    Console.WriteLine("megbukott!");
                    break;

                case 2:
                case 3:
                case 4:
                case 5:

                    Console.WriteLine("átment!");
                    break;

                default:
                    Console.WriteLine("nincs ilyen jegy a jegyek 1-től 5-ig adhatóak.");
                    break;
            }




        }

        private static void feladat21()
        {
            Console.WriteLine("21. MARADÉK 3-MAL OSZTVA");

            Console.Write("adj meg egy számott(egész): ");
            int szam;
            szam = int.Parse(Console.ReadLine());

            /*
            if (szam % 3 != 0)
            {
                Console.WriteLine("Maradék " + szam % 3);
             }
            else
            {
                Console.WriteLine("Nincs maradék");
            }
            */
            int eredmeny;
            eredmeny = (szam % 3);

            switch (szam)
            {
                case 0:

                    Console.WriteLine("nincs ilyen jegy a jegyek 1-től 5-ig adhatóak.");
                    break;

                default:
                    Console.WriteLine("Maradék " + eredmeny);
                    break;
            }
            



        }


    }
}
