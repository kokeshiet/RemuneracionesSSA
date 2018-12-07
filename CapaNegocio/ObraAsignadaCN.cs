using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class ObraAsignadaCN
    {
        ObraAsignadaCD objdato = new ObraAsignadaCD();

        public void n_insertar(ObraAsignadaCE obraAsignada)
        {
            objdato.d_insertar(obraAsignada);
        }

        public DataTable n_listado(int rut)
        {
            return objdato.d_listado(rut);
        }
        public void n_editar(ObraAsignadaCE obraAsignada)
        {
            objdato.d_editar(obraAsignada);
        }

        public DataTable n_mostrarsueldo(int id)
        {
            return objdato.d_mostrarsueldo(id);
        }

        public DataTable n_listadoXrutYObra(int rut, int idObra)
        {
            return objdato.d_listadoXrutYObra(rut, idObra);
        }
    }
}
