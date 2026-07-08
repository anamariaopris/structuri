using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace structuri
{
    internal class Produs
    {
        public String nume;
        public Double pret;
        public int stoc;
        public bool inOferta;

        public string Descriere()
        {
            string text = " ";
            text += "Nume" + this.nume + "\n";
            text += "Pret" + pret + "\n";
            text += "Stoc" + stoc + "\n";
            if (inOferta)
            {
                text += " este la oferta";
            }
            else
            {
                text += " nu este la oferta";
            }
           

            return text;
        }


        public double ValoareStoc()
        {
            return pret * stoc;
        }


        public Boolean IsInStoc()
        {

            return stoc > 0;

        }


    }
}
