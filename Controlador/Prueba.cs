using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion.models;


namespace Controlador
{
   public class Prueba
    {
        public string inicio()
        {
            ADProductos objeto = new ADProductos();
            objeto.Insertar();
            return "Hola";
        }
    }
}
