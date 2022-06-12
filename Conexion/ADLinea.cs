using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MongoDB.Bson;
using System.Data;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;
using MongoDB.Driver;

namespace Conexion
{
    

    public class ADLinea
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string _IdLinea;
        private string _Nombre;
        private string _Descripcion;
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");

        public string idLinea
        {
            get
            {
                return _IdLinea;
            }

            set
            {
                _IdLinea = value;
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

        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }

            set
            {
                _Descripcion = value;
            }
        }
        public string Insertar(ADLinea Objeto)
        {
            var Linea = db.GetCollection<ADLinea>("LineaProductos");
            Linea.Insert(Objeto);

            return "OK";
        }
        public string Editar(ADLinea Objeto)
        {
            var Linea = db.GetCollection<ADLinea>("LineaProductos");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.idLinea) }
            };
            var update = new UpdateDocument
            {
                {
                    "$set", new BsonDocument
                    {
                        {"Nombre", Objeto.Nombre },
                        {"Descripcion",Objeto.Descripcion }

                    }
                }
            };
            Linea.Update(query, update);
            return "OK";
        }
        public DataTable mostrar()
        {
            List<ADLinea> lineas = db.GetCollection<ADLinea>("LineaProductos").FindAll().ToList();
            DataTable Resultado = new DataTable("linea");
            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            Resultado.Columns.Add("Descripcion");
            for (int i = 0; i < lineas.Count; i++)
            {
                Resultado.Rows.Add(lineas[i].idLinea,
                    lineas[i].Nombre,
                    lineas[i].Descripcion);
            }
            return Resultado;
        }

        public string Eliminar(ADLinea Objeto)
        {
            Console.WriteLine("hola");
            var Linea = db.GetCollection<ADLinea>("LineaProductos");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.idLinea) }
            };
            Console.WriteLine("Holaaa");
            Linea.Remove(query);

            return "OK";

        }
        public DataTable buscar(string texto)
        {
            MongoCollection Linea = db.GetCollection<ADLinea>("LineaProductos");
            var filtro = Query<ADLinea>.EQ(cl => cl.Nombre, texto);
            List<ADLinea> lineas = Linea.FindAs<ADLinea>(filtro).ToList();

            DataTable Resultado = new DataTable("usuario");

            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            Resultado.Columns.Add("Descripcion");
            for (int i = 0; i < lineas.Count; i++)
            {
                Resultado.Rows.Add(lineas[i].idLinea,
                   lineas[i].Nombre,
                   lineas[i].Descripcion);
            }
            return Resultado;
        }
    }

}
