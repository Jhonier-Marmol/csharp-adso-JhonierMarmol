using System;

namespace tarea
{
    public class ProcesadorPagos
    {
        public void Cobrar(IMetodoPago metodoPago, decimal monto)
        {
            Console.WriteLine($"\n--- Procesando pago con {metodoPago.Nombre} ---");

            if (!metodoPago.Validar(monto))
            {
                Console.WriteLine("Error: El pago no pasó las validaciones de seguridad o límites.");
                return;
            }

            decimal comision = metodoPago.CalcularComision(monto);
            decimal totalPagar = monto + comision;

            Console.WriteLine($"Monto base: {monto:C}");
            Console.WriteLine($"Comisión: {comision:C}");
            Console.WriteLine($"Total cobrado: {totalPagar:C} ¡Pago exitoso!");
        }

        public void Devolver(IMetodoPago metodoPago, decimal monto)
        {
            Console.WriteLine($"\n--- Solicitando devolución con {metodoPago.Nombre} ---");

            if (metodoPago is IReembolsable reembolsable)
            {
                reembolsable.Reembolsar(monto);
            }
            else
            {
                Console.WriteLine($"Error: El método '{metodoPago.Nombre}' no admite reembolsos.");
            }
        }
    }
}