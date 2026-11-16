using System;
using System.Windows.Forms;

namespace Reto
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Abrimos el formulario del PIN como un diálogo modal
            using (FormPin formPin = new FormPin())
            {
                // 2. ShowDialog() se queda esperando a que el usuario acierte o agote intentos
                if (formPin.ShowDialog() == DialogResult.OK)
                {
                    // 3. SOLO si devuelve DialogResult.OK (PIN correcto), arranca el cajero
                    Application.Run(new Form1());
                }
                // Si agota los intentos, devuelve DialogResult.Cancel y la aplicación se cierra limpiamente
            }
        }
    }
}