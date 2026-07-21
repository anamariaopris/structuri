using System;
using System.Collections.Generic;
using System.Text;

namespace structuri
{
    internal class Utilizatori
    {
       public  string username;
       public  string parola;



        public bool Login(string username, string parola)
        {

            if (this.username.Equals(username) && this.parola.Equals(parola))
            {

                return true;

            }

            return false;
        }

    }
}
