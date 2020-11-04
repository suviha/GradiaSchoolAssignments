﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elaimet
{   //Esitellään luokka eli class. Koodi olisi voinut olla Program.cs tiedostossa mutta selkeyden takia luomme jokaisen luokan
    //omaan tiedostoonsa
    class Hevonen
    {
        private string nimi;
        private int paino;
        //Alla konstruktori jossa ei ola parametreja, joten kaikki luokasta 
        //synnytetyt oliot ovat samanlaisia. Konstruktorin tunnistaa siitä
        // ettei siinä ole palautustyyppiä ja metodin nimi on sama kuin luokannimi
        public Hevonen()
        {
            //Konstruktorissa voi olla oletusarvoja
            //Luokan sisällä voidaan käyttää privaatti kenttiä
            nimi = "Pulla";
            paino = 0;
        }
        //getterillä ja setterillä annetaan luokan ulkopuolisille sovelluksille mahdollisuus 
        //asettaa tai hakea kenttiä
        public string Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
            }
        }

        public int Paino
        {
            get
            {
                return paino;
            }

            set
            {
                paino = value;
            }
        }
    }
}
