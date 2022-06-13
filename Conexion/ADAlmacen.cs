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
    

    public class ADAlmacen
    {


        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string _IdAlmacen;
        private string _Nombre;
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");

        public string idAlmacen
        {
            get
            {
                return _IdAlmacen;
            }

            set
            {
                _IdAlmacen = value;
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

        
        public string Insertar(ADAlmacen Objeto)
        {
            var Almacen = db.GetCollection<ADAlmacen>("Almacen");
            Almacen.Insert(Objeto);

            return "OK";
        }
        public string Editar(ADAlmacen Objeto)
        {
            var Almacen = db.GetCollection<ADAlmacen>("Almacen");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.idAlmacen) }
            };
            var update = new UpdateDocument
            {
                {
                    "$set", new BsonDocument
                    {
                        {"Nombre", Objeto.Nombre },

                    }
                }
            };
            Almacen.Update(query, update);
            return "OK";
        }
        public DataTable mostrar()
        {
            List<ADAlmacen> almacenes= db.GetCollection<ADAlmacen>("Almacen").FindAll().ToList();
            DataTable Resultado = new DataTable("almacen");
            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            for (int i = 0; i < almacenes.Count; i++)
            {
                Resultado.Rows.Add(almacenes[i].idAlmacen,
                    almacenes[i].Nombre);
            }
            return Resultado;
        }
        public string Eliminar(ADAlmacen Objeto)
        {
            var Almacen = db.GetCollection<ADAlmacen>("Almacen");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.idAlmacen) }
            };
            Almacen.Remove(query);

            return "OK";

        }
        public DataTable buscar(string texto)
        {
            MongoCollection Almacen = db.GetCollection<ADAlmacen>("Almacen");
            var filtro = Query<ADAlmacen>.EQ(cl => cl.Nombre, texto);
            List<ADAlmacen> almacenes = Almacen.FindAs<ADAlmacen>(filtro).ToList();

            DataTable Resultado = new DataTable("almacen");

            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            for (int i = 0; i < almacenes.Count; i++)
            {
                Resultado.Rows.Add(almacenes[i].idAlmacen,
                   almacenes[i].Nombre);
            }
            return Resultado;
        }
        public string BuscarId(string texto)
        {
           
            MongoCollection Almacen = db.GetCollection<ADAlmacen>("Almacen");
            var filtro = Query<ADAlmacen>.EQ(cl => cl.idAlmacen, texto);
            List<ADAlmacen> almacenes = Almacen.FindAs<ADAlmacen>(filtro).ToList();
            if (almacenes.Count > 0)
            {
                //almacenes[0].Nombre = "Karime";
                return almacenes[0].Nombre;
            }
            else
            {
                return texto;
            }
        }
    }
}
