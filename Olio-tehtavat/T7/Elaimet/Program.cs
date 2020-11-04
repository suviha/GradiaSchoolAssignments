/*
  =============================================================================
  
 OLIO-TEHTÄVÄT: Tehtävä 7

 ==============================================================================
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
  
   Muista kommentoida toiminnalliset funktiot!

   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx

    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/
namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa miuku = new Kissa();
            //määritetään itse uusi ikä ja nimi
            miuku.asetaElaimeNimi("Miuku");
            miuku.asetaElaimenIka(-7);
            miuku.asetaOnLihansyöjä(true);
            miuku.Mau(); //Ekstrana eläimen ääni, koska muuten en näe alaluokasta mitään hyötyä.

            Console.WriteLine("\n\n");

            Koira musti = new Koira();
            //Käytetään hyödyksi get ja set metodia jolla saadaan alkuperäinen nimi ja ikä esille
            string nimi = musti.PalautaElaimenNimi;
            int ika = musti.PalautaElaimenIka;
            
            Console.WriteLine("Alkuperäinen nimi on: "+nimi);
            Console.WriteLine("Alkuperäinen ikä on: "+ika);

            musti.asetaOnLihansyöjä(false); //Bettinasta on tullut kasvissyöjä iän myötä
            musti.Hau(); //Ekstrana eläimen ääni, koska muuten en näe alaluokasta mitään hyötyä.



            Console.ReadKey();
    
        }
    }
}
