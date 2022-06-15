using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;


using MongoDB.Driver;
using SpreadsheetLight;
using MongoDB.Bson;


namespace Vistas
{
    public partial class Linea : Form
    {
        private IMongoDatabase GetDatabase()
        {
            MongoClient mongoClient = new MongoClient("mongodb://localhost:27017");
            return mongoClient.GetDatabase("Lili");
        }

        public IMongoCollection<BsonDocument> GetCollection(string Productos)
        {
            return GetDatabase().GetCollection<BsonDocument>(Productos);

        }

        private bool IsNuevo = false;
        private bool IsEditar = false;

        public Linea()
        {
            InitializeComponent();
        }
        public void Mostrar()
        {
            CLineaAlmacen Objeto = new CLineaAlmacen();
            this.dataListado.DataSource = Objeto.Mostrar();
            this.dataAlmacen.DataSource = Objeto.MostrarAlmacen();
            this.OcultarColumnas();
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Limpiar()
        {
            this.txtId.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtAlmacen.Text = string.Empty;
            this.txtNombreAlmacen.Text = string.Empty;
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns["Id"].Visible = false;
            this.dataAlmacen.Columns[0].Visible = false;
            this.dataAlmacen.Columns["Id"].Visible = false;
        }
        private void Habilitar(bool valor)
        {
            this.txtId.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            this.txtAlmacen.ReadOnly = !valor;
            this.txtNombreAlmacen.ReadOnly = !valor;
        }
        private void HabilitarBotones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnEditar.Enabled = false;
                this.btnCancelar.Enabled = true;
                this.btnAlmacenNuevo.Enabled = false;
                this.btnGuardarAlmacen.Enabled = true;
                this.btnEditarAlmacen.Enabled = false;
                this.btnCancelarAlmacen.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
                this.btnAlmacenNuevo.Enabled = true;
                this.btnGuardarAlmacen.Enabled = false;
                this.btnEditarAlmacen.Enabled = true;
                this.btnCancelarAlmacen.Enabled = false;
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Limpiar();
            this.HabilitarBotones();
            this.Habilitar(true);
            this.txtNombre.Focus();
        }

        private void Linea_Load(object sender, EventArgs e)
        {

            this.Top = 8;
            this.Left = 135;
            this.Mostrar();
            this.Habilitar(false);
            this.HabilitarBotones();
            LlenarAlmacen();
        }
        private void LlenarAlmacen()
        {
            CLineaAlmacen Objeto = new CLineaAlmacen();
            Almacen.DataSource = Objeto.MostrarAlmacen();
            Almacen.ValueMember = "Id";
            Almacen.DisplayMember = "Nombre";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombre.Text == string.Empty || this.txtDescripcion.Text == string.Empty )
                {
                    MensajeError("Faltan datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = CLineaAlmacen.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper()
                            );
                    }
                    else
                    {
                        respuesta = CLineaAlmacen.Editar(this.txtId.Text,
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper());
                        
                    }
                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("El Usuario se ingreso correctamente");

                        }
                        else
                        {
                            this.MensajeOk("El usuario se actualizo de correctamente");
                        }

                    }

                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.HabilitarBotones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                this.IsEditar = true;
                this.HabilitarBotones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero un registro a editar desde la pestaña Listado");
            }
        }
        private void tabPage2_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void checkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;

            }
            else
            {
                this.dataListado.Columns[0].Visible = false;

            }
        }
        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["ELiminar"].Index)
            {
                DataGridViewCheckBoxCell checkBox1 = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["ELiminar"];
                checkBox1.Value = !Convert.ToBoolean(checkBox1.Value);
            }
        }
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Id"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
            this.txtDescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Descripcion"].Value);
           

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Se Eliminaran las líneas seleccionadas", "Dashwork", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)

                {
                    string Id;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Console.WriteLine(Id);
                            Respuesta = CLineaAlmacen.Eliminar(Id);

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Línea eliminada correctamente");
                            }
                            else
                            {
                                this.MensajeError(Respuesta);
                            }
                        }
                    }

                    this.Mostrar();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(false);
            this.txtId.Text = string.Empty;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (this.txtBuscar.Text == string.Empty)
            {
                MensajeError("Ingrese texto");
            }
            else
            {
                this.dataListado.DataSource = CLineaAlmacen.BuscarLinea(this.txtBuscar.Text.ToUpper());
            }
        }

        private void btnAlmacenNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Limpiar();
            this.HabilitarBotones();
            this.Habilitar(true);
            this.txtNombreAlmacen.Focus();
        }

        private void btnGuardarAlmacen_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombreAlmacen.Text == string.Empty )
                {
                    MensajeError("Faltan datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = CLineaAlmacen.InsertarAlmacen(this.txtNombreAlmacen.Text.Trim().ToUpper());
                          
                    }
                    else
                    {
                        respuesta = CLineaAlmacen.EditarAlmacen(this.txtAlmacen.Text,
                            this.txtNombreAlmacen.Text.Trim().ToUpper());

                    }
                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("El Usuario se ingreso correctamente");

                        }
                        else
                        {
                            this.MensajeOk("El usuario se actualizo de correctamente");
                        }

                    }

                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.HabilitarBotones();
                    this.Limpiar();
                    this.Mostrar();


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnEditarAlmacen_Click(object sender, EventArgs e)
        {
            if (!txtAlmacen.Text.Equals(""))
            {
                this.IsEditar = true;
                this.HabilitarBotones();
                this.Habilitar(true);
            }
            else
            {
                this.MensajeError("Debe seleccionar primero un registro a editar desde la pestaña Listado");
            }
        }

        
     
        private void dataAlmacen_DoubleClick(object sender, EventArgs e)
        {
            this.txtAlmacen.Text = Convert.ToString(this.dataAlmacen.CurrentRow.Cells["Id"].Value);
            this.txtNombreAlmacen.Text = Convert.ToString(this.dataAlmacen.CurrentRow.Cells["Nombre"].Value);
            this.tabControl1.SelectedIndex = 3;
        }

        

        private void btnCancelarAlmacen_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(false);
            this.txtAlmacen.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.BuscarAl.Text == string.Empty)
            {
                MensajeError("Ingrese texto");
            }
            else
            {
                this.dataAlmacen.DataSource = CLineaAlmacen.BuscarAlmacen(this.BuscarAl.Text.ToUpper());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = Almacen.SelectedValue.ToString();
            Console.WriteLine(id);

            SLDocument sl = new SLDocument();

            int celdaCabecera = 7; //indica desde donde vamos a empezar

            sl.RenameWorksheet(SLDocument.DefaultFirstSheetName, "Productos"); //Nombre de la hoja de excel

            sl.SetCellValue("B" + 3, "Reporte de inventario"); //Titulo
            sl.SetCellValue("B" + 5, "Almacen");

            //Encabezados de la tabla
            sl.SetCellValue("B" + celdaCabecera, "ID");
            sl.SetCellValue("C" + celdaCabecera, "Nombre");
            sl.SetCellValue("D" + celdaCabecera, "Descripcion");
            sl.SetCellValue("E" + celdaCabecera, "Linea");
            sl.SetCellValue("F" + celdaCabecera, "Requerido");
            sl.SetCellValue("G" + celdaCabecera, "Stock");
            sl.SetCellValue("H" + celdaCabecera, "Minimo");

            //Query 
            IMongoCollection<BsonDocument> productosCollection = GetDatabase().GetCollection<BsonDocument>("Productos");

            List<BsonDocument> result = productosCollection.Aggregate()
                 .Match(new BsonDocument { { "almacen", id } })
                 //.Project(new BsonDocument { { "_id", 0 } })
                 .Lookup("Almacen", "almacen", "idAlmacen", @as: "almacen_docs")
                 .As<BsonDocument>()
                 .ToList();

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


            foreach (BsonDocument res in result)
            {
                Console.WriteLine(res.ToString());
            }

            sl.SaveAs("ReporteAlmacen.xlsx");

            MessageBox.Show("Reporte de inventario generado con exito", "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
