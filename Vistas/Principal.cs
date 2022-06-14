using Conexion;
using MongoDB.Driver;
using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.Conventions;

namespace Vistas
{
    public partial class Form1 : Form
    {
        public string IdUsuario = "";
        public string Apellidos = "";
        public string Nombre = "";
        public string Acceso = "";
        MongoDatabase db = new MongoClient("mongodb://localhost:27017").GetServer().GetDatabase("Lili");

        
        public Form1()
        {
            InitializeComponent();
        }

        private IMongoDatabase GetDatabase()
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            return mongoClient.GetDatabase("Lili");
        }

        public IMongoCollection<BsonDocument> GetCollection(string Productos)
        {
            return GetDatabase().GetCollection<BsonDocument>(Productos);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Salidas Objeto = new Salidas();
            Objeto.MdiParent = this;
            Objeto.IdUsuario = this.IdUsuario;
            Objeto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Productos Objeto = new Productos();
            Objeto.MdiParent = this;
            Objeto.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Usuarios Objeto = new Usuarios();
            Objeto.MdiParent = this;
            Objeto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Linea Objeto = new Linea();
            Objeto.MdiParent = this;
            Objeto.Show();
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();

            int celdaCabecera = 7; //indica desde donde vamos a empezar
            
            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Productos"); //Nombre de la hoja de excel

            sl.SetCellValue("B" + 3, "Reporte de inventario"); //Titulo
            sl.SetCellValue("B" + 5, "Almacen");

            //Encabezados de la tabla
            sl.SetCellValue("B"+ celdaCabecera, "ID");
            sl.SetCellValue("C" + celdaCabecera, "Nombre");
            sl.SetCellValue("D" + celdaCabecera, "Descripcion");
            sl.SetCellValue("E" + celdaCabecera, "Linea");
            sl.SetCellValue("F" + celdaCabecera, "Requerido");
            sl.SetCellValue("G" + celdaCabecera, "Stock");
            sl.SetCellValue("H" + celdaCabecera, "Minimo");

            //Query 
            IMongoCollection<BsonDocument> productosCollection = GetDatabase().GetCollection<BsonDocument>("Productos");
            //IMongoCollection<BsonDocument> almacenCollection = GetDatabase().GetCollection<BsonDocument>("Almacen");

            List<BsonDocument> result = productosCollection.Aggregate()
                 .Match(new BsonDocument { { "almacen", "62a647850f1e548117ddc8e1" } })
                 //.Project(new BsonDocument { { "_id", 0 } })
                 .Lookup("Almacen", "almacen", "idAlmacen", @as: "almacen_docs")
                 .As<BsonDocument>()
                 .ToList();

            foreach (BsonDocument res in result)
            {
                Console.WriteLine(res.ToString());
            }


            foreach (BsonDocument res in result)
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, res["id"].ToString());
                sl.SetCellValue("C" + celdaCabecera, res["nombre"].ToString());
                sl.SetCellValue("D" + celdaCabecera, res["descripcion"].ToString());
                sl.SetCellValue("E" + celdaCabecera, res["linea"].ToString());
                sl.SetCellValue("F" + celdaCabecera, res["requerido"].ToInt32());
                sl.SetCellValue("G" + celdaCabecera, res["stock"].ToInt32());
                sl.SetCellValue("H" + celdaCabecera, res["minimo"].ToInt32());
            }

            sl.SaveAs("Reporte.xlsx");

            MessageBox.Show("Reporte de productos generado", "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pedidos Objeto = new Pedidos();
            Objeto.MdiParent = this;
            Objeto.Show();
        }
    }
}
