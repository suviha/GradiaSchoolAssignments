/*
  =============================================================================
  
 OLIO-TEHTÄVÄT: Tehtävä 9

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
           Koira koiraAani = new Koira();
            koiraAani.Aantele();
            
            //Kissan ääni, tulostaa "Miau!"
            Kissa kissaAani = new Kissa();
            kissaAani.Aantele();

            //Eläin- olio ääni, tulostaa "Umph!". abstract määreen vuoksi oliota ei pystytä luomaan.
            Elain elainAani = new Elain();
            elainAani.Aantele();

            //Nisäkkäät- olio ääni, tulostaa "Umph!" abstract määreen vuoksi oliota ei pystytä luomaan.
            Nisakkaat nisakkaatAani = new Nisakkaat();
            nisakkaatAani.Aantele();


         

            Console.ReadKey();
        }

    }
    }

