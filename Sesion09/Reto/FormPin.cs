using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reto
{
    public partial class FormPin : Form
    {
        private const string PIN_CORRECTO = "1234";
        private int _intentos = 3;

        public FormPin()
        {
            InitializeComponent();
            this.AcceptButton = btnIngresar;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == PIN_CORRECTO)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                return;
            }

            _intentos--;
            if (_intentos > 0)
            {
                MessageBox.Show($"PIN incorrecto. Te quedan {_intentos} intento(s).", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPin.Clear();
                txtPin.Focus();
            }
            else
            {
                MessageBox.Show("Has agotado tus 3 intentos. El cajero se bloqueará.", "Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
