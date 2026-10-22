
using System;
using System.Text;

namespace Tarea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== GENERADOR DE USUARIOS =====");

            Console.Write("Ingrese el nombre completo: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Ingrese el documento: ");
            string documento = Console.ReadLine() ?? "";

            string usuario = GenerarUsuario(nombre, documento);

            Console.WriteLine("Usuario generado: " + usuario);

            Console.WriteLine();
            Console.WriteLine("===== ANALIZADOR DE FRASES =====");

            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine() ?? "";

            AnalizarFrase(frase);
        }

        static string GenerarUsuario(string nombreCompleto, string documento)
        {
            string[] palabras = nombreCompleto.Split(
                ' ', StringSplitOptions.RemoveEmptyEntries);

            if (palabras.Length < 2 || documento.Length < 2)
            {
                return "Datos no validos";
            }

            string inicial = palabras[0].Substring(0, 1);
            string apellido;

            if (palabras.Length == 4)
            {
                apellido = palabras[2];
            }
            else
            {
                apellido = palabras[1];
            }

            string usuario = inicial + apellido + documento.Substring(documento.Length - 2);
            usuario = usuario.ToLower();
            usuario = usuario
                .Replace("á", "a")
                .Replace("é", "e")
                .Replace("í", "i")
                .Replace("ó", "o")
                .Replace("ú", "u")
                .Replace("ü", "u");
            return usuario;
        }
        static void AnalizarFrase(string frase)
        {
            string[] palabras = frase.Split(
                ' ', StringSplitOptions.RemoveEmptyEntries);
            int cantidad = palabras.Length;
            StringBuilder fraseInvertida = new StringBuilder();
            for (int i = palabras.Length - 1; i >= 0; i--)
            {
                fraseInvertida.Append(palabras[i]);

                if (i > 0)
                {
                    fraseInvertida.Append(" ");
                }
            }
            Console.WriteLine("Cantidad de palabras: " + cantidad);
            Console.WriteLine("Frase invertida: " + fraseInvertida.ToString());
        }
    }
}
