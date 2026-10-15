using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace structuri.Bibleoteca
{
    internal class Carte
    {
        public string titlu;
        public string autor;
        public int pagini;
        public int pret;
        
        public string Descriere()
        {
            //string text = $"{titlu} - {autor} ,{pagini}"; 
            //return text;

            return $"{titlu} - {autor}, {pagini}, {pret} lei"; //interpolare 

        }

        //atribute noi
        public int volumPagini;



    }

}
