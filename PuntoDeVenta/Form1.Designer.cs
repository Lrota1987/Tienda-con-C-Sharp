namespace PuntoDeVenta
{
    partial class formLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUser = new TextBox();
            txtPass = new TextBox();
            lblUser = new Label();
            lblPass = new Label();
            btnEntrar = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(98, 62);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(324, 31);
            txtUser.TabIndex = 0;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(98, 143);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(324, 31);
            txtPass.TabIndex = 1;
            txtPass.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(98, 34);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(76, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuario:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(98, 115);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(105, 25);
            lblPass.TabIndex = 3;
            lblPass.Text = "Contraseña:";
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(98, 202);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(205, 63);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Acceder";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(351, 202);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(213, 63);
            btnExit.TabIndex = 5;
            btnExit.Text = "Salir";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(649, 305);
            Controls.Add(btnExit);
            Controls.Add(btnEntrar);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Name = "formLogin";
            Text = "Login";
            Load += formLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPass;
        private Label lblUser;
        private Label lblPass;
        private Button btnEntrar;
        private Button btnExit;
    }
}
