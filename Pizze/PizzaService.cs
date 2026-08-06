using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace structuri
{
    internal class PizzaService
    {
        public List<Pizza> pizzas = new List<Pizza>();

        public void LoadPizza()
        {
            Pizza pizza1 = new Pizza();
            pizza1.disponibila = true;
            pizza1.pret = 21.5;
            pizza1.nume = " pizza casei";

            pizzas.Add(pizza1);

            Pizza pizza2 = new Pizza();
            pizza2.disponibila = true;
            pizza2.pret = 24.5;
            pizza2.nume = "Margherita";
            pizzas.Add(pizza2);

            Pizza pizza3 = new Pizza();
            pizza3.disponibila = true;
            pizza3.pret = 28.0;
            pizza3.nume = "Prosciutto";
            pizzas.Add(pizza3);

            Pizza pizza4 = new Pizza();
            pizza4.disponibila = true;
            pizza4.pret = 30.5;
            pizza4.nume = "Quattro Formaggi";
            pizzas.Add(pizza4);

            Pizza pizza5 = new Pizza();
            pizza5.disponibila = false;
            pizza5.pret = 32.0;
            pizza5.nume = "Diavola";
            pizzas.Add(pizza5);

            Pizza pizza6 = new Pizza();
            pizza6.disponibila = true;
            pizza6.pret = 29.5;
            pizza6.nume = "Capricciosa";
            pizzas.Add(pizza6);

            Pizza pizza7 = new Pizza();
            pizza7.disponibila = true;
            pizza7.pret = 27.0;
            pizza7.nume = "Vegetariana";
            pizzas.Add(pizza7);

            Pizza pizza8 = new Pizza();
            pizza8.disponibila = true;
            pizza8.pret = 34.5;
            pizza8.nume = "Carnivora";
            pizzas.Add(pizza8);

            Pizza pizza9 = new Pizza();
            pizza9.disponibila = false;
            pizza9.pret = 31.0;
            pizza9.nume = "Hawaii";
            pizzas.Add(pizza9);

            Pizza pizza10 = new Pizza();
            pizza10.disponibila = true;
            pizza10.pret = 26.5;
            pizza10.nume = "Funghi";
            pizzas.Add(pizza10);

            Pizza pizza11 = new Pizza();
            pizza11.disponibila = true;
            pizza11.pret = 33.0;
            pizza11.nume = "Quattro Stagioni";
            pizzas.Add(pizza11);

            Pizza pizza12 = new Pizza();
            pizza12.disponibila = true;
            pizza12.pret = 35.5;
            pizza12.nume = "Prosciutto Crudo";
            pizzas.Add(pizza12);

            Pizza pizza13 = new Pizza();
            pizza13.disponibila = false;
            pizza13.pret = 30.0;
            pizza13.nume = "Tonno";
            pizzas.Add(pizza13);

            Pizza pizza14 = new Pizza();
            pizza14.disponibila = true;
            pizza14.pret = 28.5;
            pizza14.nume = "Salami";
            pizzas.Add(pizza14);

            Pizza pizza15 = new Pizza();
            pizza15.disponibila = true;
            pizza15.pret = 36.0;
            pizza15.nume = "Frutti di Mare";
            pizzas.Add(pizza15);

            Pizza pizza16 = new Pizza();
            pizza16.disponibila = true;
            pizza16.pret = 25.5;
            pizza16.nume = "Napoli";
            pizzas.Add(pizza16);

            Pizza pizza17 = new Pizza();
            pizza17.disponibila = true;
            pizza17.pret = 10;
            pizza17.nume = "Prosciutto Funghi";
            pizzas.Add(pizza17);
        }

        public void Afisare()
        {
            for(int i = 0;i < pizzas.Count; i++)
            {
                Console.WriteLine(pizzas[i].Descriere());
            }
        }

        public void Disponibila()
        {
            for (int i = 0; i < pizzas.Count; i++)
            {
                if (pizzas[i].disponibila == true)
                {
                    Console.WriteLine(pizzas[i].Descriere());
                }
                

            }
        }

        public bool AddPizza(Pizza pizza)
        {

            //validarile nume 

            if (pizza.nume.Length == 0)
            {

                return false;
            }
            //validare pret 

            if(pizza.pret == 0)
            {
                return false;
            }
            //validare unicitate
            for(int i = 0;i < pizzas.Count; i++)
            {
                if (pizzas[i].nume.Equals(pizza.nume)){

                    return false;
                }


            }

            this.pizzas.Add(pizza);
            return true;


        }
    }
}
