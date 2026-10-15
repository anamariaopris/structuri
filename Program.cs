using structuri;
using structuri.Bibleoteca;
using structuri.MagazinTelefoane;
using structuri.Masini;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main(string[] args)
    {

        TelefonService service = new TelefonService();

        service.LoadTelefoane();
        service.AfisareTelefoane();

        Telefon gasesteModel = service.GasesteModel("Galaxy S1");
        if (gasesteModel == null)
        {
            Console.WriteLine("nu a gasit telefonul");
        }

        Telefon x = new Telefon();

        x.model = "Pixel 8";

        bool rez = service.AddTelefon(x);

        Console.WriteLine(rez);



        int rezultat = service.FindTelefonByModel("Pixel 8");
        Console.WriteLine(rezultat);



        bool test = service.DeleteTelefonByModel("Moto G814");

        Console.WriteLine(test);


        service.AfisareTelefoane();


        

        bool test2 = service.EditPriceTelefon("Moto G84", 123);


        Console.WriteLine(test2);


        service.AfisareTelefoane();


    }


}

