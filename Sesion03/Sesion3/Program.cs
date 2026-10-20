using System.Text;

MostrarTitulo("mis metodos");
Console.WriteLine(Sumar(5, 8));
Console.WriteLine(MensajeConNumeros(15, "Este es el mensaje"));
Console.WriteLine(EsPar(7));

// Esta es un procedimiento
static void MostrarTitulo(String mensaje)
{
    Console.WriteLine($"==={mensaje.ToUpper()}===");
}

// Esta es una funcion
static int Sumar (int a, int b)
{
    return a + b;
}

static string MensajeConNumeros(int x, string dato)
{
    return $"{dato}, y su numero es {x}";
}

//static bool EsPar(int numero)
//{
//    return numero % 2 == 0;
//}

static bool EsPar(int numero) => numero % 2 == 0;

// Sobrecargas y opcionales 

static double Area(double lado) => lado * lado;

static double Area1(double ancho, double alto) => ancho * alto;

Area(4);
Area1(4, 3);

static void Saludar(string nombre = "invitado", string saludo = "Hola")
{
    Console.WriteLine($"{saludo}, {nombre}!!");
}

Saludar("Jhonier", "Bienvenido");
Saludar("Marmol");
Saludar();

static int Multiplicar(int a = 3, int b = 2) => a * b;
//{
//    return a * b;
//}

Console.WriteLine (Multiplicar(5, 3));
Console.WriteLine (Multiplicar(9));
Console.WriteLine (Multiplicar());

// Metodo comodin

static decimal LeerEntero(string mensaje)
{
    Console.Write(mensaje);
    decimal valor;
    while (!decimal.TryParse(Console.ReadLine(), out valor))
    {
        Console.WriteLine("Valor no valido. Intentar de nuevo\nDigite un numero decimal: ");
    }
    return valor;
}
Console.WriteLine(LeerEntero("Digite un numero decimal: "));

// Arreglos y cadenas
double[] notas = new double[5];
for (int i = 0; i < notas.Length; i++)
{
    Console.Write($"{i + 1}: ");
    double.TryParse(Console.ReadLine(), out notas[i]);// llena el arreglo
}
Console.WriteLine(String.Join(" | ", notas));// Muestra el arreglo

// contar vocales en una frase
static int ContarVocales(string texto)
{
    int totalvocales = 0;
    foreach (char c in texto.ToLower())
    {
        if ("aeiouáéíóú".Contains(c))
            totalvocales++;
    }
    return totalvocales;
}

Console.WriteLine(ContarVocales("Hola profe querido"));

Console.WriteLine(char.IsDigit('7'));
Console.WriteLine(char.IsDigit('e'));

Console.WriteLine(char.IsUpper('A'));
Console.WriteLine(char.IsUpper('a'));

Console.WriteLine(char.IsLower('A'));
Console.WriteLine(char.IsLower('a'));

Console.WriteLine(char.IsWhiteSpace(' '));
Console.WriteLine(char.IsWhiteSpace('x'));

// contar tipo de caracteres en un texto

string texto = "Hola mundo 2026_04";
int digitos = 0, Mayusculas = 0, Minusculas = 0, espacios = 0, especiales = 0;

foreach(char c in texto)
{
    if (char.IsDigit(c)) digitos++;
    else if (char.IsUpper(c)) Mayusculas++;
    else if (char.IsLower(c)) Minusculas++;
    else if (char.IsWhiteSpace(c)) espacios++;
    else if (char.IsSymbol(c)) especiales++;
}
Console.WriteLine($"Digitos: {digitos}");
Console.WriteLine($"Digitos: {digitos}");
Console.WriteLine($"Digitos: {digitos}");
Console.WriteLine($"Digitos: {digitos}");
Console.WriteLine($"Digitos: {digitos}");

static string invertir(string texto)
{
    var sb = new StringBuilder();
    for (int i = texto.Length - 1; i >= 0; i--) sb.Append(texto[i]);
    return sb.ToString();
}

Console.WriteLine(invertir("jhonier"));