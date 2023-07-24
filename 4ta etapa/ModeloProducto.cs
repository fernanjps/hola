// Clase Modelo para el Producto
public class ModeloProducto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public ModeloProducto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}