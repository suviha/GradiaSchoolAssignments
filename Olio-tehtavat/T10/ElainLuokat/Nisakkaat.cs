using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Nisakkaat : Elain
    {
        private bool onTurkki;

        public bool palautaOnTurkki { get => onTurkki; set => onTurkki = value; }

        public void asetaOnTurkki(bool onTurkki)
        {
            if (onTurkki == true)
            { Console.WriteLine("Nisäkkäillä on turkki"); }
            if (onTurkki == false)
            { Console.WriteLine("Onko nyt nisäkäs kyseessä?"); }
        }

    }
}
