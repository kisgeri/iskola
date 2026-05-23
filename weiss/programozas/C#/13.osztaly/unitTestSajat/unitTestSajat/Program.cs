using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GyepKalkulatorNS
{
    public class GyepKalkulator
    {
        private double gyepterulet;
        private double osszar;

        public void GyepesitestSzamol(double atmero)
        {
            double r = atmero / 2;
            gyepterulet = ((r * r) * 3.14) / 2;
            osszar = gyepterulet * 2500;

            gyepterulet = Math.Round(gyepterulet, 4);
            osszar = Math.Round(osszar, 2);
        }

        //Property-k: Olvasható adatok, de nem írhatóak közvetlenül(nem tudom mi ez)
        public double Gyepterulet
        {
            get { return gyepterulet; }
        }

        public double Osszar
        {
            get { return osszar; }
        }

        public static void Main()
        {
            //Adott egy kör alakú telek. A telek felének gyepesítését nekünk kell megoldani.
            Console.WriteLine("gyepesítés");

            GyepKalkulator kalkulator = new GyepKalkulator();

            Console.Write("Add meg az átmérőt: ");
            double atmero = Convert.ToDouble(Console.ReadLine());

            
            kalkulator.GyepesitestSzamol(atmero);

            Console.WriteLine();
            Console.WriteLine("{0} négyzetméter gyeptégla kell ami {1} Ft-ba kerül",kalkulator.Gyepterulet, kalkulator.Osszar);

            Console.ReadKey();
        }
    }
}