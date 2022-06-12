using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Data;
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
        private IEnumerable<ADProductos> joinedReadings;

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
        public DataTable mostrar()
        {
            
             DataTable Resultado = new DataTable("salidas");

            var Salidas = db.GetCollection<ADSalida>("Salidas");
            var Productos = db.GetCollection<ADProductos>("Productos");

            var query = (from p in Salidas.AsQueryable()
                         join o in Productos.AsQueryable() on p.idProducto equals o.id into joinedReadings
                         select new ADSalida()
                         {
                             idSalida = p.idSalida,
                             Cantidad = p.Cantidad,
                             joinedReadings = joinedReadings,
                         }).ToList();
            
           
                Resultado.Columns.Add("Cantidad");
                Resultado.Columns.Add("Producto");
               
                for (int i = 0; i < devices.Count; i++)
                {
                    Resultado.Rows.Add(devices[i].Cantidad,
                       devices[i].joinedReadings);
                }
            
            return Resultado;
            

        }

    }

   
}
