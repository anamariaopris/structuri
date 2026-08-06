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
                Console.WriteLine("Apasati tasta 2 pentru a vedea doar cele disponibile");
                Console.WriteLine("Apasati tasta 3 pentru a vedea validarea");


                tasta = Int32.Parse(Console.ReadLine());

                switch (tasta)
                {
                    case 0: return;
                    case 1: AfisarePizzas();
                        break;
                    case 2:
                        AfisarePizzaDisponibila();
                        break;
                    case 3:
                        AddPizza();
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

        public void AfisarePizzaDisponibila()
        {
            pizzaService.Disponibila();
        }

        public void AddPizza()
        {
            Console.Write("Nume :");
            string nume = Console.ReadLine();

            Console.Write("Pret :");
            String pret = Console.ReadLine();

             Pizza pizza = new Pizza();
             pizza.nume = nume;
             pizza.pret = Double.Parse(pret);

            if (pizzaService.AddPizza(pizza))
            {
                Console.WriteLine("pizza a fost adaugata cu success");
            }
            else
            {
                Console.WriteLine("Datele introduse nu au fost corecte");
            }
        }
    }
}
