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
    public class ObraAsignadaCD
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public void d_insertar(ObraAsignadaCE obraAsignada)
        {
            SqlCommand cmd = new SqlCommand("SVC_INS_ASIGNAROBRA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@rut", obraAsignada.rut);
            cmd.Parameters.AddWithValue("@idobra", obraAsignada.idobra);
            cmd.Parameters.AddWithValue("@fechainicio", obraAsignada.fechainicio);
            cmd.Parameters.AddWithValue("@valordia", obraAsignada.valordia);
            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

        }
    }
}
