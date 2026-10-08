using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;


namespace structuri.Masini
{
    internal class MasiniService
    {
        List <Masini> masini = new List <Masini> ();

        public void LoadCars()
        {
            Masini m1 = new Masini();
            m1.marca = "test";
            m1.capacitateCilindrica = 2;
            m1.pret = 2000;
            masini.Add(m1);

            // Mașina 1
            Masini m2 = new Masini();
            m2.marca = "Toyota";
            m2.capacitateCilindrica = 1.8;
            m2.pret = 15000;
            masini.Add(m2);

            // Mașina 2
            Masini m3 = new Masini();
            m3.marca = "BMW";
            m3.capacitateCilindrica = 3.0;
            m3.pret = 45000;
            masini.Add(m3);

            // Mașina 3
            Masini m4 = new Masini();
            m4.marca = "Dacia Logan";
            m4.capacitateCilindrica = 1.0;
            m4.pret = 85000; // sau prețul corespunzător monedei tale
            masini.Add(m4);

            // Mașina 4
            Masini m5 = new Masini();
            m5.marca = "Volkswagen Golf";
            m5.capacitateCilindrica = 2.0;
            m5.pret = 22000;
            masini.Add(m5);

            // Mașina 5
            Masini m6 = new Masini();
            m6.marca = "Audi";
            m6.capacitateCilindrica = 2.5;
            m6.pret = 38000;
            masini.Add(m6);
        }

        public void AfisareMasini()
        {
            for (int i = 0; i < masini.Count; i++)
            {
                Console.WriteLine(masini[i].marca);
            }


        }

        //functie ce ne returneaza pretul cel mai mare

        public Masini pretMaxim()
        {
            Masini masinaPretmaxim = masini[0];

            for(int i = 0;i < masini.Count; i++)
            {
                if (masini[i].pret > masinaPretmaxim.pret)
                {
                    masinaPretmaxim= masini[i];
                }
            }

            return masinaPretmaxim;



        }
    }
}
