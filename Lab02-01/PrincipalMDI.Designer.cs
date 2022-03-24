
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRegistrarCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReReporteVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReReporteCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReInventarioProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReReporteProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReReporteUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReReporteClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSisSalirSistem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(779, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes,
            this.mnuSalir});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 24);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(174, 26);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(174, 26);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(174, 26);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(174, 26);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(174, 26);
            this.mnuManClientes.Text = "Clientes";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(174, 26);
            this.mnuSalir.Text = "Salir";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRegistrarVenta,
            this.mnuProRegistrarCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProRegistrarVenta
            // 
            this.mnuProRegistrarVenta.Name = "mnuProRegistrarVenta";
            this.mnuProRegistrarVenta.Size = new System.Drawing.Size(208, 26);
            this.mnuProRegistrarVenta.Text = "Registrar Venta";
            // 
            // mnuProRegistrarCompra
            // 
            this.mnuProRegistrarCompra.Name = "mnuProRegistrarCompra";
            this.mnuProRegistrarCompra.Size = new System.Drawing.Size(208, 26);
            this.mnuProRegistrarCompra.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuReReporteVentas,
            this.mnuReReporteCompras,
            this.mnuReInventarioProductos,
            this.mnuReReporteProveedores,
            this.mnuReReporteUsuarios,
            this.mnuReReporteClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuReReporteVentas
            // 
            this.mnuReReporteVentas.Name = "mnuReReporteVentas";
            this.mnuReReporteVentas.Size = new System.Drawing.Size(252, 26);
            this.mnuReReporteVentas.Text = "Reporte de Ventas";
            // 
            // mnuReReporteCompras
            // 
            this.mnuReReporteCompras.Name = "mnuReReporteCompras";
            this.mnuReReporteCompras.Size = new System.Drawing.Size(252, 26);
            this.mnuReReporteCompras.Text = "Reporte de Compras";
            // 
            // mnuReInventarioProductos
            // 
            this.mnuReInventarioProductos.Name = "mnuReInventarioProductos";
            this.mnuReInventarioProductos.Size = new System.Drawing.Size(252, 26);
            this.mnuReInventarioProductos.Text = "Inventario de Productos";
            // 
            // mnuReReporteProveedores
            // 
            this.mnuReReporteProveedores.Name = "mnuReReporteProveedores";
            this.mnuReReporteProveedores.Size = new System.Drawing.Size(252, 26);
            this.mnuReReporteProveedores.Text = "Reporte de Proveedores";
            // 
            // mnuReReporteUsuarios
            // 
            this.mnuReReporteUsuarios.Name = "mnuReReporteUsuarios";
            this.mnuReReporteUsuarios.Size = new System.Drawing.Size(252, 26);
            this.mnuReReporteUsuarios.Text = "Reporte de Usuarios";
            // 
            // mnuReReporteClientes
            // 
            this.mnuReReporteClientes.Name = "mnuReReporteClientes";
            this.mnuReReporteClientes.Size = new System.Drawing.Size(252, 26);
            this.mnuReReporteClientes.Text = "Reporte de Clientes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSisSalirSistem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSisSalirSistem
            // 
            this.mnuSisSalirSistem.Name = "mnuSisSalirSistem";
            this.mnuSisSalirSistem.Size = new System.Drawing.Size(224, 26);
            this.mnuSisSalirSistem.Text = "Salir del Sistema";
            this.mnuSisSalirSistem.Click += new System.EventHandler(this.mnuSisSalirSistem_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRegistrarCompra;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuReReporteVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuReReporteCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuReInventarioProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuReReporteProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuReReporteUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuReReporteClientes;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSisSalirSistem;
    }
}