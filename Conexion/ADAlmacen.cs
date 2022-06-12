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
        public string Id;
        public string Nombre;
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");

        public string id
        {
            get
            {
                return Id;
            }
            set
            {
                Id = value;
            }
        }
        public string nombre
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public string Insertar(ADAlmacen objeto)
        {
            var Al = db.GetCollection<ADUsuario>("Almacen");
            Al.Insert(objeto);
            return "OK";
        }
        public string Editar(ADAlmacen Objeto)
        {
            var Al = db.GetCollection<ADUsuario>("Almacen");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.Id) }
            };
            var update = new UpdateDocument
            {
                {
                    "$set", new BsonDocument
                    {
                        {"Nombre", Objeto.Nombre }

                    }
                }
            };
            Al.Update(query, update);
            return "OK";
        }
        public DataTable mostrar()
        {
            List<ADAlmacen> almacenes = db.GetCollection<ADAlmacen>("Almacen").FindAll().ToList();
            //var query = from item in usuarios.AsEnumerable() select item;
            DataTable Resultado = new DataTable("almacen");
            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Nombre");
            for (int i = 0; i < almacenes.Count; i++)
            {
                Resultado.Rows.Add(almacenes[i].Id,
                    almacenes[i].nombre);
            }



            // //

            return Resultado;
        }
        public string Eliminar(ADAlmacen Objeto)
        {
            var almacen = db.GetCollection<ADLinea>("Almacen");
            var query = Query.EQ("_id", ObjectId.Parse(Objeto.Id));
            almacen.Remove(query);

            return "OK";
        }
    }
}
