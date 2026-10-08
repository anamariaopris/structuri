using System;
using System.Collections.Generic;
using System.Text;

namespace structuri.Masini
{
    public class Masini
    {
        public string marca;
        public double capacitateCilindrica;
        public double pret;
        
        public string Descriere()
        {
            string text = "";
            text += "Marca este : " + marca + "\n";
            text += "Capacitatea cilindrica : " + capacitateCilindrica + "\n";
            text += "Pretul este : " + pret + "\n";
            return text;
        }
    }
}
