using System;
namespace Sesion05.tarea
{
    public class CuentaBancaria
    {
        private string _titular;
        private string _numero;
        private decimal _saldo;

        public string Titular
        {
            get => _titular;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El titular no puede estar vacío.");
                _titular = value;
            }
        }

        public string Numero
        {
            get => _numero;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("El número de cuenta no puede estar vacío.");
                _numero = value;
            }
        }

        public decimal Saldo
        {
            get => _saldo;
            private set => _saldo = value;
        }

        public CuentaBancaria(string titular, string numero, decimal saldoInicial = 0)
        {
            Titular = titular;
            Numero = numero;

            if (saldoInicial < 0)
                throw new ArgumentException("El saldo inicial no puede ser negativo.");

            _saldo = saldoInicial;
        }

        public bool Depositar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("[Error] El monto a depositar debe ser mayor a cero.");
                return false;
            }

            _saldo += monto;
            return true;
        }

        public bool Retirar(decimal monto)
        {
            if (monto <= 0)
            {
                Console.WriteLine("[Error] El monto a retirar debe ser mayor a cero.");
                return false;
            }

            if (monto > _saldo)
            {
                Console.WriteLine("[Error] Fondos insuficientes para realizar el retiro.");
                return false;
            }

            _saldo -= monto;
            return true;
        }

        public bool Transferir(CuentaBancaria destino, decimal monto)
        {
            if (destino == null)
            {
                Console.WriteLine("[Error] La cuenta destino no existe.");
                return false;
            }

            if (monto <= 0)
            {
                Console.WriteLine("[Error] El monto a transferir debe ser mayor a cero.");
                return false;
            }

            if (monto > _saldo)
            {
                Console.WriteLine("[Error] Fondos insuficientes para la transferencia.");
                return false;
            }

            _saldo -= monto;
            destino._saldo += monto;
            return true;
        }
    }
}