using System;
using System.Collections.Generic;

namespace structuri
{
    internal class PizzaView
    {
        PizzaService pizzaService = new PizzaService();

        public void Play()
        {
            pizzaService.LoadPizza();
            int tasta;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Apasati tasta 0 pentru a iesi");
                Console.WriteLine("Apasati tasta 1 pentru a vedea meniul de pizza");
           
                tasta = Int32.Parse(Console.ReadLine());

                switch (tasta)
                {
                    case 0: return;
                    case 1: AfisarePizzas();
                        break;
                    default: Console.WriteLine("Input gresit"); 
                        break;
                }
            }
            while (tasta != 0);
        }


        public void AfisarePizzas()
        {

            pizzaService.Afisare();
        }


    }
}
