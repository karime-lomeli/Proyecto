using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class ADEntradas
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string idEntrada;
        public string NombreProducto;
        public string Fecha;
        public string idUsuario;
        public int Cantidad;
        public string idAlmacen;
        public string idPedido;
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");
        public string IdEntrada
        {
            get
            {
                return idEntrada;
            }
            set
            {
                idEntrada = value;
            }
        }
        public string InsertarEntrada(ADEntradas Objeto, int stock,string P)
        {
            var Entrada = db.GetCollection<ADEntradas>("Entradas");
            Entrada.Insert(Objeto);
            var Producto = db.GetCollection<ADSalida>("Productos");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(P) }
            };
            var update = new UpdateDocument
            {
                {
                    "$set", new BsonDocument
                    {
                        {"stock", stock },

                    }
                }
            };
            Producto.Update(query, update);
            return "OK";
        }
    }
}
