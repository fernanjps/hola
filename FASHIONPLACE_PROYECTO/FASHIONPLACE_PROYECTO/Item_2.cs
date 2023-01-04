using System;
using System.Collections.Generic;
using System.Text;

namespace FASHIONPLACE_PROYECTO
{
    class Item_2 : Decorador
    {

        public Item_2(OrdenBase ordenbase) : base(ordenbase)
        {

        }

     

        public override double cuantificar()
        {
            return base.cuantificar() + 100;

        }
        //Creamos la clase Item_2
        //la cual nos permite realizar el calculo
        //Del traje más el valor del Ítem


    }
}
