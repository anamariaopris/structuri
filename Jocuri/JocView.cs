using System;
using System.Collections.Generic;

namespace structuri
{
    internal class JocView
    {
        JocService jocService = new JocService();

        public void Play()
        {
            jocService.LoadJoc();
            int tasta;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Apasati tasta 0 pentru a iesi");
                Console.WriteLine("Apasati tasta 1 pentru a vedea jocurile");
                Console.WriteLine("Apasati tasta 2 pentru a vedea jocurile care nu sunt terminate");


                tasta = Int32.Parse(Console.ReadLine());

                switch (tasta)
                {
                    case 0:
                        return;
                        break;
                    case 1:
                        Afisare();
                        break;
                    case 2: JocuriNeterminate();
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
            jocService.AfisareJocuri();
        }


        public void JocuriNeterminate()
        {
            jocService.AfisareJocuriNeterminate();
        }
       

    }
}
