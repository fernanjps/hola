using System;
using System.Collections.Generic;
using System.Text;

namespace FASHIONPLACE_PROYECTO
{
    class FichaAdministrador : ClassPadre
    {
        public string ExperienciaLaboral { set; get; }
        public string Profesion { set; get; }

        public FichaAdministrador(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string ExperienciaLaboral, string Profesion)
            : base(ID, Cedula, Nombre, Apellido, Correo, Edad, Telefono, Direccion)
        {
            this.ExperienciaLaboral = ExperienciaLaboral;
            this.Profesion = Profesion;

        }
        public override void ImprimirDatos()
        {


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------");
            Console.WriteLine("---FICHA---ADMINISTRADOR---");
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Identificación: " + ID);
            Console.WriteLine("Numero de Cedula: " + Cedula);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellidos:" + Apellido);
            Console.WriteLine("Edad:" + Edad);
            Console.WriteLine("Correo Electrónico:" + Correo);
            Console.WriteLine("Número de teléfono:" + Telefono);
            Console.WriteLine("Dirección del domicilio:" + Direccion);

        }

        public override void Servicio()
        {


            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------");
            Console.WriteLine("---REQUERIMIENTOS---");
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Experiencia Laboral:" + ExperienciaLaboral);
            Console.WriteLine("Profesión   :" + Profesion);


        }
    }
}


