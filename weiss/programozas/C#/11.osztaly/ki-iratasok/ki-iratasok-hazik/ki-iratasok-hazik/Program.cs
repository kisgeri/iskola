using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ki_iratasok_hazik
{
    class Program
    {
        static void Main(string[] args)
        {
            //füzetbe lévők
            //órai munka
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("{0}*{1}={2}",3,2,3*2);//formátum string több dolog ki írása
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("képernyőre igazítás");
            Console.WriteLine();
            Console.WriteLine("ballról kitöltés".PadLeft(30,'-'));
            Console.WriteLine("következő érték".PadLeft(30,'-'));
            Console.WriteLine("harmadik érték".PadLeft(30, '-'));
            Console.ReadKey();
            Console.WriteLine();

            Console.WriteLine("tabulátoros kíírás\n");
            Console.Write("\t első");
            Console.WriteLine("\t második");
            Console.Write("\t harmadik");
            Console.WriteLine("\t negyedik");
            Console.ReadKey();

            Console.WriteLine("\n ki iratás str for (táblázat)\n");
            Console.WriteLine("{0}*{1}={2}\n", 3, 2, 3 * 2);
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine("| vezték név | kereszt név | darab  |");
            Console.WriteLine("|-----------------------------------|");
            Console.WriteLine(String.Format ("| {0,-10} | {1,-11} | {2,-7}|","Kiss","Edina",51));
            Console.WriteLine(String.Format("| {0,-10} | {1,-11} | {2,-7}|", "Kovács", "Éva", 1104));
            Console.WriteLine(String.Format("| {0,-10} | {1,-11} | {2,-7}|", "Csépi", "Richárd", 44));
            Console.WriteLine("|-----------------------------------|");
            Console.ReadKey();
            Console.WriteLine();

            //osztály társak tábla
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine("| vezték név | kereszt név | értékelés |");
            Console.WriteLine("|--------------------------------------|");
            Console.WriteLine(String.Format("| {0,-10} | {1,-11} | {2,-10}|", "Kis", "Gergely", 5));
            Console.WriteLine(String.Format("| {0,-10} | {1,-11} | {2,-10}|", "Boros", "Daniel", 4));
            Console.WriteLine(String.Format("| {0,-10} | {1,-11} | {2,-10}|", "Juhász", "Patrik", 5));
            Console.WriteLine("|--------------------------------------|");
            Console.ReadKey();
            Console.WriteLine();

            //karácsonyfa
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*".PadLeft(10));
            Console.WriteLine("***".PadLeft(11));
            Console.WriteLine("*****".PadLeft(12));
            Console.WriteLine("***".PadLeft(11));
            Console.WriteLine("*".PadLeft(10));

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×".PadLeft(10));
            Console.WriteLine("×××".PadLeft(11));

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o".PadLeft(8));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o".PadLeft(7));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o".PadLeft(5));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("××");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×".PadLeft(4));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×××");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×".PadLeft(3));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×××");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o".PadLeft(7));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o".PadLeft(5));
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("××");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×".PadLeft(4));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×××");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×".PadLeft(3));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×××");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×".PadLeft(2));
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("××××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×××××");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("o");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×××");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("×××××××");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("ł");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("×××××");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("HH".PadLeft(11));
            Console.WriteLine("HH".PadLeft(11));
            Console.WriteLine("------".PadLeft(13));



            Console.ReadKey();
            Console.WriteLine();


            //házi
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Házi");
            Console.WriteLine();
            Console.WriteLine("igazitás a sor közepére");
            Console.WriteLine();
            Console.WriteLine("{0," + (Console.WindowWidth/2+"Hello világ".Length/2)+"}","Hello világ");
            Console.WriteLine();

            Console.WriteLine("név díszesen középre");
            Console.WriteLine();
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "-------------------".Length / 2) + "}", "-------------------");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~###~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#####~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#####~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#######~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#######~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#########~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~###########~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|>>>>>>>>>#Kis Gergely#<<<<<<<<<|".Length / 2) + "}", "|>>>>>>>>>#Kis Gergely#<<<<<<<<<|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~###########~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#########~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#########~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#######~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#######~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#####~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#####~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~###~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~###~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~#~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~#~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "|=-~~~~~~~~~~~~~~~-=|".Length / 2) + "}", "|=-~~~~~~~~~~~~~~~-=|");
            Console.WriteLine("{0," + (Console.WindowWidth / 2 + "-------------------".Length / 2) + "}", "-------------------");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("**********".PadLeft(10));
            Console.WriteLine("************".PadLeft(10));
            Console.WriteLine("**************".PadLeft(10));
            Console.WriteLine("******************".PadLeft(10));
            Console.WriteLine("**************".PadLeft(10));
            Console.WriteLine("************".PadLeft(10));
            Console.WriteLine("**********".PadLeft(10));
            
            

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("családfa");
            Console.WriteLine();
            Console.Write(String.Format(" {0,-10} ", "Kis Jenő"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(String.Format(" éllettárs:({0,-10}) ", "Márton amália"));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("{0,20} ", "|-Kis Gergely"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(String.Format(" éllettárs:({0,-10}) ", ""));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(String.Format("{0,21} ", "|-Kis Boglárka"));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(String.Format(" éllettárs:({0,-10}) ", ""));




            Console.ReadKey();
        }
    }
}
