using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace k.g.j_kiiratas_dolg_outputformating
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            Console.WriteLine("1 2 3 4");
            Console.WriteLine("1 2 3");
            Console.WriteLine("1 2");
            Console.WriteLine("1");

            //2. feladat
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("××××××××××××××××××××××××××××××××××××××");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Algoritmus feladat – Kis Gergely Jenő");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("××××××××××××××××××××××××××××××××××××××");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Várakozás 5 mp-ig…");
            System.Threading.Thread.Sleep(5000);//várakozás 5mp-ig
            Console.WriteLine("Letelt az 5 mp");
            Console.ForegroundColor = ConsoleColor.Red;//szinezés pirosra
            Console.WriteLine("Üss le egy billentyűt (bármilyet)!");
            Console.ReadKey();//bármely billentyű leütése
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sikeres billentyűleütés, a program folytatódik.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nyomj Entert!");
            Console.ReadLine();//enter leütése
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Köszönöm, a program véget ért.");
            System.Threading.Thread.Sleep(2000);
            


            //3. feladat
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("########################################################################################");
            Console.WriteLine("########################################################################################");
            Console.Write("##| ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Kis Gergely Jenő ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Kisgergely48@gmail.com ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("06706680518 ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("| ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Dunaharaszti utca 21/b");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" |##");
            Console.WriteLine("########################################################################################");
            Console.WriteLine("########################################################################################");
            
            //4. feladat
            Console.WriteLine("---------------------------------");
            Console.WriteLine(" Vezetéknév | Keresztnév | Darab ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(String.Format(" {0,-10} | {1,-10} | {2,5}", "Kiss", "Edina", 51));
            Console.WriteLine(String.Format(" {0,-10} | {1,-10} | {2,5}", "Kovács", "Éva", 1104));
            Console.WriteLine(String.Format(" {0,-10} | {1,-10} | {2,5}", "Csépi", "Richárd", 440));
            Console.WriteLine("---------------------------------");
            Console.ReadLine();

            Console.WriteLine("---------------------------------");
            Console.WriteLine(" Sorszám | Feladat leírása ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine(String.Format(" {0,7} | {1,-10}", 1, "Számsor"));
            Console.WriteLine(String.Format(" {0,7} | {1,-10}", 2, "Algoritmus"));
            Console.WriteLine(String.Format(" {0,7} | {1,-10}", 3, "Névjegykártya"));
            Console.WriteLine(String.Format(" {0,7} | {1,-10}", 4, "Táblázat"));
            Console.WriteLine(String.Format(" {0,7} | {1,-10}", 5, "Csillagok"));
            Console.WriteLine(String.Format(" {0,7} | {1,-10}", 6, "Számítás"));
            Console.WriteLine("---------------------------------");
            Console.ReadLine();
            
            //5. feladat
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("***".PadLeft(9));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("***\n".PadLeft(9));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("***".PadLeft(9));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("***\n".PadLeft(9));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("***");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("***".PadLeft(9));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("***\n".PadLeft(9));

            //6. feladat
            Console.WriteLine("a választott számok: 10 és 2");
            Console.WriteLine("A számok szorzata:");
            Console.WriteLine("\t{0} * {1} = {2}",10,2,10*2);
            Console.WriteLine("A számok különbsége:");
            Console.WriteLine("\t{0} - {1} = {2}", 10, 2, 10 - 2);
            Console.WriteLine("A számok összege:");
            Console.WriteLine("\t{0} + {1} = {2}", 10, 2, 10 + 2);








            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
