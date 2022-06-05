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
    }
}
