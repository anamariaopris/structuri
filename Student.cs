using System;
using System.Collections.Generic;
using System.Text;

namespace structuri
{
    internal class Student
    {
        //ATRIBUTE SI METODE
        public String nume;
        public double medie;


        public String descriere()
        {
            String text = "";
            text += "Nume " + nume + "\n";
            text += " Medie " + medie;


            return text;

        }


    }
}
