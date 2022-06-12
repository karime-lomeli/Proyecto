using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using Conexion.models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Data;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

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

            return "OK";
        }
        public string Editar(ADUsuario Objeto)
        {
            var Usuario = db.GetCollection<ADUsuario>("Usuarios");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.Idusuario) }
            };
            var update = new UpdateDocument
            {
                {
                    "$set", new BsonDocument
                    {
                        {"Nombre", Objeto.Nombre },
                        {"Apellido",Objeto.Apellido },
                        {"Email",Objeto.Email },
                        {"Acceso",Objeto.Acceso },
                        {"Password",Objeto.Password }

                    }
                }
            };
            Usuario.Update(query, update);
            return "OK";
        }
        public string Eliminar(ADUsuario Objeto)
        {
            var Usuario = db.GetCollection<ADUsuario>("Usuarios");
            var query = Query.EQ("_id", ObjectId.Parse(Objeto.Idusuario));
            Usuario.Remove(query);

            return "OK";

        }
        public DataTable mostrar()
        {
            List<ADUsuario> usuarios = db.GetCollection<ADUsuario>("Usuarios").FindAll().ToList();
            //var query = from item in usuarios.AsEnumerable() select item;
            DataTable Resultado = new DataTable("usuario");
            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            Resultado.Columns.Add("Apellido");
            Resultado.Columns.Add("Email");
            Resultado.Columns.Add("Acceso");
            Resultado.Columns.Add("Password");
            for(int i = 0; i < usuarios.Count; i++)
            {
                Resultado.Rows.Add(usuarios[i].Idusuario,
                    usuarios[i].Nombre,
                    usuarios[i].Apellido,
                    usuarios[i].Email,
                    usuarios[i].Acceso,
                    usuarios[i].Password);
            }

            

           // //

            return Resultado;
        }
        public DataTable buscar(string texto)
        {
            MongoCollection Usuario = db.GetCollection<ADUsuario>("Usuarios");
            var filtro = Query<ADUsuario>.EQ(cl => cl.Nombre, texto);
            List<ADUsuario> usuarios = Usuario.FindAs<ADUsuario>(filtro).ToList();

            DataTable Resultado = new DataTable("usuario");

            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            Resultado.Columns.Add("Apellido");
            Resultado.Columns.Add("Email");
            Resultado.Columns.Add("Acceso");
            Resultado.Columns.Add("Password");
            for(int i = 0; i < usuarios.Count; i++)
            {
                Resultado.Rows.Add(usuarios[i].Idusuario,
                   usuarios[i].Nombre,
                   usuarios[i].Apellido,
                   usuarios[i].Email,
                   usuarios[i].Acceso,
                   usuarios[i].Password);
            }
            return Resultado;
        }

      public DataTable Login(string correo, string pass)
        {
            MongoCollection Usuario = db.GetCollection<ADUsuario>("Usuarios");
            var Usuarios = Usuario.AsQueryable<ADUsuario>();
            var res = from u in Usuarios where u.Email == correo && u.Password == pass select u;

            List<ADUsuario> usuarios = res.ToList();

            DataTable Resultado = new DataTable("usuario");

            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            Resultado.Columns.Add("Apellido");
            Resultado.Columns.Add("Email");
            Resultado.Columns.Add("Acceso");
            Resultado.Columns.Add("Password");
            for (int i = 0; i < usuarios.Count; i++)
            {
                Resultado.Rows.Add(usuarios[i].Idusuario,
                   usuarios[i].Nombre,
                   usuarios[i].Apellido,
                   usuarios[i].Email,
                   usuarios[i].Acceso,
                   usuarios[i].Password);
            }
            
            return Resultado;
        }
    }
}
