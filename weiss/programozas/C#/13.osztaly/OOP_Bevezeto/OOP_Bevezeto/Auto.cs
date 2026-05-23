using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Bevezeto
{
    public class Auto
    {
        string marka;
        int loero;
        int kmora;



        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }


        public int Loero
        {
            get { return loero; }
            set { loero = value; } //value értékel hivatkozunk a fő programban megadott értékre
        }



        public Auto(string marka, int loero, int kmora)
        {
            this.marka = marka;
            this.loero = loero;
            this.kmora = kmora;


        }

        

        public void kiir()
        {
            Console.WriteLine($"{marka} {loero} {kmora}");
            Console.WriteLine();
        }
    }


}
