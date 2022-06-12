using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;

namespace Controlador
{
   public class CProductos
    {
        public static string Insertar(string nombre, string descripcion, string almacen, string linea,
           int requerido, int minimo, int stock,string fecha)
        {
            ADProductos Objeto = new ADProductos();
            Objeto.nombre = nombre;
            Objeto.descripcion = descripcion;
            Objeto.almacen = almacen;
            Objeto.linea = linea;
            Objeto.requerido = requerido;
            Objeto.minimo = minimo;
            
            Objeto.stock = stock;
            Objeto.fecha = fecha;
            return Objeto.Insertar(Objeto);
        }
        public static string Editar(string id,string nombre, string descripcion, string almacen, string linea,
           int requerido, int minimo, int stock,string fecha)
        {
            ADProductos Objeto = new ADProductos();
            Objeto.id = id;
            Objeto.nombre = nombre;
            Objeto.descripcion = descripcion;
            Objeto.almacen = almacen;
            Objeto.linea = linea;
            Objeto.requerido = requerido;
            Objeto.minimo = minimo;
            Objeto.stock = stock;
            Objeto.fecha = fecha;
            return Objeto.Editar(Objeto);
        }
        public static DataTable Mostrar()
        {
            return new ADProductos().mostrar();
        }
        public static string Eliminar(string Id)
        {
            ADProductos Objeto = new ADProductos();
            Objeto.id = Id;
            return Objeto.Eliminar(Objeto);
        }
        public static DataTable Buscar(string texto)
        {
            ADProductos Objeto = new ADProductos();

            return Objeto.Buscar(texto);
        }
    }
}
