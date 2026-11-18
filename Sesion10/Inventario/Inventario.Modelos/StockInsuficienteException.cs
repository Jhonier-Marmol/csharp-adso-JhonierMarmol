using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario.Modelos
{
    public class StockInsuficienteException : Exception
    {
        public StockInsuficienteException(string mensaje) : base(mensaje) { }
    }
}
