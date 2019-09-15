using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListorLabbar.Lab3
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

            lista.Sort();

            foreach(var student in lista)
            {
                Console.WriteLine($"{student.Namn} - {student.Score}");
            }

        }
    }
}
