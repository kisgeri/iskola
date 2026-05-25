using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Kalapacsvetes
{
    internal class Program
    {
        static List<Sportolo> adatok = new List<Sportolo>();
        static void Main(string[] args)
        {
            olvasas();
            feladat4();
            feladat5();
            feladat6();
            feladat7();
            feladat8();
        }

        private static void feladat8()
        {
            StreamWriter irocsatorna = new StreamWriter("magyarok.txt");

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].orszagkod == "HUN")
                {
                    irocsatorna.WriteLine($"{adatok[i].eredmeny}");
                }
            }

            irocsatorna.Close();
        }

        private static void feladat7()
        {
            HashSet<string> orszagok = new HashSet<string>();

            for (int i = 0; i < adatok.Count; i++)
            {
                orszagok.Add(adatok[i].orszagkod);
            }

            foreach (string orszag in orszagok)
            {
                int darab = 0;

                for (int i = 0; i < adatok.Count; i++)
                {
                    
                    if (orszag == adatok[i].orszagkod)
                    {
                        darab++;
                    }
                }
                
                Console.WriteLine($"\t{orszag} - {darab} dobás");
                darab = 0;
            }
        }

        private static void feladat6()
        {

            Console.WriteLine($"6. feladat: adjon meg egy évszámot:");

            int evszam = Convert.ToInt32( Console.ReadLine() );
            List<string> legjobbakevben = new List<string>();

            for (int i = 0; i < adatok.Count; i++)
            {
                string[] darabol = adatok[i].datum.Split('.');
                int evszamel = Convert.ToInt32(darabol[0]);

                if (evszamel == evszam)
                {
                    legjobbakevben.Add(adatok[i].nev);
                }
            }

            if(legjobbakevben.Count>0)
            {
                Console.WriteLine($"\t{legjobbakevben.Count} darab dobás került be ebben az évben.");
                for (int i = 0; i < legjobbakevben.Count; i++)
                {
                    Console.WriteLine("\t" + legjobbakevben[i]);
                }
            }
            else
            {
                Console.WriteLine("\tEgy dobás sem került be ebben az évben.");
            }


        }

        private static void feladat5()
        {
            double hunatlag = 0;
            double hundb = 0;
            

            for (int i = 0; i < adatok.Count; i++)
            {
                if (adatok[i].orszagkod=="HUN")
                {
                    hunatlag += adatok[i].eredmeny;
                    hundb++;
                }
            }
            Console.WriteLine($"5. feladat: A magyar sportolók átlagosan {Math.Round(hunatlag / hundb,2)} métert dobtak.");
        }

        private static void feladat4()
        {
            Console.WriteLine($"4. feladat: {adatok.Count} dobás eredménye található.");
        }

        private static void olvasas()
        {
            StreamReader olvasocsatorna = new StreamReader("kalapacsvetes.txt");
            string sor = olvasocsatorna.ReadLine();

            while(!olvasocsatorna.EndOfStream)
            {
                sor = olvasocsatorna.ReadLine();
                
                Sportolo adat = new Sportolo(sor);
                adatok.Add(adat);
            }

            olvasocsatorna.Close();
        }
    }
}
