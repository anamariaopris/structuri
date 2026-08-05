using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Transactions;

namespace structuri
{
    internal class Produs
    {
        public String nume;
        public double pret;
        public int stoc;
        public bool inOferta;
        public double pretNou;
        public double procent;
        

        public string Descriere()
        {
            
            
            string text = "";
            text += "Nume " + this.nume + "\n";
            text += "Pret " + pret + "\n";
            text += "Stoc " + stoc + "\n";
            if (inOferta)
            {
                text += " este la oferta";
            }
            else
            {
                text += " nu este la oferta";
            }
           

            return text+"\n";
        }


        public double ValoareStoc()
        {
            return pret * stoc;
        }


        public Boolean IsInStoc()
        {

            return stoc > 0;

        }

        public  void  AplicaReducere(double reducere)  
        //variabila reducere defapt ia valoarea din variabila procent,
        //AplicaReducere(procent) - > aici procent nu exista defapt   
        {

            this.pret = this.pret - (reducere / 100) * this.pret;
        }
        

            

        
        

     




    }
}
