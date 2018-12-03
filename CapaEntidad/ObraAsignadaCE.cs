using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class ObraAsignadaCE
    {
        public int id { get; set; }
        public int rut { get; set; }
        public int idtrabajador { get; set; }
        public int idobra { get; set; }
        public DateTime fechainicio { get; set; }
        public int valordia { get; set; }
        public DateTime fechafin { get; set; }
    }
}
