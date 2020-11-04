using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public abstract class Linnut : Elain
    {
        private bool onHoyhenet;

        public bool palautaOnHoyhenet { get => onHoyhenet; set => onHoyhenet = value; }

        public void asetaonHoyhenet(bool onHoyhenet)
        {
            if (onHoyhenet == true)
            { Console.WriteLine("Linnuilla on höyhenet"); }
            if (onHoyhenet == false)
            { Console.WriteLine("Onko nyt lintu kyseessä?"); }
        }

    }
}
