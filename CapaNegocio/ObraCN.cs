using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class ObraCN
    {
        ObraCD objDato = new ObraCD();

        public DataTable n_listado()
        {
            return objDato.d_listado();
        }

        public void n_insertar(ObraCE obr)
        {
            objDato.d_insertar(obr);
        }

        public void n_eliminar(int id)
        {
            objDato.d_eliminar(id);
        }

        public void n_editar(ObraCE obr)
        {
            objDato.d_editar(obr);
        }
    }
}
