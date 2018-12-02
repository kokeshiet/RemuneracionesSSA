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
    public partial class frmObra : Form
    {
        public frmObra()
        {
            InitializeComponent();
            ListarObra();
        }

        ObraCE objEntidad = new ObraCE();
        ObraCN objNego = new ObraCN();

        void ListarObra()
        {
            DataTable dt = objNego.n_listado();
            dgvObra.DataSource = dt;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
            ListarObra();
            Limpiar();
        }

        private void dgvObra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvObra.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int eliminar = Convert.ToInt32(dgvObra.Rows[e.RowIndex].Cells["id_obra"].Value.ToString());
                objNego.n_eliminar(eliminar);
                ListarObra();
            }

            if (dgvObra.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                txtID.Text = dgvObra.Rows[e.RowIndex].Cells["id_obra"].Value.ToString();
                txtNombre.Text = dgvObra.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtDetalle.Text = dgvObra.Rows[e.RowIndex].Cells["detalle"].Value.ToString();

            }
        }
        void Insertar()
        {
            objEntidad.nombre = txtNombre.Text;
            objEntidad.detalle = txtDetalle.Text;


            objNego.n_insertar(objEntidad);

            MessageBox.Show("Registro insertado con éxito");
        }

        void Limpiar()
        {
            txtNombre.Text = "";
            txtDetalle.Text = "";
            txtID.Text = "";

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Editar();
            ListarObra();
            Limpiar();
        }
        void Editar()
        {
            objEntidad.id = Convert.ToInt32(txtID.Text);
            objEntidad.nombre = txtNombre.Text;
            objEntidad.detalle = txtDetalle.Text;

            objNego.n_editar(objEntidad);

            MessageBox.Show("Registro editado con éxito");
        }
    }
}
