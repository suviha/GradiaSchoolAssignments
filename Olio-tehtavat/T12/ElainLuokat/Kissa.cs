using ElainLuokat;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElainLuokat
{
    public class Kissa: Nisakkaat
    {
        List<Kissa> pennut = new List<Kissa>();
        private Kissa emo;

        public Kissa()
        {

        }

        public Kissa(int ika, string nimi)
        {
            base.ika = ika;
            base.nimi = nimi;
        }
        //pennun luonti
        public Kissa(int ika, string nimi, Kissa emo)
        {
            base.ika = ika;
            base.nimi = nimi;
            this.emo = emo;
        }

        public int LisaaPentu(string nimi, int ika = 0)
        {
            Kissa pentu = new Kissa(ika, nimi, this);
            pentu.emo = this; //Emo saa sillä hetkellä käsiteltävän olion arvon!

            pennut.Add(pentu);

            return pennut.Count;

        }

        public Kissa PalautaEmo()
        {
            return emo;
        }
        
        public List<Kissa> PalautaPentu()
        {
            return pennut;  
        }

        //Muutetaan string muotoon tulostuksen vuoksi
        public override string ToString()
        {
            if (emo != null)
            { return " Emokissa: " + emo.nimi+" \tPennun nimi: "+ base.PalautaElaimenNimi(); }
            return "Ei emoa";
        }


        public void Aantele()
        {
            Console.WriteLine("Miau!");
        }


    }
}
    

