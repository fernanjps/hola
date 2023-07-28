// Decorador para agregar el nombre Goten
public class Goten : personaje
{
    private personaje personajeBase;

    public Goten(personaje personaje)
    {
        this.personajeBase = personaje;
    }

    // Implementamos el método obtener nombre
    public override string ObtenerNombre()
    {
        return "Goten";
    }
}