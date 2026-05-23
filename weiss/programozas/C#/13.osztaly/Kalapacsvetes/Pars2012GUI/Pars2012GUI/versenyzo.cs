using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012GUI
{
    internal class versenyzo
    {
        public string nev;
        public string csoport;
        public string nemzet;
        public string sorozat;
        public double d1;
        public double d2;
        public double d3;

        public versenyzo(string sor)
        {
            string[] darabol;
            darabol = sor.Split(';');

            this.nev = darabol[0];
            this.csoport = darabol[1];
            this.nemzet = darabol[2];

            this.sorozat = $"{darabol[3]};{darabol[4]};{darabol[5]}";

            if (darabol[3] == "X")
            {
                this.d1 = -1;
            }
            else if (darabol[3] == "-")
            {
                this.d1 = -2;
            }
            else
            {
                this.d1 = double.Parse(darabol[3]);
            }

            if (darabol[4] == "X")
            {
                this.d2 = -1;
            }
            else if (darabol[4] == "-")
            {
                this.d2 = -2;
            }
            else
            {
                this.d2 = double.Parse(darabol[4]);
            }

            if (darabol[5] == "X")
            {
                this.d3 = -1;
            }
            else if (darabol[5] == "-")
            {
                this.d3 = -2;
            }
            else
            {
                this.d3 = double.Parse(darabol[5]);
            }


        }

        public double Eredmeny()
        {
            double maximum = d1;
            if (d2 > maximum)
            {
                maximum = d2;
            }
            if (d3 > maximum)
            {
                maximum = d3;
            }

            return maximum;
        }
        public string Nemzet()
        {
            string[] darabol = nemzet.Split('(');
            return darabol[0];
        }

        public string Kod()
        {
            string kod = "";
            string tisztakod = "";
            string[] darabol = nemzet.Split('(');

            kod = darabol[1];
            //replace kelett volna, de nem emlékszem rá
            tisztakod += kod[0];
            tisztakod += kod[1];
            tisztakod += kod[2];

            return tisztakod;
        }
    }
}
