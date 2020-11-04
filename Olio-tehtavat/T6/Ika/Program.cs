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
            //Luodaan arvotut iät eläimille
            Random ikaKissa = new Random();
            Random ikaKoira = new Random();


            //Luodaan kissa- ja koira-oliot
            for (int i = 0; i < 10; i++)
            {
                Kissa vanhaKissa = new Kissa();
                Koira vanhaKoira = new Koira();

                //kissoille iät väliltä 1-10
                int ikaKi = ikaKissa.Next(1, 10);
                vanhaKissa.AsetaKissanIka(ikaKi);
                Console.WriteLine("Kissa on: "+ikaKi+ " vuotta vanha");

                //koirille iät väliltä 1-15
                int ikaKo = ikaKoira.Next(1, 15);
                vanhaKoira.AsetaKoiranIka(ikaKo);
                Console.WriteLine("Koira on: " + ikaKo + " vuotta vanha");

                //ikien vertailu
                if(ikaKi<ikaKo)
                    { Console.WriteLine("Koira on vanhempi\n"); }
                if(ikaKi>ikaKo)
                    { Console.WriteLine("Kissa on vanhempi\n"); }
                if(ikaKi==ikaKo)
                    { Console.WriteLine("Kissa ja koira ovat yhtävanhoja\n"); }
            }


            Console.ReadKey();
        }
    }
}
