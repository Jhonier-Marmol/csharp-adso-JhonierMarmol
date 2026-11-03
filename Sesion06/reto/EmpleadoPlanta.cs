using reto;

namespace reto
{
    public class EmpleadoPlanta : Empleado, IBonificable
    {
        public decimal SalarioMensual { get; set; }
        public int AnosAntiguedad { get; set; }

        public override string Tipo => "Planta";

        public EmpleadoPlanta(string nombre, string documento, decimal salarioMensual, int anosAntiguedad)
            : base(nombre, documento)
        {
            SalarioMensual = salarioMensual;
            AnosAntiguedad = anosAntiguedad;
        }

        public override decimal CalcularSalario()
        {
            if (AnosAntiguedad >= 5)
            {
                return SalarioMensual * 1.05m;
            }
            return SalarioMensual;
        }

        public decimal CalcularBono()
        {
            return AnosAntiguedad >= 5 ? SalarioMensual * 0.05m : 0m;
        }
    }
}