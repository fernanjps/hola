 abstract class Usuario
{
    public int id {set;get;}
    public string nombre{set;get;}
    public string email{set;get;}
    public string password{get;set;}
    public int cedula{set;get;}

    public  Usuario (string nombre , string email, string password, int cedula , int id ): base()
    {
        this.nombre = nombre;
        this.email= email;
        this.password = password;
        this.cedula = cedula;
        this.id = id ;

    }

    //metodo o comportamiento 
    public abstract void mostrarDatos();
    

}