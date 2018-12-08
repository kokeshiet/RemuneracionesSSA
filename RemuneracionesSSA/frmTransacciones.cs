using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using CapaEntidad;
using CapaNegocio;

namespace RemuneracionesSSA
{
    public partial class frmTransacciones : Form
    {
        TransaccionesCE objEntidad = new TransaccionesCE();
        TransaccionesCN objNego = new TransaccionesCN();
        public frmTransacciones()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarTransacciones();
        }

        void ListarTransacciones()
        {
            DataTable dt = objNego.n_listarTransacciones(dtpFecha.Value);
            dgvTransacciones.DataSource = dt;
        }
    }
}
