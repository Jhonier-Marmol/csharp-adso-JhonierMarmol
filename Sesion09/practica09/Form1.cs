namespace practica09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text));
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) - Convert.ToInt32(txtNumero2.Text));
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) * Convert.ToInt32(txtNumero2.Text));
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = Convert.ToInt32(txtNumero1.Text);
                int num2 = Convert.ToInt32(txtNumero2.Text);
                txtResultado.Text = Convert.ToString(num1 / num2);
            }
            catch (DivideByZeroException)
            {
                txtResultado.Text = "Error: No se puede dividir por cero";
            }
        }
    }
}
