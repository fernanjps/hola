// Patrón Modelo-Vista-Controlador (MVC): Clase Controlador para la tienda de productos tecnológicos
public class ControladorTiendaTecnologica
{
    private List<ModeloProductoTecnologico> productos;
    private VistaTiendaTecnologica vista;

    public ControladorTiendaTecnologica()
    {
        productos = new List<ModeloProductoTecnologico>();
        vista = new VistaTiendaTecnologica();
    }

    public void AgregarProducto(string nombre, decimal precio)
    {
        productos.Add(new ModeloProductoTecnologico(nombre, precio));
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
                    ModeloProductoTecnologico productoSeleccionado = productos[opcion - 1];
                    IProductoTecnologico productoBase = new ProductoTecnologico(productoSeleccionado.Nombre, productoSeleccionado.Precio);
                    productoBase = AgregarAccesorios(productoBase);
                    total += productoBase.ObtenerPrecio();
                    Console.WriteLine($"Producto agregado: {productoBase.ObtenerDescripcion()} - Precio: {productoBase.ObtenerPrecio()}");
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

    private IProductoTecnologico AgregarAccesorios(IProductoTecnologico productoBase)
    {
        bool agregarAccesorios = true;
        while (agregarAccesorios)
        {
            Console.WriteLine("¿Desea agregar accesorios al producto? (S/N)");
            string respuesta = Console.ReadLine();
            if (respuesta.ToLower() == "s")
            {
                Console.WriteLine("Seleccione el accesorio que desea agregar: ");
                Console.WriteLine("1. Auriculares");
                Console.WriteLine("2. Funda");
                string opcionStr = Console.ReadLine();
                if (int.TryParse(opcionStr, out int opcion))
                {
                    switch (opcion)
                    {
                        case 1:
                            productoBase = new AuricularesDecorator(productoBase);
                            break;
                        case 2:
                            productoBase = new FundaDecorator(productoBase);
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente nuevamente.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                }
            }
            else if (respuesta.ToLower() == "n")
            {
                agregarAccesorios = false;
            }
            else
            {
                Console.WriteLine("Respuesta inválida. Intente nuevamente.");
            }
        }

        return productoBase;
    }
}