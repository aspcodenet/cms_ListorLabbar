using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListorLabbar.Lab4
{
    class Lab
    {
        public static void Run()
        {
            var lista = new List<Student>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                var student = new Student();
                student.Namn = "Student nummer " + i;
                student.Score = random.Next(1, 100);
                lista.Add(student);
            }

            var goodStudentsLista = new List<Student>();
            var badStudentsLista = new List<Student>();
            foreach(var student in lista)
            {
                if (student.Score >= 50)
                    goodStudentsLista.Add(student);
                else
                    badStudentsLista.Add(student);
            }

            Console.WriteLine("These students are good");
            foreach(var student in goodStudentsLista)
            {
                Console.WriteLine($"{student.Namn} - {student.Score}");
            }
            Console.WriteLine("These students are bad");
            foreach (var student in badStudentsLista)
            {
                Console.WriteLine($"{student.Namn} - {student.Score}");
            }


        }
    }
}
