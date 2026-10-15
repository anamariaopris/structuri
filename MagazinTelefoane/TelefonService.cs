using structuri.Bibleoteca;
using System;
using System.Collections.Generic;
using System.Text;

namespace structuri.MagazinTelefoane
{
    internal class TelefonService
    {
        private List<Telefon> telefoane = new List<Telefon>();

        public void LoadTelefoane()
        {
            Telefon telefon1 = new Telefon();
            telefon1.brand = "Samsung";
            telefon1.model = "Galaxy S24";
            telefon1.pret = 4299;
            telefon1.memorieGB = 256;
            telefoane.Add(telefon1);

            Telefon telefon2 = new Telefon();
            telefon2.brand = "Apple";
            telefon2.model = "iPhone 15";
            telefon2.pret = 4799;
            telefon2.memorieGB = 128;
            telefoane.Add(telefon2);

            Telefon telefon3 = new Telefon();
            telefon3.brand = "Xiaomi";
            telefon3.model = "Redmi Note 13";
            telefon3.pret = 1199;
            telefon3.memorieGB = 256;
            telefoane.Add(telefon3);

            Telefon telefon4 = new Telefon();
            telefon4.brand = "Motorola";
            telefon4.model = "Moto G84";
            telefon4.pret = 1099;
            telefon4.memorieGB = 256;
            telefoane.Add(telefon4);

            Telefon telefon5 = new Telefon();
            telefon5.brand = "Google";
            telefon5.model = "Pixel 8";
            telefon5.pret = 3199;
            telefon5.memorieGB = 128;
            telefoane.Add(telefon5);


        }

        public void AfisareTelefoane()
        {
            for (int i = 0; i < telefoane.Count; i++)
            {
                Console.WriteLine(telefoane[i].Descriere());
            }
        }

        public Telefon GasesteModel(string model)
        {
            for (int i = 0;  i < telefoane.Count; i++)
            {
                if (telefoane[i].model.Equals(model))
                {
                    return telefoane[i];
                }

            }
            return null;
        }

       
        public bool AddTelefon(Telefon telefon)
        {
            //verificam daca telefonul este in lista
            Telefon x = GasesteModel(telefon.model);
             
            if(x == null)
            {
                telefoane.Add(x);
                return true;
            }

            return false;

        }

   
        //functie de gasire masina si sa ne returneze pozitia din lista

        public int  FindTelefonByModel(String model)
        {
            for(int i =0;i < telefoane.Count; i++)
            {
                if (telefoane[i].model.Equals(model)){

                    return i;
                }
            }
            return -1;
        }

        public  bool DeleteTelefonByModel(String model)
        {
               int poz= FindTelefonByModel(model);

            if (poz != -1)
            {
                telefoane.RemoveAt(poz);
                return true;
            }

            return false;


        }

        //editare
        public bool EditPriceTelefon(String model,int newPrice)
        {
            int pozitie = FindTelefonByModel(model);

            if( pozitie != -1)
            {
                telefoane[pozitie].pret = newPrice;
                return true;
            }
            return false;

        }
        
    }

    
}
