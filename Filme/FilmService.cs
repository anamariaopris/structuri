using System;
using System.Collections.Generic;

namespace structuri
{
    internal class FilmService
    {
        private List<Film> filme = new List<Film>();



        public void LoadFilms()
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
            filme.Add(f1);

            Film f2 = new Film();
            f2.titlu = "Inception2";
            f2.gen = "SF";
            f2.regizor = "Christopher Nolan";
            f2.durataMinute = 200;
            f2.pretBilet = 45;
            f2.sala = "Sala 3";
            f2.ratingImdb = 8.0;
            f2.este3D = true;
            f2.limitaVarsta = 16;
            f2.oraDifuzare = "19:30";
            f2.locuriLibere = 45;
            filme.Add(f2);

            Film f3 = new Film();
            f3.titlu = "Inception";
            f3.gen = "SF";
            f3.regizor = "Christopher Nolan";
            f3.durataMinute = 148;
            f3.pretBilet = 32.5;
            f3.sala = "Sala 1";
            f3.ratingImdb = 8.8;
            f3.este3D = false;
            f3.limitaVarsta = 12;
            f3.oraDifuzare = "19:30";
            f3.locuriLibere = 45;
            filme.Add(f3);
            // Filmul 1
            Film f4 = new Film();
            f4.titlu = "Interstellar";
            f4.gen = "SF / Drama";
            f4.regizor = "Christopher Nolan";
            f4.durataMinute = 169;
            f4.pretBilet = 35.0;
            f4.sala = "Sala 2 Dolby Atmos";
            f4.ratingImdb = 8.7;
            f4.este3D = false;
            f4.limitaVarsta = 12;
            f4.oraDifuzare = "21:00";
            f4.locuriLibere = 60;
            filme.Add(f4);

            // Filmul 2
            Film f5 = new Film();
            f5.titlu = "The Dark Knight";
            f5.gen = "Actiune / Crime";
            f5.regizor = "Christopher Nolan";
            f5.durataMinute = 152;
            f5.pretBilet = 30.0;
            f5.sala = "Sala 1";
            f5.ratingImdb = 9.0;
            f5.este3D = false;
            f5.limitaVarsta = 14;
            f5.oraDifuzare = "18:00";
            f5.locuriLibere = 15;
            filme.Add(f5);

            // Filmul 3
            Film f6 = new Film();
            f6.titlu = "Avatar: The Way of Water";
            f6.gen = "SF / Actiune";
            f6.regizor = "James Cameron";
            f6.durataMinute = 192;
            f6.pretBilet = 42.0;
            f6.sala = "Sala IMAX 3D";
            f6.ratingImdb = 7.6;
            f6.este3D = true;
            f6.limitaVarsta = 12;
            f6.oraDifuzare = "16:30";
            f6.locuriLibere = 120;
            filme.Add(f6);

            // Filmul 4
            Film f7 = new Film();
            f7.titlu = "Dune: Part Two";
            f7.gen = "SF / Aventura";
            f7.regizor = "Denis Villeneuve";
            f7.durataMinute = 166;
            f7.pretBilet = 38.5;
            f7.sala = "Sala 3";
            f7.ratingImdb = 8.6;
            f7.este3D = false;
            f7.limitaVarsta = 12;
            f7.oraDifuzare = "20:15";
            f7.locuriLibere = 85;
            filme.Add(f7);

            // Filmul 5
            Film f8 = new Film();
            f8.titlu = "Spirited Away";
            f8.gen = "Animatie / Fantasy";
            f8.regizor = "Hayao Miyazaki";
            f8.durataMinute = 125;
            f8.pretBilet = 25.0;
            f8.sala = "Sala 4 copii";
            f8.ratingImdb = 8.6;
            f8.este3D = false;
            f8.limitaVarsta = 0;
            f8.oraDifuzare = "11:00";
            f8.locuriLibere = 40;
            filme.Add(f8);

            // Filmul 6
            Film f9 = new Film();
            f9.titlu = "The Matrix";
            f9.gen = "SF / Actiune";
            f9.regizor = "Lana Wachowski";
            f9.durataMinute = 136;
            f9.pretBilet = 28.0;
            f9.sala = "Sala 2";
            f9.ratingImdb = 8.7;
            f9.este3D = false;
            f9.limitaVarsta = 16;
            f9.oraDifuzare = "22:30";
            f9.locuriLibere = 33;
            filme.Add(f9);

            // Filmul 7
            Film f10 = new Film();
            f10.titlu = "Gladiator";
            f10.gen = "Actiune / Drama";
            f10.regizor = "Ridley Scott";
            f10.durataMinute = 155;
            f10.pretBilet = 30.0;
            f10.sala = "Sala 1";
            f10.ratingImdb = 8.5;
            f10.este3D = false;
            f10.limitaVarsta = 16;
            f10.oraDifuzare = "15:00";
            f10.locuriLibere = 8;
            filme.Add(f10);

            // Filmul 8
            Film f11 = new Film();
            f11.titlu = "Pulp Fiction";
            f11.gen = "Crime / Drama";
            f11.regizor = "Quentin Tarantino";
            f11.durataMinute = 154;
            f11.pretBilet = 32.0;
            f11.sala = "Sala VIP";
            f11.ratingImdb = 8.9;
            f11.este3D = false;
            f11.limitaVarsta = 18;
            f11.oraDifuzare = "23:00";
            f11.locuriLibere = 22;
            filme.Add(f11);

            // Filmul 9
            Film f12 = new Film();
            f12.titlu = "Coco";
            f12.gen = "Animatie / Familie";
            f12.regizor = "Lee Unkrich";
            f12.durataMinute = 105;
            f12.pretBilet = 25.0;
            f12.sala = "Sala 4 copii";
            f12.ratingImdb = 8.4;
            f12.este3D = true;
            f12.limitaVarsta = 0;
            f12.oraDifuzare = "13:30";
            f12.locuriLibere = 55;
            filme.Add(f12);

            // Filmul 10
            Film f13 = new Film();
            f13.titlu = "Shutter Island";
            f13.gen = "Mystery / Thriller";
            f13.regizor = "Martin Scorsese";
            f13.durataMinute = 138;
            f13.pretBilet = 31.0;
            f13.sala = "Sala 3";
            f13.ratingImdb = 8.2;
            f13.este3D = false;
            f13.limitaVarsta = 16;
            f13.oraDifuzare = "19:00";
            f13.locuriLibere = 47;
            filme.Add(f13);



        }



        public void AfisareFilme()
        {

            for (int i = 0; i < filme.Count; i++)
            {

                Console.WriteLine(filme[i].Descriere());
            }
        }




        //functie ce ne returneaza filmul cu durata cea mai amre

        public Film DurataMaxima() 
        {
            Film filmMaxim = filme[0];
           

            for(int i = 0; i < filme.Count; i++)
            {

                if (filme[i].durataMinute > filmMaxim.durataMinute)
                {
                    filmMaxim = filme[i];
                }
            }

            return filmMaxim;
        
        }

        //functie ce primeste ca parametru un titlu de film si returneaza filmul cu titlul respectiv

        public Film gasesteTitlu(string titlu)
        {
            for(int i = 0;i < filme.Count; i++)
            {
                if (filme[i].titlu.Equals(titlu))
                {
                    return filme[i];
                }
            }

            return null;
        }



        //functie de adaugare film

       public bool AddFilm(Film film)
        {

            Film c = gasesteTitlu(film.titlu);

            if (c == null)
            {
                filme.Add(c);
                return true;
            }
            return false;
        }

    }
    
}
