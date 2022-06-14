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
    public partial class VistaProductos : Form
    {
        public Salidas Objeto;
        public Pedidos Objeto2;
        public VistaProductos()
        {
            InitializeComponent();
        }

        private void VistaProductos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns["Eliminar"].Visible = false;
            this.dataListado.Columns["id"].Visible = false;
            //this.dataListado.Columns["almacen"].Visible = false;
            this.dataListado.Columns["minimo"].Visible = false;
            this.dataListado.Columns["requerido"].Visible = false;
            this.dataListado.Columns["stock"].Visible = false;
        }
        private void Mostrar()
        {
            this.dataListado.DataSource = CProductos.Mostrar();
            this.OcultarColumnas();
            labelTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

        }
        private void BuscarProducto()
        {
            this.dataListado.DataSource = CProductos.Buscar(this.txtBusquedaEdm.Text);
            this.OcultarColumnas();
            labelTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarProducto();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            string parametro1, parametro2, parametro4, parametro6;
            int parametro5, parametro3, parametro7;
           
            

            if (Objeto != null)
            {
                //Salidas Fromulario = Salidas.GetInstancia() ;
                parametro1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Id"].Value);
                parametro2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
                parametro5 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["Requerido"].Value);
                parametro4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Almacen"].Value);
                parametro6 = Convert.ToString(this.dataListado.CurrentRow.Cells["Linea"].Value);
                parametro3 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["Minimo"].Value);
                parametro7 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["Stock"].Value);
                Objeto.setProducto(parametro1, parametro2, parametro5, parametro4, parametro6, parametro3, parametro7);
                Objeto = null;
                this.Hide();
            }
            else
            {
                parametro2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre"].Value);
                parametro6 = Convert.ToString(this.dataListado.CurrentRow.Cells["Linea"].Value);
                parametro7 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["Stock"].Value);
                parametro4 = Convert.ToString(this.dataListado.CurrentRow.Cells["Almacen"].Value);
                parametro1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Id"].Value);
                Objeto2.idAlmacen = Convert.ToString(this.dataListado.CurrentRow.Cells["idAlmacen"].Value);
                Objeto2.setPedido(parametro2, parametro4, parametro6, parametro7,parametro1);
                Objeto2=null;
                this.Hide();
            }
        }
    }
}
