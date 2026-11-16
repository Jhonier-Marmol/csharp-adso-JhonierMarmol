using Inventario.Datos;
using Inventario.Modelos;

namespace Inventario.Servicios;

public class ServicioInventario
{
    private readonly IRepositorioProductos _repositorio;

    public ServicioInventario(IRepositorioProductos repositorio) => _repositorio = repositorio;

    public List<Producto> Listar() => _repositorio.ObtenerTodos().OrderBy(p => p.Nombre).ToList();

    public void Agregar(Producto producto)
    {
        var existente = _repositorio.BuscarPorCodigo(producto.Codigo);
        if (existente != null)
        {
            throw new InvalidOperationException($"Ya existe un producto con el código {producto.Codigo}.");
        }
        _repositorio.Agregar(producto);
    }

    public void AgregarStock(string codigo, int cantidad)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
                            ?? throw new ArgumentException($"No existe el producto {codigo}.");

        // Si tienes un método en Producto para sumar, úsalo. Si no, usa tu propiedad o método correspondiente.
        // Ejemplo asumiendo que agregaste un método o modificas el stock:
        producto.Stock += cantidad; // (O el método que uses para sumar stock)
        _repositorio.Actualizar(producto);
    }

    public void Vender(string codigo, int cantidad)
    {
        Producto producto = _repositorio.BuscarPorCodigo(codigo)
                            ?? throw new ArgumentException($"No existe el producto {codigo}.");

        if (producto.Stock < cantidad)
        {
            throw new StockInsuficienteException($"Stock insuficiente para el producto {producto.Nombre}. Stock actual: {producto.Stock}, solicitado: {cantidad}");
        }

        producto.Vender(cantidad);
        _repositorio.Actualizar(producto);
    }

    public List<Producto> StockBajo()
    {
        return _repositorio.ObtenerTodos().Where(p => p.Stock < 5).ToList();
    }
}