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
    public partial class frmListadoTrabajador : Form
    {
        public frmListadoTrabajador()
        {
            InitializeComponent();
        }

        TrabajadorCE objEntidad = new TrabajadorCE();
        TrabajadorCN objNego = new TrabajadorCN();
        
        void ListarTrabajador()
        {
            DataTable dt = objNego.n_listado();
            dgvListadoTrabajadores.DataSource = dt;
        }
        void ListarTrabajadorXrut()
        {
            DataTable dt = objNego.n_listadoXrut(Convert.ToInt32(txtRut.Text));
            dgvListadoTrabajadores.DataSource = dt;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text.Length == 0)
            {
                ListarTrabajador();
            }
            else
            {
                ListarTrabajadorXrut();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtRut.Text = "";
            txtDV.Text = "";
            DataTable dt = (DataTable)dgvListadoTrabajadores.DataSource;
            dt.Clear();
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            if (txtRut.Text.Length > 0)
            {
                txtDV.Text = CapaDatos.Util.calculaDV(Convert.ToInt32(txtRut.Text));
            }
        }
    }
}
