
using structuri;
using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 7;
        User x= new User();

        User y = new User();

        User z = new User();

        x.email = "test@gmail.com";
        x.age = 23;
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



    }
}
