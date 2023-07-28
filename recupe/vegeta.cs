// Decorador para agregar el nombre Vegeta
public class Vegeta : personaje
{
    private personaje personajeBase;

    public Vegeta(personaje personaje)
    {
        this.personajeBase = personaje;
    }

    // Implementamos el método obtener nombre
    public override string ObtenerNombre()
    {
        return "Vegeta";
    }
}