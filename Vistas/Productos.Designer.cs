
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataListado = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtBusquedaEdm = new System.Windows.Forms.TextBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.total_global = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxRfaMinimo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboWork = new System.Windows.Forms.ComboBox();
            this.textBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textIdedm = new System.Windows.Forms.TextBox();
            this.textNombreedm = new System.Windows.Forms.TextBox();
            this.bNuevonp = new System.Windows.Forms.Button();
            this.bGuardad = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(936, 390);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.bEliminar);
            this.tabPage1.Controls.Add(this.bBuscar);
            this.tabPage1.Controls.Add(this.txtBusquedaEdm);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(951, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bCancelar);
            this.tabPage2.Controls.Add(this.bEditar);
            this.tabPage2.Controls.Add(this.bGuardad);
            this.tabPage2.Controls.Add(this.bNuevonp);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.dataListado);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(928, 364);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registrar";
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
            this.dataListado.Location = new System.Drawing.Point(0, 149);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(0, 0);
            this.dataListado.TabIndex = 13;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(0, 0);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
            this.dataGridView2.Location = new System.Drawing.Point(0, 161);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(918, 266);
            this.dataGridView2.TabIndex = 14;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Eliminar";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.ReadOnly = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(9, 138);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "Eliminar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtBusquedaEdm
            // 
            this.txtBusquedaEdm.Location = new System.Drawing.Point(318, 96);
            this.txtBusquedaEdm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusquedaEdm.Name = "txtBusquedaEdm";
            this.txtBusquedaEdm.Size = new System.Drawing.Size(221, 20);
            this.txtBusquedaEdm.TabIndex = 17;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(570, 91);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(87, 28);
            this.bBuscar.TabIndex = 18;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(762, 91);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(87, 28);
            this.bEliminar.TabIndex = 19;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Productos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Producto";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.total_global);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textDescripcion);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.textBoxRfaMinimo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.comboWork);
            this.groupBox2.Controls.Add(this.textBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.textIdedm);
            this.groupBox2.Controls.Add(this.textNombreedm);
            this.groupBox2.Location = new System.Drawing.Point(8, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 317);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // total_global
            // 
            this.total_global.Location = new System.Drawing.Point(468, 238);
            this.total_global.Name = "total_global";
            this.total_global.Size = new System.Drawing.Size(100, 20);
            this.total_global.TabIndex = 49;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(406, 238);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 48;
            this.label21.Text = "Stock";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(363, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 46;
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(390, 66);
            this.textDescripcion.Multiline = true;
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(350, 100);
            this.textDescripcion.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(387, 41);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Descripción";
            // 
            // textBoxRfaMinimo
            // 
            this.textBoxRfaMinimo.Location = new System.Drawing.Point(86, 231);
            this.textBoxRfaMinimo.Name = "textBoxRfaMinimo";
            this.textBoxRfaMinimo.Size = new System.Drawing.Size(88, 20);
            this.textBoxRfaMinimo.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(210, 234);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Minimo";
            // 
            // comboWork
            // 
            this.comboWork.FormattingEnabled = true;
            this.comboWork.Location = new System.Drawing.Point(115, 142);
            this.comboWork.Name = "comboWork";
            this.comboWork.Size = new System.Drawing.Size(214, 21);
            this.comboWork.TabIndex = 15;
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(256, 231);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(85, 20);
            this.textBox.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(31, 150);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 13);
            this.label16.TabIndex = 13;
            this.label16.Text = "Workcenter";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(32, 234);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(56, 13);
            this.label17.TabIndex = 31;
            this.label17.Text = "Requerido";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 69);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 13);
            this.label18.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(31, 44);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(31, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "EDM";
            // 
            // textIdedm
            // 
            this.textIdedm.Enabled = false;
            this.textIdedm.Location = new System.Drawing.Point(115, 41);
            this.textIdedm.Name = "textIdedm";
            this.textIdedm.Size = new System.Drawing.Size(21, 20);
            this.textIdedm.TabIndex = 3;
            // 
            // textNombreedm
            // 
            this.textNombreedm.Location = new System.Drawing.Point(142, 41);
            this.textNombreedm.MaxLength = 18;
            this.textNombreedm.Name = "textNombreedm";
            this.textNombreedm.Size = new System.Drawing.Size(187, 20);
            this.textNombreedm.TabIndex = 4;
            // 
            // bNuevonp
            // 
            this.bNuevonp.Location = new System.Drawing.Point(819, 85);
            this.bNuevonp.Name = "bNuevonp";
            this.bNuevonp.Size = new System.Drawing.Size(99, 28);
            this.bNuevonp.TabIndex = 23;
            this.bNuevonp.Text = "&Nuevo";
            this.bNuevonp.UseVisualStyleBackColor = true;
            // 
            // bGuardad
            // 
            this.bGuardad.Location = new System.Drawing.Point(819, 154);
            this.bGuardad.Name = "bGuardad";
            this.bGuardad.Size = new System.Drawing.Size(99, 28);
            this.bGuardad.TabIndex = 24;
            this.bGuardad.Text = "&Guardar";
            this.bGuardad.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(819, 229);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(99, 28);
            this.bEditar.TabIndex = 25;
            this.bEditar.Text = "A&ctualizar";
            this.bEditar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(819, 319);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(99, 28);
            this.bCancelar.TabIndex = 26;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Almacén";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 89);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 21);
            this.comboBox1.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(392, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Productos";
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tabControl1);
            this.Name = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox txtBusquedaEdm;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bGuardad;
        private System.Windows.Forms.Button bNuevonp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox total_global;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxRfaMinimo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboWork;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textIdedm;
        private System.Windows.Forms.TextBox textNombreedm;
        private System.Windows.Forms.Label label5;
    }
}