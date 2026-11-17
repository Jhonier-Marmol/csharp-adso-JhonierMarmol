using System;
using System.Windows.Forms;
using Tarea;

namespace Tarea
{
    public partial class Form1 : Form
    {
        private readonly Conversor _conversor = new();

        public Form1()
        {
            InitializeComponent();
            CargarUnidades();
        }

        private void CargarUnidades()
        {
            string[] unidades = { "°C", "°F", "K" };
            cmbOrigen.Items.AddRange(unidades);
            cmbDestino.Items.AddRange(unidades);

            cmbOrigen.SelectedIndex = 0;
            cmbDestino.SelectedIndex = 1;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (!double.TryParse(txtValor.Text, out double valor))
            {
                errorProvider1.SetError(txtValor, "Por favor ingrese un valor numérico válido.");
                txtValor.Focus();
                return;
            }

            if (cmbOrigen.SelectedItem == null)
            {
                errorProvider1.SetError(cmbOrigen, "Seleccione la unidad de origen.");
                return;
            }

            if (cmbDestino.SelectedItem == null)
            {
                errorProvider1.SetError(cmbDestino, "Seleccione la unidad de destino.");
                return;
            }

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            try
            {
                double resultado = _conversor.ConvertirTemperatura(valor, origen, destino);
                lblResultado.Text = $"Resultado: {resultado:F2} {destino}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error de conversión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}