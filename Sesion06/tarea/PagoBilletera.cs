using System;

namespace tarea
{
    public class PagoBilletera : IMetodoPago, IReembolsable
    {
        public string Nombre => "Billetera Digital";

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.01m;
        }

        public bool Validar(decimal monto)
        {
            return monto <= 2_000_000m;
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine($"Reembolso: Se ha devuelto {monto:C} a la Billetera Digital del usuario.");
        }
    }
}