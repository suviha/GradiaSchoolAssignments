/*
  =============================================================================
  
 OLIO-TEHTÄVÄT: Tehtävä 10

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
            koira.asetaElaimeNimi("Tyyne");
            koira.asetaElaimenIka(5);
            koira.asetaOnTurkki(true);
            Console.WriteLine("\n\n");

           
            //Papukaija
            Papukaija papukaija = new Papukaija();
            papukaija.asetaElaimeNimi("Kapu");
            papukaija.asetaElaimenIka(17);
            papukaija.asetaonHoyhenet(true);








            Console.ReadKey();
        }

    }
    }

