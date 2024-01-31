using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyumolcsok
{
    internal class Gyumolcs
    {
        int termekkod;
        string nev;
        int mennyiseg;

        public int Termekkod { get => termekkod; set => termekkod = value; }
        public string Nev { get => nev; set => nev = value; }
        public int Mennyiseg { get => mennyiseg; set => mennyiseg = value; }

        public Gyumolcs(int termekkod, string nev, int mennyiseg)
        {
            Termekkod = termekkod;
            Nev = nev;
            Mennyiseg = mennyiseg;
        }

        public override string ToString()
        {
            return $"{this.nev} ({this.Mennyiseg} db)";
        }

        public string toTxt()
        {
            return $"{(int)termekkod};{this.nev};{(int)mennyiseg}";
        }
    }
}

