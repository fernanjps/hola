class auriculares:Tecnologia
{
    public string marca { set; get; }
    

    public auriculares(String marca) :base()
    {
        this.marca = marca;
        
    }

    public override void PagoEfectivo()
    {
        Console.WriteLine("Realizando pago en efectivo...");
        // Lógica de pago en efectivo
    }
    public override void PagoTarjeta()
    {
        Console.WriteLine("Realizando pago con tarjeta...");
        // Lógica de pago con tarjeta
    }
    public void imprimir()
    {
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("    elija la marca del auricular que desea comprar ");
        Console.WriteLine("");
        Console.WriteLine("elige la marca " + marca);

    
        Console.WriteLine("");
        Console.WriteLine("--------------------------------------------");
    }
}