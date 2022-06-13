using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
   public class ADProveedores
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string IdProveedor;
        public string nombre;
        public string idProveedor
        {
            get
            {
                return IdProveedor;
            }
            set
            {
                IdProveedor = value;
            }
        }
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");

        public DataTable Mostrar()
        {
            List<ADProveedores> proveedores = db.GetCollection<ADProveedores>("Proveedor").FindAll().ToList();
            DataTable Resultado = new DataTable("proveedor");
            Resultado.Columns.Add("IdProveedor");
            Resultado.Columns.Add("Nombre");
            for (int i = 0; i < proveedores.Count; i++)
            {
                Resultado.Rows.Add(proveedores[i].idProveedor,
                    proveedores[i].nombre);
            }
            return Resultado;
        }
    }
}
