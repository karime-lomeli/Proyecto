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
    public class ADSalida
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string idSalida;
        public string idProducto;
        public int Cantidad;
        public string fecha;
        public string idUsuario;
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");

        /*public string id
        {
            get
            {
                return idSalida;
            }
            set
            {
                idSalida = value;
            }
        }
        public string IdProducto
        {
            get
            {
                return idProducto;
            }
            set
            {
                idProducto = value;
            }
        }
        public int cantidad
        {
            get
            {
                return Cantidad;
            }
            set
            {
                Cantidad = value;
            }
        }
        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }
        public string IdUsuario
        {
            get
            {
                return idUsuario;
            }
            set
            {
                idUsuario = value;
            }
        }*/

        public string Insertar(ADSalida Objeto, int nuevo)
        {
            var Salida = db.GetCollection<ADSalida>("Salidas");
            var Producto = db.GetCollection<ADSalida>("Productos");
            Salida.Insert(Objeto);
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.idProducto) }
            };
            var update = new UpdateDocument
            {
                {
                    "$set", new BsonDocument
                    {
                        {"stock", nuevo },

                    }
                }
            };
            Producto.Update(query, update);
            return "OK";
        }

    }
}
