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
        CarteService carte_service = new CarteService();

        carte_service.LoadCarti();
        carte_service.AfisareCarti();

        //variabila de tip carte
        Carte volumPagini_test = carte_service.CeaMaiLunga();
        Console.WriteLine("Cartea cu cel mai mare volum de pagini :" + volumPagini_test.Descriere());

        Carte cautaTitlu_test = carte_service.GasesteDupaTitlu("1984");
        //Console.WriteLine("Titlul cautat este :" + cautaTitlu_test.Descriere());
        if (cautaTitlu_test == null)
        {
            Console.WriteLine("cartea nu a fost gasita");
        }
        else
        {
            Console.WriteLine("carte gasita " + cautaTitlu_test.Descriere());
        }


        Carte adaugaCarte = new Carte();
        adaugaCarte.titlu = "La Medeleni";

        bool add_test = carte_service.AddCarte(adaugaCarte);
        if (add_test == null)
        {
            Console.WriteLine("Carte adaugata cu succes ");
        }
        else
        {
            Console.WriteLine("Cartea exista deja ");
        }



    }

}

