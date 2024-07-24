namespace PuntoDeVenta
{
    partial class ventanaPrincipal
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
            btnCerrar = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            abrirFacturaToolStripMenuItem = new ToolStripMenuItem();
            impVentaToolStripMenuItem = new ToolStripMenuItem();
            txtImpuestoMenu = new ToolStripTextBox();
            descuentoToolStripMenuItem = new ToolStripMenuItem();
            txtDescuentoMenu = new ToolStripTextBox();
            btn_menu_usuarios = new ToolStripMenuItem();
            btn_menu_inventario = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            historialDeFacturasToolStripMenuItem = new ToolStripMenuItem();
            imageTill = new PictureBox();
            lblProducto = new Label();
            txtProducto = new TextBox();
            btnAgregar = new Button();
            dataGridView1 = new DataGridView();
            lblSubtotal = new Label();
            lblCantidadSubtotal = new Label();
            lblTotalCantidad = new Label();
            lblTotal = new Label();
            lblDescuento = new Label();
            txtDescuento = new TextBox();
            btnFacturar = new Button();
            txtCantProd = new TextBox();
            lblCantProd = new Label();
            txtImpuesto = new TextBox();
            lblImpuesto = new Label();
            txtFactura = new TextBox();
            lblFactura = new Label();
            txtBuscarCliente = new TextBox();
            lblCodCliente = new Label();
            txtCliente = new TextBox();
            lblCliente = new Label();
            btnBuscar = new Button();
            lblPorc1 = new Label();
            lblPorc2 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imageTill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1082, 535);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(119, 41);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, btn_menu_usuarios, btn_menu_inventario, clientesToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1228, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { abrirFacturaToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(88, 29);
            toolStripMenuItem1.Text = "Archivo";
            // 
            // abrirFacturaToolStripMenuItem
            // 
            abrirFacturaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { impVentaToolStripMenuItem, descuentoToolStripMenuItem });
            abrirFacturaToolStripMenuItem.Name = "abrirFacturaToolStripMenuItem";
            abrirFacturaToolStripMenuItem.Size = new Size(310, 34);
            abrirFacturaToolStripMenuItem.Text = "Imp. Venta y Descuentos";
            // 
            // impVentaToolStripMenuItem
            // 
            impVentaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtImpuestoMenu });
            impVentaToolStripMenuItem.Name = "impVentaToolStripMenuItem";
            impVentaToolStripMenuItem.Size = new Size(199, 34);
            impVentaToolStripMenuItem.Text = "Imp. Venta";
            // 
            // txtImpuestoMenu
            // 
            txtImpuestoMenu.Name = "txtImpuestoMenu";
            txtImpuestoMenu.Size = new Size(100, 31);
            txtImpuestoMenu.Text = "9";
            txtImpuestoMenu.TextChanged += txtImpuestoMenuChanged;
            // 
            // descuentoToolStripMenuItem
            // 
            descuentoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtDescuentoMenu });
            descuentoToolStripMenuItem.Name = "descuentoToolStripMenuItem";
            descuentoToolStripMenuItem.Size = new Size(199, 34);
            descuentoToolStripMenuItem.Text = "Descuento";
            // 
            // txtDescuentoMenu
            // 
            txtDescuentoMenu.Name = "txtDescuentoMenu";
            txtDescuentoMenu.Size = new Size(100, 31);
            txtDescuentoMenu.Text = "0";
            txtDescuentoMenu.TextChanged += DescuentoMenuChanged;
            // 
            // btn_menu_usuarios
            // 
            btn_menu_usuarios.Name = "btn_menu_usuarios";
            btn_menu_usuarios.Size = new Size(96, 29);
            btn_menu_usuarios.Text = "Usuarios";
            btn_menu_usuarios.Click += btn_menu_usuarios_Click;
            // 
            // btn_menu_inventario
            // 
            btn_menu_inventario.Name = "btn_menu_inventario";
            btn_menu_inventario.Size = new Size(107, 29);
            btn_menu_inventario.Text = "Inventario";
            btn_menu_inventario.Click += btn_menu_inventario_Click_1;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(89, 29);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { historialDeFacturasToolStripMenuItem });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(98, 29);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // historialDeFacturasToolStripMenuItem
            // 
            historialDeFacturasToolStripMenuItem.Name = "historialDeFacturasToolStripMenuItem";
            historialDeFacturasToolStripMenuItem.Size = new Size(273, 34);
            historialDeFacturasToolStripMenuItem.Text = "Historial de Facturas";
            // 
            // imageTill
            // 
            imageTill.Image = Properties.Resources._67128681;
            imageTill.Location = new Point(12, 64);
            imageTill.Name = "imageTill";
            imageTill.Size = new Size(150, 152);
            imageTill.TabIndex = 2;
            imageTill.TabStop = false;
            // 
            // lblProducto
            // 
            lblProducto.AutoSize = true;
            lblProducto.Location = new Point(624, 343);
            lblProducto.Name = "lblProducto";
            lblProducto.Size = new Size(178, 25);
            lblProducto.TabIndex = 3;
            lblProducto.Text = "Código de Producto:\r\n";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(624, 382);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(175, 31);
            txtProducto.TabIndex = 4;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(624, 425);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(335, 58);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(225, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(976, 259);
            dataGridView1.TabIndex = 6;
            // 
            // lblSubtotal
            // 
            lblSubtotal.AutoSize = true;
            lblSubtotal.Location = new Point(225, 343);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(83, 25);
            lblSubtotal.TabIndex = 7;
            lblSubtotal.Text = "Subtotal:";
            // 
            // lblCantidadSubtotal
            // 
            lblCantidadSubtotal.AutoSize = true;
            lblCantidadSubtotal.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidadSubtotal.Location = new Point(225, 377);
            lblCantidadSubtotal.Name = "lblCantidadSubtotal";
            lblCantidadSubtotal.Size = new Size(116, 65);
            lblCantidadSubtotal.TabIndex = 8;
            lblCantidadSubtotal.Text = "0.00";
            lblCantidadSubtotal.Click += lblCantidadSubtotal_Click;
            // 
            // lblTotalCantidad
            // 
            lblTotalCantidad.AutoSize = true;
            lblTotalCantidad.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalCantidad.Location = new Point(342, 511);
            lblTotalCantidad.Name = "lblTotalCantidad";
            lblTotalCantidad.Size = new Size(116, 65);
            lblTotalCantidad.TabIndex = 10;
            lblTotalCantidad.Text = "0.00";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(342, 472);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(81, 38);
            lblTotal.TabIndex = 9;
            lblTotal.Text = "Total:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(342, 414);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(100, 25);
            lblDescuento.TabIndex = 11;
            lblDescuento.Text = "Descuento:";
            // 
            // txtDescuento
            // 
            txtDescuento.Location = new Point(448, 411);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(110, 31);
            txtDescuento.TabIndex = 12;
            // 
            // btnFacturar
            // 
            btnFacturar.Location = new Point(977, 387);
            btnFacturar.Name = "btnFacturar";
            btnFacturar.Size = new Size(224, 96);
            btnFacturar.TabIndex = 13;
            btnFacturar.Text = "Facturar";
            btnFacturar.UseVisualStyleBackColor = true;
            // 
            // txtCantProd
            // 
            txtCantProd.Location = new Point(813, 382);
            txtCantProd.Name = "txtCantProd";
            txtCantProd.Size = new Size(146, 31);
            txtCantProd.TabIndex = 15;
            // 
            // lblCantProd
            // 
            lblCantProd.AutoSize = true;
            lblCantProd.Location = new Point(813, 343);
            lblCantProd.Name = "lblCantProd";
            lblCantProd.Size = new Size(87, 25);
            lblCantProd.TabIndex = 14;
            lblCantProd.Text = "Cantidad:";
            // 
            // txtImpuesto
            // 
            txtImpuesto.Location = new Point(448, 360);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(110, 31);
            txtImpuesto.TabIndex = 17;
            // 
            // lblImpuesto
            // 
            lblImpuesto.AutoSize = true;
            lblImpuesto.Location = new Point(341, 363);
            lblImpuesto.Name = "lblImpuesto";
            lblImpuesto.Size = new Size(101, 25);
            lblImpuesto.TabIndex = 16;
            lblImpuesto.Text = "Imp. Venta:";
            // 
            // txtFactura
            // 
            txtFactura.Location = new Point(293, 39);
            txtFactura.Name = "txtFactura";
            txtFactura.Size = new Size(145, 31);
            txtFactura.TabIndex = 19;
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Location = new Point(193, 45);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(94, 25);
            lblFactura.TabIndex = 18;
            lblFactura.Text = "N. Factura:";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.Location = new Point(12, 267);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(175, 31);
            txtBuscarCliente.TabIndex = 21;
            // 
            // lblCodCliente
            // 
            lblCodCliente.AutoSize = true;
            lblCodCliente.Location = new Point(12, 239);
            lblCodCliente.Name = "lblCodCliente";
            lblCodCliente.Size = new Size(158, 25);
            lblCodCliente.TabIndex = 20;
            lblCodCliente.Text = "Código de Cliente:\r\n";
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(732, 39);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(469, 31);
            txtCliente.TabIndex = 23;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(647, 45);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(69, 25);
            lblCliente.TabIndex = 22;
            lblCliente.Text = "Cliente:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(12, 319);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(175, 36);
            btnBuscar.TabIndex = 24;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblPorc1
            // 
            lblPorc1.AutoSize = true;
            lblPorc1.Location = new Point(564, 363);
            lblPorc1.Name = "lblPorc1";
            lblPorc1.Size = new Size(27, 25);
            lblPorc1.TabIndex = 25;
            lblPorc1.Text = "%";
            // 
            // lblPorc2
            // 
            lblPorc2.AutoSize = true;
            lblPorc2.Location = new Point(564, 414);
            lblPorc2.Name = "lblPorc2";
            lblPorc2.Size = new Size(27, 25);
            lblPorc2.TabIndex = 26;
            lblPorc2.Text = "%";
            // 
            // ventanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 586);
            Controls.Add(lblPorc2);
            Controls.Add(lblPorc1);
            Controls.Add(btnBuscar);
            Controls.Add(txtCliente);
            Controls.Add(lblCliente);
            Controls.Add(txtBuscarCliente);
            Controls.Add(lblCodCliente);
            Controls.Add(txtFactura);
            Controls.Add(lblFactura);
            Controls.Add(txtImpuesto);
            Controls.Add(lblImpuesto);
            Controls.Add(txtCantProd);
            Controls.Add(lblCantProd);
            Controls.Add(btnFacturar);
            Controls.Add(txtDescuento);
            Controls.Add(lblDescuento);
            Controls.Add(lblTotalCantidad);
            Controls.Add(lblTotal);
            Controls.Add(lblCantidadSubtotal);
            Controls.Add(lblSubtotal);
            Controls.Add(dataGridView1);
            Controls.Add(btnAgregar);
            Controls.Add(txtProducto);
            Controls.Add(lblProducto);
            Controls.Add(imageTill);
            Controls.Add(btnCerrar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ventanaPrincipal";
            Text = "ventanaPrincipal";
            Load += ventanaPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imageTill).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem abrirFacturaToolStripMenuItem;
        private ToolStripMenuItem btn_menu_usuarios;
        private ToolStripMenuItem btn_menu_inventario;
        private PictureBox imageTill;
        private Label lblProducto;
        private TextBox txtProducto;
        private Button btnAgregar;
        private DataGridView dataGridView1;
        private Label lblSubtotal;
        private Label lblCantidadSubtotal;
        private Label lblTotalCantidad;
        private Label lblTotal;
        private Label lblDescuento;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private TextBox txtDescuento;
        private Button btnFacturar;
        private ToolStripMenuItem historialDeFacturasToolStripMenuItem;
        private TextBox txtCantProd;
        private Label lblCantProd;
        private TextBox txtImpuesto;
        private Label lblImpuesto;
        private TextBox txtFactura;
        private Label lblFactura;
        private TextBox txtBuscarCliente;
        private Label lblCodCliente;
        private TextBox txtCliente;
        private Label lblCliente;
        private Button btnBuscar;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem impVentaToolStripMenuItem;
        private ToolStripTextBox txtImpuestoMenu;
        private ToolStripMenuItem descuentoToolStripMenuItem;
        private ToolStripTextBox txtDescuentoMenu;
        private Label lblPorc1;
        private Label lblPorc2;
    }
}