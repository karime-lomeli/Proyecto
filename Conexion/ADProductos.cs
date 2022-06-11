using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conexion.models;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.Data;
using MongoDB.Driver.Builders;
using MongoDB.Driver.Linq;

namespace Conexion
{
    public class ADProductos
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        private string idProducto;
        private string Nombre;
        private string Descripcion;
        private string Linea;
        private string Almacen;
        private int Requerido;
        private int Stock;
        private int Minimo;
        private string Fecha;
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");

        public string id
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
        public string descripcion
        {
            get
            {
                return Descripcion;
            }
            set
            {
                Descripcion = value;
            }
        }
        public string linea
        {
            get
            {
                return Linea;
            }
            set
            {
                Linea = value;
            }
        }
        public string almacen
        {
            get
            {
                return Almacen;
            }
            set
            {
                Almacen = value;
            }
        }
        public int requerido
        {
            get
            {
                return Requerido;
            }
            set
            {
                Requerido = value;
            }
        }
        public int stock
        {
            get
            {
                return Stock;
            }
            set
            {
                Stock = value;
            }
        }
        public int minimo
        {
            get
            {
                return Minimo;
            }
            set
            {
                Minimo = value;
            }
        }
        public string fecha
        {
            get
            {
                return Fecha;
            }
            set
            {
                Fecha = value;
            }
        }
        public string Insertar(ADProductos Objeto)
        {
            var Prod = db.GetCollection<ADProductos>("Productos");
            Prod.Insert(Objeto);
            return "OK";
        }
        public string Editar(ADProductos Objeto)
        {

            return "OK";
        }
    }
}
