using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormReportes : Form
{
    private readonly ServicioInventario _servicio;

    public FormReportes(ServicioInventario servicio)
    {
        InitializeComponent();
        _servicio = servicio;
        CargarReportes();
    }

    private void CargarReportes()
    {
        // Productos ordenados de mayor a menor valor total (Precio * Stock)
        var masValiosos = _servicio.Listar()
            .OrderByDescending(p => p.Precio * p.Stock)
            .ToList();

        dgvMasValiosos.DataSource = null;
        dgvMasValiosos.DataSource = masValiosos;

        // Productos con stock bajo (< 5) usando el método del servicio
        var stockBajo = _servicio.StockBajo();
        dgvStockBajo.DataSource = null;
        dgvStockBajo.DataSource = stockBajo;
    }
}