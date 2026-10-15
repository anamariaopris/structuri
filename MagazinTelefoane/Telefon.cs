using System;
using System.Collections.Generic;
using System.Text;

namespace structuri.MagazinTelefoane
{
    internal class Telefon
    {
        public string brand;
        public string model;
        public int pret;
        public int memorieGB;

        public string Descriere()
        { 

            return $"{brand} - {model}, {pret}, {memorieGB}GB"; 

        }
    }
}
