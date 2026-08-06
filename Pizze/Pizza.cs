using System;
using System.Collections.Generic;
using System.Text;

namespace structuri
{
    internal class Pizza
    {
        public string nume="";
        public double pret=0;
        public bool disponibila=false;

        public string Descriere()
        {
            return  $"Pizza: {nume}, Preț: {pret} lei, Disponibilă: {(disponibila ? "Da" : "Nu")}";
        }
    }
}
