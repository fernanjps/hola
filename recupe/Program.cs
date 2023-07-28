using System;
class Program
{
    static void Main(string[] args)
    {
        // Creamos personajes Goku y Vegeta
        personaje goku = new goku();
        personaje vegeta = new Vegeta(new goku());

        Console.WriteLine("---------------------------");
        Console.WriteLine("");
        Console.WriteLine("Los personajes son:");
        Console.WriteLine("---------------------------");
        Console.WriteLine(" - Goku");
        Console.WriteLine(" - Vegeta");
        Console.WriteLine(" - Trunks");
        Console.WriteLine(" - Goten");
        Console.WriteLine(" - Gohan");
        Console.WriteLine("");
        Console.WriteLine("---------------------------");
        // Realizamos la fusión de Trunks y Goten para obtener a Gotenks

        personaje trunks = new Trunks(new Goten(new Gohan(new goku())));
        personaje gotenks = Fusion.FusionGotenks(trunks, goku);
        Console.WriteLine(gotenks.ObtenerNombre()); // Salida: Gotenks
        Console.WriteLine("---------------------------");
        // Realizamos la fusión de Goku y Vegeta para obtener a Gogeta
        personaje gogeta = Fusion.FusionGogeta(goku, vegeta);
        Console.WriteLine(gogeta.ObtenerNombre()); // Salida: Gogeta

        Console.WriteLine("---------------------------");
        Console.ReadLine();
    }
}