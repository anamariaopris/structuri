using System;
using System.Collections.Generic;
using System.Text;

namespace structuri
{
    internal class Joc
    {
        public string nume;
        public string platforma;
        public bool terminat;

        public string Descriere()
        {
            return $"Joc: {nume}, Platforma: {platforma}, terminat : {(terminat ? "DA" : "NU")}";
        }

    }
}
