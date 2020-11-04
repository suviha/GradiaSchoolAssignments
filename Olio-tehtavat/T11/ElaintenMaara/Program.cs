using ElainLuokat;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lista eläimistä
            List<Elain> elaimet = new List<Elain>();

            //Kysytään käyttäjältä haluttu eläinten määrä
            Console.WriteLine("Monta eläintä haluaisit luoda?");
            int maara = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            int y = 0;

            //Loop, luodaan listaan oliot
            for (int i=0; i<maara; i++)
            {
                if ((i+1)%4==0)
                    {
                    Console.WriteLine("Heppanen");
                    elaimet.Add(LuoHevonen()); 
                    }
                else if (y==0)
                {
                    if((i+1)%3==0)
                    {
                        Console.WriteLine("Papukaijanen");
                        elaimet.Add(LuoPapukaija());
                    }
                    else if ((i+1)%3==1)
                    {
                        Console.WriteLine("Kissanen");
                        elaimet.Add(LuoKissa());
                    }
                    else if ((i+1)%3==2)
                    {
                        Console.WriteLine("Koiranen");
                        elaimet.Add(LuoKoira());
                    }

                }
                y = 0;

            }
            Console.WriteLine("\n\n\n");

            //Tulostus

            Console.WriteLine("Lista nisäkkäistä:");
           foreach (Nisakkaat elain in elaimet.OfType<Nisakkaat>())
           { Console.WriteLine(elain); }

            Console.WriteLine("Lista linnuista:");
            foreach (Linnut elain in elaimet.OfType<Linnut>())
            { Console.WriteLine(elain); }
           


            Console.ReadKey();
        }

        //Luodaan olioihin tiedot ja palautetaan
        private static Hevonen LuoHevonen()
        {
            Random rnd = new Random();
            Hevonen hevonen = new Hevonen();

            hevonen.AsetaElaimenNimi("Hemmo Hevonen");
            hevonen.AsetaElaimenIka(rnd.Next(0, 25));
            hevonen.AsetaOnLihansyoja(false);
            hevonen.AsetaOnTurkki(true);

            return hevonen;
        }

        private static Papukaija LuoPapukaija()
        {
            Random rnd = new Random();
            Papukaija papukaija = new Papukaija();

            papukaija.AsetaElaimenNimi("Papu Papukaija");
            papukaija.AsetaElaimenIka(rnd.Next(0, 30));
            papukaija.AsetaOnLihansyoja(false);
            papukaija.AsetaOnHoyhenet(true);

            return papukaija;
        }

        private static Kissa LuoKissa()
        {
            Random rnd = new Random();
            Kissa kissa = new Kissa();

            kissa.AsetaElaimenNimi("Mauku Kissa");
            kissa.AsetaElaimenIka(rnd.Next(0, 20));
            kissa.AsetaOnLihansyoja(true);
            kissa.AsetaOnTurkki(true);

            return kissa;
        }

        private static Koira LuoKoira()
        {
            Random rnd = new Random();
            Koira koira = new Koira();

            koira.AsetaElaimenNimi("Musti Koiranen");
            koira.AsetaElaimenIka(rnd.Next(0, 15));
            koira.AsetaOnLihansyoja(true);
            koira.AsetaOnTurkki(true);

            return koira;
        }
        
    }
}
