using System;
namespace Sesion05.tarea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PRUEBAS DE CUENTA BANCARIA ===");

            try
            {

                CuentaBancaria cuenta1 = new CuentaBancaria("Jhonier", "C001", 500m);
                CuentaBancaria cuenta2 = new CuentaBancaria("María", "C002", 200m);

                MostrarEstado(cuenta1, cuenta2);

                Console.WriteLine("\n--- Probando Depósito ($150) ---");
                cuenta1.Depositar(150m);
                MostrarEstado(cuenta1, cuenta2);

                Console.WriteLine("\n--- Probando Retiro Rechazado ($1000) ---");
                cuenta1.Retirar(1000m);
                MostrarEstado(cuenta1, cuenta2);

                Console.WriteLine("\n--- Probando Transferencia ($200 de cuenta 1 a cuenta 2) ---");
                cuenta1.Transferir(cuenta2, 200m);
                MostrarEstado(cuenta1, cuenta2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
        }

        static void MostrarEstado(params CuentaBancaria[] cuentas)
        {
            foreach (var c in cuentas)
            {
                Console.WriteLine($"[Cuenta: {c.Numero}] Titular: {c.Titular} | Saldo Actual: ${c.Saldo}");
            }
        }
    }
}