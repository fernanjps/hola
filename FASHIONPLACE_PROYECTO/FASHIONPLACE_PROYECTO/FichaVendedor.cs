using System;
using System.Collections.Generic;
using System.Text;

namespace FASHIONPLACE_PROYECTO
{
    class FichaVendedor : ClassPadre

    {

        public string RequisitosLegales { set; get; }
        public string DescripcionDelServicio { set; get; }
        public string OpcionesDeVenta { set; get; }

        public FichaVendedor(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string RequisitosLegales, string DescripcionDelServicio, string OpcionesDeVenta)
            : base(ID, Cedula, Nombre, Apellido, Correo, Edad, Telefono, Direccion)
        {
            this.RequisitosLegales = RequisitosLegales;
            this.DescripcionDelServicio = DescripcionDelServicio;
            this.OpcionesDeVenta = OpcionesDeVenta;

        }
        public override void ImprimirDatos()
        {
        
         
        

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------");
            Console.WriteLine("---FICHA---VENDEDOR---");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Identificacion: " + ID);
            Console.WriteLine("Numero de Cedula " + Cedula);
            Console.WriteLine("Nombre : " + Nombre);
            Console.WriteLine("Apellidos :" + Apellido);
            Console.WriteLine("Edad  :" + Edad);
            Console.WriteLine("Correo Electronico :" + Correo);
            Console.WriteLine("Numero de telefono :" + Telefono);
            Console.WriteLine("Direccion del domicilio :" + Direccion);
        }

        public override void Servicio()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------");
            Console.WriteLine("---PRESENTACION---");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bienvenidos a FASHIONPLACE en este lugar usted encotrara una gran variedad");
            Console.WriteLine("de trajes para cualquier evento, con de diferentes modelos y precios.");
          


        }

        public override void  legales()
        {
           
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------");
            Console.WriteLine("---REQUISITOS LEGALES---");
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------");
            Console.WriteLine("Requisitos legales: " + RequisitosLegales);
            Console.WriteLine("----------------------");
        }
        public override void venta()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------------------");
            Console.WriteLine("---CATALOGO---");
            Console.WriteLine("------------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
           
           
            Console.WriteLine("Se muestra: " + OpcionesDeVenta);
            Console.WriteLine("Traje Azul Midnight");
            Console.WriteLine("con tallas desde la 46 hasta la 58");
            Console.WriteLine("Leva Scatola Blu");
            Console.WriteLine("con tallas desde la 52 hasta la 56");
            Console.WriteLine("Traje Sand");
            Console.WriteLine("con tallas desde la 46 hasta la 58");

        }




    }
}
