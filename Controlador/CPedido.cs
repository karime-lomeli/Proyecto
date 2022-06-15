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
        public static string Insertar(string idProveedor, int cantidad, string idProducto, string fecha
            ,string idUsuario, string status,string nombreProducto,string idAlmacen, int stock,string nombreUsuario)
        {
            ADPedido Objeto = new ADPedido();
            Objeto.idProveedor = idProveedor;
            Objeto.Cantidad = cantidad;
            Objeto.idProducto = idProducto;
            Objeto.NombreProducto = nombreProducto;
            Objeto.Fecha = fecha;
            Objeto.idUsuario = idUsuario;
            Objeto.Status = status;
            //si status es recibido hay que mandar a entradas
            string idPedido = Objeto.insertarPedido(Objeto);
            string respuesta = " ";
            if (status.Equals("Recibido"))
            {
                ADEntradas Entrada = new ADEntradas();
                Entrada.NombreProducto = nombreProducto;
                Entrada.Fecha = fecha;
                Entrada.idUsuario = idUsuario;
                Entrada.Cantidad = cantidad;
                Entrada.idAlmacen = idAlmacen;
                Entrada.idPedido = idPedido;
                Entrada.Usuario = nombreUsuario;
                respuesta = Entrada.InsertarEntrada(Entrada, stock, idProducto);
                //actualizamos el stock del producto
            }

            return respuesta;
        }
        public static string Editar(string idPedido, string idProveedor, int cantidad, string idProducto, string fecha
            , string idUsuario, string status, string nombreProducto, string idAlmacen, int stock)
        {
            ADPedido Objeto = new ADPedido();
            Objeto.idProveedor = idProveedor;
            Objeto.Cantidad = cantidad;
            Objeto.idProducto = idProducto;
            Objeto.Fecha = fecha;
            Objeto.idUsuario = idUsuario;
            Objeto.Status = status;
            Objeto.idPedido = idPedido;
            //si status es recibido hay que mandar a entradas
           
            string respuesta = Objeto.Editar(Objeto);
            if (status.Equals("Recibido"))
            {
                ADEntradas Entrada = new ADEntradas();
                Entrada.NombreProducto = nombreProducto;
                Entrada.Fecha = fecha;
                Entrada.idUsuario = idUsuario;
                Entrada.Cantidad = cantidad;
                Entrada.idAlmacen = idAlmacen;
                Entrada.idPedido = idPedido;
                respuesta = Entrada.InsertarEntrada(Entrada, stock, idProducto);
                //actualizamos el stock del producto
            }

            return respuesta;
        }
        public static DataTable Mostrar()
        {
            ADPedido Objeto = new ADPedido();
            return Objeto.mostrar();
        }
        public static void InsertarProveedor()
        {
            Console.WriteLine("insertar");
            ADProveedores Objeto = new ADProveedores();
            Objeto.nombre = "Juan";
            Objeto.apellido = "Zamarripa";
            Objeto.calle = "Hidalgo";
            Objeto.colonia = "Centro";
            Objeto.ciudad = "Aguascalientes";
            Objeto.telefono = "4491253678";
            Objeto.correo = "juan@gmail.com";
            Objeto.Insertar(Objeto);
        }
        public static DataTable MostrarProveedor()
        {
            ADProveedores Objeto = new ADProveedores();
            return Objeto.Mostrar();
        }
        public static int ReturnStock(string id)
        {
            ADProductos Objeto = new ADProductos();
            return Objeto.stockReturn(id);
        }
        public static string ReturnAlmacen(string id)
        {
            ADProductos Objeto = new ADProductos();
            return Objeto.AlmacenReturn(id);
        }
    }
}
