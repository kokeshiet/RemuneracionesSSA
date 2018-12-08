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
    public partial class frmAsignarObra : Form
    {
        public frmAsignarObra()
        {
            InitializeComponent();
        }

        TrabajadorCE objEntidadTrabajador = new TrabajadorCE();
        TrabajadorCN objNegoTrabajador = new TrabajadorCN();
        ObraCE objEntidadObra = new ObraCE();
        ObraCN objNegoObra = new ObraCN();
        ObraAsignadaCE objEntidadObraAsig = new ObraAsignadaCE();
        ObraAsignadaCN objNegoObraAsig = new ObraAsignadaCN();

        private void frmAsignarObra_Load(object sender, EventArgs e)
        {
            DataTable dtDoctores = new DataTable();
            dtDoctores = objNegoObra.n_listado();
            DataRow rowDoctores;
            rowDoctores = dtDoctores.NewRow();
            rowDoctores[0] = "0";
            rowDoctores[1] = "Seleccione Obra";
            dtDoctores.Rows.InsertAt(rowDoctores, 0);
            cbObra.DataSource = dtDoctores;
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
                DataTable dt = objNegoTrabajador.n_listadoXrut(Convert.ToInt32(txtRut.Text));
                if (dt.Rows.Count > 0)
                {
                    txtNombre.Text = dt.Rows[0][0].ToString();
                    txtApaterno.Text = dt.Rows[0][1].ToString();
                    txtAmaterno.Text = dt.Rows[0][2].ToString();
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        void Limpiar()
        {
            txtRut.Text = "";
            txtDV.Text = "";
            txtNombre.Text = "";
            txtApaterno.Text = "";
            txtAmaterno.Text = "";
            cbObra.SelectedIndex = 0;
            txtValorDia.Text = "";
            dtFechaInicio.Value = DateTime.Now;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            Insertar();
            Limpiar();
        }

        void Insertar()
        {
            if (txtRut.Text.Length == 0 || txtNombre.Text.Length == 0 || txtApaterno.Text.Length == 0 || txtAmaterno.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                objEntidadObraAsig.rut = Convert.ToInt32(txtRut.Text);
                objEntidadObraAsig.idobra = Convert.ToInt32(cbObra.SelectedValue);
                objEntidadObraAsig.fechainicio = dtFechaInicio.Value;
                objEntidadObraAsig.valordia = Convert.ToInt32(txtValorDia.Text);

                objNegoObraAsig.n_insertar(objEntidadObraAsig);

                MessageBox.Show("Asignación registrada con éxito", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
