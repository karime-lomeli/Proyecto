using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;

namespace Controlador
{
   public class CPedido
    {
        public static string Insertar(string nombre, string fecha, string idUsuario,int cantidad, string idAlmacen)
        {
            return "Hols";
        }
        public static DataTable MostrarProveedor()
        {
            ADProveedores Objeto = new ADProveedores();
            return Objeto.Mostrar();
        }
    }
}
