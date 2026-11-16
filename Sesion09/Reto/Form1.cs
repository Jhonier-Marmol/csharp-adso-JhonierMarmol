using System;
using System.Windows.Forms;
using Sesion05.reto;

namespace Reto
{
    public partial class Form1 : Form
    {
        private readonly CuentaBancaria _cuenta = new("Jhonier Mármol", "001-123", 500000m);
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitular.Text = $"Titular: {_cuenta.Titular} ({_cuenta.Numero})";
            ActualizarSaldo();
        }
        private void ActualizarSaldo()
        {
            lblSaldo.Text = $"Saldo actual: {_cuenta.Saldo:C0}";
        }
        private void RegistrarMovimiento(string tipo, decimal monto)
        {
            string hora = DateTime.Now.ToString("HH:mm:ss");
            string texto = $"[{hora}] {tipo}: {monto:C0}";
            lstMovimientos.Items.Insert(0, texto);
        }
        private void btnDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = nudMonto.Value;
                _cuenta.Depositar(monto);
                ActualizarSaldo();
                RegistrarMovimiento("Depósito", monto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnRetirar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = nudMonto.Value;
                _cuenta.Retirar(monto);
                ActualizarSaldo();
                RegistrarMovimiento("Retiro", monto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTransferir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = nudMonto.Value;
                _cuenta.Transferir(monto);
                ActualizarSaldo();
                RegistrarMovimiento("Transferencia", monto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de Operación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}