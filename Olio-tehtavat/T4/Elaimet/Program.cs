﻿/*
  =============================================================================
  
 OLIO-TEHTÄVÄT: Tehtävä 4

 ==============================================================================
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElainLuokat;

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
            //Tässä luot luokasta olion
            Hevonen heppa = new Hevonen();
            //Tulosta olion nimi ja paino
            Console.WriteLine("Hevosen nimi: "+heppa.Nimi +"\nHevosen paino: "+ heppa.Paino+" kg");
            Console.WriteLine("\n\n");

            //Muuta olion nimeä ja painoa
            Console.WriteLine("Anna hevoselle uusi nimi: ");
            string uusi_nimi = Console.ReadLine();
            heppa.Nimi = uusi_nimi;
           
            Console.WriteLine("Anna hevoselle uusi paino: ");
            int uusi_paino = Convert.ToInt16(Console.ReadLine());
            heppa.Paino = uusi_paino;
            Console.WriteLine("\n");

            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            Console.WriteLine("Hevosen nimi: " + heppa.Nimi + "\nHevosen paino: " + heppa.Paino + " kg");
            

            //Luodaan kisu olio, annetaan kissalle nimi ja tulostetaan se
            Kissa kisu = new Kissa();
            kisu.AsetaKissanNimi("Poju");
            Console.WriteLine("Kissan alkuperäinen nimi on: " + kisu.nimi +"\n\n");

            //Kissalle uusi nimi
            kisu.AsetaKissanNimi("Miuku");
            Console.WriteLine("Kissan uusi nimi on: " + kisu.nimi);
            Console.WriteLine("Kissan ikä on: "+ kisu.PalautaIka+ "\n\n");

            //Toinen kissa olio.
            Kissa mauku = new Kissa();

            Console.WriteLine("Viimeisimmän kissan nimi on: " + mauku.nimi);
            Console.WriteLine("Ja sen ikä on " + mauku.PalautaIka + " vuotta"+ "\n\n");

            
            //Uusi olio, Iän kysyminen ja sen tarkistus + tulostus
            Kissa karvapallo = new Kissa();
            Console.WriteLine("Anna kissan uusi ikä: ");
            karvapallo.PalautaIka = Convert.ToInt16(Console.ReadLine());

            if (karvapallo.IkaTarkistus())
            { Console.WriteLine("Kissan ikä on: "+karvapallo.PalautaIka+" vuotta" + "\n\n"); }
            if (!karvapallo.IkaTarkistus())
            { Console.WriteLine("Kissan ikä ei voi olla negatiivinen ("+karvapallo.PalautaIka+" vuotta)" + "\n\n"); }


            //Uusi nimi, mutta Hildaa ei hyväksytä missään muodossa
            Console.WriteLine("Anna jälleen uusi nimi kissalle");
            string uusi_kissanimi = Console.ReadLine();
            karvapallo.PalautaNimi=uusi_kissanimi.ToUpper();
            

            //Uusi olio (teht. 3 osiolle 4)
            Kissa kisuli = new Kissa();
            kisuli.AsetaKissanNimi("Kisuli"); //jos nimen muuttaa Hildaksi ohjelma hyväksyy sen.

            Console.WriteLine("olion tämän hetkinen nimi: "+kisuli.nimi);



            Console.ReadKey();
    
        }
    }
}
