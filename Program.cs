using structuri;
using structuri.Bibleoteca;
using structuri.MagazinTelefoane;
using structuri.Masini;
using System;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main(string[] args)
    {
        AdapostService service = new AdapostService();

        service.LoadAdaposturi();
        service.AfisareAdaposturi();


        Adapost gaseste_test = service.GasesteAdapostul("Bucuresti5");

        if (gaseste_test != null)
        {
            Console.WriteLine("adapost gasit!");
        }
        else
        {
            Console.WriteLine("nu exista in lista");
        }


        Adapost cautat = new Adapost();
        cautat.nume = "Bucuresti1";
        bool add_test = service.AddAdapost(cautat);
        Console.WriteLine(add_test);


        int find_test = service.FindPositionAdapostByName("Bucuresti5");
        Console.WriteLine(find_test);
        Console.WriteLine();


        bool delete_test = service.DeleteAdapostByName("Bucuresti2");
        Console.WriteLine(delete_test);
        service.AfisareAdaposturi();

        bool edit_test = service.EditSpecieAdapost("Bucuresti1", "soarece");
        Console.WriteLine(edit_test);
        service.AfisareAdaposturi();

    }


}

