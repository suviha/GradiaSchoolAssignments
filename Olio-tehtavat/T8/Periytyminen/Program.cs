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
            Kissa miuku = new Kissa();
            //määritetään itse uusi ikä ja nimi
            miuku.asetaElaimeNimi("Miuku");
            miuku.asetaElaimenIka(-7);
            miuku.asetaOnLihansyöjä(true);
            miuku.Kehraa();

            Console.WriteLine("\n\n");

            Koira musti = new Koira();
            //Käytetään hyödyksi get ja set metodia jolla saadaan alkuperäinen nimi ja ikä esille
            string nimi = musti.PalautaElaimenNimi;
            int ika = musti.PalautaElaimenIka;

            Console.WriteLine("Alkuperäinen nimi on: " + nimi);
            Console.WriteLine("Alkuperäinen ikä on: " + ika);

            musti.asetaOnLihansyöjä(false); //Bettinasta on tullut kasvissyöjä iän myötä




            Console.ReadKey();
        }
    }
}
