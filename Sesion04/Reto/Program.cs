Dictionary<string, List<double>> notasAprendices = new Dictionary<string, List<double>>();
int opcion = 0;

do
{
    Console.Clear();
    Console.WriteLine("========================================");
    Console.WriteLine("      GESTOR DE NOTAS CON LINQ          ");
    Console.WriteLine("========================================");
    Console.WriteLine("1. Registrar aprendiz (sin repetir)");
    Console.WriteLine("2. Agregar nota (de 0 a 5)");
    Console.WriteLine("3. Listar todos (nombre, cantidad, promedio, juicio)");
    Console.WriteLine("4. Ranking de mayor a menor promedio");
    Console.WriteLine("5. Mejor aprendiz y cuántos aprobaron");
    Console.WriteLine("6. Eliminar aprendiz");
    Console.WriteLine("7. Salir");
    Console.WriteLine("========================================");
    Console.Write("Selecciona una opción: ");

    if (int.TryParse(Console.ReadLine(), out opcion))
    {
        Console.WriteLine();
        switch (opcion)
        {
            case 1:
                RegistrarAprendiz(notasAprendices);
                break;
            case 2:
                AgregarNota(notasAprendices);
                break;
            case 3:
                ListarTodos(notasAprendices);
                break;
            case 4:
                MostrarRanking(notasAprendices);
                break;
            case 5:
                MostrarMejorYAprobados(notasAprendices);
                break;
            case 6:
                EliminarAprendiz(notasAprendices);
                break;
            case 7:
                Console.WriteLine("¡Saliendo del programa. Hasta luego!");
                break;
            default:
                Console.WriteLine("Opción no válida. Intenta de nuevo.");
                break;
        }
    }
    else
    {
        Console.WriteLine("Por favor, ingresa un número válido.");
    }

    if (opcion != 7)
    {
        Console.WriteLine("\nPresiona cualquier tecla para continuar...");
        Console.ReadKey();
    }

} while (opcion != 7);

static void RegistrarAprendiz(Dictionary<string, List<double>> diccionario)
{
    Console.Write("Ingresa el nombre del aprendiz: ");
    string nombre = Console.ReadLine()?.Trim();

    if (string.IsNullOrEmpty(nombre))
    {
        Console.WriteLine("El nombre no puede estar vacío.");
        return;
    }

    if (diccionario.ContainsKey(nombre))
    {
        Console.WriteLine($"El aprendiz '{nombre}' ya se encuentra registrado.");
    }
    else
    {
        diccionario.Add(nombre, new List<double>());
        Console.WriteLine($"¡Aprendiz '{nombre}' registrado exitosamente!");
    }
}
static void AgregarNota(Dictionary<string, List<double>> diccionario)
{
    Console.Write("Ingresa el nombre del aprendiz: ");
    string nombre = Console.ReadLine()?.Trim();

    if (!diccionario.ContainsKey(nombre))
    {
        Console.WriteLine("El aprendiz no existe en el sistema.");
        return;
    }

    Console.Write("Ingresa la nota (entre 0 y 5): ");
    if (double.TryParse(Console.ReadLine(), out double nota) && nota >= 0 && nota <= 5)
    {
        diccionario[nombre].Add(nota);
        Console.WriteLine($"Nota {nota} agregada correctamente a {nombre}.");
    }
    else
    {
        Console.WriteLine("Nota inválida. Debe ser un valor numérico entre 0 y 5.");
    }
}
static void ListarTodos(Dictionary<string, List<double>> diccionario)
{
    if (diccionario.Count == 0)
    {
        Console.WriteLine("No hay aprendices registrados.");
        return;
    }

    Console.WriteLine($"{"Nombre",-15} {"Cantidad de notas",-18} {"Promedio",-12} {"Juicio"}");
    Console.WriteLine(new string('-', 55));

    foreach (var aprendiz in diccionario)
    {
        string nombre = aprendiz.Key;
        List<double> notas = aprendiz.Value;
        int cantidad = notas.Count;
        double promedio = cantidad > 0 ? notas.Average() : 0;
        string juicio = cantidad > 0 && promedio >= 3.0 ? "A" : "D";

        Console.WriteLine($"{nombre,-15} {cantidad,-18} {promedio,-12:N1} {juicio}");
    }
}

static void MostrarRanking(Dictionary<string, List<double>> diccionario)
{
    var ranking = diccionario
        .Where(a => a.Value.Count > 0)
        .OrderByDescending(a => a.Value.Average())
        .ToList();

    if (ranking.Count == 0)
    {
        Console.WriteLine("No hay aprendices con notas registradas para generar el ranking.");
        return;
    }

    Console.WriteLine("--- RANKING DE APRENDICES (MAYOR A MENOR PROMEDIO) ---");
    Console.WriteLine($"{"Nombre",-15} {"Promedio"}");
    Console.WriteLine(new string('-', 30));

    foreach (var item in ranking)
    {
        Console.WriteLine($"{item.Key,-15} {item.Value.Average():N1}");
    }
}
static void MostrarMejorYAprobados(Dictionary<string, List<double>> diccionario)
{
    var conNotas = diccionario.Where(a => a.Value.Count > 0).ToList();

    if (conNotas.Count == 0)
    {
        Console.WriteLine("No hay datos suficientes para calcular.");
        return;
    }
    var mejor = conNotas.OrderByDescending(a => a.Value.Average()).First();
    int aprobados = conNotas.Count(a => a.Value.Average() >= 3.0);

    Console.WriteLine($"Mejor aprendiz: {mejor.Key} (Promedio: {mejor.Value.Average():N1})");
    Console.WriteLine($"Total de aprendices que aprobaron: {aprobados}");
}
static void EliminarAprendiz(Dictionary<string, List<double>> diccionario)
{
    Console.Write("Ingresa el nombre del aprendiz a eliminar: ");
    string nombre = Console.ReadLine()?.Trim();

    if (diccionario.Remove(nombre))
    {
        Console.WriteLine($"El aprendiz '{nombre}' ha sido eliminado exitosamente.");
    }
    else
    {
        Console.WriteLine("No se encontró un aprendiz con ese nombre.");
    }
}
