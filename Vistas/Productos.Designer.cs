
namespace Vistas
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.checkEliminar = new System.Windows.Forms.CheckBox();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelNoParte = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Almacen = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.txtS = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtMinimo = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtRequerido = new System.Windows.Forms.TextBox();
            this.Linea = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(454, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 33);
            this.label5.TabIndex = 3;
            this.label5.Text = "Productos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 144);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 431);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnEliminar);
            this.tabPage2.Controls.Add(this.checkEliminar);
            this.tabPage2.Controls.Add(this.dataListado);
            this.tabPage2.Controls.Add(this.labelNoParte);
            this.tabPage2.Controls.Add(this.txtBuscar);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1088, 402);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(957, 26);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(116, 34);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // checkEliminar
            // 
            this.checkEliminar.AutoSize = true;
            this.checkEliminar.Location = new System.Drawing.Point(0, 84);
            this.checkEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkEliminar.Name = "checkEliminar";
            this.checkEliminar.Size = new System.Drawing.Size(77, 20);
            this.checkEliminar.TabIndex = 14;
            this.checkEliminar.Text = "Eliminar";
            this.checkEliminar.UseVisualStyleBackColor = true;
            this.checkEliminar.CheckedChanged += new System.EventHandler(this.checkEliminar_CheckedChanged);
            // 
            // dataListado
            // 
            this.dataListado.AllowUserToAddRows = false;
            this.dataListado.AllowUserToDeleteRows = false;
            this.dataListado.AllowUserToOrderColumns = true;
            this.dataListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataListado.BackgroundColor = System.Drawing.Color.White;
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(0, 128);
            this.dataListado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersWidth = 51;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(1085, 267);
            this.dataListado.TabIndex = 13;
            this.dataListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataListado_CellContentClick);
            this.dataListado.DoubleClick += new System.EventHandler(this.dataListado_DoubleClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // labelNoParte
            // 
            this.labelNoParte.AutoSize = true;
            this.labelNoParte.Location = new System.Drawing.Point(299, 36);
            this.labelNoParte.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNoParte.Name = "labelNoParte";
            this.labelNoParte.Size = new System.Drawing.Size(61, 16);
            this.labelNoParte.TabIndex = 4;
            this.labelNoParte.Text = "Producto";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(385, 32);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(293, 22);
            this.txtBuscar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(723, 26);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 34);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Almacen);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.txtS);
            this.tabPage1.Controls.Add(this.txtStock);
            this.tabPage1.Controls.Add(this.txtDescripcion);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.txtMinimo);
            this.tabPage1.Controls.Add(this.txtMin);
            this.tabPage1.Controls.Add(this.txtRequerido);
            this.tabPage1.Controls.Add(this.Linea);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1088, 402);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Almacen
            // 
            this.Almacen.FormattingEnabled = true;
            this.Almacen.Location = new System.Drawing.Point(141, 100);
            this.Almacen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Almacen.Name = "Almacen";
            this.Almacen.Size = new System.Drawing.Size(284, 24);
            this.Almacen.TabIndex = 62;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(899, 238);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 34);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(899, 171);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(132, 34);
            this.btnEditar.TabIndex = 60;
            this.btnEditar.Text = "A&ctualizar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(899, 103);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 34);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(899, 31);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(132, 34);
            this.btnNuevo.TabIndex = 58;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(596, 320);
            this.txtS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(119, 22);
            this.txtS.TabIndex = 55;
            // 
            // txtStock
            // 
            this.txtStock.AutoSize = true;
            this.txtStock.Location = new System.Drawing.Point(541, 329);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(41, 16);
            this.txtStock.TabIndex = 54;
            this.txtStock.Text = "Stock";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(485, 76);
            this.txtDescripcion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(335, 110);
            this.txtDescripcion.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(481, 46);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 50;
            this.label14.Text = "Descripción";
            // 
            // txtMinimo
            // 
            this.txtMinimo.AutoSize = true;
            this.txtMinimo.Location = new System.Drawing.Point(280, 329);
            this.txtMinimo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtMinimo.Name = "txtMinimo";
            this.txtMinimo.Size = new System.Drawing.Size(50, 16);
            this.txtMinimo.TabIndex = 53;
            this.txtMinimo.Text = "Minimo";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(353, 320);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(112, 22);
            this.txtMin.TabIndex = 52;
            // 
            // txtRequerido
            // 
            this.txtRequerido.Location = new System.Drawing.Point(112, 320);
            this.txtRequerido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRequerido.Name = "txtRequerido";
            this.txtRequerido.Size = new System.Drawing.Size(116, 22);
            this.txtRequerido.TabIndex = 43;
            // 
            // Linea
            // 
            this.Linea.FormattingEnabled = true;
            this.Linea.Location = new System.Drawing.Point(141, 161);
            this.Linea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Linea.Name = "Linea";
            this.Linea.Size = new System.Drawing.Size(284, 24);
            this.Linea.TabIndex = 41;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(29, 171);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 16);
            this.label16.TabIndex = 40;
            this.label16.Text = "Línea";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(29, 329);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 16);
            this.label17.TabIndex = 42;
            this.label17.Text = "Requerido";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(29, 41);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 35;
            this.label19.Text = "Producto";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(141, 37);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(27, 22);
            this.txtId.TabIndex = 36;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 103);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(60, 16);
            this.label20.TabIndex = 38;
            this.label20.Text = "Almacen";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 37);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MaxLength = 18;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(248, 22);
            this.txtNombre.TabIndex = 37;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1097, 572);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelNoParte;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.CheckBox checkEliminar;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox Almacen;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label txtStock;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtMinimo;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtRequerido;
        private System.Windows.Forms.ComboBox Linea;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtNombre;
    }
}