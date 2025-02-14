using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nevezetesalgoritmus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow; 
            Console.WriteLine("Nevezetes algoritmus felladatok:\n\n\n\n");

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("sorozatszámitás:\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            
            feladat1();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat2();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat3();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat4();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat5();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat6();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat7();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat8();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat9();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("eldöntés:\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;
            
            feladat10();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat11();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat12();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat13();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat14();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat15();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("kiválasztás:\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;

            feladat16();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();


            feladat17();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat18();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("lineáris keresés:\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;

            feladat19();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat20();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat21();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("megszámlálás:\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;

            feladat22();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat23();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();
            
            feladat24();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat25();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("maximum kiválasztás:\n\n\n");

            Console.ForegroundColor = ConsoleColor.White;

            feladat26();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat27();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

            feladat28();
            Console.WriteLine("\n");
            Console.ReadKey();
            Console.WriteLine();

        }

        private static void feladat1()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("1.Feladat ÁTLAGHŐMÉRSÉKLET:");
            Console.ForegroundColor = ConsoleColor.White;

            int jegyzetnapokdb;
            double atlaghomerseklet;

            jegyzetnapokdb = 7;
            atlaghomerseklet = 0;
            
            for (int i=0; i < jegyzetnapokdb; i++)
            {
                Console.Write("ad meg a napi hőmérséklettet: ");
                 atlaghomerseklet += Convert.ToDouble(Console.ReadLine());

            }
            Console.WriteLine();
            atlaghomerseklet = (atlaghomerseklet / jegyzetnapokdb);
            atlaghomerseklet = Math.Round(atlaghomerseklet,2);
            Console.WriteLine("átlaghőmérséklet: "+atlaghomerseklet);
        }

        private static void feladat2()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("2.Feladat EGÉSZ SOROZAT:\n");
            Console.ForegroundColor = ConsoleColor.White;

            int jegyzetnapokdb;
            double osszeg;
            double atlag;
            double szorzat;
            double aktualisszam;

            jegyzetnapokdb = 5;
            osszeg = 0;
            szorzat = 1;
            

            for (int i = 0; i < jegyzetnapokdb; i++)
            {
                Console.Write("adj meg számokat: ");
                aktualisszam = Convert.ToDouble(Console.ReadLine());
                osszeg += aktualisszam;
                szorzat = szorzat * aktualisszam ;

            }
            Console.WriteLine();
            atlag = (osszeg / jegyzetnapokdb);
            atlag = Math.Round(atlag, 2);
            Console.WriteLine("összeg: " + osszeg);
            Console.WriteLine("átlag: " + atlag);
            Console.WriteLine("szorzat: " + szorzat);


        }

        private static void feladat3()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("3. Feladat KOLDUS BEVÉTELE");
            Console.ForegroundColor = ConsoleColor.White;

            int aktualisszam;
            double osszeg;
            double atlag;
            int db;

            osszeg = 0;
            db = 0;


            do
            {
                Console.Write("adj a koldusnak pénz (ha nem akarsz írj 0-át): ");
                aktualisszam = Convert.ToInt32(Console.ReadLine());
                osszeg += aktualisszam;
                db = db+1;
                atlag = (osszeg / db);

            } while ( aktualisszam != 0);
            Console.WriteLine();
            
            atlag = Math.Round(atlag, 2);
            Console.WriteLine("összeg: " + osszeg);
            Console.WriteLine("átlag: " + atlag);
            
        }

        private static void feladat4()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("4. Feladat TESTMAGASSÁGOK");
            Console.ForegroundColor = ConsoleColor.White;

            double[] magassagok;
            double atlag;
            int db;

            atlag = 0;
            magassagok = new double[10] { 2.10, 2, 1.95, 1.9, 2.12, 2.05, 1.85, 1.95, 1.92, 2 };
            db = 0;

            for (int i = 0; i < magassagok.Length; i++)
            {
                atlag += magassagok[i];
                db += 1;

                Console.WriteLine(String.Format("{0,5} játékos: {1,7} m",db,magassagok[i]));
            }
            atlag = atlag / db;
            atlag = Math.Round(atlag, 2);
            Console.WriteLine("Az átlag magasság: " + atlag+" m");
            


        }

        private static void feladat5()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("5. Feladat CSOPORTÁTLAG");
            Console.ForegroundColor = ConsoleColor.White;

            int[] jegyek;
            double atlag;
            int db;
            bool egesz;

            jegyek = new int[7];
            atlag = 0;
            db = 0;


            for (int i = 0; i < jegyek.Length; i++)
            {
                db += 1;

                Console.Write(db+". jegy: ");

                egesz = int.TryParse(Console.ReadLine(), out jegyek[i]);
                if ((egesz != true) || (jegyek[i] > 5 || jegyek[i] < 1))
                {
                    if (egesz != true)
                    { Console.WriteLine("nem egész szám"); }
                    else if (jegyek[i] > 5 || jegyek[i] < 1)
                    { Console.WriteLine("A szám nincs az intervalumban."); }

                    i = i - 1;
                    db -= 1;
                }

                else
                {
                    Console.WriteLine("ez jó");
                    atlag += jegyek[i];
                }





                
            }
            atlag = atlag / db;
            atlag = Math.Round(atlag, 2);
            Console.WriteLine("A jegyek átlaga: " + atlag);

        }

        private static void feladat6()
        { 
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("6. Feladat VÉLETLEN SZORZAT");
            Console.ForegroundColor = ConsoleColor.White;

            int[] veletlenszamok;
            Random rnd = new Random();
            double osszeg;
            double atlag;
            int szorzat;
            int db;

            Console.Write("adj meg egy egész számott: ");
            db = int.Parse(Console.ReadLine());
            veletlenszamok = new int[db];
            osszeg = 0;
            atlag = 0;
            szorzat = 1;

            for(int i = 0; i < veletlenszamok.Length; i++ )
            {
                veletlenszamok[i] = rnd.Next(10);

                Console.WriteLine("veletlenek["+(i+1)+"] = "+veletlenszamok[i]);

                osszeg = osszeg + veletlenszamok[i];
                szorzat = szorzat * veletlenszamok[i];
            }
            atlag = osszeg / db;
            atlag = Math.Round(atlag, 2);

            Console.WriteLine();
            Console.WriteLine("Összeg = "+osszeg);
            Console.WriteLine("Átlag = "+atlag);
            Console.WriteLine("Szorzat = "+szorzat);

        }

        private static void feladat7()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("7. Feladat PÉNZTÁRBLOKK ELLENŐRZÉSE");
            Console.ForegroundColor = ConsoleColor.White;

            int termekara;
            int osszeg;

            osszeg = 0;

            Console.WriteLine("Kérem a blokkon szereplő összegeket (Enterrel az összeg után)! ");
            Console.WriteLine("Ha (0), akkor vége az adatbevitelnek!\n");

            do
            {
                
                termekara = Convert.ToInt32(Console.ReadLine());
                osszeg = osszeg + termekara;


            } while (termekara != 0);
            Console.WriteLine("A tételek összege = "+ osszeg);
        }

        private static void feladat8()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("8. Feladat BEKÉRÉS ADOTT ÖSSZEG ELÉRÉSÉIG");
            Console.ForegroundColor = ConsoleColor.White;

            int szam;
            int szam2;
            int osszeg;

            osszeg = 0;
            szam2 = 0;

            Console.WriteLine("Kérek számokat ha az összegük eléri legalább a 100-at vége az adatbevitelnek!");
            Console.WriteLine("A számnak mindig nagyobnak kell lenni mint az előzőnek!");
            do
            {

                szam = Convert.ToInt32(Console.ReadLine());

                if(szam <= szam2)
                {
                    Console.WriteLine("ezt ("+szam+") nem adhatom hozá nem nagyobb mint "+szam2);
                }
                else
                {
                    osszeg = osszeg + szam;
                    szam2 = szam;
                }


            } while (osszeg < 100);

            osszeg = osszeg - szam;

            Console.WriteLine();
            Console.WriteLine("az utolső szám amit nem adunk hozá az összeghez az "+ szam);
            Console.WriteLine("A számok összege "+szam+" nélkül = "+ osszeg);
        }

        private static void feladat9()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("9. Feladat KARAKTERFÜZÉR");
            Console.ForegroundColor = ConsoleColor.White;

            int db;
            string karakterlanc;
            int hanyadik;

            Console.WriteLine("ad meg milyen hosszú a karakter lánc: ");
            db = int.Parse(Console.ReadLine());
            karakterlanc = "";

            for(int i = 0; i < db; i++)
            {
                Console.Write("karakterek["+i+"] = ");
                karakterlanc = karakterlanc + Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("A karakterfüzér tartalma: "+karakterlanc);
            Console.WriteLine();

            Console.Write("hanyadik karaktert kéred?");
            hanyadik = int.Parse(Console.ReadLine());

            if(hanyadik > karakterlanc.Length)
            {
                Console.WriteLine("nincs "+hanyadik+" indexű elem");
            }
            else
            {
                Console.WriteLine("karakterek["+hanyadik+"] = "+karakterlanc[hanyadik]);
            }
        }

        private static void feladat10()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("10. Feladat KÉRDŐJEL");
            Console.ForegroundColor = ConsoleColor.White;

            bool kerdojel;
            int i;
            string szoveg;

            kerdojel = false;
            i = 0;

            Console.Write("írj be egy szöveget: ");
            szoveg = Console.ReadLine();
            Console.WriteLine();

            while(i < szoveg.Length && kerdojel == false)
            {
                
                
                if (szoveg[i] == '?')
                {
                    kerdojel = true;
                }

                i++;

            }

            if(kerdojel == true)
            {
                Console.WriteLine("van a szövegben kérdőjel");
            }
            else
            {
                Console.WriteLine("nincs a szövegbe kérdőjel");
            }
        }

        private static void feladat11()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("11. Feladat MELEGEDÉS");
            Console.ForegroundColor = ConsoleColor.White;

            double[] Celsius;
            bool csökenes;
            double fok;

            Celsius = new double[6] { -5, -4.5,-2,-1,-0.5,-1 };
            csökenes = false;
            fok = 0;

            Console.WriteLine("A januári hőmérsékleteket egy tömbben tároljuk. Az értékek: ");
            for (int i = 0; i < Celsius.Length; i++)
            {
                Console.WriteLine("jamuár"+i+1+".: "+Celsius[i]+" Celsius");
                
                if(Celsius[i] < fok && i > 0)
                {
                    csökenes = true;
                }
                fok = Celsius[i];
            }

            if(csökenes)
            {
                Console.WriteLine("Az adott hónapban nem emelkedett folyamatosan a napi átlaghőmérséklet.");
            }
            else
            {
                Console.WriteLine("Az adott hónapban folyamatosan nőt a napi átlag hőmérséklet.");
            }
        }

        private static void feladat12()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("12. Feladat HÓNAP-E");
            Console.ForegroundColor = ConsoleColor.White;

            string[] honapok;
            bool honape;
            string szoveg;
            string kisszoveg;
            int i;

            honapok = new string[] {"január", "február", "március","április","május","június","július","augusztus","szeptember","október","november","december"};
            honape = false;
            i = 0;
            Console.Write("kérem egy hónap nevét: ");
            szoveg = Console.ReadLine();
            kisszoveg = szoveg.ToLower();
            Console.WriteLine();

            while(i < honapok.Length && honape == false)
            {
                if(szoveg == honapok[i] || kisszoveg == honapok[i])
                {
                    honape = true;
                }

                i++;
            }
            if(honape)
            {
                Console.WriteLine("A beírt érték hónapnév.");
            }
            else
            {
                Console.WriteLine("A beírt érték nem hónapnév.");
            }
        }

        private static void feladat13()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("13. Feladat BUKOTT-E");
            Console.ForegroundColor = ConsoleColor.White;

            string[] tantargyak;
            int[] jegyek;
            int i;
            bool bukot;

            tantargyak = new string[] { "Magyar nyelv","Magyar irodalom","Matematika","Angol","Testnevelés","Programozás" };
            jegyek = new int[] {2,1,3,4,2,5 };
            i = 0;
            bukot = false;

            while(i < jegyek.Length && bukot == false)
            {
                Console.WriteLine(tantargyak[i]+": " + jegyek[i]);
                if(jegyek[i] == 1)
                { 
                    bukot = true; 
                }
                i++;
            }
            if(bukot)
            {
                Console.WriteLine("A diák bukott legalább egy tantárgyból");
            }
            else
            {
                Console.WriteLine("A diák nem bukott semiből");
            }
        
        
        
        }

        private static void feladat14()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("14. Feladat KITŰNŐ");
            Console.ForegroundColor = ConsoleColor.White;

            string[] tantargyak;
            int[] jegyek;
            int i;
            bool nemkituno;

            tantargyak = new string[] { "Magyar nyelv", "Magyar irodalom", "Matematika", "Angol", "Testnevelés", "Programozás" };
            jegyek = new int[] { 5, 5, 5, 5, 5, 5 };
            i = 0;
            nemkituno = false;

            while (i < jegyek.Length && nemkituno == false)
            {
                Console.WriteLine(tantargyak[i] + ": " + jegyek[i]);
                if (jegyek[i] <= 4)
                {
                    nemkituno = true;
                }
                i++;
            }
            if (nemkituno)
            {
                Console.WriteLine("A diák nem ktűnő tanuló");
            }
            else
            {
                Console.WriteLine("A diák kitűnő tanuló");
            }
        }

        private static void feladat15()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("15. Feladat PÁRATLAN");
            Console.ForegroundColor = ConsoleColor.White;

            int[] szamok;
            int i;
            int i2;
            int i3;
            bool paratlan;
            bool paros;

            szamok = new int[10] { -10, -7, -4, -1, 2, 5,8,11,14,17 };
            i = 0;
            i2 = 0;
            i3 = 0;
            paratlan = false;
            paros = false;
    
            
            for (int j = 0; j< szamok.Length;j++)
            {
                Console.Write(szamok[j]+", ");
            }
            Console.WriteLine();

            Console.WriteLine("a., Van-e közöttük páratlan szám?");
            while (i < szamok.Length && paratlan == false)
            {
                Console.Write(szamok[i] + ", ");
                if(szamok[i] % 2 != 0)
                {
                    paratlan = true;
                }

                i++;
            }
            if(paratlan)
            {
                Console.WriteLine("volt páratlan");
            }
            else
            {
                Console.WriteLine("nem volt páratlan szám");
            }




            Console.WriteLine("b., Minden szám páratlan-e?");
            while (i2 < szamok.Length && paros == false)
            {
                Console.Write(szamok[i2] + ", ");
                if(szamok[i2] % 2 == 0)
                {
                    paros = true;
                }

                i2++;
            }
            if(paros)
            {
                Console.WriteLine("nem minden páratlan");
            }
            else
            {
                Console.WriteLine("minden páratlan");
            }


            Console.WriteLine("c., Számtani sorozat?");
            int szam;
            int kulonbseg;
            szam = 0;
            kulonbseg = 0;
            int elozokulonbseg = 0;
            int sorozat = 0;
            
            while (i3 < szamok.Length)
            {
                kulonbseg = szam - szamok[i3];

                Console.Write(szamok[i3] + ", ");
                
                if(elozokulonbseg == kulonbseg)
                {
                    sorozat += 1;
                }

                szam = szamok[i3];

                elozokulonbseg = kulonbseg;

                i3++;
                Console.WriteLine(sorozat);

            }
            if (sorozat+2 == i3)
            {
                Console.WriteLine("az elemek számtani sorozatott alkotnak.");
            }
            else
            {
                Console.WriteLine("az elemek számtani sorozatott nem alkotnak.");
            }

        }

        private static void feladat16()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("16. Feladat ELSŐ PÁROS");
            Console.ForegroundColor = ConsoleColor.White;

            int[] szamok;

            szamok = new int[] { -11, -7, 5, -1, 2, 5, 8, 11, 14, 17,-11,-7,5,-1 };

            
            for(int i = 0; i < szamok.Length; i++)
            {
                if(szamok[i] % 2 == 0)
                {
                    Console.WriteLine("az első páros szám: "+szamok[i]);
                    break;
                }
            }
        }

        private static void feladat17()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("17. Feladat SZÓKÖZ HELYE");
            Console.ForegroundColor = ConsoleColor.White;

            string szöveg;

            szöveg = "ebben a szövegben van space";

            for (int i = 0; i < szöveg.Length; i++)
            {
                if (szöveg[i] == ' ')
                {
                    Console.WriteLine("az első space sorszáma (0 az első): " + i);
                    break;
                }
            }
        }

        private static void feladat18()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("18. Feladat HÓNAP SORSZÁMA");
            Console.ForegroundColor = ConsoleColor.White;

            string[] honapok;
            string szoveg;
            string kisszoveg;
            int i;

            honapok = new string[] { "január", "február", "március", "április", "május", "június", "július", "augusztus", "szeptember", "október", "november", "december" };
            i = 0;
            Console.Write("kérem egy hónap nevét: ");
            szoveg = Console.ReadLine();
            kisszoveg = szoveg.ToLower();
            Console.WriteLine();

            while (i < honapok.Length )
            {
                if (szoveg == honapok[i] || kisszoveg == honapok[i])
                {
                    Console.WriteLine(i+1 +". hónap a "+ szoveg);
                }

                i++;
            }

        }

        private static void feladat19()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("19. Feladat HALLGATÓ KERESZTNEVE");
            Console.ForegroundColor = ConsoleColor.White;

            string[] hallgatok;
            bool peter;

            hallgatok = new string[8] { "Nagy Lajos", "Kovách Martin", "Kiss Béla", "Juhász Patrik", "Boros Déniel", "Márton Anna", "Kléber Gergely", "Molnár Péter" };
            peter = false;

            for(int i = 0; i < hallgatok.Length; i++)
            {
                if(hallgatok[i].EndsWith("Péter"))
                {
                    peter = true;
                    Console.WriteLine("van Péter nevű hallgató. Sorszáma: " + i + "  Teljes neve: " + hallgatok[i]);
                }
            }
            if(peter == false)
            {
                Console.WriteLine("nincs Péter nevű hallgató");
            }
            
        }

        private static void feladat20()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("20. Feladat NEGATÍV ÉRTÉK");
            Console.ForegroundColor = ConsoleColor.White;

            int[] szamok;
            bool negativ;

            szamok = new int[5] { 11, 7, 5, -1, 2, };
            negativ = false;

            for (int i = 0; i < szamok.Length; i++)
            {
                if (szamok[i] < 0)
                {
                    negativ = true;
                    Console.WriteLine("az első negatív elem: " + szamok[i]);
                    
                }
            }
            if(negativ == false)
            {
                Console.WriteLine("nincs negatív elem");
            }


        }

        private static void feladat21()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("21. Feladat KÉRDŐJEL");
            Console.ForegroundColor = ConsoleColor.White;

            string szöveg;
            bool kerdojel;

            szöveg = "ebben ? a szövegben van ";
            kerdojel = false;

            for (int i = 0; i < szöveg.Length; i++)
            {
                if (szöveg[i] == '?')
                {
                    Console.WriteLine("az első ? sorszáma : "+ (i+1));
                    kerdojel = true;
                    break;
                }
            }
            if(kerdojel == false)
            {
                Console.WriteLine("nincs ?");
            }
        }

        private static void feladat22()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("22. Feladat FELKIÁLTÓJELEK SZÁMA");
            Console.ForegroundColor = ConsoleColor.White;

            string szoveg;
            int felkialtodb;

            Console.Write("írj be egy szövegett: ");
            szoveg = Console.ReadLine();
            Console.WriteLine();
            felkialtodb = 0;

            for(int i = 0; i<szoveg.Length;i++)
            {
                if(szoveg[i] == '!')
                {
                    felkialtodb += 1;
                }
            }

            Console.WriteLine("A szövegben "+felkialtodb+"db ! van.");
        }

        private static void feladat23()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("23. Feladat LÉTMINIMUM ALATT");
            Console.ForegroundColor = ConsoleColor.White;

            int[] letszam;
            int[] jovedelem;
            int letminimum_allat;
            int oszletszam;
            int oszjovedelem;
            int egyfojovedelem;


            letminimum_allat = 0;
            letszam = new int[] { 2,6,3,4,1 };
            jovedelem = new int[] { 10000,7000,14000,9909,57000 };
            oszletszam = 0;
            oszjovedelem = 0;

            for (int i=0; i < letszam.Length;i++)
            {
                oszletszam += letszam[i];
                oszjovedelem += jovedelem[i];
            }
            egyfojovedelem = oszjovedelem / oszletszam;
            Console.WriteLine(egyfojovedelem);
            for(int i2=0; i2<letszam.Length;i2++)
            {
                if(letszam[i2] * egyfojovedelem < jovedelem[i2])
                {
                    letminimum_allat += 1;
                }
            }
            Console.WriteLine(letminimum_allat+" család van a létminimum alatt.");

        }

        private static void feladat24()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("24. Feladat MAGÁNHANGZÓK SZÁMA");
            Console.ForegroundColor = ConsoleColor.White;

            char[] maganhang;
            string szoveg;
            string kisszoveg;
            int i2;
            int db;

            maganhang = new char[] { 'a', 'á', 'e', 'é', 'i', 'í', 'o', 'ó', 'ö', 'ő', 'u', 'ú', 'ü', 'ű' };
            szoveg = "Ez itt a szöveg";
            kisszoveg = szoveg.ToLower();
            db = 0;

            Console.WriteLine("A szöveg: "+szoveg);
            for(int i = 0; i<kisszoveg.Length;i++)
            {
                i2 = 0;
                while (i2<maganhang.Length)
                {
                    if(kisszoveg[i] == maganhang[i2])
                    {
                        db++;
                    }
                    
                    i2++;
                }
                
                    /*
                for (int i2 = 0; i2 < maganhang.Length; i2++)
                {

                }*/
            }
            Console.WriteLine("A szövegben "+db+" magánhangzó van.");


        }

        private static void feladat25()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("25. Feladat OLIMPIAI KVALIFIKÁCIÓ");
            Console.ForegroundColor = ConsoleColor.White;

            int versenyzokszam;
            double bejutasihatar;
            int tovabbjut;

            tovabbjut = 0;
            bejutasihatar = 2;
            Console.Write("Ad meg a versenyzők számátt: ");
            versenyzokszam =int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Az olimpiai csapatba jutás határa: "+bejutasihatar);

            double[] versenyzoido;
            versenyzoido = new double[versenyzokszam];

            for(int i = 0; i< versenyzoido.Length; i++)
            {
                Console.Write("eredmények ["+i+"] = ");
                versenyzoido[i]= Convert.ToDouble(Console.ReadLine());
                
                if(versenyzoido[i] >= bejutasihatar)
                {
                    tovabbjut++;
                }
            }
            double szazalek =  Convert.ToDouble(tovabbjut) / Convert.ToDouble(versenyzokszam) * 100;
            Console.WriteLine("Induló versenyzők száma : {0} fő, ebből {1} fő jutott be az olimpiai csapatba, ami {2}%-ot jelent",versenyzokszam,tovabbjut,szazalek );




        }

        private static void feladat26()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("26. Feladat LÁZ");
            Console.ForegroundColor = ConsoleColor.White;

            string[] betegek;
            double[] lazlap;
            double legmagasabblaz;
            int legmagasabblazindex;

            betegek = new string[10] {"Lajos","Béla","Patrik","Dani","Jancsi","Ching","Gergő","Mária","Magdi","júlia" };
            lazlap = new double[10] {12.6,21.3,38.2,3.4,26.3,45.7,25.4,28.8,28,7 };
            legmagasabblaz = 0;
            legmagasabblazindex = 0;
        
            for(int i = 0; i<lazlap.Length;i++)
            {
                if(lazlap[i] > legmagasabblaz)
                {
                    legmagasabblaz = lazlap[i];
                }

            }
            for(int i2 = 0; i2<lazlap.Length;i2++)
            {
                if(lazlap[i2] == legmagasabblaz)
                {
                    legmagasabblazindex = i2;
                }
            }
            Console.WriteLine(betegek[legmagasabblazindex]+" rendelkezik a legmagasabb lázal ami "+legmagasabblaz);
        
        }

        private static void feladat27()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("27. Feladat BEVÉTELEK");
            Console.ForegroundColor = ConsoleColor.White;

            string[] napok;
            double[] bevetel;
            double legmagasabb;
            int legmagasabbindex;
            double legkisebb;
            int legkisebbindex;

            napok = new string[7] { "hétfő","kedd","szerda","csütörtök","péntek","szombat","vasárnap" };
            bevetel = new double[7] { 12.6, 21.3, 38.2, 3.4, 26.3, 45.7, 25.4 };
            legmagasabb = 0;
            legmagasabbindex = 0;
            
            legkisebbindex = 0;

            for (int i = 0; i < bevetel.Length; i++)
            {
                if (bevetel[i] > legmagasabb)
                {
                    legmagasabb = bevetel[i];
                }
               
            }

            legkisebb = legmagasabb;
            for (int i2 = 0; i2 < bevetel.Length; i2++)
            {
                if (bevetel[i2] < legkisebb)
                {
                    legkisebb = bevetel[i2];
                }

            }

            for (int i3 = 0; i3 < bevetel.Length; i3++)
            {
                if (bevetel[i3] == legmagasabb)
                {
                    legmagasabbindex = i3;
                }
                if (bevetel[i3] == legkisebb)
                {
                    legkisebbindex = i3;
                }
            }
            Console.WriteLine("A legkisebb bevétel és napja: "+legkisebb+" "+napok[legkisebbindex]+ ", A legnagyobb bevétel és napja: " + legmagasabb + " " + napok[legmagasabbindex]);

        }

        private static void feladat28()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("28. Feladat LEGROSSZABB JEGY");
            Console.ForegroundColor = ConsoleColor.White;

            int[] jegyek;
            int legrosszabb_jegy;
            int legjobb_jegy;

            jegyek = new int[] { 3,4,5,3,5,4,5,3 };
            legjobb_jegy = 0;
            legrosszabb_jegy = 0;


            for (int i = 0; i < jegyek.Length; i++)
            {
                if (jegyek[i] > legjobb_jegy)
                {
                    legjobb_jegy = jegyek[i];
                }

            }

            legrosszabb_jegy = legjobb_jegy;
            for (int i2 = 0; i2 < jegyek.Length; i2++)
            {
                if (jegyek[i2] < legrosszabb_jegy)
                {
                    legrosszabb_jegy = jegyek[i2];
                }

            }

            Console.Write("A legroszabb jegy: " + legrosszabb_jegy + " aminek a helye(i): ");

            for (int i3 = 0; i3 < jegyek.Length; i3++)
            {
                if (jegyek[i3] == legrosszabb_jegy)
                {
                    Console.Write(i3+", "); 
                }
                
            }
            Console.WriteLine();

        }
    }
}
