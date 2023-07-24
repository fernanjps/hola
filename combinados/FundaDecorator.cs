public class FundaDecorator : AccesorioDecorator
{
    public FundaDecorator(IProductoTecnologico producto) : base(producto)
    {
    }

    public override string ObtenerDescripcion()
    {
        return base.ObtenerDescripcion() + ", Funda";
    }

    public override decimal ObtenerPrecio()
    {
        return base.ObtenerPrecio() + 10.0m;
    }
}