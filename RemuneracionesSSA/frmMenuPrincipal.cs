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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTrabajador_Click(object sender, EventArgs e)
        {
            trabajadoresToolStripMenuItem_Click(sender, e);
        }

        private void btnObra_Click(object sender, EventArgs e)
        {
            obrasToolStripMenuItem_Click(sender, e);
        }

        private void trabajadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadoTrabajador listadoTrabajador = new frmListadoTrabajador();
            listadoTrabajador.MdiParent = this;
            listadoTrabajador.StartPosition = FormStartPosition.CenterParent;
            listadoTrabajador.Show();
        }

        private void asignarObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAsignarObra asignarObra = new frmAsignarObra();
            asignarObra.MdiParent = this;
            asignarObra.StartPosition = FormStartPosition.CenterParent;
            asignarObra.Show();
        }

        private void finalizarObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFinalizarObra finalizarObra = new frmFinalizarObra();
            finalizarObra.MdiParent = this;
            finalizarObra.StartPosition = FormStartPosition.CenterParent;
            finalizarObra.Show();
        }

        private void obrasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmListadoObra listadoObra = new frmListadoObra();
            listadoObra.MdiParent = this;
            listadoObra.StartPosition = FormStartPosition.CenterParent;
            listadoObra.Show();
        }

        private void btnAsignarObra_Click(object sender, EventArgs e)
        {
            asignarObraToolStripMenuItem_Click(sender, e);

        }

        private void btnFinalizarObra_Click(object sender, EventArgs e)
        {
            finalizarObraToolStripMenuItem_Click(sender, e);
        }

        private void sueldosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoTrabajador sueldoTrabajador = new frmSueldoTrabajador();
            sueldoTrabajador.MdiParent = this;
            sueldoTrabajador.StartPosition = FormStartPosition.CenterParent;
            sueldoTrabajador.Show();
        }

        private void btnMostrarSueldo_Click(object sender, EventArgs e)
        {
            sueldosToolStripMenuItem_Click(sender, e);
        }

        private void sueldoTrabajadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoTrabajador sueldoTrabajador = new frmSueldoTrabajador();
            sueldoTrabajador.MdiParent = this;
            sueldoTrabajador.StartPosition = FormStartPosition.CenterParent;
            sueldoTrabajador.Show();
        }

        private void transaccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransacciones transacciones = new frmTransacciones();
            transacciones.MdiParent = this;
            transacciones.StartPosition = FormStartPosition.CenterParent;
            transacciones.Show();
        }

        private void sueldoPorObraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSueldoObras sueldoObras = new frmSueldoObras();
            sueldoObras.MdiParent = this;
            sueldoObras.StartPosition = FormStartPosition.CenterParent;
            sueldoObras.Show();
        }
    }
}
