// Ejemplo de uso
public class Program
{
    public static void Main(string[] args)
    {
        // Crear objetos de productos
        IProducto laptop = new Producto("Laptop", 1000);
        IProducto smartphone = new Producto("Smartphone", 500);
        IProducto tablet = new Producto("Tablet", 300);

        // Aplicar decorador de descuento a un producto
        IProducto productoConDescuento = new ProductoConDescuento(smartphone, 0.1m); // Descuento del 10%

        // Crear instancia de la tienda
        Tienda tienda = new Tienda();
        tienda.AgregarProducto(laptop);
        tienda.AgregarProducto(productoConDescuento);
        tienda.AgregarProducto(tablet);

        // Realizar compra
        tienda.RealizarCompra();
    }
}