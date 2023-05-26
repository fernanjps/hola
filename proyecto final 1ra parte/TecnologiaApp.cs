class TecnologiaApp : Tecnologia
{
    private double precioTotal;

    public TecnologiaApp()
    {
        precioTotal = 1000 ;
    }

    public override void PagoEfectivo()
    {
        Console.WriteLine("Realizando pago en efectivo...");
        Console.WriteLine("El precio total es: $" + precioTotal);
    }

    public override void PagoTarjeta()
    {
        Console.WriteLine("Realizando pago con tarjeta...");
        Console.WriteLine("El precio total es: $" + precioTotal);
    }

    public void SeleccionarProducto(int indice)
    {
        if (indice >= 0 && indice < productos.Count)
        {
            double precio = precios[indice];
            precioTotal += precio;
            Console.WriteLine("Producto seleccionado: " + productos[indice]);
            Console.WriteLine("Precio actualizado: $" + precioTotal);
        }
        else
        {
            Console.WriteLine("Índice de producto inválido.");
        }
    }
}