using System;

namespace tarea
{
    public class PagoEfectivo : IMetodoPago
    {
        public string Nombre => "Efectivo";

        public decimal CalcularComision(decimal monto)
        {
            return 0m;
        }

        public bool Validar(decimal monto)
        {
            return true;
        }
    }
}