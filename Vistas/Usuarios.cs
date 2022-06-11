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

            //this.Mostrar();
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
