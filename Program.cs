using structuri;
using structuri.Masini;
using System;
using System.Security.Cryptography.X509Certificates;
using static System.Net.WebRequestMethods;

class Program
{
    static void Main(string[] args)
    {
        Film f1 = new Film();
        f1.titlu = "Inception";
        f1.gen = "SF";
        f1.regizor = "Christopher Nolan";
        f1.durataMinute = 148;
        f1.pretBilet = 32.5;
        f1.sala = "Sala 1";
        f1.ratingImdb = 8.8;
        f1.este3D = false;
        f1.limitaVarsta = 12;
        f1.oraDifuzare = "19:30";
        f1.locuriLibere = 45;
        

        FilmService service = new FilmService();


        service.LoadFilms();
     
        bool x=service.AddFilm(f1);


        Console.WriteLine(x);

        

       




    }


}

