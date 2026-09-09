using System;
using System.Collections.Generic;

namespace structuri
{
    internal class MelodieView
    {

        MelodieService serv = new MelodieService();
        
        public void Play()
        {
            serv.LoadMelodie();
            int tasta;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Apasati tasta 0 pentru a iesi");
                Console.WriteLine("Apasati tasta 1 pentru a vedea melodiile");


                tasta = Int32.Parse(Console.ReadLine());

                switch (tasta)
                {
                    case 0:
                        return;
                        break;
                    case 1: 
                        Afisare();
                        break;
                    default:
                        Console.WriteLine("Input gresit");
                        break;
                }
            }
            while (tasta != 0);
        }

        public void Afisare()
        {
            serv.Afisare();
        }


    }
}
