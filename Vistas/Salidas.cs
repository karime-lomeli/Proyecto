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
    public partial class Salidas : Form
    {
        private bool IsNuevo = false;
        public string IdUsuario;
        private DataTable dtDetalle;
        private static Salidas _instancia;
        private int nuevo;

        public static Salidas GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Salidas();
            }

            return _instancia;
        }
        public Salidas()
        {
            InitializeComponent();

            this.txtID.Visible = false;
            this.txtAlmacen.Visible = false;
            this.txtProducto.ReadOnly = true;
            this.txtNomAlmacen.ReadOnly = true;
            this.txtLinea.ReadOnly = true;
            this.txtCantidad.ReadOnly = true;
        }
        public void setProducto(string idProducto, string nombre, int requerido, string almacen, string linea, 
             int stockMinimo,int stock)
        {
            
            this.txtID.Text = idProducto;
            this.txtProducto.Text = nombre;
            this.txtRequerido.Text = Convert.ToString(requerido);
            this.txtNomAlmacen.Text = almacen;
            this.txtLinea.Text = linea;
            this.txtMinimo.Text = Convert.ToString(stockMinimo);
            this.txtDisponible.Text = Convert.ToString(stock);

        }
        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeWarning(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Limpiar()
        {
            this.txtCodigo.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.creartabla();
        }
        private void LimpiarDetalle()
        {
            this.txtID.Text = string.Empty;
            this.txtProducto.Text = string.Empty;
            this.txtRequerido.Text = string.Empty;
            this.txtMinimo.Text = string.Empty;
            this.txtNomAlmacen.Text = string.Empty;
            this.txtAlmacen.Text = string.Empty;
            this.txtLinea.Text = string.Empty;
            this.txtCantidad.Text = string.Empty;
            this.txtDisponible.Text = string.Empty;
        }
        private void Habilitar(bool valor)
        {
            this.txtID.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.dateTimePickerFechaIngreso.Enabled = valor;

            this.txtCantidad.ReadOnly = !valor;
            //this.textBoxStockInicial.ReadOnly = true;
            this.txtMinimo.ReadOnly = true;
            this.txtRequerido.ReadOnly = true;
            this.txtProducto.ReadOnly = true;

            this.btnProducto.Enabled = valor;
            this.btnAgregar.Enabled = valor;
            this.txtDisponible.ReadOnly = true;

        }
        private void HabilitarBotones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnGuardar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnQuitar.Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnGuardar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnQuitar.Enabled = false;
            }
        }
        /*private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;

        }*/
        /*private void Mostrar()
         {
             this.dataListado.DataSource = LSalidas.Mostrar();
             this.OcultarColumnas();
             labelTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

         }*/
        /* private void BuscarFecha()
         {
             dataListado.DataSource = LSalidas.BuscarFecha(dateTimePickerFechaInicio.Value.ToString("yyyy-MM-dd"), dateTimePickerFechaFin.Value.ToString("yyyy-MM-dd"));
             OcultarColumnas();
             labelTotal.Text = "Total Registros: " + dataListado.Rows.Count;
         }
        private void MostrarDetalles()
        {
            dataGridViewDetalle.DataSource = LSalidas.MostrarDetalleSalida(textIdsalida.Text);
        }*/
        private void creartabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("idedm", Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("edm", Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("workcenter", Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("linea", Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("cantidad_salida", Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("disponible", Type.GetType("System.Int32"));
            dataGridViewDetalle.DataSource = dtDetalle;
        }

        private void Salidas_Load(object sender, EventArgs e)
        {
            this.Top = 15;
            this.Left = 190;
            //this.Mostrar();
            this.Habilitar(false);
            this.HabilitarBotones();
            this.creartabla();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            VistaProductos vista = new VistaProductos();
            vista.Objeto = this;
            vista.ShowDialog();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
           //this.BuscarFecha();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.HabilitarBotones();
            this.Limpiar();
            this.LimpiarDetalle();
            this.Habilitar(true);
            this.txtCodigo.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifica que 
                if (this.txtProducto.Text == string.Empty)
                {
                    MensajeError("No has seleccionado un EDM");
                    btnProducto.Focus();
                }
                else if (validaCampos(txtCantidad.Text) > 1)
                {
                    MensajeError("Ingresa una cantidad valida");
                    txtCantidad.Focus();
                }
                else if (this.txtCantidad.Text == string.Empty)
                {
                    MensajeError("Ingrese cantidad");
                    txtCantidad.Focus();
                }
                else if (this.txtCodigo.Text == string.Empty)
                {
                    MensajeError("No ha ingreso un codgio");
                    txtCodigo.Focus();
                }
                else if (Convert.ToInt32(txtCantidad.Text) <= 0)
                {
                    MensajeError("Ingresa una cantidad valida.");
                    txtCantidad.Focus();
                }
               

                    bool registrar = true;
                   
                    if (registrar && Convert.ToInt32(txtDisponible.Text) == 0)
                    {
                        MensajeError("Sin stock");
                    }
                    
   
                    else if (registrar && Convert.ToInt32(txtCantidad.Text) > Convert.ToInt32(txtDisponible.Text))
                    {
                        MensajeError("No tenes stock suficiente");
                    }
                    else if (registrar && ((Convert.ToDecimal(txtDisponible.Text) - Convert.ToDecimal(txtCantidad.Text)) <= Convert.ToDecimal(txtMinimo.Text)))
                    {
                        if(dtDetalle.Rows.Count == 1)
                        {
                            MensajeError("Tienes elementos pendientes por guardar");
                        }
                        else
                        {

                    
                            MensajeWarning("Ya llegaste a tu stock minimo");
                            DataRow row = this.dtDetalle.NewRow();
                            row["idedm"] = this.txtID.Text;
                            row["edm"] = this.txtProducto.Text;
                            row["almacen"] = this.txtNomAlmacen.Text;
                            row["linea"] = this.txtLinea.Text;
                            row["cantidad_salida"] = Convert.ToInt32(this.txtCantidad.Text);
                            row["disponible"] = Convert.ToInt32(this.txtDisponible.Text);
                            this.dtDetalle.Rows.Add(row);
                        nuevo = Convert.ToInt32(this.txtDisponible.Text) - Convert.ToInt32(txtCantidad.Text);
                            this.LimpiarDetalle();
                            this.HabilitarBotones();
                             }
                    }
                    else
                    if (registrar && Convert.ToDecimal(txtCantidad.Text) <= Convert.ToDecimal(txtDisponible.Text))
                    {
                        if (registrar && Convert.ToDecimal(txtCantidad.Text) == 0)
                        {
                            MensajeError("Ingresa una cantidad valida");
                        }
                        else
                        {
                        if (dtDetalle.Rows.Count == 1)
                        {
                            MensajeError("Tienes elementos pendientes por guardar");
                        }
                        else
                        {
                            DataRow row = this.dtDetalle.NewRow();
                            row["idedm"] = this.txtID.Text;
                            row["edm"] = this.txtProducto.Text;
                            row["workcenter"] = this.txtNomAlmacen.Text;
                            row["linea"] = this.txtLinea.Text;
                            row["cantidad_salida"] = Convert.ToDecimal(this.txtCantidad.Text);
                            row["Disponible"] = Convert.ToDecimal(this.txtDisponible.Text);
                            this.dtDetalle.Rows.Add(row);
                            nuevo = Convert.ToInt32(this.txtDisponible.Text) - Convert.ToInt32(txtCantidad.Text);
                            this.HabilitarBotones();
                            this.LimpiarDetalle();
                        }
                        }

                    }
                    else
                    {
                        MensajeError("No tienes productos suficientes.");
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private int validaCampos(string text)
        {
            int contador = 0;
            char[] test = text.ToCharArray();
            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == '.')
                {
                    contador++;
                }
            }


            return contador;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";

                if (this.dtDetalle.Rows.Count == 0)
                {
                    MensajeError("No hay EDM's en la lista");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        CSalidas Objeto = new CSalidas();
                        
                        respuesta = Objeto.Insertar(IdUsuario, Convert.ToString( dateTimePickerFechaIngreso.Value).ToString(),txtCodigo.Text, dtDetalle, nuevo);
                    }
                    if (respuesta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.MensajeOk("Se inserto de forma correcta");
                        }
                    }
                    else
                    {
                        this.MensajeError(respuesta);
                    }
                    this.IsNuevo = false;
                    this.HabilitarBotones();
                    this.Limpiar();
                    this.LimpiarDetalle();
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
