using System;
using System.Collections.Generic;
using System.Text;

namespace structuri
{
    public class Film
    {
        // Atributele inițiale
        public string titlu;
        public int locuriLibere;

        // Atributele noi adăugate (doar câmpuri publice)
        public string gen;
        public int durataMinute;
        public string regizor;
        public double pretBilet;
        public string sala;
        public double ratingImdb;
        public bool este3D;
        public int limitaVarsta;
        public string oraDifuzare; // Ex: "19:30" sau "Vineri, 20:00"

        public string Descriere()
        {
            string text = "";
            text += "Titlul este " +titlu+ "\n";
            text += "Locuri libere :"+locuriLibere+ "\n";

            return text;

        }


    }
}
