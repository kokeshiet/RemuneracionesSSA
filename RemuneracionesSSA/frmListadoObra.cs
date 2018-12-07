using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace RemuneracionesSSA
{
    public partial class frmListadoObra : Form
    {
        public frmListadoObra()
        {
            InitializeComponent();
        }

        ObraCE objEntidad = new ObraCE();
        ObraCN objNego = new ObraCN();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarTrabajador();
        }

        void ListarTrabajador()
        {
            DataTable dt = objNego.n_listado();
            dgvListadoObras.DataSource = dt;
        }
    }
}
