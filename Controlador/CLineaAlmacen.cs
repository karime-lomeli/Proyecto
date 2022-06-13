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
            Objeto.idLinea= id;
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
            Objeto.idLinea = Id;
            return Objeto.Eliminar(Objeto);
        }
        public static DataTable BuscarLinea(string texto)
        {
            ADLinea Objeto = new ADLinea();

            return Objeto.buscar(texto);
        }
        public static string InsertarAlmacen(string nombre)
        {
            ADAlmacen Objeto = new ADAlmacen();
            Objeto.Nombre = nombre;

            return Objeto.Insertar(Objeto);
        }
        public static string EditarAlmacen(string id, string nombre)
        {
            ADAlmacen Objeto = new ADAlmacen();
            Objeto.idAlmacen = id;
            Objeto.Nombre = nombre;
            return Objeto.Editar(Objeto);
        }
        public DataTable MostrarAlmacen()
        {

            return new ADAlmacen().mostrar();
        }
        public static string EliminarAlmacen(string Id)
        {
            ADAlmacen Objeto = new ADAlmacen();
            Objeto.idAlmacen = Id;
            return Objeto.Eliminar(Objeto);
        }
        public static DataTable BuscarAlmacen(string texto)
        {
            ADAlmacen Objeto = new ADAlmacen();

            return Objeto.buscar(texto);
        }
        public static string BuscarAlmacenid(string texto)
        {
            ADAlmacen Objeto = new ADAlmacen();
            return Objeto.BuscarId(texto);
        }
    }
}