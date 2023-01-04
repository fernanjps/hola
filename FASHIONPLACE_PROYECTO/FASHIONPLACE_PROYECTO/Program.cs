using System;

namespace FASHIONPLACE_PROYECTO
{
    class Program
    {
        static void Main(string[] args)
        {

            FichaVendedor F_vende = new FichaVendedor(7896356, 1307895622, " Julio ", " Flores ", " juio87@gmail.com ", 38, 0987851913, " Las Cumbres", " Mayor edad , Experencia Previa ,  Aprendizaje proactivo    ", " Ventas de trajes formales  ", " Catalogo de las vestimenatas ");
            F_vende.Servicio();
            F_vende.ImprimirDatos();
            F_vende.legales();
            F_vende.venta();


            FichaUsuario F_usu = new FichaUsuario(126647893, 1361798123, " Mario ", " Perez ", " Mario1995@gmail.com ", 25, 0934547727, " Calle 110 Av 12 ", " Forma de pago aun por especificar");
            F_usu.ImprimirDatos();
            F_usu.pago();




            FichaAdministrador Admin = new FichaAdministrador(546758, 1316718111, " Joel ", " Catagua ", " ajmc1316718111@gmail.com ", 21, 0981851234, " Leonidas Proaño ", " Contar con una experiencia laboral de 2 años  ", " Diseñador de modas  ");
            Admin.ImprimirDatos();
            Admin.Servicio();

         
          
   
            var FichaU = new FichaUsuario(126647893, 1361798123, " Mario ", " Perez ", " Mario1995@gmail.com ",
             25, 0934547727, " Calle 110 Av 12 ", " Forma de pago aun por especificar");

            var item_1 = new Item_1(FichaU);
            Console.WriteLine($"El precio en efectivo del traje mas un par de mancuernillas es : {item_1.cuantificar()}");
            var item_2 = new Item_2(FichaU);
            Console.WriteLine($"El precio en efectivo del traje mas una corbata es: {item_2.cuantificar()}");

           


           
            RequisitosFuncionales requi = new RequisitosFuncionales();
            requi.requisitos();




            //Para finalizar añadimos el método cuantificar de la clase Decorador.


        }
    }
}
