Console.WriteLine("Hello, i'm Goku!!!");

// Crear una lista
List<string> compras = ["Arroz", "Leche"];
Console.WriteLine($"Tienes antes de agregar {compras.Count} elementos"); // Permite contar los productos de la lista
compras.Add("Cafe"); // Permite agregar a una lista
Console.WriteLine($"Tienes despues de agregar {compras.Count} elementos");

compras.Remove("Cafe");

Console.WriteLine(string.Join(", ", compras));
compras.Sort();
Console.WriteLine(string.Join(", ", compras));
// Console.WriteLine([2]);

Console.WriteLine("=============================");
// Crear un diccionario

Dictionary<string, string> agenda = new(StringComparer.OrdinalIgnoreCase);

agenda["Ana"] = "300555555555";
agenda["Luis"] = "30166666666";

if (agenda.TryGetValue("ana", out string? telefono))
{
    Console.WriteLine($"Ana: {telefono}");
}

foreach (var (nombre, tel) in agenda)
{
    Console.WriteLine($"{nombre}: {tel}");
}

Console.WriteLine("===========================");
// Diccionario con listas adentro

Dictionary<string, List<double>> notas = new(StringComparer.OrdinalIgnoreCase);
notas["Miguel"] = [];
notas["Miguel"] .Add(4.5);
notas["Miguel"] .Add(3.8);
notas["Miguel"] .Add(1);

foreach (var(nombre, nota) in notas)
{
    Console.WriteLine($"{nombre}: {string.Join(" - ", nota)}");
}

Console.WriteLine("===========================");

List<int> numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
var pares = numeros.Where(n => n % 2 == 0).ToList();
var top3 = numeros.OrderByDescending(n => n).Take(3).ToList();
Console.WriteLine($"Pares: {string.Join(", ", pares)}");
Console.WriteLine($"Top 3: {string.Join(", ", top3)}");
Console.WriteLine($"Suma: {numeros.Sum()}, promedio: {numeros.Average()}");
Console.WriteLine($"Hay algun numero mayor a 80?: {numeros.Any(n => n == 80)} ");
Console.WriteLine($"Numeros mayores a 80: {string.Join(", ", numeros.Where(n => n > 80))}");

Console.WriteLine("===========================");
// Record

List<Producto> productos = [
    new ("Cuaderno", "Papeleria", 6500m, 40),
    new ("Mouse", "Tecnologia", 45000m, 3),
    new ("USB 64 Gb", "Tecnologia", 3000m, 15)
    ];

var baratos = productos.Where(p => p.Precio < 10000m);
var masCaro = productos.MaxBy(p => p.Precio);
var masCaro1 = productos.Max(p => p.Precio);
decimal valorInventario = productos.Sum(p => p.Precio * p.Stock);

Console.WriteLine($"Menores a 10000 \n{string.Join(", ", baratos)}");
Console.WriteLine($"Mas caro: {masCaro}");
Console.WriteLine($"Mas caro: {masCaro1}");
Console.WriteLine($"Valor del inventario: {valorInventario}");

var porCategoria = productos
    .GroupBy(p => p.Categoria)
    .Select(g => new { Categoria = g.Key, Unidades = g.Sum(p => p.Stock) });

foreach(var c in porCategoria)
{
    Console.WriteLine($"{c.Categoria,-12} {c.Unidades} unidades");
}

record Producto(string Nombre, string Categoria, decimal Precio, int Stock);