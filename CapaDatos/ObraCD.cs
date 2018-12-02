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
    public class ObraCD
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["conexionSQLServer"].ConnectionString);

        public DataTable d_listado()
        {
            SqlCommand cmd = new SqlCommand("SP_LISTAR_OBRA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void d_insertar(ObraCE obr)
        {
            SqlCommand cmd = new SqlCommand("SVC_INS_INSERTAR_OBRA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obr.nombre);
            cmd.Parameters.AddWithValue("@detalle", obr.detalle);

            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

        }

        public void d_eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("SVC_INS_ELIMINAR_OBRA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_obra", id);
            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void d_editar(ObraCE obr)
        {
            SqlCommand cmd = new SqlCommand("SVC_UPD_ACTUALIZAR_OBRA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_obra", obr.id);
            cmd.Parameters.AddWithValue("@nombre", obr.nombre);
            cmd.Parameters.AddWithValue("@detalle", obr.detalle);

            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}
