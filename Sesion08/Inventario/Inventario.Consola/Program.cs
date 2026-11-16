using Inventario;
using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

var servicio = new ServicioInventario(new RepositorioJson("inventario.json"));
bool salir = false;

while (!salir)
{
    Console.Clear();
    Console.WriteLine("=== SISTEMA DE INVENTARIO ===");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender producto");
    Console.WriteLine("4. Ver inventario");
    Console.WriteLine("5. Ver productos con stock bajo (< 5)");
    Console.WriteLine("6. Salir");
    Console.Write("\nSeleccione una opción: ");

    string? opcion = Console.ReadLine();

    try
    {
        switch (opcion)
        {
            case "1":
                Console.Write("Código: ");
                string codigo = Console.ReadLine()!;
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine()!;
                Console.Write("Precio: ");
                decimal precio = decimal.Parse(Console.ReadLine()!);
                Console.Write("Stock inicial: ");
                int stock = int.Parse(Console.ReadLine()!);

                var nuevoProducto = new Producto(codigo, nombre, precio, stock);
                servicio.Agregar(nuevoProducto);
                Console.WriteLine("\n¡Producto registrado con éxito!");
                break;

            case "2":
                Console.Write("Código del producto: ");
                string codStock = Console.ReadLine()!;
                Console.Write("Cantidad a sumar: ");
                int cantStock = int.Parse(Console.ReadLine()!);

                servicio.AgregarStock(codStock, cantStock);
                Console.WriteLine("\n¡Stock actualizado con éxito!");
                break;

            case "3":
                Console.Write("Código del producto: ");
                string codVenta = Console.ReadLine()!;
                Console.Write("Cantidad a vender: ");
                int cantVenta = int.Parse(Console.ReadLine()!);

                servicio.Vender(codVenta, cantVenta);
                Console.WriteLine("\n¡Venta realizada con éxito!");
                break;

            case "4":
                var productos = servicio.Listar();
                Console.WriteLine("\n--- LISTA DE PRODUCTOS ---");
                if (productos.Count == 0)
                {
                    Console.WriteLine("No hay productos registrados.");
                }
                else
                {
                    foreach (var p in productos)
                    {
                        Console.WriteLine($"[{p.Codigo}] {p.Nombre} - ${p.Precio:N2} - Stock: {p.Stock}");
                    }
                }
                break;

            case "5":
                var bajos = servicio.StockBajo();
                Console.WriteLine("\n--- PRODUCTOS CON STOCK BAJO (< 5) ---");
                if (bajos.Count == 0)
                {
                    Console.WriteLine("No hay productos con stock bajo.");
                }
                else
                {
                    foreach (var p in bajos)
                    {
                        Console.WriteLine($"[{p.Codigo}] {p.Nombre} - Stock: {p.Stock}");
                    }
                }
                break;

            case "6":
                salir = true;
                Console.WriteLine("\n¡Hasta luego!");
                continue;

            default:
                Console.WriteLine("\nOpción no válida.");
                break;
        }
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"\n[Error]: {ex.Message}");
        Console.ResetColor();
    }

    Console.WriteLine("\nPresione cualquier tecla para continuar...");
    Console.ReadKey();
}