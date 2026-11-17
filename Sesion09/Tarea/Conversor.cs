using System;

namespace Tarea
{
    public class Conversor
    {
        public double ConvertirTemperatura(double valor, string origen, string destino)
        {
            double enCelsius = origen switch
            {
                "°C" => valor,
                "°F" => (valor - 32) * 5.0 / 9.0,
                "K" => valor - 273.15,
                _ => throw new ArgumentException("Unidad de origen no válida.")
            };
            return destino switch
            {
                "°C" => enCelsius,
                "°F" => (enCelsius * 9.0 / 5.0) + 32,
                "K" => enCelsius + 273.15,
                _ => throw new ArgumentException("Unidad de destino no válida.")
            };
        }
    }
}