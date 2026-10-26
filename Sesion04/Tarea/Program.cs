
List<Venta> ventas = new List<Venta>
        {
            new ("Portátil", "Medellín", 2, 2_800_000m),
            new ("Mouse", "Bogotá", 10, 45_000m),
            new ("Teclado", "Cali", 5, 120_000m),
            new ("Monitor", "Medellín", 3, 750_000m),
            new ("Mouse", "Medellín", 8, 45_000m),
            new ("Portátil", "Bogotá", 1, 2_800_000m),
            new ("Diadema", "Cali", 6, 180_000m),
            new ("Monitor", "Bogotá", 2, 750_000m),
            new ("Teclado", "Medellín", 4, 120_000m),
            new ("Diadema", "Bogotá", 3, 180_000m),
            new ("Portátil", "Cali", 2, 2_800_000m),
            new ("Mouse", "Cali", 12, 45_000m)
        };

Console.WriteLine("========================================");
Console.WriteLine("      REPORTE DE VENTAS CON LINQ        ");
Console.WriteLine("========================================\n");
decimal totalVendido = ventas.Sum(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"1. Total vendido: {totalVendido:C0}");
decimal promedioVenta = ventas.Average(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"2. Promedio por venta: {promedioVenta:C0}");
Console.WriteLine("\n3. Ventas por ciudad (de mayor a menor):");
var ventasPorCiudad = ventas
    .GroupBy(v => v.Ciudad)
    .Select(g => new { Ciudad = g.Key, TotalIngresos = g.Sum(v => v.Cantidad * v.PrecioUnitario) })
    .OrderByDescending(x => x.TotalIngresos);

foreach (var item in ventasPorCiudad)
{
    Console.WriteLine($"   - {item.Ciudad}: {item.TotalIngresos:C0}");
}
Console.WriteLine("\n4. Top 3 de productos por ingresos:");
var topProductos = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new { Producto = g.Key, TotalIngresos = g.Sum(v => v.Cantidad * v.PrecioUnitario) })
    .OrderByDescending(x => x.TotalIngresos)
    .Take(3);

foreach (var item in topProductos)
{
    Console.WriteLine($"   - {item.Producto}: {item.TotalIngresos:C0}");
}
var productoMasVendido = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new { Producto = g.Key, TotalUnidades = g.Sum(v => v.Cantidad) })
    .OrderByDescending(x => x.TotalUnidades)
    .FirstOrDefault();

Console.WriteLine($"\n5. Producto más vendido en unidades: {productoMasVendido?.Producto} ({productoMasVendido?.TotalUnidades} unidades)");

Console.WriteLine("\n========================================");
Console.WriteLine("Presiona cualquier tecla para salir...");
Console.ReadKey();
record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);