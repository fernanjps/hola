using System;
using System.Collections.Generic;
// Patrón Modelo-Vista-Controlador (MVC): Clase Modelo para el producto tecnológico
public class ModeloProductoTecnologico
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public ModeloProductoTecnologico(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }
}