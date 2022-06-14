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
        private bool IsEditar = false;
        public string IdUsuario;
        private DataTable dtDetalle;
        private static Salidas _instancia;
        private int nuevo;
        private int stock;
        public string idAlmacen;
        private string idProducto;
        public string idUsuario;
        private bool IsPendiente=false;
        private bool IsRecibido = false;
        private int cantidadnueva;
        public string idProd;
        public string NombreUsuario = " ";

        public Pedidos()
        {
            InitializeComponent();
            this.txtNombre.ReadOnly = true;
            this.txtCantidad.ReadOnly = true;
        }
        public void setPedido(string nombre, string almacen, string linea, int stock,string idProducto)
        {

            this.txtNombre.Text = nombre;
            this.stock = stock;
            this.idProducto = idProducto;

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
        private void Mostrar()
        {
            dataListado.DataSource = CPedido.Mostrar();
            OcultarColumnas();
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
            this.Proveedor.Enabled = valor;
            this.RRecibido.Checked = valor;
            this.RPendiente.Checked = valor;
            this.RPendiente.Enabled = valor;
            this.RRecibido.Enabled = valor;

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
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
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
            //CPedido.InsertarProveedor();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns["Eliminar"].Visible = false;
            this.dataListado.Columns["Id"].Visible = false;
            this.dataListado.Columns["IdProveedor"].Visible = false;
            this.dataListado.Columns["IdProducto"].Visible = false;
        }

        private void Pedidos_Load(object sender, EventArgs e)
        {
            this.Top = 8;
            this.Left = 135;
            this.Mostrar();
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
            }else if(RPendiente.Checked==false && RRecibido.Checked==false)
            {
                MensajeError("Status pendiente");
            }
            else
            {
                string respuesta = " ";
                if (IsNuevo) {
                    CPedido Objeto = new CPedido();
                    string status = " ";
                    if (RPendiente.Checked == true && RRecibido.Checked == false)
                    {
                        status = "Pendiente";
                    } else if (RRecibido.Checked == true && RPendiente.Checked == false)
                    {
                        status = "Recibido";
                    }
                    stock = stock + Convert.ToInt32(this.txtCantidad.Text);
                    string fecha = DateTime.Now.ToString("yyyy.MM.dd_hh.mm.ss");
                    respuesta= CPedido.Insertar(Proveedor.SelectedValue.ToString(),
                        Convert.ToInt32(txtCantidad.Text),
                        idProducto, fecha, idUsuario, status, this.txtNombre.Text,idAlmacen, stock,NombreUsuario);
                    MensajeOk("El pedido se ha registrado");
                }
                else
                {
                    CPedido Objeto = new CPedido();
                    string status = " ";
                    if (IsPendiente && RPendiente.Checked == true && RRecibido.Checked == false )
                    {
                        status = "Pendiente";
                    }else if(IsPendiente && RRecibido.Checked == true && RPendiente.Checked == false)
                    {
                        status = "Recibido";
                    }
                    stock = CPedido.ReturnStock(idProd);
                    stock = stock + Convert.ToInt32(this.txtCantidad.Text);
                    Console.WriteLine(stock);
                    string fecha = DateTime.Now.ToString("yyyy.MM.dd_hh.mm.ss");
                    idAlmacen = CPedido.ReturnAlmacen(idProd);
                    respuesta = CPedido.Editar(this.txtId.Text,Proveedor.SelectedValue.ToString(),
                    Convert.ToInt32(txtCantidad.Text),
                    idProd, fecha, idUsuario, status, this.txtNombre.Text, idAlmacen, stock);
                    MensajeOk("El status se ha actualizado");




                }
                IsNuevo = false;
                IsEditar = false;
                IsPendiente = false;
                IsRecibido = false;
                Mostrar();
                Limpiar();
                Habilitar(false);
                HabilitarBotones();
                
            }
        }
        private void LlenarProveedor()
        {
            CPedido Objeto = new CPedido();
            Proveedor.DataSource = CPedido.MostrarProveedor();
            Proveedor.ValueMember = "idProveedor";
            Proveedor.DisplayMember = "nombre";
        }
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Id"].Value);
            this.idProd=Convert.ToString(this.dataListado.CurrentRow.Cells["IdProducto"].Value);
            this.txtNombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Producto"].Value);
            this.Proveedor.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["IdProveedor"].Value);
            this.txtCantidad.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Cantidad"].Value);
            this.cantidadnueva = Convert.ToInt32(this.dataListado.CurrentRow.Cells["Cantidad"].Value);
            if(Convert.ToString( this.dataListado.CurrentRow.Cells["Status"].Value).Equals("Recibido"))
            {
                RRecibido.Checked = true;
                RPendiente.Checked = false;
                IsRecibido = true;
                this.btnEditar.Enabled = false;
            }
            else if(Convert.ToString(this.dataListado.CurrentRow.Cells["Status"].Value).Equals("Pendiente"))
            {
                RPendiente.Checked = true;
                RRecibido.Checked = false;
                IsPendiente = true;
            }

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(!this.txtCantidad.Text.Equals(" "))
            {
                this.IsEditar = true;
                this.HabilitarBotones();
                this.txtNombre.ReadOnly = true;
                this.btnProducto.Enabled = false;
                this.txtCantidad.ReadOnly = true;
                this.btnGuardar.Enabled = true;
                RPendiente.Enabled = true;
                RRecibido.Enabled = true;
            }
            else
            {
                MensajeError("Seleccione un pedido");
            }
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.IsPendiente = false;
            this.IsRecibido = false;
            this.HabilitarBotones();
            this.Limpiar();
            this.Habilitar(false);
        }
    }
}
