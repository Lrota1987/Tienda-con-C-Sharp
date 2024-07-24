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
    public partial class ventanaPrincipal : Form
    {
        private DataTable dt;
        conexionSQLN cn = new conexionSQLN();

        private double subtotal = 0;
        private double total = 0;
        private double descuento = 0;

        public ventanaPrincipal()
        {
            InitializeComponent();

            txtImpuesto.Text = txtImpuestoMenu.Text;
            txtDescuento.Text = txtDescuentoMenu.Text;

            dt = new DataTable();
            dt.Columns.Add("Código del Producto");
            dt.Columns.Add("Producto");
            dt.Columns.Add("Precio Unitario");
            dt.Columns.Add("Cantidad");
            dt.Columns.Add("Descuento");
            dt.Columns.Add("Precio Total");

            dataGridView1.DataSource = dt;

            txtFactura.Text = cn.consultaFactura();
        }

        private void ventanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        public void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void btn_menu_usuarios_Click(object sender, EventArgs e)
        {
            UsersForm v1 = new UsersForm();
            this.Hide();
            v1.ShowDialog();
            this.Show();

        }


        private void btn_menu_inventario_Click_1(object sender, EventArgs e)
        {

            Inventario v1 = new Inventario();
            this.Hide();
            v1.ShowDialog();
            this.Show();

        }

        private void lblCantidadSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void txtImpuestoMenuChanged(object sender, EventArgs e)
        {
            txtImpuesto.Text = txtImpuestoMenu.Text;
        }

        private void DescuentoMenuChanged(object sender, EventArgs e)
        {
            txtDescuento.Text = txtDescuentoMenu.Text;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            var resultado = cn.consultarProducto(txtProducto.Text);
            DataRow row = dt.NewRow();

            row["Código del Producto"] = txtProducto.Text;
            row["Producto"] = resultado.Item1;
            row["Precio Unitario"] = resultado.Item2;
            row["Cantidad"] = txtCantProd.Text;
            row["Descuento"] = txtDescuento.Text;
            row["Precio Total"] = Convert.ToString(Convert.ToDouble(resultado.Item2) * Convert.ToInt32(txtCantProd.Text));

            dt.Rows.Add(row);

            subtotal = subtotal + Convert.ToInt32(row["Precio Total"]);



            if (descuento == 0)
            {
                total = subtotal + (subtotal * double.Parse(txtImpuesto.Text) / 100);
            }
            else
            {
                total = subtotal + (subtotal * double.Parse(txtImpuesto.Text) / 100);
                total = total - (total * (descuento));
            }

            lblCantidadSubtotal.Text = subtotal.ToString();
            lblTotalCantidad.Text = total.ToString();


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            var resultado2 = cn.consultarCliente(txtBuscarCliente.Text);

            txtCliente.Text = resultado2.Item1 + " DESCUENTO: " + resultado2.Item2 + "%";
            txtDescuento.Text = (resultado2.Item2*100).ToString();
            descuento = resultado2.Item2;
            


        }
    }
}
