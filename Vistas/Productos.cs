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

namespace Vistas
{
    public partial class Productos : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static Productos _Instancia;

        public Productos()
        {
            InitializeComponent();
            this.LlenarLinea();
        }
        public static Productos GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new Productos();

            }
            return _Instancia;
        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        

       
        private void Productos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 177;
            this.Mostrar();
            this.Habilitar(false);
            this.HabilitarBotones();
        }

        private void Limpiar()
        {
            this.txtNombre.Text = string.Empty;
            this.txtDescripcion.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtRequerido.Text = string.Empty;
            this.txtMin.Text = string.Empty;
            this.txtS.Text = string.Empty;

        }
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtDescripcion.ReadOnly = !valor;
            

            this.Linea.Enabled = valor;
            this.Almacen.Enabled = valor;
            this.txtId.ReadOnly = !valor;
            this.txtRequerido.ReadOnly = !valor;
            this.txtMin.ReadOnly = !valor;
            this.txtS.ReadOnly = !valor;
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
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnEditar.Enabled = true;
                this.btnCancelar.Enabled = false;
            }
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns["Eliminar"].Visible = false;
            this.dataListado.Columns["Id"].Visible = false;
           // this.dataListado.Columns["idworkcenter"].Visible = false;
            //this.dataListado.Columns["stock_minimo"].Visible = false;
            //this.dataListado.Columns["rfa_pendiente"].Visible = false;

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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombre.Text == string.Empty || this.txtDescripcion.Text == string.Empty ||
                    this.txtMin.Text == string.Empty || this.txtRequerido.Text == string.Empty || this.txtS.Text==string.Empty
                    )
                //this.Almacen.Text == string.Empty || this.Linea.Text==string.Empty
                {
                    MensajeError("Falta ingresar datos");
                }
                else
                {
                    
                    if (this.IsNuevo)
                    {
                        string fecha = DateTime.Now.ToString("yyyy.MM.dd_hh.mm.ss");
                        respuesta = CProductos.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper(),
                            (string)this.Almacen.SelectedValue,
                            this.Linea.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.txtRequerido.Text),
                            Convert.ToInt32(this.txtMin.Text),
                            Convert.ToInt32(this.txtS.Text),fecha);
                    }
                    else
                    {
                        string fecha = DateTime.Now.ToString("yyyy.MM.dd_hh.mm.ss");
                        respuesta = CProductos.Editar(this.txtId.Text,
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtDescripcion.Text.Trim().ToUpper(),
                            "Hola",
                            this.Linea.Text.Trim().ToUpper(),
                            Convert.ToInt32(this.txtRequerido.Text),
                            Convert.ToInt32(this.txtMin.Text),
                            Convert.ToInt32(this.txtS.Text),
                            fecha);
                    }
                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("El Registro se inserto Correctamente");
                        }
                        else
                        {
                            this.MensajeOk("El registro se Actualizo de correctamente");
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
        private void Mostrar()
         {
             this.dataListado.DataSource = CProductos.Mostrar();
             this.OcultarColumnas();
            // labelTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

         }
        private void LlenarLinea()
        {
            CLineaAlmacen Objeto = new CLineaAlmacen();
            Linea.DataSource = Objeto.Mostrar() ;
            Linea.ValueMember = "Id";
            Linea.DisplayMember = "Nombre";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.IsNuevo = false;
            this.IsEditar = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(false);
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
            this.Linea.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["Linea"].Value);
            this.Almacen.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["Almacen"].Value);
            this.txtRequerido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Requerido"].Value);

            this.txtMin.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Minimo"].Value);
            this.txtS.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Stock"].Value);
            
            this.tabControl1.SelectedIndex = 1;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Se Eliminaran los registos seleccionados", "Dashwork", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)

                {
                    string Id;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Respuesta = CProductos.Eliminar(Id);

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Registro eliminado Correctamente");
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
        private void Buscar(string texto)
        {
            this.dataListado.DataSource = CProductos.Buscar(texto);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar(txtBuscar.Text);
        }
    }
}
