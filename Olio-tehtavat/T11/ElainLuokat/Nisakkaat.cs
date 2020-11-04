using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Nisakkaat : Elain
    {
        //Nisäkkäiden oma ominaisuus
        private bool onTurkki;

        

        public void AsetaOnTurkki(bool onTurkki)
        {
            this.onTurkki = onTurkki;
        }

        public bool PalautaOnTurkki ()
        { return onTurkki; }

        //Muutetaan tiedot string muotoon, jotta saadaan tulostettua
        public override string ToString()
        {
            return "Nisäkkään nimi: " + PalautaElaimenNimi() + "\nIkä: " + PalautaElaimenIka() + "\nOnko lihansyöjä? " + PalautaOnLihansyoja() + "\nOnko turkki? " + onTurkki+"\n\n\n";
        }
    }
}
