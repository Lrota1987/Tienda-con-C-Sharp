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
    public partial class Inventario : Form
    {

        conexionSQLN cn = new conexionSQLN();
        public Inventario()
        {
            InitializeComponent();

            dataGridView.DataSource = cn.ConsultaDataGridViewInventario();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cn.InsertarInventario(txtProduct.Text, txtCategoria.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text)) == 1)
            {
                MessageBox.Show("El producto se ha añadido con éxito.");
                dataGridView.DataSource = cn.ConsultaDataGridViewInventario();

            }
            else
            {
                MessageBox.Show("Ha habido un error al añadir el producto.");
            }
        }

        private void btnMod_Click(object sender, EventArgs e)
        {

            if (cn.modificarProducto(txtProduct.Text, txtCategoria.Text, Convert.ToInt32(txtPrecio.Text), Convert.ToInt32(txtCantidad.Text), txtProdMod.Text) == 1)
            {
                MessageBox.Show("El producto se ha modificado correctamente");
                dataGridView.DataSource = cn.ConsultaDataGridViewInventario();
            }
            else
            {
                MessageBox.Show("Ha habido un error al modificar el producto.");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (cn.eliminarProducto(txtProduct.Text) == 1)
            {
                MessageBox.Show("El producto se ha eliminado correctamente");
                dataGridView.DataSource = cn.ConsultaDataGridViewInventario();
            }
            else
            {
                MessageBox.Show("Ha habido un error al eliminar el producto.");
            }

        }
    }
}
