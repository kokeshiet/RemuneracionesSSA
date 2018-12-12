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
    public partial class frmSueldoObras : Form
    {
        ObraCE objEntidadObra = new ObraCE();
        ObraCN objNegoObra = new ObraCN();
        ObraAsignadaCE objEntidadObraAsig = new ObraAsignadaCE();
        ObraAsignadaCN objNegoObraAsig = new ObraAsignadaCN();

        public frmSueldoObras()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbObra.SelectedIndex == 0)
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
            DataTable dt = objNegoObraAsig.n_listadoSueldoXobra(cbObra.SelectedIndex);
            if (dt.Rows.Count > 0)
            {
                lblSueldo.Text = "$ " + dt.Rows[0][0].ToString();
            }
        }

        private void frmSueldoObras_Load(object sender, EventArgs e)
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
            cbObra.ValueMember = "idobra";
            cbObra.SelectedItem = 0;
            cbObra.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        void Limpiar()
        {
            lblSueldo.Text = "$";
        }

    }
}
