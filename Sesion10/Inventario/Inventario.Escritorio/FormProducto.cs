using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    public Producto? ProductoCreado { get; private set; }

    public FormProducto() => InitializeComponent();

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();

        try
        {
            if (_productoExistente is null)
            {
                ProductoCreado = new Producto(
                    txtCodigo.Text,
                    txtNombre.Text,
                    nudPrecio.Value,
                    (int)nudStock.Value
                );
            }
            else
            {
                _productoExistente.ActualizarDatos(txtNombre.Text, nudPrecio.Value);
                ProductoCreado = _productoExistente;
            }

            DialogResult = DialogResult.OK;
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
        }
    }
    private readonly Producto? _productoExistente;

    // Constructor para EDITAR un producto existente
    public FormProducto(Producto productoAEditar) : this()
    {
        _productoExistente = productoAEditar;

        txtCodigo.Text = productoAEditar.Codigo;
        txtCodigo.Enabled = false; // Deshabilitado según la tarea

        txtNombre.Text = productoAEditar.Nombre;
        nudPrecio.Value = productoAEditar.Precio;
        nudStock.Value = productoAEditar.Stock;
        nudStock.Enabled = false; // El stock se maneja por venta o agregar stock
    }
}