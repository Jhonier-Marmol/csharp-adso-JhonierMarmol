using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(7 / 2);
            Console.WriteLine(7 / 2.0);
            Console.WriteLine(7 % 2);
            Console.WriteLine((10 + 3) * 2);

            decimal valor = 1234567.891m;
            Console.WriteLine($"{valor:N2}");   // 1.234.567,89
            Console.WriteLine($"{valor:C0}");   // $ 1.234.568

            Console.Write("Escribe tu edad: ");
            if (int.TryParse(Console.ReadLine(), out int edad))
            {
                Console.WriteLine($"El próximo año tendrás {edad + 1} años.");
            }
            else
            {
                Console.WriteLine("Eso no es un número entero.");
            }

            double nota1, nota2, nota3;

            Console.Write("Ingrese la primera nota (0.0 y 5.0): ");
            while (!double.TryParse(Console.ReadLine(), out nota1) || nota1 < 0 || nota1 > 5)
            {
                Console.Write("Nota invalida. Ingrese una nota entre 0.0 y 5.0: ");
            }
            Console.Write("Ingrese la primera nota (0.0 y 5.0): ");
            while (!double.TryParse(Console.ReadLine(), out nota2) || nota2 < 0 || nota2 > 5)
            {
                Console.Write("Nota invalida. Ingrese una nota entre 0.0 y 5.0: ");
            }
            Console.Write("Ingrese la primera nota (0.0 y 5.0): ");
            while (!double.TryParse(Console.ReadLine(), out nota3) || nota3 < 0 || nota3 > 5)
            {
                Console.Write("Nota invalida. Ingrese una nota entre 0.0 y 5.0: ");
            }
            double promedio = (nota1 + nota2 + nota3) / 3;
            Console.WriteLine($"El promedio es: {promedio:N1}");
        }
    }

}
