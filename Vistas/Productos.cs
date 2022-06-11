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
            /*this.Mostrar();
            this.Habilitar(false);
            this.HabilitarBotones();*/
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
                            this.Almacen.Text.Trim().ToUpper(),
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
                            this.Almacen.Text.Trim().ToUpper(),
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
                    //this.Mostrar();


                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
