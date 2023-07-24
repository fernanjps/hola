using System;
using System.Collections.Generic;

// Patrón Decorador: Interfaz para productos tecnológicos
public interface IProductoTecnologico
{
    string ObtenerDescripcion();
    decimal ObtenerPrecio();
}