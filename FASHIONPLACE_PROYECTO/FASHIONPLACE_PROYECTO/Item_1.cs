using System;
using System.Collections.Generic;
using System.Text;

namespace FASHIONPLACE_PROYECTO
{
    class Item_1 : Decorador
    {

        public Item_1(OrdenBase ordenbase) : base(ordenbase)
        {

        }

        public override double cuantificar()
        {
            return base.cuantificar() + 80;

        }
        //Creamos la clase Item_1
        //la cual permite realizar el calculo
        //del traje más el valor del Ítem

    }

}


