using System;
using System.Collections.Generic;
using System.Linq;

namespace Reto
{
    internal record LineaVenta(
        string Codigo,
        string Nombre,
        int Cantidad,
        decimal Subtotal
    );

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Producto> inventario = new List<Producto>
            {
                new Producto("P001", "Teclado", 80000, 10),
                new Producto("P002", "Mouse", 45000, 15),
                new Producto("P003", "Monitor", 650000, 5)
            };

            List<LineaVenta> carrito = new List<LineaVenta>();

            int opcion = 0;

            while (opcion != 6)
            {
                Console.WriteLine("\n===== TIENDA =====");
                Console.WriteLine("1. Registrar producto");
                Console.WriteLine("2. Agregar stock");
                Console.WriteLine("3. Vender producto");
                Console.WriteLine("4. Ver carrito");
                Console.WriteLine("5. Ver inventario");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Ingrese una opción válida.");
                    opcion = 0;
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        RegistrarProducto(inventario);
                        break;

                    case 2:
                        AgregarStock(inventario);
                        break;

                    case 3:
                        VenderProducto(inventario, carrito);
                        break;

                    case 4:
                        VerCarrito(carrito);
                        break;

                    case 5:
                        VerInventario(inventario);
                        break;

                    case 6:
                        Console.WriteLine("Gracias por usar la tienda.");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
        }

        static void RegistrarProducto(List<Producto> inventario)
        {
            try
            {
                Console.Write("Código: ");
                string codigo = Console.ReadLine() ?? "";

                if (inventario.Any(p => p.Codigo == codigo.Trim().ToUpper()))
                {
                    Console.WriteLine("Ese código ya existe.");
                    return;
                }

                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";

                Console.Write("Precio: ");
                if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
                {
                    Console.WriteLine("El precio debe ser numérico.");
                    return;
                }

                Console.Write("Stock inicial: ");
                if (!int.TryParse(Console.ReadLine(), out int stock))
                {
                    Console.WriteLine("El stock debe ser un número entero.");
                    return;
                }

                Producto nuevo = new Producto(codigo, nombre, precio, stock);

                inventario.Add(nuevo);

                Console.WriteLine("Producto registrado correctamente.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("El número ingresado es demasiado grande.");
            }
        }

        static void AgregarStock(List<Producto> inventario)
        {
            Console.Write("Código del producto: ");
            string codigo = (Console.ReadLine() ?? "").Trim().ToUpper();

            Producto? producto = inventario.FirstOrDefault(
                p => p.Codigo == codigo
            );

            if (producto == null)
            {
                Console.WriteLine("El producto no existe.");
                return;
            }

            Console.Write("Cantidad para agregar: ");

            if (!int.TryParse(Console.ReadLine(), out int cantidad))
            {
                Console.WriteLine("Ingrese una cantidad válida.");
                return;
            }

            try
            {
                producto.AgregarStock(cantidad);
                Console.WriteLine("Stock actualizado correctamente.");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (OverflowException)
            {
                Console.WriteLine("El stock resultante es demasiado grande.");
            }
        }

        static void VenderProducto(
            List<Producto> inventario,
            List<LineaVenta> carrito)
        {
            Console.Write("Código del producto: ");
            string codigo = (Console.ReadLine() ?? "").Trim().ToUpper();

            Producto? producto = inventario.FirstOrDefault(
                p => p.Codigo == codigo
            );

            if (producto == null)
            {
                Console.WriteLine("El producto no existe.");
                return;
            }

            Console.Write("Cantidad que desea comprar: ");

            if (!int.TryParse(Console.ReadLine(), out int cantidad))
            {
                Console.WriteLine("Ingrese una cantidad válida.");
                return;
            }

            if (!producto.Vender(cantidad))
            {
                Console.WriteLine("Cantidad inválida o stock insuficiente.");
                return;
            }

            decimal subtotal = producto.Precio * cantidad;

            LineaVenta linea = new LineaVenta(
                producto.Codigo,
                producto.Nombre,
                cantidad,
                subtotal
            );

            carrito.Add(linea);

            Console.WriteLine("Producto agregado al carrito.");
            Console.WriteLine($"Subtotal: {subtotal:C}");
        }

        static void VerCarrito(List<LineaVenta> carrito)
        {
            Console.WriteLine("\n===== CARRITO DE COMPRAS =====");

            if (carrito.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            foreach (LineaVenta linea in carrito)
            {
                Console.WriteLine(
                    $"{linea.Codigo} - {linea.Nombre} | " +
                    $"Cantidad: {linea.Cantidad} | " +
                    $"Subtotal: {linea.Subtotal:C}"
                );
            }

            decimal total = carrito.Sum(l => l.Subtotal);

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"TOTAL: {total:C}");
        }

        static void VerInventario(List<Producto> inventario)
        {
            Console.WriteLine("\n===== INVENTARIO =====");

            foreach (Producto producto in inventario)
            {
                Console.WriteLine(
                    $"{producto.Codigo} | {producto.Nombre} | " +
                    $"Precio: {producto.Precio:C} | " +
                    $"Stock: {producto.Stock}"
                );
            }
        }
    }
}
