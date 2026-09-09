using System;
using System.Collections.Generic;

namespace structuri
{
    internal class JocService
    {
        public List<Joc> jocuri = new List<Joc>();
       
      
        public void LoadJoc()
        {
            Joc joc1 = new Joc();
            joc1.terminat = false;
            joc1.nume = "Minecraft";
            joc1.platforma = "PC";
            jocuri.Add(joc1);

            Joc joc2 = new Joc();
            joc2.terminat = true;
            joc2.nume = "The Witcher 3";
            joc2.platforma = "PC";
            jocuri.Add(joc2);

            Joc joc3 = new Joc();
            joc3.terminat = false;
            joc3.nume = "GTA V";
            joc3.platforma = "PlayStation 5";
            jocuri.Add(joc3);

            Joc joc4 = new Joc();
            joc4.terminat = true;
            joc4.nume = "God of War";
            joc4.platforma = "PlayStation 5";
            jocuri.Add(joc4);

            Joc joc5 = new Joc();
            joc5.terminat = false;
            joc5.nume = "Forza Horizon 5";
            joc5.platforma = "Xbox Series X";
            jocuri.Add(joc5);

            Joc joc6 = new Joc();
            joc6.terminat = true;
            joc6.nume = "Red Dead Redemption 2";
            joc6.platforma = "PC";
            jocuri.Add(joc6);

            Joc joc7 = new Joc();
            joc7.terminat = false;
            joc7.nume = "Cyberpunk 2077";
            joc7.platforma = "PC";
            jocuri.Add(joc7);

            Joc joc8 = new Joc();
            joc8.terminat = true;
            joc8.nume = "Spider-Man 2";
            joc8.platforma = "PlayStation 5";
            jocuri.Add(joc8);

            Joc joc9 = new Joc();
            joc9.terminat = false;
            joc9.nume = "EA Sports FC 26";
            joc9.platforma = "PlayStation 5";
            jocuri.Add(joc9);

            Joc joc10 = new Joc();
            joc10.terminat = true;
            joc10.nume = "Assassin's Creed Valhalla";
            joc10.platforma = "Xbox Series X";
            jocuri.Add(joc10);

        }

        public void AfisareJocuri()
        {
            for(int i = 0;i < jocuri.Count; i++)
            {
                Console.WriteLine(jocuri[i].Descriere());
            }
        }

        public void AfisareJocuriNeterminate()
        {
            for (int i = 0; i < jocuri.Count; i++)
            {

                if (!jocuri[i].terminat)
                {
                    Console.WriteLine(jocuri[i].Descriere());
                }
            }
        }









    }
}
