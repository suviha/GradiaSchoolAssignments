using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        private int ika;
        private string nimi;

        public void asetaElaimenIka(int ika)
        {
            this.ika = ika;
            if (ika > 0)
            { Console.WriteLine("Eläimen ikä on: " + ika + " vuotta"); }
            else
            { Console.WriteLine("Eläimen ikä ei voi olla negatiivinen (" + ika + ")"); }
        }

        public void asetaElaimeNimi(string nimi)
        {
            this.nimi = nimi;
            Console.WriteLine("Eläimen nimi on : " + nimi);
        }

        public int PalautaElaimenIka
        {
            get
            { return ika; }
            set
            {
                ika = value;
            }
        }

        public string PalautaElaimenNimi
        {
            get
            { return nimi; }
            set
            {
                nimi = value;
            }
        }


    }
}
