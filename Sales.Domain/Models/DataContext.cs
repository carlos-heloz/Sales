using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace Sales.Domain.Models
{
    /*Clase que utilizara Entity Framework, por lo tanto,
    hereda de la clase DbContext*/
    public class DataContext: DbContext
    {
        /*Llamamos al constructor de la clase DbContext y le pasamos
         como parametro nuestra cadena de conexion (esta la podemos encontrar
         en el archivo config de el proyecto backend o el proyecto API).*/
        public DataContext(): base("DefaultConnection")
        {

        }

        /*CADA VEZ QUE SE INSTANCIE ESTA CLASE CREARA UNA CONEXION A LA BASE DE DATOS*/
    }
}
