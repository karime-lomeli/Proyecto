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
    public partial class Pedidos : Form
    {
        private bool IsNuevo = false;
        public string IdUsuario;
        private DataTable dtDetalle;
        private static Salidas _instancia;
        private int nuevo;
        private int stock;
        private string idAlmacen;

        public Pedidos()
        {
            InitializeComponent();
            this.txtNombre.ReadOnly = true;
            this.txtNomAlmacen.ReadOnly = true;
            this.txtLinea.ReadOnly = true;
            this.txtCantidad.ReadOnly = true;
        }
        public void setPedido(string nombre, string almacen, string linea, int stock)
        {

            this.txtNombre.Text = nombre;
            this.txtNomAlmacen.Text = almacen;
            this.txtLinea.Text = linea;
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
            this.txtNomAlmacen.Text = string.Empty;
            this.txtLinea.Text = string.Empty;

        }
        private void LimpiarDetalle()
        {
            
            this.txtNomAlmacen.Text = string.Empty;
            this.txtLinea.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtNombre.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.txtNombre.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            //this.textBoxStockInicial.ReadOnly = true;

            this.btnProducto.Enabled = valor;

        }
        private void HabilitarBotones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
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
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            VistaProductos vista = new VistaProductos();
            vista.Objeto2 = this;
            vista.ShowDialog();
        }
    }
}
