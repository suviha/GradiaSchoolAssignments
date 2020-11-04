using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    public class Koira
    {
        private int ika;
        private string nimi;


        //parametriton konstruktori (konstruktorissa tunnistaa siitä ettei siinä ole palautustyyppiä)
        //(siinä on myös sama nimi kuin luokalla)
        public Koira()
        {
            ika = 8;
            nimi = "Haikkuli";
        }

        //parametrillinen konstruktori, 
        public Koira(int ika, string nimi)
        {
            this.ika = ika;
            this.nimi = nimi;
        }

        //tallentaa nimen public muuttujaan
        public void AsetaKoiranNimi(string nimi)
        { this.nimi = nimi; }

        //tallentaa iän public muuttujaan
        public void AsetaKoiranIka(int ika)
        { this.ika = ika; }

        //palauttaa nimen
        public string PalautaNimi
        {
            get
            { return nimi; }
            set
            {

                if (value == "MUSTI")
                { Console.WriteLine("Se ei ole sopiva nimi koiralle." + "\n\n"); }
                else
                {
                    nimi = value;
                    Console.WriteLine("Koiran nimi on: " + nimi + "\n\n");
                }
            }
        }

        // palauttaa iän
        public int PalautaIka
        {
            get
            { return ika; }
            set
            {
                ika = value;
            }
        }

        //tarkastaa iän
        public bool IkaTarkistus()
        {
            return this.ika > 0;
        }
    }
}


