using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CapaDatos
{
    public class UsuarioCD
    {
        public static DataTable loginUsuario(string user, string pass)
        {
            DataSet dtsRetorno = new DataSet();
            try
            {
                capaEntidad.sqlCE sql = new capaEntidad.sqlCE();
                sql.addParametro("@login", user);
                sql.addParametro("@password", pass);
                dtsRetorno = sql.querySPDataset("SVC_QRY_CONSULTA_LOGIN");
                sql.Desconectar();
            }
            catch (Exception ex)
            {

                throw;
            }
            return dtsRetorno.Tables[0];
        }
    }
}
