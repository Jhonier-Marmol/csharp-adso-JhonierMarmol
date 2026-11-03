using System;

namespace tarea
{
    public class PagoTarjeta : IMetodoPago, IReembolsable
    {
        public string Nombre => "Tarjeta de Crédito";
        public string NumeroTarjeta { get; set; }

        public PagoTarjeta(string numeroTarjeta)
        {
            NumeroTarjeta = numeroTarjeta;
        }

        public decimal CalcularComision(decimal monto)
        {
            return monto * 0.03m;
        }

        public bool Validar(decimal monto)
        {
            return !string.IsNullOrEmpty(NumeroTarjeta) && NumeroTarjeta.Length == 16 && long.TryParse(NumeroTarjeta, out _);
        }

        public void Reembolsar(decimal monto)
        {
            Console.WriteLine($"Reembolso: Se ha devuelto {monto:C} a la tarjeta terminada en {NumeroTarjeta[^4..]}");
        }
    }
}