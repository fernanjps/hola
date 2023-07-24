// Patrón Decorador: Accesorios concretos
public class AuricularesDecorator : AccesorioDecorator
{
    public AuricularesDecorator(IProductoTecnologico producto) : base(producto)
    {
    }

    public override string ObtenerDescripcion()
    {
        return base.ObtenerDescripcion() + ", Auriculares";
    }

    public override decimal ObtenerPrecio()
    {
        return base.ObtenerPrecio() + 20.0m;
    }
}