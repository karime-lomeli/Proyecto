using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
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
        public string apellido;
        public string calle;
        public string colonia;
        public string ciudad;
        public string telefono;
        public string correo;
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
        public void Insertar(ADProveedores objeto)
        {
            var Proveedores = db.GetCollection<ADProveedores>("Proveedor");
            Proveedores.Insert(objeto);
        }
        public string BuscarId(string texto)
        {
            MongoCollection Proveedor = db.GetCollection<ADProveedores>("Proveedor");
            var filtro = Query<ADProveedores>.EQ(cl => cl.idProveedor, texto);
            List<ADProveedores> prov = Proveedor.FindAs<ADProveedores>(filtro).ToList();
            return "Hola";
        }
    }
}
