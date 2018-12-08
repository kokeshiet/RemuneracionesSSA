using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using System.Data;

namespace CapaNegocio
{
    public class TransaccionesCN
    {
        TransaccionesCD objdato = new TransaccionesCD();

        public DataTable n_listarTransacciones(DateTime fecha)
        {
            return objdato.d_listarTransacciones(fecha);
        }
    }
}
