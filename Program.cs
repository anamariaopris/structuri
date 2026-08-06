using structuri;
using System;

class Program
{
    static void Main(string[] args)
    {
        PizzaService service = new PizzaService();

        service.LoadPizza();
        service.Afisare();
        bool sol = service.EditDisponibilitate("Margherita", false);
        Console.WriteLine(sol);
        Console.WriteLine("=================");
        service.Afisare();



    }
}
