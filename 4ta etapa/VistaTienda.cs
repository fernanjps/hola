// Clase Vista para la Tienda
public class VistaTienda
{
    public void MostrarMenu(List<ModeloProducto> productos)
    {
        Console.WriteLine("---- MENÚ DE PRODUCTOS ----");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {productos[i].Nombre} - Precio: {productos[i].Precio}");
        }
        Console.WriteLine("0. Salir");
        Console.WriteLine("---------------------------");
    }

    public void MostrarCompra(decimal total)
    {
        Console.WriteLine($"Total de la compra: {total}");
    }
}