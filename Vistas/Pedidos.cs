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
    public partial class Pedidos : Form
    {
        private bool IsNuevo = false;
        public string IdUsuario;
        private DataTable dtDetalle;
        private static Salidas _instancia;
        private int nuevo;
        private int stock;
        public string idAlmacen;
        private string idProducto;

        public Pedidos()
        {
            InitializeComponent();
            this.txtNombre.ReadOnly = true;
            this.txtCantidad.ReadOnly = true;
        }
        public void setPedido(string nombre, string almacen, string linea, int stock)
        {

            this.txtNombre.Text = nombre;
            this.stock = stock;

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
            this.txtNombre.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            

        }
        private void LimpiarDetalle()
        {
            
          
            this.txtCantidad.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.btnProducto.Enabled = valor;
            this.txtCantidad.ReadOnly = !valor;

        }
        private void HabilitarBotones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEditar.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnEditar.Enabled = true;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.HabilitarBotones();
            this.Limpiar();
            this.LimpiarDetalle();
            this.Habilitar(true);
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            this.Top = 8;
            this.Left = 135;
           // this.Mostrar();
            this.Habilitar(false);
            this.HabilitarBotones();
            this.LlenarProveedor();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            VistaProductos vista = new VistaProductos();
            vista.Objeto2 = this;
            vista.ShowDialog();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == string.Empty)
            {
                MensajeError("No hay producto");
            }else if(txtCantidad.Text == string.Empty)
            {
                MensajeError("Ingrese cantidad");
            }else if (Convert.ToInt32(txtCantidad.Text) <= 0)
            {
                MensajeError("Ingrese cantidad valida");
            }
            else
            {
                CPedido Objeto = new CPedido();

            }
        }
        private void LlenarProveedor()
        {
            CPedido Objeto = new CPedido();
            Proveedor.DataSource = CPedido.MostrarProveedor();
            Proveedor.ValueMember = "Id";
            Proveedor.DisplayMember = "Nombre";
        }
    }
}
