using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;

namespace PuntoDeVenta
{
    public partial class UsersForm : Form
    {
        conexionSQLN cn = new conexionSQLN();

        public UsersForm()
        {
            InitializeComponent();
            dataGridViewUsers.DataSource = cn.ConsultaDataGridView();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            if (cn.InsertarUser(txtName.Text, txtApellido.Text, txtDNI.Text, txtTlfn.Text, txtUser.Text, txtPass.Text) == 1)
            {
                MessageBox.Show("El usuario ha sido añadido con éxito!");
            }
            else
            {
                MessageBox.Show("No se ha podido añadir el usuario");
            }

            dataGridViewUsers.DataSource = cn.ConsultaDataGridView();
        }

        private void btNModificar_Click(object sender, EventArgs e)
        {


            dataGridViewUsers.DataSource = cn.ConsultaDataGridView();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cn.EliminarUser(txtUser.Text) == 1)
            {
                MessageBox.Show("El usuario se ha eliminado correctamente.");
            }
            else
            {
                MessageBox.Show("No se ha podido eliminar el usuario.");
            }

            dataGridViewUsers.DataSource = cn.ConsultaDataGridView();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
