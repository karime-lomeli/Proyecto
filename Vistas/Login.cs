﻿using System;
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
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Prueba objeto = new Prueba();

            this.label1.Text = objeto.inicio();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Dashwork", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable Datos = CUsuario.Login(this.txtCorreo.Text, this.txtPass.Text);

            if (Datos.Rows.Count==0)
            {
                MensajeError("Datos incorrectos");
            }
            
            else
            {

               
                Form1 Form = new Form1();
                Form.IdUsuario = Datos.Rows[0][0].ToString();
                Form.Apellidos = Datos.Rows[0][1].ToString();
                Form.Nombre = Datos.Rows[0][2].ToString();
                Form.Acceso = Datos.Rows[0][3].ToString();
                Form.Show();
                Hide();
            }
        }
    }
}
