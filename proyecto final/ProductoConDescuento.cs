using System;
using System.Collections.Generic;
// Decorador de Producto que añade una funcionalidad adicional (descuento)
public class ProductoConDescuento : IProducto
{
    private IProducto producto;
    private decimal descuento;

    public ProductoConDescuento(IProducto producto, decimal descuento)
    {
        this.producto = producto;
        this.descuento = descuento;
    }

    public string ObtenerNombre()
    {
        return producto.ObtenerNombre() + " (con descuento)";
    }

    public decimal ObtenerPrecio()
    {
        decimal precioOriginal = producto.ObtenerPrecio();
        decimal precioConDescuento = precioOriginal - (precioOriginal * descuento);
        return precioConDescuento;
    }
}