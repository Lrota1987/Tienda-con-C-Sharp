using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace Datos
{
    public class conexionSQL
    {

        NpgsqlConnection conexion = new NpgsqlConnection("Host= 172.17.0.30 ; User Id= postgres ; Password= Eypscap01 ; Database= cursoCSharp ; Port= 5432");


        public int  consultaLogin (string user, string pass)
        {

            int count;
            conexion.Open();
            string query = "Select Count(*) from \"usuarios\" where \"usuario\"= '"+ user +"' and \"contrasena\"= '"+ pass +"'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();
            return count;

        }

        public int consultaUsuario(string user)
        {

            int count;
            string query = "Select Count(*) from \"usuarios\" where \"usuario\"= '" + user + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            conexion.Close();
            return count;

        }

        public DataTable ConsultaUsuariosDG()
        {

            string query = "select * from \"usuarios\"";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;

        }

        public DataTable ConsultaInventarioDG()
        {

            string query = "select * from \"inventario\"";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            NpgsqlDataAdapter data = new NpgsqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;

        }

        public int InsertarUser(string nombre, string apellido, string dni, string telefono, string usuario, string pass)
        {
            conexion.Open();
            int flag = 0;
            if (consultaUsuario(usuario) == 0)
            {
                conexion.Open();
                string query = "INSERT INTO \"usuarios\" (\"nombre\", \"apellidos\", \"dni\", \"telefono\", \"usuario\", \"contrasena\") VALUES ('" + nombre + "', '" + apellido + "', '" + dni + "', '" + telefono + "', '" + usuario + "', '" + pass + "')";
                NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
                flag = cmd.ExecuteNonQuery();

            }
            
            conexion.Close();  
            return flag;

        }

        public int InsertarProducto(string producto, string categoria, int precio, int cantidad)
        {

            int flag = 0;
            conexion.Open();
            string query = "INSERT INTO \"inventario\" (\"producto\", \"categoria\", \"precio\", \"cantidad\", \"codigo\") VALUES ('" + producto + "', '" + categoria + "', '" + precio + "', '" + cantidad + "', trunc(random() * 9999 +1000))";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();

            conexion.Close();
            return flag;

        }

        public int EliminarUser(string usuario)
        {

            int flag = 0;
            conexion.Open();
            string query = "DELETE from \"usuarios\" where \"usuario\"= '"+ usuario +"'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();

            conexion.Close();
            return flag;

        }

        public int EliminarProducto(string producto)
        {

            int flag = 0;
            conexion.Open();
            string query = "DELETE from \"inventario\" where \"producto\"= '" + producto + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();

            conexion.Close();
            return flag;

        }

        public int ModificarProducto(string producto, string categoria, int precio, int cantidad, string prodMod)
        {

            int flag = 0;
            conexion.Open();
            string query = "Update \"inventario\" set \"producto\"= '"+ producto +"', \"categoria\"='"+ categoria +"', \"precio\"="+ precio +", \"cantidad\"= "+ cantidad +" where \"producto\"= '"+ prodMod +"'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            flag = cmd.ExecuteNonQuery();

            conexion.Close();
            return flag;

        }

        public Tuple<string, string> consultarProducto(string codigo)
        {
            conexion.Open();
            string conexion1 = "NULL";
            string conexion2 = "NULL";
            string query = "Select * from \"inventario\" where \"codigo\"= '" + codigo + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            string[] columnas = new string[2];
            if (reader.Read())
            {
                conexion1 = reader["producto"].ToString();
                conexion2 = reader["precio"].ToString();


            }

            conexion.Close();
            return Tuple.Create(conexion1, conexion2);

        }

        public string ConsultaFactura()
        {

            conexion.Open();
            string query = "SELECT( SELECT numerofactura FROM facturacion ORDER BY numerofactura DESC LIMIT 1) +1 as numerofactura";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            NpgsqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                string numfact = reg["numerofactura"].ToString();
                conexion.Close();
                return numfact;
            }
            else
            {
                conexion.Close();
                return "No ha devuelto nada.";
            }

        }

        public Tuple<string, double> consultarCliente(string codigo)
        {
            conexion.Open();
            string conexion1 = "NULL";
            double conexion2 = 0;
            string query = "Select * from \"clientes\" where \"codigo\"= '" + codigo + "'";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conexion);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                conexion1 = reader["nombre"].ToString() + " " + reader["apellido"].ToString();
                conexion2 = Convert.ToDouble(reader["descuento"]);


            }

            conexion.Close();
            return Tuple.Create(conexion1, conexion2);

        }
    }
}
