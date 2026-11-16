using System;

namespace Sesion05.reto
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

        private void ValidarMonto(decimal monto)
        {
            if (monto <= 0)
                throw new ArgumentException("El monto debe ser mayor a $0.");

            if (monto % 10000 != 0)
                throw new ArgumentException("El monto debe ser múltiplo de $10.000.");
        }

        public void Depositar(decimal monto)
        {
            ValidarMonto(monto);
            _saldo += monto;
        }

        public void Retirar(decimal monto)
        {
            ValidarMonto(monto);
            if (monto > _saldo)
                throw new InvalidOperationException("Fondos insuficientes para realizar el retiro.");

            _saldo -= monto;
        }

        public void Transferir(decimal monto)
        {
            ValidarMonto(monto);
            if (monto > _saldo)
                throw new InvalidOperationException("Fondos insuficientes para la transferencia.");

            _saldo -= monto;
        }
    }
}