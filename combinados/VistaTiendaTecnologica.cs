// Patrón Modelo-Vista-Controlador (MVC): Clase Vista para la tienda de productos tecnológicos
public class VistaTiendaTecnologica
{
    public void MostrarMenu(List<ModeloProductoTecnologico> productos)
    {
        Console.WriteLine("---- MENÚ DE PRODUCTOS TECNOLÓGICOS ----");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i].Nombre} - Precio: {productos[i].Precio}");
        }
        Console.WriteLine("0. Salir");
        Console.WriteLine("-------------------------------------");
    }

    public void MostrarCompra(decimal total)
    {
        Console.WriteLine($"Total de la compra: {total}");
    }
}