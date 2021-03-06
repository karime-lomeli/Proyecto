using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion;

namespace Controlador
{
    public class CUsuario
    {
        public static string Insertar(string nombre, string apellido, string email,  string acceso, string password)
        {
            ADUsuario Objeto = new ADUsuario();
            Objeto.Nombre = nombre;
            Objeto.Apellido = apellido;
            Objeto.Email = email;
            Objeto.Acceso = acceso;
            Objeto.Password = password;

            return Objeto.Insertar(Objeto);

        }
        public static string Editar(string idusuario, string nombre, string apellido, string email,
             string acceso, string password)
        {
            ADUsuario Objeto = new ADUsuario();
            Objeto.Idusuario = idusuario;
            Objeto.Nombre = nombre;
            Objeto.Apellido = apellido;
            Objeto.Email = email;
            Objeto.Acceso = acceso;
            Objeto.Password = password;
            return Objeto.Editar(Objeto);
        }
        public DataTable Mostrar()
        {
            
            return new ADUsuario().mostrar();
        }
        public static string Eliminar(string Id)
        {
            ADUsuario Objeto = new ADUsuario();
            Objeto.Idusuario = Id;
            return Objeto.Eliminar(Objeto);
        }
        public static DataTable BuscarUsuario(string texto)
        {
            ADUsuario Objeto = new ADUsuario();

            return Objeto.buscar(texto);
        }
        public static DataTable Login(string correo, string pass)
        {
            ADUsuario Objeto = new ADUsuario();
            return Objeto.Login(correo, pass);
        }
    }
}
