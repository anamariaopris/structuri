using System;
using System.Collections.Generic;
using System.Text;

namespace structuri
{
    internal class ContBancar
    {
        public String titular;
        public double sold;
        public String nume;
       

        public void  Depune(double suma)
        {

            if (suma > 0)
            {
                sold += suma;
            }
            else
            {
                Console.WriteLine("suma introdusa este negativa");
            }
        }

        public void Retrage(double suma)
        {
            if(suma > 0 && suma <= sold)
            {
                sold = sold - suma;
            }
            else
            {
                Console.WriteLine("Fonduri insuficiente");
            }

        }

        public bool PoateRetrage(double suma)
        {
            if (suma > sold )
            {
                return true;

            }
            else
            {
                return false;
            }



        }




    }
  
}
