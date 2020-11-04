using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Linnut : Elain
    {
        //Lintujen oma ominaisuus
        private bool onHoyhenet;

       
        public void AsetaOnHoyhenet(bool onHoyhenet)
        {
            this.onHoyhenet = onHoyhenet;
        }

        public bool PalautaOnHoyhenet() 
        { return onHoyhenet;  }

        //Muutetaan tiedot string muotoon, jotta saadaan tulostettua
        public override string ToString()
        {
            return "Linnun nimi: "+ PalautaElaimenNimi()+"\nIkä: "+PalautaElaimenIka()+"\nOnko lihansyöjä? "+PalautaOnLihansyoja()+"\nOnko höyhenet: "+onHoyhenet + "\n\n\n";
        }
        

    }

}

