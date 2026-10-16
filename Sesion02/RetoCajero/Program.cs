using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetoCajero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("=====Bienvenido al menu de cajero=====");
            Console.ResetColor();
            int saldo = 500000;
            int i = 0;
            int transaccion = 0;
            CultureInfo culture = CultureInfo.GetCultureInfo("es-CO");

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite el PIN de la tarjeta: ");
                string pin = Console.ReadLine();
                if (pin == "1234")
                {
                    Console.WriteLine("\n1.Consulatar saldo\n2.Depositar\n3.Retirar\n4.Salir");
                    string opc = Console.ReadLine();
                    i = 5;
                    while (opc != "4")
                    {
                        switch (opc)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Su saldo actual es {saldo.ToString("C0", culture)}");
                                Console.ResetColor();
                                transaccion += 1;
                                break;

                            case "2":
                                int depositar = 0;
                                do
                                {
                                    Console.WriteLine("Cuanto desea depositar: ");
                                } while (!int.TryParse(Console.ReadLine(), out depositar));
                                saldo += depositar;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Deposito exitoso. Tu saldo actual es {saldo.ToString("C0", culture)}");
                                Console.ResetColor();
                                transaccion++;
                                break;

                            case "3":
                                int retirar = 0;
                                do
                                {
                                    Console.WriteLine("Cuanto desea retirar: ");
                                } while (!int.TryParse(Console.ReadLine(), out retirar) || retirar < 0 || retirar > saldo);
                                if (retirar % 10000 == 0)
                                    saldo -= retirar;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"Retiro exitoso. Tu saldo actual es {saldo.ToString("C0", culture)}");
                                Console.ResetColor();
                                transaccion++;
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Seleccion Erronea");
                                Console.ResetColor();
                                break;
                        }Console.WriteLine("\n1.Consultar saldo\n2.Depositar\n3.Retirar\n4.Salir");
                    opc = Console.ReadLine();
                    }   
                }
            }
            if (i == 3)
                Console.WriteLine("tarjeta bloqueada");
            else
            {
                Console.WriteLine("transaccion finalizada");
                Console.WriteLine($"Cantidad de transacciones {transaccion}");
            }
        }
    }
}
