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
    public partial class frmSueldoTrabajador : Form
    {

        ObraCE objEntidadObra = new ObraCE();
        ObraCN objNegoObra = new ObraCN();
        ObraAsignadaCE objEntidadObraAsig = new ObraAsignadaCE();
        ObraAsignadaCN objNegoObraAsig = new ObraAsignadaCN();
        public frmSueldoTrabajador()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtRut.Text.Length == 0 || cbObra.SelectedIndex == 0)
            {
                MessageBox.Show("Debe ingresar un rut y seleccionar una obra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ListaObra();
            }
        }

        void ListaObra()
        {
            DataTable dt = objNegoObraAsig.n_listadoXrutYObra(Convert.ToInt32(txtRut.Text),cbObra.SelectedIndex);
            if (dt.Rows.Count > 0)
            {
                txtNombre.Text = dt.Rows[0][0].ToString();
                txtApaterno.Text = dt.Rows[0][1].ToString();
                txtAmaterno.Text = dt.Rows[0][2].ToString();
                dtpInicioObra.Value = Convert.ToDateTime(dt.Rows[0][3].ToString());
                dtpFinObra.Value = Convert.ToDateTime(dt.Rows[0][4].ToString());
                txtValorDia.Text = dt.Rows[0][5].ToString();
                txtDiasTrabajados.Text = dt.Rows[0][6].ToString();
                txtSueldo.Text = dt.Rows[0][7].ToString();
            }
        }
        private void frmSueldoTrabajador_Load(object sender, EventArgs e)
        {
            DataTable dtObra = new DataTable();
            dtObra = objNegoObra.n_listado();
            DataRow rowDoctores;
            rowDoctores = dtObra.NewRow();
            rowDoctores[0] = "0";
            rowDoctores[1] = "Seleccione Obra";
            dtObra.Rows.InsertAt(rowDoctores, 0);
            cbObra.DataSource = dtObra;
            cbObra.DisplayMember = "nombre";
            cbObra.ValueMember = "id_obra";
            cbObra.SelectedItem = 0;
            cbObra.DropDownStyle = ComboBoxStyle.DropDownList;
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
