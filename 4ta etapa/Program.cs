



public class Program
{
    public static void Main(string[] args)
    {
        ControladorTienda controlador = new ControladorTienda();

        // Agregar productos
        controlador.AgregarProducto("Laptop", 1000);
        controlador.AgregarProducto("Smartphone", 500);
        controlador.AgregarProducto("Tablet", 300);

        // Realizar compra
        controlador.RealizarCompra();
    }
}