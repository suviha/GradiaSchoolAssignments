using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Elain
    {
        private int ika = 9;
        private string nimi = "Bettina";
       private bool onLihanSyoja;

        public void asetaElaimenIka(int ika)
        { this.ika = ika;
            if (ika > 0) 
            { Console.WriteLine("Eläimen ikä on: " + ika + " vuotta"); }
            else 
            { Console.WriteLine("Eläimen ikä ei voi olla negatiivinen ("+ika+")"); }
        } 

        public void asetaElaimeNimi(string nimi)
         { this.nimi = nimi;
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

        public void asetaOnLihansyöjä(bool onLihansyoja) 
        {
            this.onLihanSyoja = onLihansyoja;
            Console.WriteLine("Lihansyöjä? (True/False) " +onLihanSyoja);

        }
        public bool PalautaOnLihansyöjä
        {
         get { return onLihanSyoja; }
            set { onLihanSyoja = value; }
        }
    }
}
