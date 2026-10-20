using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata.Ecma335;

namespace structuri
{
    internal class AdapostService
    {
        private List <Adapost> adaposturi = new List <Adapost> ();

        public void LoadAdaposturi()
        {
            Adapost adapost1 = new Adapost ();
            adapost1.nume = "Bucuresti1";
            adapost1.specie = "caine";
            adapost1.adoptat = true;
            adaposturi.Add(adapost1);

            Adapost adapost2 = new Adapost ();
            adapost2.nume = "Bucuresti2";
            adapost2.specie = "pisica";
            adapost2.adoptat = true;
            adaposturi.Add (adapost2);

            Adapost adapost3 = new Adapost();
            adapost3.nume = "Bucuresti3";
            adapost3.specie = "papagal";
            adapost3.adoptat = false;
            adaposturi.Add(adapost3);

            Adapost adapost4 = new Adapost();
            adapost4.nume = "Bucuresti4";
            adapost4.specie = "iepure";
            adapost4.adoptat = false;
            adaposturi.Add (adapost4);

            Adapost adapost5 = new Adapost();
            adapost5.nume = "Bucuresti5";
            adapost5.specie = "hamster";
            adapost5.adoptat = true;
            adaposturi.Add(adapost5);

        }
        
        public void AfisareAdaposturi()
        {
            for(int i = 0; i < adaposturi.Count; i++)
            {
                Console.WriteLine(adaposturi[i].Descriere());
            }   
        }


        public Adapost GasesteAdapostul(string nume)
        {
            for(int i = 0; i < adaposturi.Count; i++)
            {
                if (adaposturi[i].nume.Equals(nume))
                {
                    return adaposturi[i];
                }
            }
            return null;
        }


        //Metoda Addadapost primeste un ob de tip Adapost pe care l am numit adapostprimit
        public bool AddAdapost(Adapost adapostprimit)
        {
            //cautat pastreaza valorarea returnata de Metoda GasesteAdapsotul, adica rez cautarii
            //adapostprimit - numele ob trimis din Main,val dupa care caut
            Adapost cautat = GasesteAdapostul(adapostprimit.nume);

            if (cautat == null) //nu exista un ob cu acest nume, pot sa il adaug!
            {
                adaposturi.Add(adapostprimit);

                return true;
            
            }
        
            return false;

               
        }

        //aflu pozitia(indexul)pe care se afla adapostul in lista
        public int FindPositionAdapostByName(string nume)
        {
            for(int i =0; i < adaposturi.Count; i++)
            {
                if (adaposturi[i].nume.Equals(nume))
                {
                    return i;
                }
            }
            return -1;
        }

        public bool DeleteAdapostByName(String nume)
        {
            int pozitia = FindPositionAdapostByName(nume);

            if(pozitia != -1)   
            {
                adaposturi.RemoveAt(pozitia);
                return true;
            }
            return false;

        }

        public bool EditSpecieAdapost(string nume ,string newSpecie)
        {
            int pozitie = FindPositionAdapostByName(nume);

            if(pozitie != -1)
            {
                adaposturi[pozitie].specie = newSpecie;
                return true;
            }
            return false;
        }




    }
}
