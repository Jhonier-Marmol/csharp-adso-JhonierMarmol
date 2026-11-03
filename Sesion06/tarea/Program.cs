using System;

namespace tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            ProcesadorPagos procesador = new ProcesadorPagos();

            IMetodoPago efectivo = new PagoEfectivo();
            IMetodoPago tarjeta = new PagoTarjeta("1234567812345678");
            IMetodoPago billetera = new PagoBilletera();

            procesador.Cobrar(efectivo, 150_000m);
            procesador.Cobrar(tarjeta, 500_000m);
            procesador.Cobrar(billetera, 1_500_000m);

            procesador.Devolver(efectivo, 150_000m);
            procesador.Devolver(tarjeta, 500_000m);
            procesador.Devolver(billetera, 1_500_000m);
        }
    }
}