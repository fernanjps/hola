// Clase que gestiona la lista de productos y el menú interactivo
public class Tienda
{
    private List<IProducto> productos;

    public Tienda()
    {
        productos = new List<IProducto>();
    }

    public void AgregarProducto(IProducto producto)
    {
        productos.Add(producto);
    }

    public void MostrarMenu()
    {
        Console.WriteLine("---- MENÚ DE PRODUCTOS ----");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i].ObtenerNombre()} - Precio: {productos[i].ObtenerPrecio()}");
        }
        Console.WriteLine("0. Salir");
        Console.WriteLine("---------------------------");
    }

    public void RealizarCompra()
    {
        decimal total = 0;
        bool salir = false;
        while (!salir)
        {
            MostrarMenu();
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
                    IProducto productoSeleccionado = productos[opcion - 1];
                    total += productoSeleccionado.ObtenerPrecio();
                    Console.WriteLine($"Producto agregado: {productoSeleccionado.ObtenerNombre()}");
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

        Console.WriteLine($"Total de la compra: {total}");
    }
}