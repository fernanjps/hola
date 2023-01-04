using System;
using System.Collections.Generic;
using System.Text;

namespace FASHIONPLACE_PROYECTO
{
  
        class FichaUsuario : ClassPadre, OrdenBase
        {

            public string MetodoDePago { set; get; }

            public FichaUsuario(int ID, int Cedula, string Nombre, string Apellido, string Correo, int Edad, int Telefono, string Direccion, string MetodoDePago)
                : base(ID, Cedula, Nombre, Apellido, Correo, Edad, Telefono, Direccion)
            {
                this.MetodoDePago = MetodoDePago;
            }

            public override void ImprimirDatos()
            {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("----------------------");
            Console.WriteLine("---FICHA---USUARIO---");
            Console.WriteLine("----------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Identificación: " + ID);
            Console.WriteLine("Numero de Cedula " + Cedula);
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Apellidos:" + Apellido);
            Console.WriteLine("Edad:" + Edad);
            Console.WriteLine("Correo Electrónico:" + Correo);
            Console.WriteLine("Número de teléfono:" + Telefono);
            Console.WriteLine("Dirección del domicilio:" + Direccion);



        }

        public override void pago()
            {

                double operar, credito, final, resultado, debito, resul;
                operar = 106 * 12 / 100;
                final = 106 + operar;
                credito = 106 * 40 / 100;
                resultado = 106 + credito;
                debito = 106 * 18 / 100;
                resul = 106 + debito;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("----------------------");
                Console.WriteLine("---METODOS DE PAGO---");
                Console.WriteLine("----------------------");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Forma de pago:" + MetodoDePago);
                Console.WriteLine("El precio inicial del traje es de:" + 106);
                Console.WriteLine("Estas son las diferentes formas de pago con su respectivo interés");
                Console.WriteLine("El precio en efectivo más el 12% de interés es de:" + final);
                Console.WriteLine("El precio en tarjeta de crédito más el 40% de interés es de:" + resultado);
                Console.WriteLine("El precio en tarjeta de débito más el 18% de interés es de:" + resul);



        }
        public double cuantificar()
            {
                return 106;
            }

        }

        //En esta clase Ficha_Usuario le otorgamos la herencia de la clase padre
        //Creamos el metodo pago que es manejado mediante el polimorfismo por interface


    }









