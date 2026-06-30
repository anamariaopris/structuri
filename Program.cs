
using structuri;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {


        ex4();
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
        Console.WriteLine("Useri activi" + contorActivi );

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

       
        
        if (x.age == y.age &&x.age== z.age)
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
        Produs x = new Produs

       

        //

    }


}
