// Patrón Decorador: Clase que agrega funcionalidad adicional (accesorios) al producto tecnológico
public abstract class AccesorioDecorator : IProductoTecnologico
{
    protected IProductoTecnologico producto;

    public AccesorioDecorator(IProductoTecnologico producto)
    {
        this.producto = producto;
    }

    public virtual string ObtenerDescripcion()
    {
        return producto.ObtenerDescripcion();
    }

    public virtual decimal ObtenerPrecio()
    {
        return producto.ObtenerPrecio();
    }
}