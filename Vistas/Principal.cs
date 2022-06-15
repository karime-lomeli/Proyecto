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

        public IMongoCollection<BsonDocument> GetCollection(string Entradas)
        {
            return GetDatabase().GetCollection<BsonDocument>(Entradas);

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Salidas Objeto = new Salidas();
            Objeto.MdiParent = this;
            Objeto.IdUsuario = this.IdUsuario;
            Objeto.Show();
        }
        private void GestionUsuario()
        {
            //Si es manager se le dan todos los permisos
            if (Acceso == "Manager")
            {
                this.button3.Enabled = true; //lineas
                this.button1.Enabled = true; //productos
                this.button2.Enabled = true; //salidas
                this.button4.Enabled = true; //usuarios
                this.button6.Enabled = true; //pedidos
                this.btnReportes.Enabled = true;

            }
            //Si es usuario solo salidas y reportes.
            if (Acceso == "Usuario")
            {
                this.button3.Enabled = false;
                this.button1.Enabled = true;
                this.button2.Enabled = true;
                this.button4.Enabled = false;
                this.button6.Enabled = false;
                this.btnReportes.Enabled = false;
            }
            //Administrador, todo excepto usuarios.
            if (Acceso == "Administrador")
            {
                this.button3.Enabled = false;
                this.button1.Enabled = true;
                this.button2.Enabled = true;
                this.button4.Enabled = false;
                this.button6.Enabled = true;
                this.btnReportes.Enabled = true;
            }
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
            
            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Entradas"); //Nombre de la hoja de excel

            sl.SetCellValue("B" + 3, "Reporte de entradas"); //Titulo
            sl.SetCellValue("B" + 5, "Entradas");

            //Encabezados de la tabla
            sl.SetCellValue("B"+ celdaCabecera, "Usuario");
            sl.SetCellValue("C" + celdaCabecera, "Producto");
            sl.SetCellValue("D" + celdaCabecera, "Cantidad");
            sl.SetCellValue("E" + celdaCabecera, "Fecha");

            //Query 
            IMongoCollection<BsonDocument> entradasCollection = GetDatabase().GetCollection<BsonDocument>("Entradas");

            List<BsonDocument> result = entradasCollection.Aggregate()
                 //.Match(new BsonDocument { { "almacen", "62a647850f1e548117ddc8e1" } })
                 //.Project(new BsonDocument { { "_id", 0 } })
                 .Lookup("Usuarios", "idUsuario", "Idusuario", @as: "usuarios_docs") 
                 .As<BsonDocument>()
                 .ToList();

            foreach (BsonDocument res in result)
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, res["Usuario"].ToString());
                sl.SetCellValue("C" + celdaCabecera, res["NombreProducto"].ToString());
                sl.SetCellValue("D" + celdaCabecera, res["Cantidad"].ToInt32());
                sl.SetCellValue("E" + celdaCabecera, res["Fecha"].ToString());
            }

            foreach (BsonDocument res in result)
            {
                Console.WriteLine(res.ToString());
            }

            sl.SaveAs("ReporteEntradas.xlsx");

            MessageBox.Show("Reporte de entradas generado con exito", "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pedidos Objeto = new Pedidos();
            Objeto.MdiParent = this;
            Objeto.NombreUsuario = this.Nombre;
            Objeto.idUsuario = this.IdUsuario;
            Objeto.Show();
        }

        private void fileMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
