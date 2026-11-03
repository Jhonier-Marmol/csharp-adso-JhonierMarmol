namespace tarea
{
    public interface IMetodoPago
    {
        string Nombre { get; }
        decimal CalcularComision(decimal monto);
        bool Validar(decimal monto);
    }
}