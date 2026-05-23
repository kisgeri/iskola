using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateGUI
{
    public class hirdetesek
    {
        public string nev;
        public string telefonSzam;
        public string kategoria;
        public int szobak;
        public double alapterulet;
        public int emelet;

        public hirdetesek(string sor)
        {
            string[] darabol = sor.Split(';');

            this.nev = darabol[10];
            this.telefonSzam = darabol[11];
            this.kategoria = darabol[13];
            this.szobak = int.Parse(darabol[1]);
            this.alapterulet = double.Parse(darabol[4]);
            this.emelet = int.Parse(darabol[3]);
        }
    }
}
