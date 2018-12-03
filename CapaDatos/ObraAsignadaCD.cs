﻿using System;
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

        public DataTable d_listado(int rut)
        {
            SqlCommand cmd = new SqlCommand("SP_LISTAR_OBRAS_ASIGNADAS", cn);
            cmd.Parameters.AddWithValue("@RUT", rut);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

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

        public void d_editar(ObraAsignadaCE obraAsignada)
        {
            SqlCommand cmd = new SqlCommand("SVC_UPD_ACTUALIZAR_OBRA_ASIGNADA", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", obraAsignada.id);
            cmd.Parameters.AddWithValue("@fechafin", obraAsignada.fechafin);

            if (cn.State == ConnectionState.Open) cn.Close();
            {
                cn.Open();
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }
    }
}