using System;
using System.Collections.Generic;

namespace structuri
{
    internal class StudentService
    {
        private List<Student> studenti = new List<Student>();

        public bool Adauga(Student student)
        {
            if (student.nume.Length == 0)
            {
                return false;
            }

            studenti.Add(student);
            return true;
        }

        public Student Cauta(string nume)
        {
            for (int i = 0; i < studenti.Count; i++)
            {
                if (studenti[i].nume.Equals(nume))
                {
                    return studenti[i];
                }
            }

            return null;
        }

        public bool Sterge(string nume)
        {
            Student gasit = Cauta(nume);

            if (gasit == null)
            {
                return false;
            }

            studenti.Remove(gasit);
            return true;
        }

        public List<Student> GetAll()
        {
            return studenti;
        }
    }
}
