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
    public class ADPedido
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string idPedido;
        public string idProveedor;
        public int Cantidad;
        public string idProducto;
        public string Fecha;
        public string idUsuario;
        public string Status;
        public string NombreProducto;

        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");
        public string IdPedido
        {
            get
            {
                return idPedido;
            }
            set
            {
                idPedido = value;
            }
        }

        public string insertarPedido(ADPedido objeto)
        {
            var Pedidos = db.GetCollection<ADPedido>("Pedidos");
            Pedidos.Insert(objeto);
            return idPedido;
        }
        public string Editar(ADPedido Objeto)
        {
            var Pedido = db.GetCollection<ADPedido>("Pedidos");
            var query = new QueryDocument
            {
                {"_id",ObjectId.Parse(Objeto.idPedido) }
            };
            var update = new UpdateDocument
            {
                {
                    "$set", new BsonDocument
                    {
                       // {"idProveedor", Objeto.idProveedor },
                        //{"Cantidad",Objeto.Cantidad },
                        //{"idProducto",Objeto.idProducto},
                        //{"Fecha",Objeto.Fecha },
                        {"idUsuario",Objeto.idUsuario },
                        { "Status",Objeto.Status}

                    }
                }
            };
            Pedido.Update(query, update);
            return "OK";
        }
        public DataTable mostrar()
        {
            ADUsuario Usuario = new ADUsuario();
            ADProductos Producto = new ADProductos();
            ADProveedores Proveedor = new ADProveedores();
            List<ADPedido> pedidos = db.GetCollection<ADPedido>("Pedidos").FindAll().ToList();
            DataTable Resultado = new DataTable("pedido");
            Resultado.Columns.Add("Id");
            Resultado.Columns.Add("Producto");
            Resultado.Columns.Add("Cantidad");
            Resultado.Columns.Add("Proveedor");
            Resultado.Columns.Add("UsuarioSolicitante");
            Resultado.Columns.Add("Status");
            Resultado.Columns.Add("Fecha");
            Resultado.Columns.Add("IdProveedor");
            Resultado.Columns.Add("IdProducto");
            for (int i = 0; i < pedidos.Count; i++)
            {
                string usuario = Usuario.BuscarId(pedidos[i].idUsuario);
                string producto = Producto.BuscarId(pedidos[i].idProducto);
                string proveedor = Proveedor.BuscarId(pedidos[i].idProveedor);

                Resultado.Rows.Add(pedidos[i].idPedido,
                    producto,
                    pedidos[i].Cantidad,
                    proveedor,
                    usuario,
                    pedidos[i].Status,
                   pedidos[i].Fecha,
                   pedidos[i].idProveedor,
                   pedidos[i].idProducto
                   );
            }



            // //

            return Resultado;
        }
    }
}
