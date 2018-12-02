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
    public class TrabajadorCD
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["sqlconex"].ConnectionString);

        public DataTable d_listado()
        {
            SqlCommand cmd = new SqlCommand("SP_LISTAR", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public void d_insertar(TrabajadorCE emp)
        {
            SqlCommand cmd = new SqlCommand("SVC_INS_INSERTAR_EMPLEADO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", emp.nombre);
            cmd.Parameters.AddWithValue("@apaterno", emp.apaterno);
            cmd.Parameters.AddWithValue("@amaterno", emp.amaterno);
            cmd.Parameters.AddWithValue("@rut", emp.rut);
            cmd.Parameters.AddWithValue("@dv", emp.dv);
            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }

        }

        public void d_eliminar(int id)
        {
            SqlCommand cmd = new SqlCommand("SVC_INS_ELIMINAR_EMPLEADO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_trabajador", id);
            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public void d_editar(TrabajadorCE emp)
        {
            SqlCommand cmd = new SqlCommand("SVC_UPD_ACTUALIZAR_EMPLEADO", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_trabajador", emp.id);
            cmd.Parameters.AddWithValue("@nombre", emp.nombre);
            cmd.Parameters.AddWithValue("@apaterno", emp.apaterno);
            cmd.Parameters.AddWithValue("@amaterno", emp.amaterno);
            cmd.Parameters.AddWithValue("@rut", emp.rut);
            cmd.Parameters.AddWithValue("@dv", emp.dv);

            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }


        }
    }
}
