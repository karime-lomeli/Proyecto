
namespace Vistas
{
    partial class Salidas
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
            this.dateTimePickerFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.labelTotal = new System.Windows.Forms.Label();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bBuscar = new System.Windows.Forms.Button();
            this.labelNoParte = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewDetalle = new System.Windows.Forms.DataGridView();
            this.bCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxStockMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLinea = new System.Windows.Forms.TextBox();
            this.textBoxIdworkcenter = new System.Windows.Forms.TextBox();
            this.textBoxWorkcenter = new System.Windows.Forms.TextBox();
            this.textBoxStockInicial = new System.Windows.Forms.TextBox();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonEdm = new System.Windows.Forms.Button();
            this.textBoxIdEdm = new System.Windows.Forms.TextBox();
            this.textBoxEdm = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonQuitar = new System.Windows.Forms.Button();
            this.textBoxCorrelativo = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.dateTimePickerFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.k = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bGuardad = new System.Windows.Forms.Button();
            this.bNuevonp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(933, 378);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateTimePickerFechaFin);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dateTimePickerFechaInicio);
            this.tabPage2.Controls.Add(this.labelTotal);
            this.tabPage2.Controls.Add(this.dataListado);
            this.tabPage2.Controls.Add(this.bBuscar);
            this.tabPage2.Controls.Add(this.labelNoParte);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(925, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Salidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaFin
            // 
            this.dateTimePickerFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaFin.Location = new System.Drawing.Point(401, 33);
            this.dateTimePickerFechaFin.Name = "dateTimePickerFechaFin";
            this.dateTimePickerFechaFin.Size = new System.Drawing.Size(132, 21);
            this.dateTimePickerFechaFin.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(398, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Fecha fin de busqueda";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(179, 33);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(147, 21);
            this.dateTimePickerFechaInicio.TabIndex = 14;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(536, 329);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 16);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "label4";
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
            this.dataListado.Location = new System.Drawing.Point(3, 84);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(916, 242);
            this.dataListado.TabIndex = 11;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(637, 26);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(87, 28);
            this.bBuscar.TabIndex = 8;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // labelNoParte
            // 
            this.labelNoParte.AutoSize = true;
            this.labelNoParte.Location = new System.Drawing.Point(176, 14);
            this.labelNoParte.Name = "labelNoParte";
            this.labelNoParte.Size = new System.Drawing.Size(150, 16);
            this.labelNoParte.TabIndex = 7;
            this.labelNoParte.Text = "Fecha inicio de busqueda";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewDetalle);
            this.tabPage3.Controls.Add(this.bCancelar);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.bGuardad);
            this.tabPage3.Controls.Add(this.bNuevonp);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(925, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Registro";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDetalle
            // 
            this.dataGridViewDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalle.Location = new System.Drawing.Point(18, 229);
            this.dataGridViewDetalle.Name = "dataGridViewDetalle";
            this.dataGridViewDetalle.Size = new System.Drawing.Size(741, 117);
            this.dataGridViewDetalle.TabIndex = 13;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(797, 181);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(99, 28);
            this.bCancelar.TabIndex = 12;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxStockMinimo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBoxLinea);
            this.groupBox2.Controls.Add(this.textBoxIdworkcenter);
            this.groupBox2.Controls.Add(this.textBoxWorkcenter);
            this.groupBox2.Controls.Add(this.textBoxStockInicial);
            this.groupBox2.Controls.Add(this.textBoxCantidad);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.buttonEdm);
            this.groupBox2.Controls.Add(this.textBoxIdEdm);
            this.groupBox2.Controls.Add(this.textBoxEdm);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(18, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(741, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles";
            // 
            // textBoxStockMinimo
            // 
            this.textBoxStockMinimo.Location = new System.Drawing.Point(465, 83);
            this.textBoxStockMinimo.Name = "textBoxStockMinimo";
            this.textBoxStockMinimo.Size = new System.Drawing.Size(69, 21);
            this.textBoxStockMinimo.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Stock Mínimo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Stock Disponible";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 16);
            this.label9.TabIndex = 52;
            this.label9.Text = "Línea";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 51;
            this.label8.Text = "Almacen";
            // 
            // textBoxLinea
            // 
            this.textBoxLinea.Location = new System.Drawing.Point(77, 88);
            this.textBoxLinea.Name = "textBoxLinea";
            this.textBoxLinea.Size = new System.Drawing.Size(210, 21);
            this.textBoxLinea.TabIndex = 50;
            // 
            // textBoxIdworkcenter
            // 
            this.textBoxIdworkcenter.Location = new System.Drawing.Point(106, 62);
            this.textBoxIdworkcenter.Name = "textBoxIdworkcenter";
            this.textBoxIdworkcenter.Size = new System.Drawing.Size(181, 21);
            this.textBoxIdworkcenter.TabIndex = 49;
            // 
            // textBoxWorkcenter
            // 
            this.textBoxWorkcenter.Location = new System.Drawing.Point(77, 61);
            this.textBoxWorkcenter.Name = "textBoxWorkcenter";
            this.textBoxWorkcenter.Size = new System.Drawing.Size(22, 21);
            this.textBoxWorkcenter.TabIndex = 48;
            // 
            // textBoxStockInicial
            // 
            this.textBoxStockInicial.Location = new System.Drawing.Point(465, 29);
            this.textBoxStockInicial.Name = "textBoxStockInicial";
            this.textBoxStockInicial.Size = new System.Drawing.Size(69, 21);
            this.textBoxStockInicial.TabIndex = 46;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(643, 71);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(69, 21);
            this.textBoxCantidad.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(575, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Cantidad";
            // 
            // buttonEdm
            // 
            this.buttonEdm.Location = new System.Drawing.Point(264, 32);
            this.buttonEdm.Name = "buttonEdm";
            this.buttonEdm.Size = new System.Drawing.Size(33, 21);
            this.buttonEdm.TabIndex = 24;
            this.buttonEdm.UseVisualStyleBackColor = true;
            // 
            // textBoxIdEdm
            // 
            this.textBoxIdEdm.Location = new System.Drawing.Point(48, 32);
            this.textBoxIdEdm.Name = "textBoxIdEdm";
            this.textBoxIdEdm.Size = new System.Drawing.Size(22, 21);
            this.textBoxIdEdm.TabIndex = 23;
            // 
            // textBoxEdm
            // 
            this.textBoxEdm.Location = new System.Drawing.Point(77, 32);
            this.textBoxEdm.Name = "textBoxEdm";
            this.textBoxEdm.Size = new System.Drawing.Size(181, 21);
            this.textBoxEdm.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "EDM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.buttonQuitar);
            this.groupBox1.Controls.Add(this.textBoxCorrelativo);
            this.groupBox1.Controls.Add(this.buttonAgregar);
            this.groupBox1.Controls.Add(this.dateTimePickerFechaIngreso);
            this.groupBox1.Controls.Add(this.k);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(18, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 92);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Salidas ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 16);
            this.label10.TabIndex = 21;
            this.label10.Text = "Código";
            // 
            // buttonQuitar
            // 
            this.buttonQuitar.Location = new System.Drawing.Point(486, 35);
            this.buttonQuitar.Name = "buttonQuitar";
            this.buttonQuitar.Size = new System.Drawing.Size(99, 28);
            this.buttonQuitar.TabIndex = 14;
            this.buttonQuitar.Text = "Quitar";
            this.buttonQuitar.UseVisualStyleBackColor = true;
            // 
            // textBoxCorrelativo
            // 
            this.textBoxCorrelativo.Location = new System.Drawing.Point(264, 38);
            this.textBoxCorrelativo.MaxLength = 9;
            this.textBoxCorrelativo.Name = "textBoxCorrelativo";
            this.textBoxCorrelativo.Size = new System.Drawing.Size(180, 21);
            this.textBoxCorrelativo.TabIndex = 20;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(600, 35);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(99, 28);
            this.buttonAgregar.TabIndex = 13;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerFechaIngreso
            // 
            this.dateTimePickerFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFechaIngreso.Location = new System.Drawing.Point(60, 60);
            this.dateTimePickerFechaIngreso.Name = "dateTimePickerFechaIngreso";
            this.dateTimePickerFechaIngreso.Size = new System.Drawing.Size(108, 21);
            this.dateTimePickerFechaIngreso.TabIndex = 15;
            // 
            // k
            // 
            this.k.AutoSize = true;
            this.k.Location = new System.Drawing.Point(9, 64);
            this.k.Name = "k";
            this.k.Size = new System.Drawing.Size(45, 16);
            this.k.TabIndex = 6;
            this.k.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 4;
            // 
            // bGuardad
            // 
            this.bGuardad.Location = new System.Drawing.Point(797, 126);
            this.bGuardad.Name = "bGuardad";
            this.bGuardad.Size = new System.Drawing.Size(99, 28);
            this.bGuardad.TabIndex = 10;
            this.bGuardad.Text = "&Guardar";
            this.bGuardad.UseVisualStyleBackColor = true;
            // 
            // bNuevonp
            // 
            this.bNuevonp.Location = new System.Drawing.Point(797, 69);
            this.bNuevonp.Name = "bNuevonp";
            this.bNuevonp.Size = new System.Drawing.Size(99, 28);
            this.bNuevonp.TabIndex = 9;
            this.bNuevonp.Text = "&Nuevo";
            this.bNuevonp.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(397, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "SALIDAS PRODUCTOS";
            // 
            // Salidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 465);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Location = new System.Drawing.Point(200, 0);
            this.Name = "Salidas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Label labelNoParte;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewDetalle;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxStockMinimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLinea;
        private System.Windows.Forms.TextBox textBoxIdworkcenter;
        private System.Windows.Forms.TextBox textBoxWorkcenter;
        private System.Windows.Forms.TextBox textBoxStockInicial;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonEdm;
        private System.Windows.Forms.TextBox textBoxIdEdm;
        private System.Windows.Forms.TextBox textBoxEdm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonQuitar;
        private System.Windows.Forms.TextBox textBoxCorrelativo;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaIngreso;
        private System.Windows.Forms.Label k;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bGuardad;
        private System.Windows.Forms.Button bNuevonp;
        private System.Windows.Forms.Label label1;
    }
}