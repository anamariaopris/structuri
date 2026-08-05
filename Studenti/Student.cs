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
        public String password;


        public String Descriere()
        {
            String text = "";
            text += "Nume " + nume + "\n";
            text += " Medie " + medie;


            return text;

        }

        public Boolean IsValidCredentials(String username, String password)
        {
            if (this.nume.Equals(username) && this.password.Equals(password))
            {
                return true;
            }

            return false;


        }

    }
}
