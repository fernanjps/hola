// Programa principal (Controlador para la tienda de productos tecnológicos)
public class Program
{
    public static void Main(string[] args)
    {
        ControladorTiendaTecnologica controlador = new ControladorTiendaTecnologica();

        // Agregar productos tecnológicos
        controlador.AgregarProducto("Laptop", 1000);
        controlador.AgregarProducto("Smartphone", 500);
        controlador.AgregarProducto("Tablet", 300);

        // Realizar compra
        controlador.RealizarCompra();
    }
}