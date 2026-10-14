using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=== CALCULADORA DE PROPINA ===");
            Console.ResetColor();

            Console.Write("Total de la cuenta: ");
            bool okTotal = decimal.TryParse(Console.ReadLine(), out decimal total);

            Console.Write("Porcentaje de propina: ");
            bool okPct = decimal.TryParse(Console.ReadLine(), out decimal porcentaje);

            Console.Write("Número de personas: ");
            bool okPersonas = int.TryParse(Console.ReadLine(), out int personas);

            if (okTotal && okPct && okPersonas)
            {
                if (personas <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número de personas debe ser mayor que cero.");
                    Console.ResetColor();
                }
                else if (total < 0 || porcentaje < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ingresa valores positivos para la cuenta y la propina.");
                    Console.ResetColor();
                }
                else
                {
                    decimal propina = total * porcentaje / 100m;
                    decimal totalFinal = total + propina;
                    decimal porPersona = totalFinal / personas;

                    CultureInfo cultura = CultureInfo.GetCultureInfo("es-CO");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Propina: {propina.ToString("C0", cultura)}");
                    Console.WriteLine($"Total: {totalFinal.ToString("C0", cultura)}");
                    Console.WriteLine($"Cada persona paga: {porPersona.ToString("C0", cultura)}");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Uno de los datos no es válido. Intenta nuevamente.");
            }
        }
    }
}