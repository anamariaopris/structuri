
using structuri;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    static void Main(string[] args)
    {


        Exercitiul15();
        

      



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
        x.age = 40;
        x.password = "123a";
        x.isActive = true;
        x.name = "Ana";

        y.email = "test2@gmail.com";
        y.age = 30;
        y.password = "12a";
        y.isActive = true;
        y.name = "Maria";


        z.email = "test3@gmail.com";
        z.age = 20;
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
        y.stoc = 1;

        z.nume = "surub";
        z.pret = 12.5;
        z.stoc = 10;

        //suma preturilor celor 3 produse ; afiseaza val totala a stocului unui produs(pret *stoc)

        double sumaPretProduse = x.pret + y.pret + z.pret;

        Console.WriteLine("Suma pretului celor trei produse este: " + sumaPretProduse);


        double valoareStoc = z.pret * z.stoc;

        Console.WriteLine("Valoarea totala a stocului unui produs este : " + valoareStoc);

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
        st2.password = "1234";

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


        Console.WriteLine(st2.IsValidCredentials("Raul","1234"));

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

    static void exercitiul8ProduseAuStoc()
    {
        Produs A = new Produs();
        Produs B = new Produs();
        Produs C = new Produs();

        A.pret = 12.5;
        A.nume = "surub";
        A.stoc = 2;

        B.pret = 10;
        B.nume = "lanterna";
        B.stoc = 1;

        C.pret = 5;
        C.nume = "baterie";
        C.stoc = 10;

        List<Produs> produse = new List<Produs>();

        produse.Add(A);
        produse.Add(B);
        produse.Add(C);

        int prag =2;

        int ct = 0;
        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].stoc > prag)
            {
                ct++;
            }
           
        }
        Console.WriteLine("Cate produse au stoc peste prag ; " + ct++);

    }

    static void exercitiul9TotalStoc()
    {
        Produs A = new Produs();
        Produs B = new Produs();
        Produs C = new Produs();

        A.pret = 12.5;
        A.nume = "surub";
        A.stoc = 2;

        B.pret = 10;
        B.nume = "lanterna";
        B.stoc = 1;

        C.pret = 5;
        C.nume = "baterie";
        C.stoc = 10;


        Console.WriteLine(C.IsInStoc());

        List<Produs> produse = new List<Produs>();

        produse.Add(A);
        produse.Add(B);
        produse.Add(C);

        double sumaTotala = 0;
        for (int i = 0; i < produse.Count; i++)
        {
             sumaTotala+= produse[i].ValoareStoc();
        }

        Console.WriteLine("Valoare totala stoc :" + sumaTotala);

    }

    static void ExercitiiMetodeCrud1()
    {
        ContBancar  ct= new ContBancar();

        ct.titular = "test";
        ct.sold = 20;

        ct.Depune(-323);
         

        Console.WriteLine(ct.sold);
    }
    
    static void ExercitiiMetodeCrud2()
    {
        ContBancar X = new ContBancar();

        X.sold = 150;
        X.Retrage(200);

        Console.WriteLine(X.sold);
    }

    //static void  exercitiimetodecrud3()
    //{

    //    contbancar x = new contbancar();

    //    x.sold = 90;

    //    if (x.poateretrage(90))
    //    {
    //        console.writeline("se poate");
    //    }
    //    else
    //    {
    //        console.writeline("fonduri insuficiente");
    //    }

    //}

    //static void ExercitiiMetodeCrud4()
    //{

    //    Utilizator a = new Utilizator();

    //    a.username = "Ana.Maria";
    //    a.esteActiv = true;
    //    a.password = "abcd";

    //    if (a.Login("test1","psw"))
    //    {
    //        Console.WriteLine("logat");

    //    }
    //    else
    //    {
    //        Console.WriteLine("credentiale incorecte");
    //    }

    //    Utilizator b = new Utilizator();

    //    b.username = "TEST";
    //    b.esteActiv = true;
    //    b.password = "password";

    //    if (b.Login("TEST", "password"))
    //    {
    //        Console.WriteLine("logat");

    //    }
    //    else
    //    {
    //        Console.WriteLine("Credentiale incorecte");
    //    }


    //}

    //static void ExercitiiMetodeCrud5()
    //{
    //    Utilizator x = new Utilizator();
    //    x.password = "password";

    //    if(x.ParolaEstePuternica())
    //    {
    //        Console.WriteLine("Parola corecta");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Parola prea scurta");
    //    }



    //}
    //static void ExercitiiMetodeCrud6()
    //{

    //    Utilizator x = new Utilizator();
    //    x.email = "ana@gmail.com";

    //    if (x.EmailEsteValid())
    //    {
    //        Console.WriteLine("Contine");

    //    }
    //    else
    //    {
    //        Console.WriteLine("Nu contine");
    //    }

    //}
    //static void ExercitiiMetodeCrud7()
    //{
    //    Utilizator x = new Utilizator();
    //    x.email = "ana@gmail.com";

    //    if (x.EmailEsteValid() || x.ParolaEstePuternica())
    //    {
    //        Console.WriteLine("Cont creat cu succes");

    //    }
    //    else
    //    {
    //        Console.WriteLine("Date invalide");
    //    }

    //}

    static void ExercitiiMetodeCrud8()
    {
        Produs q = new Produs();
        q.nume = "laptop";
        q.pret = 2500;

        Produs w = new Produs();
        w.nume = "tastatra";
        w.pret = 0;

        List<Produs> produse = new List<Produs>();

        if (q.nume.Length > 0 && q.pret > 0)
        {
            produse.Add(q);
            
        }
        else
        {
            Console.WriteLine(q.nume +" nu respecta validarea listei");
        }


        if(w.nume.Length > 0 && w.pret > 0)
        {
            produse.Add(w);
            
        }
        else
        {
            Console.WriteLine (w.nume + " respins");
        }

        Console.WriteLine("produsele adaugate au fost");
        for(int i = 0; i < produse.Count; i++)
        {
            Console.WriteLine(produse[i].nume);
        }



    }

    static void ExercitiiMetodeCrud9()
    {
        Produs z = new Produs();
        Produs x = new Produs();
        Produs ab = new Produs();
        Produs abc = new Produs();


        z.nume = "lanterna";
        x.nume = "baterie";
        ab.nume = "lanterna2";
        abc.nume = "baterie";

        z.pret = 12;
        x.pret = 5;
        ab.pret = 25;
        abc.pret = 1;

        z.stoc = 1;
        x.stoc = 3;
        ab.stoc = 5;
        abc.stoc = 10;



        List<Produs> produse = new List<Produs>();
        produse.Add(z);
        produse.Add(x);
        produse.Add(ab);
        produse.Add(abc);


        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].nume.Equals("lanterna"))
            {

                Console.WriteLine(produse[i].Descriere());

            }
           

        }

        



    }
    static void ExercitiiMetodeCrud10()
    {
        Produs z = new Produs();
        Produs x = new Produs();
        Produs ab = new Produs();
        Produs abc = new Produs();


        z.nume = "lanterna";
        x.nume = "baterie";
        ab.nume = "lanterna2";
        abc.nume = "baterie";

        z.pret = 12;
        x.pret = 5;
        ab.pret = 25;
        abc.pret = 1;

        z.stoc = 1;
        x.stoc = 3;
        ab.stoc = 5;
        abc.stoc = 10;

        List<Produs> produse = new List<Produs>();

        produse.Add(z);
        produse.Add(x);
        produse.Add(ab);
        produse.Add(abc);
        Console.WriteLine("Pretul initial este " + abc.pret);

        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].nume.Equals("baterie"))
            {
                produse[i].pret = 1234;
            }

            
        }
        Console.WriteLine("Pretul final este  "+ abc.pret);

    }

    static void ExercitiiMetodeCrud11()
    {
        Produs z = new Produs();
        Produs x = new Produs();
        Produs ab = new Produs();
        Produs abc = new Produs();


        z.nume = "lanterna";
        x.nume = "baterie";
        ab.nume = "lanterna2";
        abc.nume = "baterie2";

        z.pret = 12;
        x.pret = 5;
        ab.pret = 25;
        abc.pret = 1;

        z.stoc = 1;
        x.stoc = 3;
        ab.stoc = 5;
        abc.stoc = 10;

        List<Produs> produse = new List<Produs>();

        produse.Add(z);
        produse.Add(x);
        produse.Add(ab);
        produse.Add(abc);

        //Console.WriteLine(produse.Count);
        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].nume.Equals("baterie2"))
            {
                
                produse.RemoveAt(i);


            }
            


        }
        Console.WriteLine("=====================");    
        for (int i = 0; i < produse.Count; i++)
        {
            Console.WriteLine(produse[i].Descriere());
        }


    }

    static void ExercitiiMetodeCrud12()
    {
        Produs z = new Produs();
        Produs x = new Produs();
        Produs ab = new Produs();
        Produs abc = new Produs();


        z.nume = "lanterna";
        x.nume = "baterie";
        ab.nume = "lanterna2";
        abc.nume = "baterie2";

        z.pret = 12;
        x.pret = 5;
        ab.pret = 25;
        abc.pret = 1;

        z.stoc = 1;
        x.stoc = 3;
        ab.stoc = 5;
        abc.stoc = 10;

        z.inOferta = true;
        x.inOferta = true;
        ab.inOferta = false;
        abc.inOferta= true;

        List<Produs> produse = new List<Produs>();

        produse.Add(z);
        produse.Add(x);
        produse.Add(ab);
        produse.Add(abc);

        int ct = 0;
        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].inOferta)
            {
                ct++;
                Console.WriteLine(produse[i].Descriere());
            }

        }



        Console.WriteLine("In total sunt "+ct +" produse la oferat");
    }

    static void Exercitiul13()
    {
        Utilizatori x = new Utilizatori();
        x.username = "Ana";
        x.parola = "abcd";

        Utilizatori y = new Utilizatori();
        y.username = "Raul";
        y.parola = "bcd";


        Utilizatori w = new Utilizatori();
        w.username = "Mihai";
        w.parola = "zzz";


        List<Utilizatori> utilizatori = new List<Utilizatori>();

        utilizatori.Add(x);
        utilizatori.Add(y);
        utilizatori.Add(w);

        //
        string usr = "Ana";
        string pass = "abcd";

        Utilizatori cautat = null;

        for (int i = 0; i < utilizatori.Count; i++)
        {
            if (utilizatori[i].username.Equals(usr))
            {



                cautat = utilizatori[i];

            }

        }

        if (cautat != null)
        {

            if (cautat.Login(usr, pass))
            {
                Console.WriteLine("Autentificare reusita");
            }
            else
            {
                Console.WriteLine("parola incorecta");
            }
        }
        else
        {
            Console.WriteLine("Utilizatorul nu exiusta");
        }




    }

    static void Exercitiul14()
    {
        Produs x = new Produs();
        x.nume = "produs1";
        x.pret = 120;
        x.stoc = 2;
        x.procent = 5;

        Produs y = new Produs();
        y.nume = "produs2";
        y.pret = 100;
        y.stoc = 20;
        y.procent = 30;

        Produs z = new Produs();
        z.nume = "produs3";
        z.pret = 850;
        z.stoc = 2;
        z.procent = 10;


        Produs q = new Produs();
        q.nume = "produs4";
        q.pret = 140;
        q.stoc = 3;
        q.procent = 15;

        List<Produs> produse = new List<Produs>();
        produse.Add(x);
        produse.Add(y);
        produse.Add(z);
        produse.Add(q);

        double total = 0;
        for(int i = 0; i< produse.Count; i++)
        {

            total += produse[i].ValoareStoc();
        }

        Console.WriteLine("Valoarea produselor este "+total);

        double procent = 10;
  
        for(int i = 0; i < produse.Count; i++)
        {

            produse[i].AplicaReducere(procent);

        }

        Console.WriteLine("Dupa reducere noul pret al produselor este");
        for (int i = 0; i < produse.Count; i++)
        {

            Console.WriteLine(produse[i].nume+" " + produse[i].pret);

        }


    }

    static void ExercitiuRecapitulare14()
    {
        Produs xyz1 = new Produs();
        xyz1.nume = "AAA";
        xyz1.stoc = 2;
        xyz1.pret = 10;


        Produs xyz2 = new Produs();
        xyz2.nume = "bbb";
        xyz2.stoc = 20;
        xyz2.pret = 100;


        Produs xyz3 = new Produs();
        xyz3.nume = "xxx";
        xyz3.stoc = 15;
        xyz3.pret = 500;

        List <Produs> produse = new List<Produs>();

        produse.Add(xyz1);
        produse.Add(xyz2);
        produse.Add(xyz3);

        double valoareSuma = 0; //nu cunosc suma de la inceput

        for (int i = 0;i < produse.Count; i++)
        {
            valoareSuma = valoareSuma + produse[i].ValoareStoc();
            //produse[i] - > doar un produs oarecare din lista

        }
        Console.WriteLine(valoareSuma);

        double procent = 10;

        for(int i = 0; i < produse.Count; i++)
        {
            produse[i].AplicaReducere(procent);


            //Console.WriteLine(produse[i].pret ); 
        }
    
        Console.WriteLine("Dupa reducere noul pret al produselor este: ");


        for (int i = 0; i < produse.Count; i++)
        {

            Console.WriteLine(produse[i].nume + " " + produse[i].pret);

        }


    }

    static void Exercitiul15()
    {
        Produs x = new Produs();
        x.nume = "produs1";
        x.pret = 120;
        x.stoc = 2;
        x.procent = 5;

        Produs y = new Produs();
        y.nume = "";
        y.pret = 100;
        y.stoc = 20;
        y.procent = 30;

        Produs z = new Produs();
        z.nume = "produs3";
        z.pret = 850;
        z.stoc = 2;
        z.procent = 10;

        List<Produs> produse = new List<Produs>();
        Console.WriteLine("============Adaugarea cu validare====================");
        if (x.nume.Length > 0 && x.pret > 0)
        {
            produse.Add(x);

        }
        else
        {
            Console.WriteLine(x.nume + " nu respecta validarea listei");
        }

        if(y.nume.Length > 0 && y.pret > 0)
        {
            produse.Add(y);

        }
        else
        {
            Console.WriteLine(y.nume + " nu respecta validarea listei");
        }

        if(z.nume.Length > 0 && z.pret > 0)
        {
            produse.Add(z);
        }
        else
        {
            Console.WriteLine(z.nume + " nu respecta validarea listei");
        }

        Console.WriteLine("============Afisarea produselor dupa adaugare=============");
        for (int i = 0; i < produse.Count; i++)
        {

            Console.WriteLine(produse[i].Descriere());

        }

        Produs produsCautat = null;
        string numeProdusCautat = "produs3asdsa";

        int noulPret = 12;

        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].nume.Equals(numeProdusCautat))
            {
                produsCautat = produse[i];
            }

        }

        if (produsCautat != null)
        {

            produsCautat.pret = noulPret;

        }
        else
        {
            Console.WriteLine(numeProdusCautat+ "nu exista in lista");
        }


        Console.WriteLine("=============Afisarea produselor dupa editare pret==========");

        for (int i = 0; i < produse.Count; i++)
        {

            Console.WriteLine(produse[i].Descriere());

        }


        Produs prCautat = null;
        string numePrCautat = "produs1";
        for (int i = 0; i < produse.Count; i++)
        {
            if (produse[i].nume.Equals(numePrCautat))
            {
                prCautat = produse[i];
              
            }

         
        }

        //
        if (prCautat != null)
        {
            produse.Remove(prCautat);
            Console.WriteLine("prodsul a fost sters");
        }
        else
        {
            Console.WriteLine("produslu nu  afost gasit");
        }

        for (int i = 0; i < produse.Count; i++)
        {

            Console.WriteLine(produse[i].Descriere());

        }


    }

    static void Exercitiul1Pizza()
    {
        Pizza x = new Pizza();
        x.nume = "Margherita";
        x.pret = 20;
        x.disponibila = true;

        Pizza y = new Pizza();
        y.nume = "Capriciosa";
        y.pret = 25;
        y.disponibila = true;

        Pizza w = new Pizza();
        w.nume = "Diavola";
        w.pret = 40;
        w.disponibila = false;

        List<Pizza> pizze = new List<Pizza>();

        pizze.Add(x);
        pizze.Add(y);
        pizze.Add(w);

        Pizza gasita = null;
       
        string cautaPizza = "Margherita";

        for (int i = 0; i < pizze.Count; i++)
        {
            if(gasita != null)
            {
                gasita = pizze[i];

            }



        }






    }







}

