// Decorador para agregar el nombre Trunks
public class Trunks : personaje
{
    private personaje personajeBase;

    public Trunks(personaje personaje)
    {
        this.personajeBase = personaje;
    }

    // Implementamos el método obtener nombre
    public override string ObtenerNombre()
    {
        return "Trunks";
    }
}