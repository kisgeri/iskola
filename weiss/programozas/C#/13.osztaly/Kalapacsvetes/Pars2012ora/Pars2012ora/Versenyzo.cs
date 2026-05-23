using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012ora
{
    public class Versenyzo
    {
        public string nev;
        public char csoport;
        public string nemzeteskod;
        public string sorozat;
        public double d1;
        public double d2;
        public double d3;

        private string nemzet;
        private string kod;


        public Versenyzo(string sor)
        {
            string[] darbol;
            darbol = sor.Split(';');

            this.nev = darbol[0];
            this.csoport = Convert.ToChar(darbol[1]);
            this.nemzeteskod = darbol[2];

            this.sorozat = $"{darbol[3]};{darbol[4]};{darbol[5]}";

            if (darbol[3] == "X")
            {
                this.d1 = -1;
            }
            else if(darbol[3] == "-")
            {
                this.d1 = -2;
            }
            else
            {
                this.d1 = double.Parse(darbol[3]);
            }

            if (darbol[4] == "X")
            {
                this.d2 = -1;
            }
            else if (darbol[4] == "-")
            {
                this.d2 = -2;
            }
            else
            {
                this.d2 = double.Parse(darbol[4]);
            }

            if (darbol[5] == "X")
            {
                this.d3 = -1;
            }
            else if (darbol[5] == "-")
            {
                this.d3 = -2;
            }
            else
            {
                this.d3 = double.Parse(darbol[5]);
            }
        }

        public void kiir()
        {
            Console.WriteLine($"{nev};{csoport};{nemzeteskod},{sorozat}");
        }

        public double Eredmeny => Math.Max(d1, Math.Max(d2, d3));

        public string Nemzet
        {

            get
            {
                nemzet = nemzeteskod.Split('(')[0].TrimEnd();
                return nemzet;
            }

        }

        public string Kod
        {

            get
            {
                kod = nemzeteskod.Split('(')[1].TrimEnd(')');
                return kod;
            }

        }
    }
}
