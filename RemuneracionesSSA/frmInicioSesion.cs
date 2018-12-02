using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RemuneracionesSSA
{
    public partial class frmInicioSesion : Form
    {
        public frmInicioSesion()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable dtsRetorno = new DataTable();
            dtsRetorno = CapaDatos.UsuarioCD.loginUsuario(txtUsuario.Text, txtContrasenia.Text);
            if (dtsRetorno.Rows.Count > 0)
            {
                frmMenuPrincipal frmInicio = new frmMenuPrincipal();
                frmInicio.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario y/o Contraseña incorrecta, intente nuevamente");
            }
        }
    }
}
