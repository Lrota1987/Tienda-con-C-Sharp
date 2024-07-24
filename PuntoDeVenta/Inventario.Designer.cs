namespace PuntoDeVenta
{
    partial class Inventario
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
            pictureBoxCarretilla = new PictureBox();
            dataGridView = new DataGridView();
            btnAgregar = new Button();
            btnMod = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            txtProduct = new TextBox();
            txtCategoria = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            label3 = new Label();
            txtCantidad = new TextBox();
            label4 = new Label();
            txtProdMod = new TextBox();
            lblProdMod = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarretilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1020, 465);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(175, 81);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBoxCarretilla
            // 
            pictureBoxCarretilla.Image = Properties.Resources.preview;
            pictureBoxCarretilla.Location = new Point(1054, 29);
            pictureBoxCarretilla.Name = "pictureBoxCarretilla";
            pictureBoxCarretilla.Size = new Size(155, 143);
            pictureBoxCarretilla.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCarretilla.TabIndex = 1;
            pictureBoxCarretilla.TabStop = false;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 29);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 62;
            dataGridView.Size = new Size(1005, 305);
            dataGridView.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(12, 465);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(176, 81);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnMod
            // 
            btnMod.Location = new Point(208, 465);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(177, 81);
            btnMod.TabIndex = 4;
            btnMod.Text = "Modificar Producto";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += btnMod_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(405, 465);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(170, 81);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar Producto";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 356);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 6;
            label1.Text = "Producto";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(12, 395);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(176, 31);
            txtProduct.TabIndex = 7;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(227, 395);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(176, 31);
            txtCategoria.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(227, 356);
            label2.Name = "label2";
            label2.Size = new Size(88, 25);
            label2.TabIndex = 8;
            label2.Text = "Categoria";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(440, 395);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(176, 31);
            txtPrecio.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(440, 356);
            label3.Name = "label3";
            label3.Size = new Size(60, 25);
            label3.TabIndex = 10;
            label3.Text = "Precio";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(655, 395);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(176, 31);
            txtCantidad.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(655, 356);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 12;
            label4.Text = "Cantidad";
            // 
            // txtProdMod
            // 
            txtProdMod.Location = new Point(872, 395);
            txtProdMod.Name = "txtProdMod";
            txtProdMod.Size = new Size(176, 31);
            txtProdMod.TabIndex = 15;
            // 
            // lblProdMod
            // 
            lblProdMod.AutoSize = true;
            lblProdMod.Location = new Point(872, 356);
            lblProdMod.Name = "lblProdMod";
            lblProdMod.Size = new Size(179, 25);
            lblProdMod.TabIndex = 14;
            lblProdMod.Text = "Producto a modificar";
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 569);
            Controls.Add(txtProdMod);
            Controls.Add(lblProdMod);
            Controls.Add(txtCantidad);
            Controls.Add(label4);
            Controls.Add(txtPrecio);
            Controls.Add(label3);
            Controls.Add(txtCategoria);
            Controls.Add(label2);
            Controls.Add(txtProduct);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnMod);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView);
            Controls.Add(pictureBoxCarretilla);
            Controls.Add(btnCerrar);
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCarretilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCerrar;
        private PictureBox pictureBoxCarretilla;
        private DataGridView dataGridView;
        private Button btnAgregar;
        private Button btnMod;
        private Button btnEliminar;
        private Label label1;
        private TextBox txtProduct;
        private TextBox txtCategoria;
        private Label label2;
        private TextBox txtPrecio;
        private Label label3;
        private TextBox txtCantidad;
        private Label label4;
        private TextBox txtProdMod;
        private Label lblProdMod;
    }
}