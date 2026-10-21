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
        
        FilmService service = new FilmService();

        service.LoadFilms();
        service.AfisareFilme();


        Film durataMaxima_test = service.DurataMaxima();
        Console.WriteLine(durataMaxima_test.durataMinute);

        //metoda intoarce o variabila de tip Film
        Film gasesteTitlu_test = service.gasesteTitlu("Inception2");
        if(gasesteTitlu_test == null)
        {
            Console.WriteLine("Filmul nu exista! ");
        }
        else
        {
            Console.WriteLine(gasesteTitlu_test.Descriere());
        }


        Film cautat = new Film();
        cautat.titlu = "SPIDERMAN";
        bool add_test = service.AddFilm(cautat);
        Console.WriteLine(add_test);
        service.AfisareFilme();

        //metoda intoarce o variabila de tip int
        int findposition_Test = service.FindPositionbyTitle("Gladiator");
        Console.WriteLine(findposition_Test);


        bool delete_test = service.DeleteMovieByTitle("Inception2");
        Console.WriteLine(delete_test);
        service.AfisareFilme();

        bool edit_test = service.EdiMovie("Gladiator", 100);
        Console.WriteLine(edit_test);
        service.AfisareFilme();

        

    }

}

