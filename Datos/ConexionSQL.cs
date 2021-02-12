using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class ConexionSQL
    {
        static string conexionstring = "server= localhost; database = PuntodeVenta;" + "integrated security= true";
        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin (string Usuario, string Contrasenia)
        {
            int count;
            con.Open();
            string Query = "Select Count(*) From Persona where usuario = '" + Usuario + "'" +
                "and contrasenia = '"+Contrasenia+"'";

            SqlCommand cmd = new SqlCommand(Query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
            return count;
        }

        public DataTable ConsultaUsuariosDG()
        {
            string query = "select * from Persona";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);
            return tabla;
        }
    }
}
