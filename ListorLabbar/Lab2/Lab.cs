using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListorLabbar.Lab2
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
                student.Score = random.Next(1,100);
                lista.Add(student);
            }

            Student studentWithMax = null;
            Student studentWithMin = null;
            foreach (var student in lista)
            {
                if (studentWithMax == null ||
                    student.Score > studentWithMax.Score)
                    studentWithMax = student;
                if (studentWithMin == null ||
                    student.Score < studentWithMin.Score)
                    studentWithMin = student;
            }
            Console.WriteLine($"Bäst: {studentWithMax.Namn} - {studentWithMax.Score}");
            Console.WriteLine($"Sämst: {studentWithMin.Namn} - {studentWithMin.Score}");
        }
    }
}
