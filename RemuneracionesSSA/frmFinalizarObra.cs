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
    public partial class frmFinalizarObra : Form
    {

        ObraAsignadaCE objEntidad = new ObraAsignadaCE();
        ObraAsignadaCN objNego = new ObraAsignadaCN();

        public frmFinalizarObra()
        {
            InitializeComponent();
        }

        void ListarObrasAsignadas()
        {
            DataTable dt = objNego.n_listado(Convert.ToInt32(txtRut.Text));
            dgvDatos.DataSource = dt;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ListarObrasAsignadas();
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = dgvDatos.Rows[e.RowIndex].Cells["id"].Value.ToString();
            txtIdTrabajador.Text = dgvDatos.Rows[e.RowIndex].Cells["id_trabajador"].Value.ToString();
            txtIDobra.Text = dgvDatos.Rows[e.RowIndex].Cells["id_obra"].Value.ToString();
            txtObra.Text = dgvDatos.Rows[e.RowIndex].Cells["nombre1"].Value.ToString();
            txtValorDia.Text = dgvDatos.Rows[e.RowIndex].Cells["valordia"].Value.ToString();
            dtpFechaInicio.Value = Convert.ToDateTime(dgvDatos.Rows[e.RowIndex].Cells["fechainicio"].Value.ToString());
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            Editar();
            Limpiar();
        }
        void Editar()
        {
            try
            {
                objEntidad.idobra = Convert.ToInt32(txtIDobra.Text);
                objEntidad.idtrabajador = Convert.ToInt32(txtIdTrabajador.Text);
                objEntidad.valordia = Convert.ToInt32(txtValorDia.Text);
                objEntidad.fechainicio = Convert.ToDateTime(dtpFechaInicio.Value);
                objEntidad.fechafin = Convert.ToDateTime(dtpFechaFin.Value);

                objNego.n_editar(objEntidad);

                MessageBox.Show("Obra Finalizada con éxito","Finalizar Obra",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex) 
            {
            }
        }

        private void txtRut_TextChanged(object sender, EventArgs e)
        {
            if (txtRut.Text.Length > 0)
            {
                txtDV.Text = CapaDatos.Util.calculaDV(Convert.ToInt32(txtRut.Text));
            }
        }

        void Limpiar()
        {
            txtRut.Text = "";
            txtDV.Text = "";
            txtObra.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            DataTable dt = (DataTable)dgvDatos.DataSource;
            dt.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
