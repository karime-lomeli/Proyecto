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
    public partial class Usuarios : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;

        public Usuarios()
        {
            InitializeComponent();
        }
        public void Mostrar()
        {
            CUsuario Objeto = new CUsuario();
            this.dataListado.DataSource = Objeto.Mostrar();
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
            this.txtApellido.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.Acceso.Text = string.Empty;
            this.txtPass.Text = string.Empty;

        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns["Id"].Visible = false;
        }
        private void Habilitar(bool valor)
        {
            this.txtId.ReadOnly = !valor;
            this.txtNombre.ReadOnly = !valor;
            this.txtApellido.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.Acceso.Enabled = valor;
            this.txtPass.ReadOnly = !valor;
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

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 177;

            this.Mostrar();
            this.Habilitar(false);
            this.HabilitarBotones();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string respuesta = "";
                if (this.txtNombre.Text == string.Empty || this.txtApellido.Text == string.Empty  ||
                    this.txtPass.Text == string.Empty )
                {
                    MensajeError("Faltan datos");
                }
                else
                {
                    if (this.IsNuevo)
                    {
                        respuesta = CUsuario.Insertar(this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellido.Text.Trim().ToUpper(),
                            this.txtEmail.Text.Trim(),
                            this.Acceso.Text,
                            this.txtPass.Text);
                    }
                    else
                    {
                        respuesta = CUsuario.Editar(this.txtId.Text,
                            this.txtNombre.Text.Trim().ToUpper(),
                            this.txtApellido.Text.Trim().ToUpper(),
                            this.txtEmail.Text.Trim(),
                            this.Acceso.Text,
                            this.txtPass.Text);

                    }
                    if (respuesta.Equals("Hola"))
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
            this.txtApellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Apellido"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Email"].Value);
            
            this.Acceso.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Acceso"].Value);
            this.txtPass.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Password"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Se Eliminaran los usuarios seleccionados", "Sistema de EDMs", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)

                {
                    string Id;
                    string Respuesta = "";

                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Id = Convert.ToString(row.Cells[1].Value);
                            Respuesta = CUsuario.Eliminar(Id);

                            if (Respuesta.Equals("OK"))
                            {
                                this.MensajeOk("Usuario eliminado Correctamente");
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
    }
}
