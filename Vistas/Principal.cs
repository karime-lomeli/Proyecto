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

            int celdaCabecera = 5; //indica desde donde vamos a empezar
            
            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Productos"); //Nombre de la hoja de excel

            //Encabezados de la tabla
            sl.SetCellValue("B"+ celdaCabecera, "ID");
            sl.SetCellValue("C" + celdaCabecera, "Nombre");
            sl.SetCellValue("D" + celdaCabecera, "Descripción");
            sl.SetCellValue("E" + celdaCabecera, "Linea");
            sl.SetCellValue("F" + celdaCabecera, "Almacen");
            sl.SetCellValue("G" + celdaCabecera, "Requerido");
            sl.SetCellValue("H" + celdaCabecera, "Minimo");
            sl.SetCellValue("I" + celdaCabecera, "Stock");

            //Query 
            List<ADProductos> productos = db.GetCollection<ADProductos>("Productos").FindAll().ToList();

            for (int i = 0; i < productos.Count; i++)
            {
                celdaCabecera++;
                sl.SetCellValue("B" + celdaCabecera, productos[i].id.ToString());
                sl.SetCellValue("C" + celdaCabecera, productos[i].nombre.ToString());
                sl.SetCellValue("D" + celdaCabecera, productos[i].descripcion.ToString());
                sl.SetCellValue("E" + celdaCabecera, productos[i].linea.ToString());
                sl.SetCellValue("F" + celdaCabecera, productos[i].almacen.ToString());
                sl.SetCellValue("G" + celdaCabecera, productos[i].requerido);
                sl.SetCellValue("H" + celdaCabecera, productos[i].minimo);
                sl.SetCellValue("I" + celdaCabecera, productos[i].stock);

            }
            sl.SaveAs("Reporte.xlsx");

            MessageBox.Show("Reporte de productos generado", "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
