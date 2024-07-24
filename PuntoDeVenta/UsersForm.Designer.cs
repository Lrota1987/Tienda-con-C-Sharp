namespace PuntoDeVenta
{
    partial class UsersForm
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
            dataGridViewUsers = new DataGridView();
            label1 = new Label();
            txtName = new TextBox();
            txtApellido = new TextBox();
            lblApellido = new Label();
            txtDNI = new TextBox();
            lblDNI = new Label();
            txtTlfn = new TextBox();
            lblTlfn = new Label();
            groupBox1 = new GroupBox();
            txtPass = new TextBox();
            lblPass = new Label();
            lblUser = new Label();
            txtUser = new TextBox();
            btnNewUser = new Button();
            btNModificar = new Button();
            btnEliminar = new Button();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(19, 20);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.RowHeadersWidth = 62;
            dataGridViewUsers.Size = new Size(1324, 370);
            dataGridViewUsers.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 460);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // txtName
            // 
            txtName.Location = new Point(19, 488);
            txtName.Name = "txtName";
            txtName.Size = new Size(166, 31);
            txtName.TabIndex = 2;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(224, 488);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(166, 31);
            txtApellido.TabIndex = 4;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(224, 460);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(86, 25);
            lblApellido.TabIndex = 3;
            lblApellido.Text = "Apellidos";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(438, 488);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(166, 31);
            txtDNI.TabIndex = 6;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(438, 460);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(43, 25);
            lblDNI.TabIndex = 5;
            lblDNI.Text = "DNI";
            // 
            // txtTlfn
            // 
            txtTlfn.Location = new Point(644, 488);
            txtTlfn.Name = "txtTlfn";
            txtTlfn.Size = new Size(166, 31);
            txtTlfn.TabIndex = 8;
            // 
            // lblTlfn
            // 
            lblTlfn.AutoSize = true;
            lblTlfn.Location = new Point(644, 460);
            lblTlfn.Name = "lblTlfn";
            lblTlfn.Size = new Size(79, 25);
            lblTlfn.TabIndex = 7;
            lblTlfn.Text = "Telefono";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPass);
            groupBox1.Controls.Add(lblPass);
            groupBox1.Controls.Add(lblUser);
            groupBox1.Controls.Add(txtUser);
            groupBox1.Location = new Point(832, 410);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(523, 122);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Información de Acceso";
            // 
            // txtPass
            // 
            txtPass.Location = new Point(243, 78);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(166, 31);
            txtPass.TabIndex = 15;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(243, 50);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(101, 25);
            lblPass.TabIndex = 14;
            lblPass.Text = "Contraseña";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(38, 50);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(72, 25);
            lblUser.TabIndex = 12;
            lblUser.Text = "Usuario";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(38, 78);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(166, 31);
            txtUser.TabIndex = 13;
            // 
            // btnNewUser
            // 
            btnNewUser.Location = new Point(19, 548);
            btnNewUser.Name = "btnNewUser";
            btnNewUser.Size = new Size(186, 75);
            btnNewUser.TabIndex = 12;
            btnNewUser.Text = "Nuevo Usuario";
            btnNewUser.UseVisualStyleBackColor = true;
            btnNewUser.Click += btnNewUser_Click;
            // 
            // btNModificar
            // 
            btNModificar.Location = new Point(264, 548);
            btNModificar.Name = "btNModificar";
            btNModificar.Size = new Size(186, 75);
            btNModificar.TabIndex = 13;
            btNModificar.Text = "Modificar Usuario";
            btNModificar.UseVisualStyleBackColor = true;
            btNModificar.Click += btNModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(507, 548);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(186, 75);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar Usuario";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(1157, 548);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(186, 75);
            btnCerrar.TabIndex = 15;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1367, 644);
            Controls.Add(btnCerrar);
            Controls.Add(btnEliminar);
            Controls.Add(btNModificar);
            Controls.Add(btnNewUser);
            Controls.Add(groupBox1);
            Controls.Add(txtTlfn);
            Controls.Add(lblTlfn);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(txtApellido);
            Controls.Add(lblApellido);
            Controls.Add(txtName);
            Controls.Add(label1);
            Controls.Add(dataGridViewUsers);
            Name = "UsersForm";
            Text = "UsersForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Label label1;
        private TextBox txtName;
        private TextBox txtApellido;
        private Label lblApellido;
        private TextBox txtDNI;
        private Label lblDNI;
        private TextBox txtTlfn;
        private Label lblTlfn;
        private GroupBox groupBox1;
        private TextBox txtPass;
        private TextBox txtUser;
        private Label lblPass;
        private Label lblUser;
        private Button btnNewUser;
        private Button btNModificar;
        private Button btnEliminar;
        private Button btnCerrar;
    }
}