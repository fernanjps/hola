// Clase abstracta Fusion para realizar la fusión de personajes
public abstract class Fusion : personaje
{
    // Método para obtener el nombre de la fusión Gotenks
    public static personaje FusionGotenks(personaje personaje1, personaje personaje2)
    {
        Console.WriteLine("Realizando la fusión de Trunks y Goten...");
        return new Gotenks();
    }

    // Método para obtener el nombre de la fusión Gogeta
    public static personaje FusionGogeta(personaje personaje1, personaje personaje2)
    {
        Console.WriteLine("Realizando la fusión de Goku y Vegeta...");
        return new Gogeta();
    }
}