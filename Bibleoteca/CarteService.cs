using System;
using System.Collections.Generic;
using System.Text;
using static System.Net.WebRequestMethods;

namespace structuri.Bibleoteca
{
    internal class CarteService
    {
        private List <Carte> carti = new List<Carte>();

        public void LoadCarti()
        {
            Carte carte1 = new Carte();
            carte1.titlu = "Dune";
            carte1.autor = "Frank Herbert";
            carte1.pagini = 412;
            carte1.pret = 49;
            carti.Add(carte1);

            Carte carte2 = new Carte();
            carte2.titlu = "1984";
            carte2.autor = "George Orwell";
            carte2.pagini = 328;
            carte2.pret = 35;
            carti.Add(carte2);

            Carte carte3 = new Carte();
            carte3.titlu = "Ion";
            carte3.autor = "Liviu Rebreanu";
            carte3.pagini = 512;
            carte3.pret = 29;
            carti.Add(carte3);

            Carte carte4 = new Carte();
            carte4.titlu = "Micul Print";
            carte4.autor = "Antoine de Saint-Exupery";
            carte4.pagini = 96;
            carte4.pret = 25;
            carti.Add(carte4);

        }

        public void AfisareCarti() //doar afiseaza
        {

            for (int i = 0; i <carti.Count; i++)
            {

                Console.WriteLine(carti[i].Descriere());
            }

        }

        public Carte CeaMaiLunga()
        {
            Carte carteMax = carti[0];

            for (int i = 0; i < carti.Count; i++)
            {

                if (carti[i].pagini > carteMax.pagini)
                {
                    carteMax = carti[i];
                }
               
            }

            return carteMax;
        } 

        public Carte GasesteDupaTitlu(string titlu)
        {
            for (int i = 0; i < carti.Count; i++)
            {
                if (carti[i].titlu.Equals(titlu))
                {
                    return carti[i];
                }
            }

            return null;
        } 

        public bool AddCarte(Carte carte)
        {
            Carte x = GasesteDupaTitlu(carte.titlu);

            if (x == null)
            {
                carti.Add(carte);
                return true;
            }

            return false;
        }

        

    }
}
