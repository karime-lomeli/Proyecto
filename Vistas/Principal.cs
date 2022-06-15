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
using SpreadsheetLight.Drawing;

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

            System.Drawing.Bitmap bm = new System.Drawing.Bitmap(@"C:\xampp\htdocs\Proyecto\Vistas\imagenes\logoLili.PNG");
            byte[] ba;
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bm.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                ms.Close();
                ba = ms.ToArray();
            }

            SLPicture pic = new SLPicture(ba, DocumentFormat.OpenXml.Packaging.ImagePartType.Png);
            pic.SetPosition(0, 0);
            pic.ResizeInPixels(150, 80);
            sl.InsertPicture(pic);

            sl.SetCellValue("C2", "Reporte de entradas"); //Titulo
            SLStyle estiloT = sl.CreateStyle();
            estiloT.Font.FontName = "Arial";
            estiloT.Font.FontSize = 14;
            estiloT.Font.Bold = true;
            sl.SetCellStyle("C2", estiloT);
            sl.MergeWorksheetCells("C2", "E2");

            int celdaCabecera = 6, celdaInicial = 6; //indica desde donde vamos a empezar
            
            
            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Entradas"); //Nombre de la hoja de excel            
            //Encabezados de la tabla
            sl.SetCellValue("B"+ celdaCabecera, "Usuario");
            sl.SetCellValue("C" + celdaCabecera, "Producto");
            sl.SetCellValue("D" + celdaCabecera, "Cantidad");
            sl.SetCellValue("E" + celdaCabecera, "Fecha");

            SLStyle estiloCa = sl.CreateStyle();
            estiloCa.Font.FontName = "Arial";
            estiloCa.Font.FontSize = 12;
            estiloCa.Font.Bold = true;
            estiloCa.Font.FontColor = System.Drawing.Color.White;
            estiloCa.Fill.SetPattern(DocumentFormat.OpenXml.Spreadsheet.PatternValues.Solid, System.Drawing.Color.Red, System.Drawing.Color.Red);
            sl.SetCellStyle("B" + celdaCabecera, "E" + celdaCabecera, estiloCa);

            SLStyle estiloEx = sl.CreateStyle();
            estiloEx.FormatCode = "#,##0.00";
            sl.SetCellStyle("D"+celdaInicial,"E" + celdaCabecera, estiloEx);

            //sl.SetCellValue("D" + celdaCabecera + 1, "SUM(D6:D11)");
            //sl.AutoFitColumn("B", "F");



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

            SLStyle EstiloB = sl.CreateStyle();
            EstiloB.Border.LeftBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.LeftBorder.Color = System.Drawing.Color.Black;
            EstiloB.Border.TopBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.RightBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            EstiloB.Border.BottomBorder.BorderStyle = DocumentFormat.OpenXml.Spreadsheet.BorderStyleValues.Thin;
            sl.SetCellStyle("B" + celdaInicial, "E" + celdaCabecera, EstiloB);

            sl.AutoFitColumn("B","E");

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
