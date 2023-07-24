// Patrón Decorador: Clase base para productos tecnológicos
public class ProductoTecnologico : IProductoTecnologico
{
    private string descripcion;
    private decimal precio;

    public ProductoTecnologico(string descripcion, decimal precio)
    {
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public string ObtenerDescripcion()
    {
        return descripcion;
    }

    public decimal ObtenerPrecio()
    {
        return precio;
    }
}