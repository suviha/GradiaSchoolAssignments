/*
  =============================================================================
  
 Suvi Hakola
 OLIO-TEHTÄVÄT: Tehtävä 12

 ==============================================================================
 */

using ElainLuokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
        

            //Koiran ääni, tulostaa "Hau!"
           Koira koira = new Koira();
            koira.Aantele();
            koira.AsetaElaimenNimi("Tyyne");
            koira.AsetaElaimenIka(5);
            koira.AsetaOnTurkki(true);
            Console.WriteLine("\n\n");

           
            //Papukaija
            Papukaija papukaija = new Papukaija();
            papukaija.AsetaElaimenNimi("Kapu");
            papukaija.AsetaElaimenIka(17);
            papukaija.AsetaOnHoyhenet(true);








            Console.ReadKey();
        }

    }
    }

