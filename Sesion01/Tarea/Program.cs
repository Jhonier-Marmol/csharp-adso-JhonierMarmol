using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== TAREA SESION 01 ===");
            Console.ResetColor();

            Console.WriteLine("1. Segundos a reloj");
            Console.WriteLine("2. Convertir Celsius a Fahrenheit");
            Console.WriteLine("3. Promedio de tres notas");
            Console.Write("Elige un ejercicio: ");

            bool okOpcion = int.TryParse(Console.ReadLine(), out opcion);

            if (!okOpcion)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debes ingresar una opción válida.");
                Console.ResetColor();
                return;
            }

            switch (opcion)
            {
                case 1:
                    SegundosAReloj();
                    break;

                case 2:
                    ConvertirTemperatura();
                    break;

                case 3:
                    CalcularPromedio();
                    break;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Selecciona una opción del 1 al 3.");
                    Console.ResetColor();
                    break;
            }
        }

        static void SegundosAReloj()
        {
            Console.Write("Ingresa la cantidad de segundos: ");

            bool ok = int.TryParse(Console.ReadLine(), out int segundos);

            if (!ok || segundos < 0)
            {
                Console.WriteLine("Ingresa una cantidad válida de segundos.");
                return;
            }

            int horas = segundos / 3600;
            int minutos = (segundos % 3600) / 60;
            int restantes = segundos % 60;

            Console.WriteLine(
                $"{horas} h {minutos} min {restantes} s");
        }

        static void ConvertirTemperatura()
        {
            Console.Write("Ingresa la temperatura en Celsius: ");

            bool ok = decimal.TryParse(
                Console.ReadLine(), out decimal celsius);

            if (!ok)
            {
                Console.WriteLine("Por favor, ingresa una temperatura válida.");
                return;
            }

            decimal fahrenheit = celsius * 9m / 5m + 32m;

            Console.WriteLine($"Temperatura en Fahrenheit: {fahrenheit:N1} °F");
        }

        static void CalcularPromedio()
        {
            Console.Write("Ingresa la primera nota: ");
            bool ok1 = decimal.TryParse(
                Console.ReadLine(), out decimal nota1);

            Console.Write("Ingresa la segunda nota: ");
            bool ok2 = decimal.TryParse(
                Console.ReadLine(), out decimal nota2);

            Console.Write("Ingresa la tercera nota: ");
            bool ok3 = decimal.TryParse(
                Console.ReadLine(), out decimal nota3);

            if (!ok1 || !ok2 || !ok3 ||
                nota1 < 0 || nota1 > 5 ||
                nota2 < 0 || nota2 > 5 ||
                nota3 < 0 || nota3 > 5)
            {
                Console.WriteLine(
                    "Las tres notas deben ser números entre 0 y 5.");
                return;
            }

            decimal promedio = (nota1 + nota2 + nota3) / 3m;

            Console.WriteLine($"El promedio es: {promedio:N1}");
        }
    }
}
