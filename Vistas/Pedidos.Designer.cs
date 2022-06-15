
namespace Vistas
{
    partial class Pedidos
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtId = new System.Windows.Forms.TextBox();
            this.Proveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RRecibido = new System.Windows.Forms.RadioButton();
            this.RPendiente = new System.Windows.Forms.RadioButton();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnReporteProveedor = new System.Windows.Forms.Button();
            this.cmBoxReporteProveedor = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(-5, 81);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1065, 471);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmBoxReporteProveedor);
            this.tabPage2.Controls.Add(this.btnReporteProveedor);
            this.tabPage2.Controls.Add(this.dataListado);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1057, 442);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            this.dataListado.Location = new System.Drawing.Point(-1, 144);
            this.dataListado.Margin = new System.Windows.Forms.Padding(4);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.RowHeadersWidth = 51;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(1085, 319);
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
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtId);
            this.tabPage1.Controls.Add(this.Proveedor);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txtCantidad);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.RRecibido);
            this.tabPage1.Controls.Add(this.RPendiente);
            this.tabPage1.Controls.Add(this.btnProducto);
            this.tabPage1.Controls.Add(this.btnCancelar);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnGuardar);
            this.tabPage1.Controls.Add(this.btnNuevo);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.txtNombre);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1057, 442);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Registrar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(545, 148);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.MaxLength = 18;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(296, 22);
            this.txtId.TabIndex = 74;
            this.txtId.Visible = false;
            // 
            // Proveedor
            // 
            this.Proveedor.FormattingEnabled = true;
            this.Proveedor.Location = new System.Drawing.Point(145, 197);
            this.Proveedor.Margin = new System.Windows.Forms.Padding(4);
            this.Proveedor.Name = "Proveedor";
            this.Proveedor.Size = new System.Drawing.Size(300, 24);
            this.Proveedor.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Proveedor";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(144, 267);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(297, 22);
            this.txtCantidad.TabIndex = 71;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 276);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 70;
            this.label1.Text = "Cantidad";
            // 
            // RRecibido
            // 
            this.RRecibido.AutoSize = true;
            this.RRecibido.Location = new System.Drawing.Point(245, 329);
            this.RRecibido.Margin = new System.Windows.Forms.Padding(4);
            this.RRecibido.Name = "RRecibido";
            this.RRecibido.Size = new System.Drawing.Size(83, 20);
            this.RRecibido.TabIndex = 69;
            this.RRecibido.TabStop = true;
            this.RRecibido.Text = "Recibido";
            this.RRecibido.UseVisualStyleBackColor = true;
            // 
            // RPendiente
            // 
            this.RPendiente.AutoSize = true;
            this.RPendiente.Location = new System.Drawing.Point(48, 329);
            this.RPendiente.Margin = new System.Windows.Forms.Padding(4);
            this.RPendiente.Name = "RPendiente";
            this.RPendiente.Size = new System.Drawing.Size(89, 20);
            this.RPendiente.TabIndex = 68;
            this.RPendiente.TabStop = true;
            this.RPendiente.Text = "Pendiente";
            this.RPendiente.UseVisualStyleBackColor = true;
            // 
            // btnProducto
            // 
            this.btnProducto.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnProducto.Location = new System.Drawing.Point(451, 122);
            this.btnProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(44, 26);
            this.btnProducto.TabIndex = 65;
            this.btnProducto.UseVisualStyleBackColor = false;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(647, 366);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(132, 34);
            this.btnCancelar.TabIndex = 61;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEditar.Location = new System.Drawing.Point(161, 21);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(160, 34);
            this.btnEditar.TabIndex = 60;
            this.btnEditar.Text = "A&ctualizar Status";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.SystemColors.Control;
            this.btnGuardar.Location = new System.Drawing.Point(827, 366);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(132, 34);
            this.btnGuardar.TabIndex = 59;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNuevo.Location = new System.Drawing.Point(48, 21);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(83, 34);
            this.btnNuevo.TabIndex = 58;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(53, 121);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 16);
            this.label19.TabIndex = 35;
            this.label19.Text = "Producto";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(145, 119);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 18;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(296, 22);
            this.txtNombre.TabIndex = 37;
            // 
            // btnReporteProveedor
            // 
            this.btnReporteProveedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnReporteProveedor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReporteProveedor.Location = new System.Drawing.Point(883, 363);
            this.btnReporteProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporteProveedor.Name = "btnReporteProveedor";
            this.btnReporteProveedor.Size = new System.Drawing.Size(144, 34);
            this.btnReporteProveedor.TabIndex = 65;
            this.btnReporteProveedor.Text = "Generar Reporte";
            this.btnReporteProveedor.UseVisualStyleBackColor = false;
            this.btnReporteProveedor.Click += new System.EventHandler(this.btnReporteProveedor_Click);
            // 
            // cmBoxReporteProveedor
            // 
            this.cmBoxReporteProveedor.FormattingEnabled = true;
            this.cmBoxReporteProveedor.Location = new System.Drawing.Point(549, 369);
            this.cmBoxReporteProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.cmBoxReporteProveedor.Name = "cmBoxReporteProveedor";
            this.cmBoxReporteProveedor.Size = new System.Drawing.Size(300, 24);
            this.cmBoxReporteProveedor.TabIndex = 74;
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 553);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pedidos";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.RadioButton RRecibido;
        private System.Windows.Forms.RadioButton RPendiente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Proveedor;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnReporteProveedor;
        private System.Windows.Forms.ComboBox cmBoxReporteProveedor;
    }
}