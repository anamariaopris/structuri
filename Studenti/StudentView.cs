using System;
using System.Collections.Generic;

namespace structuri
{
    internal class StudentView
    {
        private StudentService service = new StudentService();

        public void Play()
        {
            int tasta;
            do
            {
                Console.WriteLine();
                Console.WriteLine("Apasati tasta 0 pentru a iesi");
                Console.WriteLine("Apasati tasta 1 pentru a adauga un student");
                Console.WriteLine("Apasati tasta 2 pentru a afisa toti studentii");
                Console.WriteLine("Apasati tasta 3 pentru a cauta un student");
                Console.WriteLine("Apasati tasta 4 pentru a sterge un student");
                tasta = Int32.Parse(Console.ReadLine());

                switch (tasta)
                {
                    case 0: return;
                    case 1: Adaugare(); break;
                    case 2: Afisare(); break;
                    case 3: Cautare(); break;
                    case 4: Stergere(); break;
                    default: InputGresit(); break;
                }
            }
            while (tasta != 0);
        }

        public void InputGresit()
        {
            Console.WriteLine("Ati introdus un caracter nepermis!");
        }

        public void Adaugare()
        {
            Console.Write("Nume: ");
            string nume = Console.ReadLine();

            Console.Write("Medie: ");
            double medie = Double.Parse(Console.ReadLine());

            Student student = new Student();
            student.nume = nume;
            student.medie = medie;

            if (service.Adauga(student))
            {
                Console.WriteLine("Student adaugat");
            }
            else
            {
                Console.WriteLine("Date invalide");
            }
        }

        public void Afisare()
        {
            List<Student> studenti = service.GetAll();

            if (studenti.Count == 0)
            {
                Console.WriteLine("Catalogul este gol");
                return;
            }

            foreach (Student s in studenti)
            {
                Console.WriteLine(s.nume + " - media " + s.medie);
            }
        }

        public void Cautare()
        {
            Console.Write("Nume cautat: ");
            string nume = Console.ReadLine();

            Student gasit = service.Cauta(nume);

            if (gasit == null)
            {
                Console.WriteLine("Studentul nu exista");
                return;
            }

            Console.WriteLine(gasit.nume + " - media " + gasit.medie);
        }

        public void Stergere()
        {
            Console.Write("Nume de sters: ");
            string nume = Console.ReadLine();

            if (service.Sterge(nume))
            {
                Console.WriteLine("Student sters");
            }
            else
            {
                Console.WriteLine("Studentul nu exista");
            }
        }
    }
}
