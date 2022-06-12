using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;

namespace Controlador
{
    public class CLineaAlmacen
    {
        public static string Insertar(string nombre, string descripcion)
        {
            ADLinea Objeto = new ADLinea();
            Objeto.Nombre = nombre;
            Objeto.Descripcion = descripcion;

            return Objeto.Insertar(Objeto);
        }
        public static string Editar(string id,string nombre,string descripcion)
        {
            ADLinea Objeto = new ADLinea();
            Objeto.id = id;
            Objeto.Nombre = nombre;
            Objeto.Descripcion = descripcion;
            return Objeto.Editar(Objeto);
        }
        public DataTable Mostrar()
        {

            return new ADLinea().mostrar();
        }
        public static string Eliminar(string Id)
        {
            ADLinea Objeto = new ADLinea();
            Objeto.id = Id;
            return Objeto.Eliminar(Objeto);
        }
    }
}