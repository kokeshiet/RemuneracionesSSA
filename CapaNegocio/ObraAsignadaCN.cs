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
    }
}
