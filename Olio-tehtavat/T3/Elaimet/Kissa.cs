using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{
    class Kissa
    {
        private int ika;
        public string nimi;
        
        
             //parametriton konstruktori (konstruktorissa tunnistaa siitä ettei siinä ole palautustyyppiä)
            //(siinä on myös sama nimi kuin luokalla)
            public Kissa() 
                {
                ika = 8;
                nimi = "Viljami Villikorva";
                }

            //parametrillinen konstruktori, 
            public Kissa(int ika, string nimi)
            {
                this.ika = ika;
                this.nimi = nimi;
            }

            //tallentaa nimen public muuttujaan
            public void AsetaKissanNimi(string nimi)
            {  this.nimi = nimi;  }

            //tallentaa iän public muuttujaan
            public void AsetaKisanIka(int ika) 
            { this.ika = ika; }

        //palauttaa nimen
        public string PalautaNimi
            {
                get
                    { return nimi; }
            set
            {
                
                if (value == "HILDA")
                    { Console.WriteLine("Se ei ole sopiva nimi kissalle." + "\n\n"); }
                    else
                    {
                        nimi = value;
                        Console.WriteLine("Kissan nimi on: " + nimi + "\n\n");
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
    

