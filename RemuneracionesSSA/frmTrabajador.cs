using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidad;

namespace RemuneracionesSSA
{
    public partial class frmTrabajador : Form
    {
        public frmTrabajador()
        {
            InitializeComponent();
        }

        private void AgregarTrabajador_Load(object sender, EventArgs e)
        {
            ListarEmpleado();
        }

        TrabajadorCE objEntidad = new TrabajadorCE();
        TrabajadorCN objNego = new TrabajadorCN();

        void ListarEmpleado()
        {
            DataTable dt = objNego.n_listado();
            dgvTrabajador.DataSource = dt;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Insertar();
            ListarEmpleado();
            Limpiar();
        }

        void Insertar()
        {
            objEntidad.nombre = txtNombre.Text;
            objEntidad.apaterno = txtAPaterno.Text;
            objEntidad.amaterno = txtAMaterno.Text;
            objEntidad.rut = Convert.ToInt32(txtRut.Text);
            objEntidad.dv = txtDV.Text;

            objNego.n_insertar(objEntidad);

            MessageBox.Show("Registro insertado con éxito");
        }
        void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtAMaterno.Text = "";
            txtAPaterno.Text = "";
            txtRut.Text = "";
            txtDV.Text = "";
        }

        private void dgvTrabajador_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTrabajador.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int eliminar = Convert.ToInt32(dgvTrabajador.Rows[e.RowIndex].Cells["id_trabajador"].Value.ToString());
                objNego.n_eliminar(eliminar);
                ListarEmpleado();
            }

            if (dgvTrabajador.Rows[e.RowIndex].Cells["Modificar"].Selected)
            {
                txtID.Text = dgvTrabajador.Rows[e.RowIndex].Cells["id_trabajador"].Value.ToString();
                txtNombre.Text = dgvTrabajador.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
                txtAPaterno.Text = dgvTrabajador.Rows[e.RowIndex].Cells["apaterno"].Value.ToString();
                txtAMaterno.Text = dgvTrabajador.Rows[e.RowIndex].Cells["amaterno"].Value.ToString();
                txtRut.Text = dgvTrabajador.Rows[e.RowIndex].Cells["rut"].Value.ToString();
                txtDV.Text = dgvTrabajador.Rows[e.RowIndex].Cells["dv"].Value.ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar();
            ListarEmpleado();
            Limpiar();
        }
        void Editar()
        {
            objEntidad.id = Convert.ToInt32(txtID.Text);
            objEntidad.nombre = txtNombre.Text;
            objEntidad.apaterno = txtAPaterno.Text;
            objEntidad.amaterno = txtAMaterno.Text;
            objEntidad.rut = Convert.ToInt32(txtRut.Text);
            objEntidad.dv = txtDV.Text;
            objNego.n_editar(objEntidad);

            MessageBox.Show("Registro editado con éxito");
        }
        void eliminar()
        {
            int eliminar = Convert.ToInt32(txtID);
            objNego.n_eliminar(eliminar);
            ListarEmpleado();
        }
    }
}
