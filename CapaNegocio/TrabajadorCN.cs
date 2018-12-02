using capaEntidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class TrabajadorCN
    {
        TrabajadorCD objdato = new TrabajadorCD();

        public DataTable n_listado()
        {
            return objdato.d_listado();
        }

        public void n_insertar(TrabajadorCE emp)
        {
            objdato.d_insertar(emp);
        }

        public void n_eliminar(int cod)
        {
            objdato.d_eliminar(cod);
        }

        public void n_editar(TrabajadorCE emp)
        {
            objdato.d_editar(emp);
        }
    }
}
