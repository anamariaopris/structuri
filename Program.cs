using structuri;
using structuri.Bibleoteca;
using structuri.Masini;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main(string[] args)
    {
      

        CarteService service = new CarteService(); //creaza ob service cu lista goala

        // apoi incarc cartile prin ob service cu metoda Load

        service.LoadCarti();

        //afisez cu metoda
        service.AfisareCarti();

        Carte carteMax = service.CeaMaiLunga(); // intorc tipul "carte din Service.cs" 
        Console.WriteLine(carteMax.titlu);

        Carte gasesteTitlu = service.GasesteDupaTitlu("Ion"); //titlul introdus in metoda appoi salvat in variabila gasesteTitlu
        Console.WriteLine(gasesteTitlu.titlu);



    }


}

