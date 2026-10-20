using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace structuri
{
    internal class Adapost
    {
        public string nume;
        public string specie;
        public bool adoptat;
        
        public string Descriere()
        {
            string text = "";
            text += "nume : " + nume + "\n";
            text += "specie : " + specie + "\n";
            text += "adoptat : " + adoptat + "\n";

            return text;
        }  
    }
}
