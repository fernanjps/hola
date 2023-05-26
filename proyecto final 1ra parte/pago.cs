class pago:TecnologiaApp
{
    int dolares;

    public  pago (  int dolares )
    {
        this.dolares = dolares;
        
        
    }

    public void mostrarDatos()
    {
        Console.WriteLine("Su valor a pagar es: valor{0}" , dolares );

    }

    public void Menu()
    {
        Console.WriteLine("--- MENÚ ---");
        Console.WriteLine("1. psgo en paypal");
        Console.WriteLine("2. Pago en efectivo");
        Console.WriteLine("3. Pago con tarjeta");
        Console.WriteLine("4. Salir");

        int opcion;
        do
        {
            Console.Write("Ingrese una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    mostrarDatos();
                    break;
                case 2:
                    PagoEfectivo();
                    break;
                case 3:
                    PagoTarjeta();
                    break;
                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Intente nuevamente.");
                    break;
            }
        } while (opcion != 4);
    }
}