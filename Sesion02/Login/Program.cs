using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su usuario: ");
            string user = Console.ReadLine().ToLower().Trim();
            Console.WriteLine("Ingrese su contraseña: ");
            string pass = Console.ReadLine().ToLower().Trim();
            if (user == "admin" && pass == "12345")
            {
                Console.WriteLine("Bienvenido al sistema");
                Console.WriteLine("Calculadora con Swith");
                Console.WriteLine("Digite el valor para A");
                string entrada = Console.ReadLine().Trim();
                int a = Convert.ToInt32(entrada);
                Console.WriteLine("Diegite el valor para B");
                float b = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("Digite la opcion deseada: ");
                //Console.WriteLine("1. Sumar");
                //Console.WriteLine("2. Restar");
                //Console.WriteLine("3. Multiplicar");
                //Console.WriteLine("4. Dividir");
                Console.WriteLine("Digite la opcion deseada:\n1.Sumar\n2.Restar\n3.Multiplicar\n4.Dividir\n5.notas");
                int opc = Convert.ToInt32(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        Console.WriteLine($"La suma de {a} + {b} es {a + b}");
                        break;
                    case 2:
                        Console.WriteLine($"La resta de {a} - {b} es {a - b}");
                        break;
                    case 3:
                        Console.WriteLine($"La multiplicacion de {a} x {b} es {a * b}");
                        break;
                    case 4:
                        if (b == 0)
                            Console.WriteLine("No se puede devidir entre (0)");
                        else
                        Console.WriteLine($"La division de {a} / {b} es {a / b}");
                        break;
                    case 5:
                        double nota = Convert.ToDouble(Console.ReadLine());
                        if (nota < 0 || nota > 5)
                            Console.WriteLine("La nota tiene que ser entre (0) o (5)");
                        else
                        {
                            if (nota < 3.0)
                                Console.WriteLine("Nota Deficiente");
                            else if (nota < 4)
                                Console.WriteLine("Nota aceptable");
                            else if (nota < 4.6)
                                Console.WriteLine("Nota sobresaliente");
                            else
                                Console.WriteLine("Nota excelente");
                        }
                        break;
                    default:
                        Console.WriteLine("Eleccion Incorrecta");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error en el usuario o contraseña");
            }
        }
    }
}
