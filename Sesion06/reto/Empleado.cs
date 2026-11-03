namespace reto
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public string Documento { get; set; }

        public virtual string Tipo => "Empleado";

        protected Empleado(string nombre, string documento)
        {
            Nombre = nombre;
            Documento = documento;
        }

        public abstract decimal CalcularSalario();

        public override string ToString()
        {
            return $"{Nombre} (Doc: {Documento}) - Tipo: {Tipo} - Pago: {CalcularSalario():C}";
        }
    }
}