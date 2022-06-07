
namespace Vistas
{
     partial class Form1
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAlmacen = new System.Windows.Forms.ToolStripMenuItem();
            this.eDMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.workcenterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(156)))), ((int)(((byte)(220)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.MenuAlmacen,
            this.MenuUsuario,
            this.windowsMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.ForeColor = System.Drawing.Color.White;
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(41, 20);
            this.fileMenu.Text = "&Salir";
            // 
            // MenuAlmacen
            // 
            this.MenuAlmacen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eDMToolStripMenuItem,
            this.workcenterToolStripMenuItem});
            this.MenuAlmacen.Enabled = false;
            this.MenuAlmacen.ForeColor = System.Drawing.Color.White;
            this.MenuAlmacen.Name = "MenuAlmacen";
            this.MenuAlmacen.Size = new System.Drawing.Size(66, 20);
            this.MenuAlmacen.Text = "&Almacen";
            // 
            // eDMToolStripMenuItem
            // 
            this.eDMToolStripMenuItem.Name = "eDMToolStripMenuItem";
            this.eDMToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.eDMToolStripMenuItem.Text = "EDM";
            // 
            // workcenterToolStripMenuItem
            // 
            this.workcenterToolStripMenuItem.Name = "workcenterToolStripMenuItem";
            this.workcenterToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.workcenterToolStripMenuItem.Text = "Workcenter";
            // 
            // MenuUsuario
            // 
            this.MenuUsuario.Enabled = false;
            this.MenuUsuario.ForeColor = System.Drawing.Color.White;
            this.MenuUsuario.Name = "MenuUsuario";
            this.MenuUsuario.Size = new System.Drawing.Size(64, 20);
            this.MenuUsuario.Text = "Usuarios";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeAllToolStripMenuItem});
            this.windowsMenu.ForeColor = System.Drawing.Color.White;
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAlmacen;
        private System.Windows.Forms.ToolStripMenuItem eDMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem workcenterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuUsuario;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
    }
}