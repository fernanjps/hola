class Program
{
    private static void Main(string[] args)
    {

        TecnologiaApp app = new TecnologiaApp();
        app.AgregarProducto("Teléfono", 500.00);
        app.AgregarProducto("Tablet", 300.00);
        app.AgregarProducto("Laptop", 800.00);
        app.AgregarProducto("auriculares", 50.00);
        app.AgregarProducto("cargador", 8.00);


        app.Menu();

        pago pago=new pago(1000);


        Console.ReadLine();

    
    }

}
