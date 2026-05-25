using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalapacsvetes
{
    internal class Sportolo
    {
        public int helyezes;
        public double eredmeny;
        public string nev;
        public string orszagkod;
        public string helyszin;
        public string datum;

        public Sportolo(string sor)
        {
            string[] darabol = sor.Split(';');

            this.helyezes = int.Parse(darabol[0]);
            this.eredmeny = double.Parse(darabol[1]);
            this.nev = darabol[2];
            this.orszagkod = darabol[3];
            this.helyszin = darabol[4];
            this.datum = darabol[5];
        }
    }

    
}
