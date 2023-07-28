// Decorador para agregar el nombre Gohan
public class Gohan : personaje
{
    private personaje personajeBase;

    public Gohan(personaje personaje)
    {
        this.personajeBase = personaje;
    }

    // Implementamos el método obtener nombre
    public override string ObtenerNombre()
    {
        return "Gohan";
    }
}
