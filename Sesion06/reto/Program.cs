using System;
using System.Collections.Generic;
using System.Linq;

namespace reto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<Empleado> nomina = [
                new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
                new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
                new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
                new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
                new Contratista("Sofía León", "1005", 4_000_000m)
            ];

            Console.WriteLine("=== PAGOS INDIVIDUALES ===");
            foreach (var emp in nomina)
            {
                Console.WriteLine(emp.ToString());
            }

            Console.WriteLine("\n-------------------------------------------");

            decimal totalNomina = nomina.Sum(e => e.CalcularSalario());
            Console.WriteLine($"Total Nómina: {totalNomina:C}");

            var mayorPago = nomina.MaxBy(e => e.CalcularSalario());
            Console.WriteLine($"Mayor Pago: {mayorPago?.Nombre} con {mayorPago?.CalcularSalario():C}");

            Console.WriteLine("\n=== TOTAL POR TIPO ===");
            var totalPorTipo = nomina.GroupBy(e => e.Tipo);
            foreach (var grupo in totalPorTipo)
            {
                decimal subtotal = grupo.Sum(e => e.CalcularSalario());
                Console.WriteLine($"- {grupo.Key}: {subtotal:C}");
            }

            decimal totalBonos = nomina.OfType<IBonificable>().Sum(b => b.CalcularBono());
            Console.WriteLine($"\nTotal Bonos: {totalBonos:C}");
        }
    }
}