using System;
using System.Collections.Generic;

abstract class Tecnologia
{
    protected List<string> productos;
    protected List<double> precios;

    public Tecnologia()
    {
        productos = new List<string>();
        precios = new List<double>();
    }

    public void AgregarProducto(string producto, double precio)
    {
        productos.Add(producto);
        precios.Add(precio);
    }

    public void MostrarProductos()
    {
        Console.WriteLine("Productos disponibles:");
        for (int i = 0; i < productos.Count; i++)
        {
            Console.WriteLine(i + 1 + ". " + productos[i] + " - Precio: $" + precios[i]);
        }
    }

    public abstract void PagoEfectivo();
    public abstract void PagoTarjeta();

    public void Menu()
    {
        Console.WriteLine("--- MENÚ ---");
        Console.WriteLine("1. Mostrar productos");
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
                    MostrarProductos();
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