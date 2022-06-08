
namespace Vistas
{
    partial class Usuarios
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
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.labelNoParte = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bCancelar = new System.Windows.Forms.Button();
            this.bEditar = new System.Windows.Forms.Button();
            this.bGuardad = new System.Windows.Forms.Button();
            this.bNuevonp = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textIdusuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboAcceso = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 102);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 350);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelNoParte);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.bEliminar);
            this.tabPage1.Controls.Add(this.txtBusqueda);
            this.tabPage1.Controls.Add(this.dataListado);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(920, 324);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textPass);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textEmail);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.textApellido);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.bCancelar);
            this.tabPage2.Controls.Add(this.bEditar);
            this.tabPage2.Controls.Add(this.bGuardad);
            this.tabPage2.Controls.Add(this.bNuevonp);
            this.tabPage2.Controls.Add(this.textNombre);
            this.tabPage2.Controls.Add(this.textIdusuario);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.comboAcceso);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 324);
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
            this.dataListado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataListado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar});
            this.dataListado.Location = new System.Drawing.Point(3, 88);
            this.dataListado.MultiSelect = false;
            this.dataListado.Name = "dataListado";
            this.dataListado.ReadOnly = true;
            this.dataListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataListado.Size = new System.Drawing.Size(906, 210);
            this.dataListado.TabIndex = 5;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(288, 48);
            this.txtBusqueda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(325, 20);
            this.txtBusqueda.TabIndex = 6;
            // 
            // bEliminar
            // 
            this.bEliminar.Location = new System.Drawing.Point(793, 40);
            this.bEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(87, 28);
            this.bEliminar.TabIndex = 7;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(62, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Eliminar";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // labelNoParte
            // 
            this.labelNoParte.AutoSize = true;
            this.labelNoParte.Location = new System.Drawing.Point(225, 52);
            this.labelNoParte.Name = "labelNoParte";
            this.labelNoParte.Size = new System.Drawing.Size(44, 13);
            this.labelNoParte.TabIndex = 9;
            this.labelNoParte.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "USUARIOS";
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(467, 131);
            this.textPass.Name = "textPass";
            this.textPass.Size = new System.Drawing.Size(123, 20);
            this.textPass.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 184);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Acceso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 32;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(149, 226);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(202, 20);
            this.textEmail.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Correo";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(149, 181);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(202, 20);
            this.textApellido.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apellido";
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(737, 219);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(99, 28);
            this.bCancelar.TabIndex = 27;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // bEditar
            // 
            this.bEditar.Location = new System.Drawing.Point(737, 172);
            this.bEditar.Name = "bEditar";
            this.bEditar.Size = new System.Drawing.Size(99, 28);
            this.bEditar.TabIndex = 26;
            this.bEditar.Text = "E&ditar";
            this.bEditar.UseVisualStyleBackColor = true;
            // 
            // bGuardad
            // 
            this.bGuardad.Location = new System.Drawing.Point(737, 126);
            this.bGuardad.Name = "bGuardad";
            this.bGuardad.Size = new System.Drawing.Size(99, 28);
            this.bGuardad.TabIndex = 25;
            this.bGuardad.Text = "&Guardar";
            this.bGuardad.UseVisualStyleBackColor = true;
            // 
            // bNuevonp
            // 
            this.bNuevonp.Location = new System.Drawing.Point(737, 78);
            this.bNuevonp.Name = "bNuevonp";
            this.bNuevonp.Size = new System.Drawing.Size(99, 28);
            this.bNuevonp.TabIndex = 24;
            this.bNuevonp.Text = "&Nuevo";
            this.bNuevonp.UseVisualStyleBackColor = true;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(149, 131);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(202, 20);
            this.textNombre.TabIndex = 23;
            // 
            // textIdusuario
            // 
            this.textIdusuario.Enabled = false;
            this.textIdusuario.Location = new System.Drawing.Point(152, 85);
            this.textIdusuario.Name = "textIdusuario";
            this.textIdusuario.Size = new System.Drawing.Size(103, 20);
            this.textIdusuario.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Id Usuario";
            // 
            // comboAcceso
            // 
            this.comboAcceso.AutoCompleteCustomSource.AddRange(new string[] {
            "Manager",
            "Administrador",
            "Usuario"});
            this.comboAcceso.FormattingEnabled = true;
            this.comboAcceso.Items.AddRange(new object[] {
            "Manager",
            "Administrador",
            "Usuario"});
            this.comboAcceso.Location = new System.Drawing.Point(454, 181);
            this.comboAcceso.Name = "comboAcceso";
            this.comboAcceso.Size = new System.Drawing.Size(136, 21);
            this.comboAcceso.TabIndex = 37;
            this.comboAcceso.Text = "Manager";
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(943, 473);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelNoParte;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.DataGridView dataListado;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Eliminar;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.Button bEditar;
        private System.Windows.Forms.Button bGuardad;
        private System.Windows.Forms.Button bNuevonp;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textIdusuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboAcceso;
        private System.Windows.Forms.Label label1;
    }
}