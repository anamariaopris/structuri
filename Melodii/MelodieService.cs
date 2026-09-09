using System;
using System.Collections.Generic;

namespace structuri
{
    internal class MelodieService
    {
        public List<Melodie> melodii = new List<Melodie>();

        public void LoadMelodie()
        {

            Melodie melodie1 = new Melodie();

            melodie1.titlu = "aaa";
            melodie1.artist = "bbb";
            melodie1.durata = 100;

            melodii.Add(melodie1);

            Melodie melodie2 = new Melodie();
            melodie2.titlu = "BBBB";
            melodie2.artist = "ana";
            melodie2.durata = 123;

            melodii.Add(melodie2);

            Melodie melodie3 = new Melodie();
            melodie3.titlu = "CCC";
            melodie3.artist = "maria";
            melodie3.durata = 90;
            melodii.Add(melodie3);

            Melodie melodie4 = new Melodie();
            melodie4.titlu = "Shape of You";
            melodie4.artist = "Ed Sheeran";
            melodie4.durata = 233;
            melodii.Add(melodie4);

            Melodie melodie5 = new Melodie();
            melodie5.titlu = "Blinding Lights";
            melodie5.artist = "The Weeknd";
            melodie5.durata = 200;
            melodii.Add(melodie5);

            Melodie melodie6 = new Melodie();
            melodie6.titlu = "Bohemian Rhapsody";
            melodie6.artist = "Queen";
            melodie6.durata = 355;
            melodii.Add(melodie6);

            Melodie melodie7 = new Melodie();
            melodie7.titlu = "Stay";
            melodie7.artist = "The Kid LAROI & Justin Bieber";
            melodie7.durata = 141;
            melodii.Add(melodie7);

            Melodie melodie8 = new Melodie();
            melodie8.titlu = "Bad Habits";
            melodie8.artist = "Ed Sheeran";
            melodie8.durata = 231;
            melodii.Add(melodie8);


            Melodie melodie9 = new Melodie();
            melodie9.titlu = "As It Was";
            melodie9.artist = "Harry Styles";
            melodie9.durata = 167;
            melodii.Add(melodie9);

            Melodie melodie10 = new Melodie();
            melodie10.titlu = "Flowers";
            melodie10.artist = "Miley Cyrus";
            melodie10.durata = 200;
            melodii.Add(melodie10);

            Melodie melodie11 = new Melodie();
            melodie11.titlu = "Starboy";
            melodie11.artist = "The Weeknd";
            melodie11.durata = 230;
            melodii.Add(melodie11);

            Melodie melodie12 = new Melodie();
            melodie12.titlu = "Someone Like You";
            melodie12.artist = "Adele";
            melodie12.durata = 285;
            melodii.Add(melodie12);

            Melodie melodie13 = new Melodie();
            melodie13.titlu = "Perfect";
            melodie13.artist = "Ed Sheeran";
            melodie13.durata = 263;
            melodii.Add(melodie13);



        }

        public void Afisare()
        {
            for(int i= 0;i < melodii.Count; i++)
            {
                Console.WriteLine(melodii[i].Descriere());
            }
        }
    }
}
