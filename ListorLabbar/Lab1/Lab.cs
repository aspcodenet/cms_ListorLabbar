using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListorLabbar.Lab1
{
    class Lab
    {
        public static void Run()
        {
            var lista = new List<int>();
            while(true)
            {
                Console.WriteLine("Mata in tal - skriv N för att avsluta");
                var input = Console.ReadLine();
                if (input.ToUpper() == "N") break;
                int varde;
                if (int.TryParse(input, out varde))
                    lista.Add(varde);
            }
            Console.WriteLine($"Du matade in {lista.Count} tal");

            var summa = 0;
            foreach (var i in lista)
                summa += i;

            Console.WriteLine($"Summan är {summa}");

            decimal medel = Convert.ToDecimal(summa) / 
                Convert.ToDecimal(lista.Count);
            Console.WriteLine($"Medelvärde är {medel:0.00}");

            var min = int.MaxValue;
            var max = 0;
            foreach (var i in lista)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }
            Console.WriteLine($"Min {min}  Max {max}");

        }
    }
}
