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
        public string Descripcion { get; set; }
        public int idAlmacen { get; set; }
        public int requerido { get; set; }
        public int minimo { get; set; }
        public int stock { get; set; }
        public string fecha { get; set; }

        public void Insertar()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("Lili");

            var Productos = database.GetCollection<ADProductos>("Productos");
            var AdProductos = new ADProductos { Nombre = "Pegamento", Descripcion = "Descripcion", idAlmacen = 1, requerido = 10, minimo = 2, stock = 9, fecha= "5/1/2008 8:30:52 AM" };
            Productos.InsertOne(AdProductos);
        }
    }
}
