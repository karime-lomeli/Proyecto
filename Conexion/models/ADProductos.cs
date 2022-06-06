using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Conexion.models
{
    public class ADProductos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Nombre { get; set; }
        [BsonElement("nombre")]
        public string Descripcion { get; set; }
        [BsonElement("descripcion")]
        public int idAlmacen { get; set; }
        [BsonElement("idalmacen")]
        public int requerido { get; set; }
        [BsonElement("requerido")]
        public int minimo { get; set; }
        [BsonElement("minimo")]
        public int stock { get; set; }
        [BsonElement("stock")]
        public DateTime fecha { get; set; }

        public void Insertar()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Lili");

            var Productos = database.GetCollection<ADProductos>("Productos");
            var AdProductos = new ADProductos { Nombre = "Pegamento", Descripcion = "Descripcion", idAlmacen = 1, requerido = 10, minimo = 2, stock = 100 };
            Productos.InsertOne(AdProductos);
        }
    }
}
