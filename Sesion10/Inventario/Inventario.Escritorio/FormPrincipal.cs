using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormPrincipal : Form
{
    private readonly ServicioInventario _servicio = new(new RepositorioJson("inventario.json"));

    public FormPrincipal()
    {
        InitializeComponent();
        CargarProductos();
    }

    private void CargarProductos(List<Producto>? productos = null)
    {
        var listaActual = productos ?? _servicio.Listar();
        dgvProductos.DataSource = null;
        dgvProductos.DataSource = listaActual;

        // Muestra el valor total del inventario
        decimal total = listaActual.Sum(p => p.Precio * p.Stock);
        lblValor.Text = $"Valor del inventario: {total:C0}";

        // Actualiza el texto del StatusStrip con el total de productos en pantalla
        lblEstadoCantidad.Text = $"Total de productos: {listaActual.Count}";
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e) =>
    CargarProductos(_servicio.BuscarPorTexto(txtBuscar.Text));

    private Producto? Seleccionado() => dgvProductos.CurrentRow?.DataBoundItem as Producto;

    private void dgvProductos_DataBindingComplete_1(object sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvProductos.Columns["Precio"] is DataGridViewColumn precio)
        {
            precio.DefaultCellStyle.Format = "C0";
        }
        foreach (DataGridViewRow fila in dgvProductos.Rows)
        {
            if (fila.DataBoundItem is Producto { Stock: < 5 })
            {
                fila.DefaultCellStyle.BackColor = Color.MistyRose;
            }
        }
    }

    private void btnAgregar_Click_1(object sender, EventArgs e)
    {
        using var form = new FormProducto();
        if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null) return;
        try
        {
            _servicio.Agregar(form.ProductoCreado);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    private void btnVender_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            // Vende la cantidad indicada en el NumericUpDown (nudCantidad)
            _servicio.Vender(producto.Codigo, (int)nudCantidad.Value);
            CargarProductos();
        }
        catch (StockInsuficienteException ex)
        {
            MessageBox.Show(ex.Message, "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
    private void btnAgregarStock_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        try
        {
            // Suma la cantidad indicada en el nudCantidad (o puedes usar otro control si lo prefieres)
            _servicio.AgregarStock(producto.Codigo, (int)nudCantidad.Value);
            CargarProductos();
            MessageBox.Show("Stock actualizado con éxito.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto) return;
        var respuesta = MessageBox.Show($"¿Eliminar {producto.Nombre}?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (respuesta == DialogResult.Yes)
        {
            _servicio.Eliminar(producto.Codigo);
            CargarProductos();
        }
    }
    // 1. Evento para la opción Archivo -> Salir
    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close(); // Cierra la aplicación de escritorio
    }

    // 2. Evento para la opción Ayuda -> Acerca de
    private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "Sistema de Inventario en Capas\nDesarrollado para la práctica de Windows Forms.",
            "Acerca de",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        );
    }

    // 3. Configura y activa el Timer en tu constructor (o en Form_Load)
    // Asegúrate de iniciar el timer en el constructor de FormPrincipal:
    // timer1.Interval = 1000; // cada 1 segundo
    // timer1.Start();

    private void timer1_Tick(object sender, EventArgs e)
    {
        // Muestra la hora actual en la barra de estado inferior
        lblEstadoHora.Text = DateTime.Now.ToString("HH:mm:ss");
    }


}