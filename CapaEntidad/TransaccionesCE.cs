using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class TransaccionesCE
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string accion { get; set; }
        public string detalle { get; set; }
        public DateTime fecha { get; set; }
    }
}
