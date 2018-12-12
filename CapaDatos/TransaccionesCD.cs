using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using CapaEntidad;

namespace CapaDatos
{
    public class TransaccionesCD
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public DataTable d_listarTransacciones(DateTime fecha)
        {
            SqlCommand cmd = new SqlCommand("SVC_QRY_LISTAR_TRANSACCIONES_POR_FECHA", cn);
            cmd.Parameters.AddWithValue("@fecha", fecha);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
