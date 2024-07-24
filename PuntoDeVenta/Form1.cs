using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;


namespace PuntoDeVenta
{
    public partial class formLogin : Form
    {

        conexionSQLN cn = new conexionSQLN();

        public formLogin()
        {
            InitializeComponent();
        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            if (cn.conSQL(txtUser.Text, txtPass.Text) == 1)
            {

                MessageBox.Show("El usuario ha sido encontrado.");
                //Cierra la ventana de Login
                this.Hide();
                //Abre la ventana principal.
                ventanaPrincipal v1 = new ventanaPrincipal();
                v1.Show();

            }
            else
            {
                MessageBox.Show("El usuario no ha sido encontrado");
            }

        }
    }
}
