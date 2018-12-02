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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrabajador trabajador = new frmTrabajador();
            trabajador.MdiParent = this;
            trabajador.StartPosition = FormStartPosition.CenterParent;
            trabajador.Show();
        }

        private void obrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmObra obra = new frmObra();
            obra.MdiParent = this;
            obra.StartPosition = FormStartPosition.CenterParent;
            obra.Show();
        }
    }
}
