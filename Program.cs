
using structuri;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {


        exdercitiul7ProduseleDinOferta();


    }

    static void ex1()
    {

        User x = new User();

        User y = new User();

        User z = new User();

        x.email = "test@gmail.com";
        x.age = 43;
        x.password = "123a";
        x.isActive = true;
        x.name = "Ana";

        y.email = "test2@gmail.com";
        y.age = 30;
        y.password = "12a";
        y.isActive = true;
        y.name = "Maria";


        z.email = "test3@gmail.com";
        z.age = 33;
        z.password = "1aa";
        z.isActive = true;
        z.name = "test";


        //todo: afiseazami userul  cu varsta cea mai mare

        //cazul x 
        if (x.age > y.age && x.age > z.age)
        {
            Console.WriteLine("Userul cu varsta maxima este " + x.age);
        }
        else if (y.age > x.age && y.age > z.age)
        {
            Console.WriteLine("Userul cu varsta maxima este " + y.age);
        }
        else
        {
            Console.WriteLine("Userul cu varsta maxima este " + z.age);
        }
    }

    static void ex2()
    {
        User x = new User();

        User y = new User();

        User z = new User();

        x.email = "test@gmail.com";
        x.age = 43;
        x.password = "123a";
        x.isActive = true;
        x.name = "Ana";

        y.email = "test2@gmail.com";
        y.age = 30;
        y.password = "12a";
        y.isActive = true;
        y.name = "Maria";


        z.email = "test3@gmail.com";
        z.age = 33;
        z.password = "1aa";
        z.isActive = true;
        z.name = "test";

        //cati useri sunt activi

        int contorActivi = 0;

        if (x.isActive)
        {

            contorActivi++;

        }
        if (y.isActive)
        {
            contorActivi++;
        }
        if (z.isActive)
        {
            contorActivi++;
        }
        Console.WriteLine("Useri activi" + contorActivi);

    }

    static void ex3()
    {
        User x = new User();

        User y = new User();

        User z = new User();

        x.email = "test@gmail.com";
        x.age = 43;
        x.password = "123a";
        x.isActive = true;
        x.name = "Ana";

        y.email = "test2@gmail.com";
        y.age = 30;
        y.password = "12a";
        y.isActive = true;
        y.name = "Maria";


        z.email = "test3@gmail.com";
        z.age = 33;
        z.password = "1aa";
        z.isActive = true;
        z.name = "test";

        //afiseaza varsta medie a celor 3 useri

        double sumamedie = (x.age + y.age + z.age) / 3;


        Console.WriteLine(sumamedie);

    }

    static void ex4()
    {
        User x = new User();

        User y = new User();

        User z = new User();

        x.email = "test@gmail.com";
        x.age = 43;
        x.password = "123a";
        x.isActive = true;
        x.name = "Ana";

        y.email = "test2@gmail.com";
        y.age = 30;
        y.password = "12a";
        y.isActive = true;
        y.name = "Maria";


        z.email = "test3@gmail.com";
        z.age = 33;
        z.password = "1aa";
        z.isActive = true;
        z.name = "test";

        //sunt de acceasi varsta?



        if (x.age == y.age && x.age == z.age)
        {
            Console.WriteLine("au varste identice");
        }
        else
        {
            Console.WriteLine(" nu au aceeasi varsta");
        }

    }
    static void ex5()
    {
        Produs x = new Produs();

        Produs y = new Produs();

        Produs z = new Produs();

        x.nume = "baterie";
        x.pret = 5;
        x.stoc = 2;

        y.nume = "bec";
        y.pret = 10;
        x.stoc = 1;

        z.nume = "surub";
        z.pret = 12.5;
        z.stoc = 10;

        //suma preturilor celor 3 produse ; afiseaza val totala a stocului unui produs(pret *stoc)

        double sumaPretProduse = x.pret + y.pret + z.pret;

        Console.WriteLine("Suma pretului celor trei produse este: " + sumaPretProduse);


        double surub = 12.5 * 10;

        Console.WriteLine("Valoarea totala a stocului unui produs este : " + surub);

    }
    static void ex6()
    {
        Produs x = new Produs();

        Produs y = new Produs();

        Produs z = new Produs();

        x.nume = "baterie";
        x.pret = 5;
        x.stoc = 2;

        y.nume = "bec";
        y.pret = 10;
        y.stoc = 1;
        y.inOferta = true;


        z.nume = "surub";
        z.pret = 12.5;
        z.stoc = 10;
        z.inOferta = true;

        //Cerință: afișează numele doar pentru produsele care sunt în ofertă.
        //Indiciu: câte un if (produs.inOferta) pentru fiecare obiect.

        if (x.inOferta)
        {
            Console.WriteLine("baterie este in oferta ");
        }
        if (y.inOferta)
        {

            Console.WriteLine("bec este in oferta ");

        }
        if (z.inOferta)
        {

            Console.WriteLine("surub este in oferta ");
        }

    }
    static void ex7()
    {
        //creaza 2 obiecte Produs
        Produs x = new Produs();
        Produs y = new Produs();

        //1.afiseaza pretul fiecarui produs
        x.nume = "laptop";
        x.pret = 1000;


        y.nume = "telefon";
        y.pret = 2000.5;

        Console.WriteLine(x.nume + " : " + x.pret);
        Console.WriteLine(y.nume + " : " + y.pret);

        //2.scade 10 din pretul fiecaruia (produs.pret = produs.pret - 10)

        Console.WriteLine("Pret dupa scadere");
        Console.WriteLine(x.nume + " : " + x.pret);
        Console.WriteLine(y.nume + " : " + x.pret);


    }

    static void ex8()
    {
        Student x = new Student();
        Student y = new Student();
        Student z = new Student();

        x.nume = "Matei";
        x.medie = 2;

        y.nume = "Marius";
        y.medie = 5.5;

        z.nume = "Razvan";
        z.medie = 7;


        if (x.medie >= 5)
        {
            Console.WriteLine(x.nume + " Promovat");
        }
        else
        {

            Console.WriteLine(x.nume + " Nepromovat");

        }
        if (y.medie >= 5)
        {
            Console.WriteLine(y.nume + " Promovat");
        }
        else
        {

            Console.WriteLine(y.nume + " Nepromovat");

        }
        if (z.medie >= 5)
        {
            Console.WriteLine(z.nume + " Promovat");
        }
        else
        {

            Console.WriteLine(z.nume + " Nepromovat");

        }





    }
    static void ex9()
    {
        Produs x = new Produs();

        x.nume = "laptop";
        x.pret = 2500;
        x.stoc = 12;
        string text = "Nume " + x.nume + "\n";
        text += "Pret " + x.pret + "\n";
        text += "Stoc " + x.stoc;

        // Console.WriteLine(x.nume + " - " + x.pret + " lei - in stoc : " + x.stoc + " buc " );

        Console.WriteLine(text);
    }



    //exercitii liste si for

    static void ex1Liste()
    {
        Produs x = new Produs();
        x.pret = 12;
        x.nume = "laptop";
        x.inOferta = false;
        x.stoc = 12;

        Produs x1 = new Produs();
        x1.pret = 12;
        x1.nume = "laptop1";
        x1.inOferta = false;
        x1.stoc = 12;

        Produs x2 = new Produs();
        x2.pret = 12;
        x2.nume = "laptop2";
        x2.inOferta = false;
        x2.stoc = 12;

        Produs x3 = new Produs();
        x3.pret = 12;
        x3.nume = "laptop3";
        x3.inOferta = false;
        x3.stoc = 12;

        Produs x4 = new Produs();
        x4.pret = 12;
        x4.nume = "laptop4";
        x4.inOferta = false;
        x4.stoc = 12;

        Console.WriteLine(x4.Descriere());


        List<Produs> produse = new List<Produs>(); //listele sunt indexate 0

        produse.Add(x1);//0
        produse.Add(x2);//1
        produse.Add(x3);//2
        produse.Add(x4);//3



        Console.WriteLine(produse[0].Descriere());
        Console.WriteLine(produse[1].Descriere());
        Console.WriteLine(produse[2].Descriere());
        Console.WriteLine(produse[3].Descriere());

        //produse.Count =>4
        Console.WriteLine("Afisarea unei liste de produse folosind for");
        for (int i = 0; i < produse.Count; i++)
        {
            Console.WriteLine(produse[i].Descriere());
        }


        //0<4 da  af(produse[0])  i devine 1

        //1<4  da  af(produse[1]) i devine 2
        //2<4  da af(produse[2])  i devine 3


    }

    static void ex2Liste()
    {
        Student st1 = new Student();
        st1.nume = "Ana";
        st1.medie = 10;

        Student st2 = new Student();
        st2.nume = "Raul";
        st2.medie = 5;

        Student st3 = new Student();
        st3.nume = "Mihai";
        st3.medie = 10;

        List<Student> studenti = new List<Student>();

        studenti.Add(st1);
        studenti.Add(st2);
        studenti.Add(st3);

        Console.WriteLine("Afisarea unei liste cu studenti :");
        for (int i = 0; i < studenti.Count; i++)
        {
            Console.WriteLine(studenti[i].Descriere());
        }


    }

    static void exercitiul2Sumapreturilor()
    {
        Produs a = new Produs();
        a.pret = 5;
        a.nume = "televizor";

        Produs b = new Produs();
        b.pret = 10;
        b.nume = "bec";

        Produs c = new Produs();
        c.pret = 12.5;
        c.nume = "TV";

        List<Produs> produse = new List<Produs>();

        produse.Add(a);
        produse.Add(b);
        produse.Add(c);

        double suma = 0;
        for (int i = 0; i < produse.Count; i++)
        {


            suma += produse[i].pret;

        }
        Console.WriteLine("Suma produselor este " + suma);

    }

    static void exercitiul3PretulMediu()
    {
        Produs Q = new Produs();
        Q.pret = 5;
        Produs W = new Produs();
        W.pret = 10;
        Produs E = new Produs();
        E.pret = 12.5;

        List<Produs> produse = new List<Produs>();

        produse.Add(Q);
        produse.Add(W);
        produse.Add(E);

        double suma = 0;
        for (int i = 0; i < produse.Count; i++)
        {
            suma += produse[i].pret;
        }
        Console.WriteLine("Suma medie este : " + (double)(suma / produse.Count));


    }

    static void exercitiul4CelMaiScumpProdus()
    {
        Produs A = new Produs();
        Produs B = new Produs();
        Produs C = new Produs();

        A.pret = 12.5;
        A.nume = "surub";

        B.pret = 10;
        B.nume = "lanterna";

        C.pret = 5;
        C.nume = "baterie";

        List<Produs> produse = new List<Produs>();

        produse.Add(A);
        produse.Add(B);
        produse.Add(C);

        Produs maxim = produse[0]; // este pretul maxim

        for (int i = 1; i < produse.Count; i++)
        {
            if(produse[i].pret > maxim.pret)
            {
                maxim = produse[i];
            }

        }

        Console.WriteLine("Produsul cel mai scump este " + maxim.nume);


    }

    static void exercitiul5CelMaiIeftinProdus()
    {
        Produs A = new Produs();
        Produs B = new Produs();
        Produs C = new Produs();

        A.pret = 12.5;
        A.nume = "surub";

        B.pret = 10;
        B.nume = "lanterna";

        C.pret = 5;
        C.nume = "baterie";

        List<Produs> produse = new List<Produs>();

        produse.Add(A);
        produse.Add(B);
        produse.Add(C);

        Produs minim = produse[2];

        for (int i = 0; i < produse.Count; i++) //parcurg fiecare element din lista cu Count i++ 
        {
            if (produse[i].pret <= minim.pret)
                minim = produse[i];

            
        }

        Console.WriteLine("Produsul cel mai ieftin este " + minim.nume);

    }
    
    static void exercitiu6CateProduseInOferta ()
    {
        Produs A = new Produs();
        Produs B = new Produs();
        Produs C = new Produs();

        A.pret = 12.5;
        A.nume = "surub";
        A.inOferta = false;

        B.pret = 10;
        B.nume = "lanterna";
        B.inOferta = true;

        C.pret = 5;
        C.nume = "baterie";
        C.inOferta = true;

        List<Produs> produse = new List<Produs>();

        produse.Add(A);
        produse.Add(B);
        produse.Add(C);

        int ct = 0;//numar produsele in oferta 

        for (int i = 0; i < produse.Count; i++) //parcurg fiecare element din lista cu Count i++ 
        {
            if (produse[i].inOferta)

                ct++;


        }

        Console.WriteLine("Cate produse sunt in oferta: " + ct);

    }

    static void exdercitiul7ProduseleDinOferta()
    {
        Produs A = new Produs();
        Produs B = new Produs();
        Produs C = new Produs();

        A.pret = 12.5;
        A.nume = "surub";
        A.inOferta = false;

        B.pret = 10;
        B.nume = "lanterna";
        B.inOferta = true;

        C.pret = 5;
        C.nume = "baterie";
        C.inOferta = true;

        List<Produs> produse = new List<Produs>();

        produse.Add(A);
        produse.Add(B);
        produse.Add(C);

        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].inOferta)
            {
                Console.WriteLine(produse[i].nume);
            }
        }



    }


}
