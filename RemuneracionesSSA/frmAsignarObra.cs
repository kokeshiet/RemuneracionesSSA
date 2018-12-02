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

        TrabajadorCE objEntidad = new TrabajadorCE();
        TrabajadorCN objNego = new TrabajadorCN();

        private void frmAsignarObra_Load(object sender, EventArgs e)
        {
            DataTable dtDoctores = new DataTable();
            dtDoctores = objNego.n_listado();
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
                DataTable dt = objNego.n_listadoXrut(Convert.ToInt32(txtRut.Text));
                if (dt.Rows.Count > 0)
                {
                    txtNombre.Text = dt.Rows[0][0].ToString();
                    txtApaterno.Text = dt.Rows[0][1].ToString();
                    txtAmaterno.Text = dt.Rows[0][2].ToString();
                }
            }
        }
    }
}
