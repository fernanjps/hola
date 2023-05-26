class cliente:TecnologiaApp
{
    
    public int id {set;get;}
    public string nombre {set;get;}
    public string email{set;get;}
    public string password{get;set;}
    public int cedula{set;get;}
    public int numero {set;get;}

    public cliente ( string email,string nombre , string password, int cedula , int id,int numero )
    {
        
        this.numero = numero ;

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