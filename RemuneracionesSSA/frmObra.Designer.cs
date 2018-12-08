namespace RemuneracionesSSA
{
    partial class frmObra
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvObra = new System.Windows.Forms.DataGridView();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDetalle);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Obra";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Location = new System.Drawing.Point(56, 71);
            this.txtDetalle.MaxLength = 50;
            this.txtDetalle.Multiline = true;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(133, 44);
            this.txtDetalle.TabIndex = 5;
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(56, 45);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(133, 20);
            this.txtNombre.TabIndex = 4;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(56, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(28, 20);
            this.txtID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(234, 31);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(234, 60);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvObra
            // 
            this.dgvObra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvObra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Eliminar,
            this.Modificar});
            this.dgvObra.Location = new System.Drawing.Point(12, 142);
            this.dgvObra.Name = "dgvObra";
            this.dgvObra.Size = new System.Drawing.Size(520, 89);
            this.dgvObra.TabIndex = 3;
            this.dgvObra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObra_CellContentClick);
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 49;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Name = "Modificar";
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar.Width = 75;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(234, 89);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmObra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 240);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvObra);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmObra";
            this.Text = "...::: Mantenedor Obra :::...";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dgvObra;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewButtonColumn Modificar;
        private System.Windows.Forms.Button btnLimpiar;
    }
}