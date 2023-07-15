// Implementación de la clase base de Producto
public class Producto : IProducto
{
    private string nombre;
    private decimal precio;

    public Producto(string nombre, decimal precio)
    {
        this.nombre = nombre;
        this.precio = precio;
    }

    public string ObtenerNombre()
    {
        return nombre;
    }

    public decimal ObtenerPrecio()
    {
        return precio;
    }
}