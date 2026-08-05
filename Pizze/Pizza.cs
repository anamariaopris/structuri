using System;
using System.Collections.Generic;
using System.Text;

namespace structuri
{
    internal class Pizza
    {
        public string nume;
        public double pret;
        public bool disponibila;

        public string Descriere()
        {
            return  $"Pizza: {nume}, Preț: {pret} lei, Disponibilă: {(disponibila ? "Da" : "Nu")}";
        }
    }
}
