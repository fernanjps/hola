public class ControladorTienda
{
    private List<ModeloProducto> productos;
    private VistaTienda vista;

    public ControladorTienda()
    {
        productos = new List<ModeloProducto>();
        vista = new VistaTienda();
    }

    public void AgregarProducto(string nombre, decimal precio)
    {
        productos.Add(new ModeloProducto(nombre, precio));
    }

    public void RealizarCompra()
    {
        decimal total = 0;
        bool salir = false;
        while (!salir)
        {
            vista.MostrarMenu(productos);
            Console.WriteLine("Seleccione un producto (ingrese el número) o ingrese 0 para finalizar la compra:");
            string opcionStr = Console.ReadLine();
            if (int.TryParse(opcionStr, out int opcion))
            {
                if (opcion == 0)
                {
                    salir = true;
                }
                else if (opcion >= 1 && opcion <= productos.Count)
                {
                    ModeloProducto productoSeleccionado = productos[opcion - 1];
                    total += productoSeleccionado.Precio;
                    Console.WriteLine($"Producto agregado: {productoSeleccionado.Nombre}");
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
            }
            else
            {
                Console.WriteLine("Opción inválida. Intente nuevamente.");
            }
        }

        vista.MostrarCompra(total);
    }
}