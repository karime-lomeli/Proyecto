using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Conexion.models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Conexion
{
    public class ADUsuario
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string _Idusuario;
        private string _Nombre;
        private string _Apellido;
        private string _Email;
        private string _Acceso;
        private string _Password;
        private string _TextoBuscar;
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");
        public string Idusuario
        {
            get
            {
                return _Idusuario;
            }

            set
            {
                _Idusuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }

            set
            {
                _Nombre = value;
            }
        }

        public string Apellido
        {
            get
            {
                return _Apellido;
            }

            set
            {
                _Apellido = value;
            }
        }

        public string Email
        {
            get
            {
                return _Email;
            }

            set
            {
                _Email = value;
            }
        }

      

        public string Acceso
        {
            get
            {
                return _Acceso;
            }

            set
            {
                _Acceso = value;
            }
        }

        public string Password
        {
            get
            {
                return _Password;
            }

            set
            {
                _Password = value;
            }
        }

        public string TextoBuscar
        {
            get
            {
                return _TextoBuscar;
            }

            set
            {
                _TextoBuscar = value;
            }
        }

        public string Insertar(ADUsuario Objeto)
        {
            var Us = db.GetCollection<ADUsuario>("Usuarios");
            Us.Insert(Objeto);

            return "Hola";
        }
        public string Editar(ADUsuario Objeto)
        {
            return "Hola";
        }

    }
}
