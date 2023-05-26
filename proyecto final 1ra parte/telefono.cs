class telefono:Tecnologia
{
    public string marca { set; get; }
    

    

    public telefono(String marca) :base()
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

}