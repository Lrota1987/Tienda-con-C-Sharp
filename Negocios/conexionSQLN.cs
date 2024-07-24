using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocios
{
    public class conexionSQLN
    {

        conexionSQL conection = new conexionSQL();

        public int conSQL(string user, string pass)
        {

            return conection.consultaLogin(user, pass);

        }

        public DataTable ConsultaDataGridView()
        {

            return conection.ConsultaUsuariosDG();

        }

        public DataTable ConsultaDataGridViewInventario()
        {

            return conection.ConsultaInventarioDG();

        }

        public int InsertarUser(string nombre, string apellido, string dni, string telefono, string usuario, string pass)
        {

            return conection.InsertarUser(nombre, apellido, dni, telefono, usuario, pass );

        }

        public int InsertarInventario(string producto, string categoria, int precio, int cantidad)
        {

            return conection.InsertarProducto(producto, categoria, precio, cantidad);

        }

        public int EliminarUser(string usuario)
        {
            return conection.EliminarUser(usuario);
        }

        public int eliminarProducto(string producto)
        {
            return conection.EliminarProducto(producto);
        }

        public int modificarProducto(string producto, string categoria, int precio, int cantidad, string prodMod)
        {

            return conection.ModificarProducto(producto, categoria, precio, cantidad, prodMod);

        }

        public Tuple<string, string> consultarProducto(string codigo)
        {
            return conection.consultarProducto(codigo);
        }

        public string consultaFactura()
        {
            return conection.ConsultaFactura();
        }

        public Tuple<String, double> consultarCliente(string codigo)
        {
            return conection.consultarCliente(codigo);
        }

    }
}
