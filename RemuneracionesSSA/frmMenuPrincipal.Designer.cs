namespace RemuneracionesSSA
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trabajadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.obrasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sueldosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finalizarObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnTrabajador = new System.Windows.Forms.ToolStripButton();
            this.btnObra = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAsignarObra = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizarObra = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnMostrarSueldo = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslUsaurio = new System.Windows.Forms.ToolStripStatusLabel();
            this.sueldoPorObraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenedoresToolStripMenuItem,
            this.listadosToolStripMenuItem,
            this.asignacionesToolStripMenuItem,
            this.transaccionesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenedoresToolStripMenuItem
            // 
            this.mantenedoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadoresToolStripMenuItem,
            this.obrasToolStripMenuItem});
            this.mantenedoresToolStripMenuItem.Name = "mantenedoresToolStripMenuItem";
            this.mantenedoresToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.mantenedoresToolStripMenuItem.Text = "Mantenedores";
            // 
            // trabajadoresToolStripMenuItem
            // 
            this.trabajadoresToolStripMenuItem.Name = "trabajadoresToolStripMenuItem";
            this.trabajadoresToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.trabajadoresToolStripMenuItem.Text = "Trabajadores";
            this.trabajadoresToolStripMenuItem.Click += new System.EventHandler(this.trabajadoresToolStripMenuItem_Click);
            // 
            // obrasToolStripMenuItem
            // 
            this.obrasToolStripMenuItem.Name = "obrasToolStripMenuItem";
            this.obrasToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.obrasToolStripMenuItem.Text = "Obras";
            this.obrasToolStripMenuItem.Click += new System.EventHandler(this.obrasToolStripMenuItem_Click);
            // 
            // listadosToolStripMenuItem
            // 
            this.listadosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trabajadoresToolStripMenuItem1,
            this.obrasToolStripMenuItem1,
            this.sueldosToolStripMenuItem,
            this.sueldoPorObraToolStripMenuItem});
            this.listadosToolStripMenuItem.Name = "listadosToolStripMenuItem";
            this.listadosToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.listadosToolStripMenuItem.Text = "Listados";
            // 
            // trabajadoresToolStripMenuItem1
            // 
            this.trabajadoresToolStripMenuItem1.Name = "trabajadoresToolStripMenuItem1";
            this.trabajadoresToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.trabajadoresToolStripMenuItem1.Text = "Trabajadores";
            this.trabajadoresToolStripMenuItem1.Click += new System.EventHandler(this.trabajadoresToolStripMenuItem1_Click);
            // 
            // obrasToolStripMenuItem1
            // 
            this.obrasToolStripMenuItem1.Name = "obrasToolStripMenuItem1";
            this.obrasToolStripMenuItem1.Size = new System.Drawing.Size(190, 22);
            this.obrasToolStripMenuItem1.Text = "Obras";
            this.obrasToolStripMenuItem1.Click += new System.EventHandler(this.obrasToolStripMenuItem1_Click);
            // 
            // sueldosToolStripMenuItem
            // 
            this.sueldosToolStripMenuItem.Name = "sueldosToolStripMenuItem";
            this.sueldosToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sueldosToolStripMenuItem.Text = "Sueldo Por Trabajador";
            this.sueldosToolStripMenuItem.Click += new System.EventHandler(this.sueldosToolStripMenuItem_Click);
            // 
            // asignacionesToolStripMenuItem
            // 
            this.asignacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignarObraToolStripMenuItem,
            this.finalizarObraToolStripMenuItem});
            this.asignacionesToolStripMenuItem.Name = "asignacionesToolStripMenuItem";
            this.asignacionesToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.asignacionesToolStripMenuItem.Text = "Asignaciones";
            // 
            // asignarObraToolStripMenuItem
            // 
            this.asignarObraToolStripMenuItem.Name = "asignarObraToolStripMenuItem";
            this.asignarObraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.asignarObraToolStripMenuItem.Text = "Asignar Obra";
            this.asignarObraToolStripMenuItem.Click += new System.EventHandler(this.asignarObraToolStripMenuItem_Click);
            // 
            // finalizarObraToolStripMenuItem
            // 
            this.finalizarObraToolStripMenuItem.Name = "finalizarObraToolStripMenuItem";
            this.finalizarObraToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.finalizarObraToolStripMenuItem.Text = "Finalizar Obra";
            this.finalizarObraToolStripMenuItem.Click += new System.EventHandler(this.finalizarObraToolStripMenuItem_Click);
            // 
            // transaccionesToolStripMenuItem
            // 
            this.transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            this.transaccionesToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.transaccionesToolStripMenuItem.Text = "Transacciones";
            this.transaccionesToolStripMenuItem.Click += new System.EventHandler(this.transaccionesToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnTrabajador,
            this.btnObra,
            this.toolStripSeparator1,
            this.btnAsignarObra,
            this.btnFinalizarObra,
            this.toolStripSeparator3,
            this.btnMostrarSueldo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 86);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Image = global::RemuneracionesSSA.Properties.Resources.exit_64x64;
            this.btnSalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(68, 83);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTrabajador
            // 
            this.btnTrabajador.Image = global::RemuneracionesSSA.Properties.Resources.Trabajado_64x64;
            this.btnTrabajador.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnTrabajador.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnTrabajador.Name = "btnTrabajador";
            this.btnTrabajador.Size = new System.Drawing.Size(68, 83);
            this.btnTrabajador.Text = "Trabajador";
            this.btnTrabajador.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTrabajador.Click += new System.EventHandler(this.btnTrabajador_Click);
            // 
            // btnObra
            // 
            this.btnObra.Image = global::RemuneracionesSSA.Properties.Resources.Obra_64x64;
            this.btnObra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnObra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnObra.Name = "btnObra";
            this.btnObra.Size = new System.Drawing.Size(68, 83);
            this.btnObra.Text = "Obra";
            this.btnObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnObra.Click += new System.EventHandler(this.btnObra_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 86);
            // 
            // btnAsignarObra
            // 
            this.btnAsignarObra.Image = global::RemuneracionesSSA.Properties.Resources.AsignarObra1_64x64;
            this.btnAsignarObra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAsignarObra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAsignarObra.Name = "btnAsignarObra";
            this.btnAsignarObra.Size = new System.Drawing.Size(80, 83);
            this.btnAsignarObra.Text = "Asignar Obra";
            this.btnAsignarObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAsignarObra.Click += new System.EventHandler(this.btnAsignarObra_Click);
            // 
            // btnFinalizarObra
            // 
            this.btnFinalizarObra.Image = global::RemuneracionesSSA.Properties.Resources.FinalizarObra64x64;
            this.btnFinalizarObra.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFinalizarObra.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizarObra.Name = "btnFinalizarObra";
            this.btnFinalizarObra.Size = new System.Drawing.Size(83, 83);
            this.btnFinalizarObra.Text = "Finalizar Obra";
            this.btnFinalizarObra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinalizarObra.ToolTipText = "Finalizar Obra";
            this.btnFinalizarObra.Click += new System.EventHandler(this.btnFinalizarObra_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 86);
            // 
            // btnMostrarSueldo
            // 
            this.btnMostrarSueldo.Image = global::RemuneracionesSSA.Properties.Resources.Sueldo64x64;
            this.btnMostrarSueldo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnMostrarSueldo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMostrarSueldo.Name = "btnMostrarSueldo";
            this.btnMostrarSueldo.Size = new System.Drawing.Size(106, 83);
            this.btnMostrarSueldo.Text = "Sueldo Trabajador";
            this.btnMostrarSueldo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMostrarSueldo.Click += new System.EventHandler(this.btnMostrarSueldo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslUsaurio});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuario:";
            // 
            // tsslUsaurio
            // 
            this.tsslUsaurio.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslUsaurio.Name = "tsslUsaurio";
            this.tsslUsaurio.Size = new System.Drawing.Size(54, 17);
            this.tsslUsaurio.Text = "Ninguno";
            // 
            // sueldoPorObraToolStripMenuItem
            // 
            this.sueldoPorObraToolStripMenuItem.Name = "sueldoPorObraToolStripMenuItem";
            this.sueldoPorObraToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sueldoPorObraToolStripMenuItem.Text = "Sueldos Por Obra";
            this.sueldoPorObraToolStripMenuItem.Click += new System.EventHandler(this.sueldoPorObraToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "...::: Menu Principal :::... | ...::: Constructora Nova :::...";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trabajadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem obrasToolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnTrabajador;
        private System.Windows.Forms.ToolStripButton btnObra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem asignacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignarObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finalizarObraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldosToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnAsignarObra;
        private System.Windows.Forms.ToolStripButton btnFinalizarObra;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnMostrarSueldo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel tsslUsaurio;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem transaccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sueldoPorObraToolStripMenuItem;
    }
}