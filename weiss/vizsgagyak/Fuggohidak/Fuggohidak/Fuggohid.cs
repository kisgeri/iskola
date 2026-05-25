using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Fuggohidak
{
    public class Fuggohid
    {
        public int helyezes;
        public string nev;
        public string hely;
        public string orszag;
        public double hossz;
        public int ev;

        public Fuggohid(string sor)
        {
            string[] darabol = sor.Split('\t');

            this.helyezes = int.Parse(darabol[0]);
            this.nev = darabol[1];
            this.hely = darabol[2];
            this.orszag = darabol[3];
            this.hossz = double.Parse(darabol[4]);
            this.ev = int.Parse(darabol[5]);
        }
    }
}
