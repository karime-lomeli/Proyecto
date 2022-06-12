using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;

namespace Controlador
{
   public class CSalidas
    {
        public string Insertar(string id, string fecha,string codigo, DataTable salidas, int nuevo)
        {
            ADSalida Objeto = new ADSalida
            {
                idProducto = salidas.Rows[0]["idProducto"].ToString(),
                Cantidad = Convert.ToInt32(salidas.Rows[0]["Cantidad"].ToString()),
                fecha = fecha,
                idUsuario = id

            };

            return Objeto.Insertar(Objeto, nuevo);
            
        }
        public DataTable Mostrar()
        {
            return new ADSalida().mostrar();
        }
    }
}
