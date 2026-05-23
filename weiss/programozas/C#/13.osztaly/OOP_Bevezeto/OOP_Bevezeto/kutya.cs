using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Bevezeto
{
    public class kutya
    {
        public string fajta;
        public string neme;
        public string szin;
        public int eletkor;
        
        public kutya(string fajtaja)
        {
            this.fajta = "kutya";
        }
        public kutya()
        {
            szin = "nem meghatározott";
            neme = "nem meghatározott";
        }
        /*
        public kutya(string fajtaja="chiwawa", string nem="kan",string szine="fehér",int kora=1)
        {
            this.fajta = fajtaja;
            this.neme = nem;
            this.szin = szine;
            this.eletkor = kora;
        }
        */
        public void kiir()
        {
            Console.WriteLine("fajta: "+fajta);
            Console.WriteLine("Neme: "+neme);
            Console.WriteLine("Szine: " +szin);
            Console.WriteLine("Életkora: "+eletkor);
            Console.WriteLine();
        }
    }
}
