using System;
using System.Collections.Generic;
using System.Text;

namespace FASHIONPLACE_PROYECTO
{
    class Decorador : OrdenBase
    {
        protected OrdenBase ordenbase;

        public Decorador(OrdenBase ordenbase)
        {
            this.ordenbase = ordenbase;
        }
        public virtual double cuantificar()


        { 
            return ordenbase.cuantificar(); 
        }
        //El Patrón de diseño "Decorador"
        //Creamos una clase nueva con el nombre Decorador
        //La variable OrdenBase debe estar protegida
        //Luego el método Calcular debe de ser public virtual

    }
}
