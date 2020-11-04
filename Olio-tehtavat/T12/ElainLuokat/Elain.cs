using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Elain
    {
        protected int ika;
        protected string nimi;
        private bool onLihanSyoja;

        //Ika asetukset
        public void AsetaElaimenIka(int ika)
        {
            this.ika = ika;
            if (ika > 0)
            { return; }
        } 
        
        public int PalautaElaimenIka ()
        {
            { return ika; }
            
        }
        //Nimi asetukset
        public void AsetaElaimenNimi(string nimi)
        {
            this.nimi = nimi;
        }


        public string PalautaElaimenNimi()
        {
            { return nimi; }
        }

        //Lihansyöjä asetukset
        public void AsetaOnLihansyoja(bool onLihansyoja)
        {
            this.onLihanSyoja = onLihansyoja;

        }
        public bool PalautaOnLihansyoja()
        {
            { return onLihanSyoja; }
        }

       
    }
}
