namespace RemuneracionesSSA
{
    partial class frmSueldoTrabajador
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
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.cbObra = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtDV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblSueldo = new System.Windows.Forms.Label();
            this.lblDiasTrabajados = new System.Windows.Forms.Label();
            this.lblValorDia = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.lblAmaterno = new System.Windows.Forms.Label();
            this.lblApaterno = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtSueldo = new System.Windows.Forms.TextBox();
            this.txtDiasTrabajados = new System.Windows.Forms.TextBox();
            this.txtValorDia = new System.Windows.Forms.TextBox();
            this.dtpFinObra = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioObra = new System.Windows.Forms.DateTimePicker();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Controls.Add(this.cbObra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.txtDV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 74);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Criterios de Busqueda";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(221, 43);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // cbObra
            // 
            this.cbObra.FormattingEnabled = true;
            this.cbObra.Location = new System.Drawing.Point(42, 45);
            this.cbObra.Name = "cbObra";
            this.cbObra.Size = new System.Drawing.Size(147, 21);
            this.cbObra.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Obra";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(221, 17);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtDV
            // 
            this.txtDV.Enabled = false;
            this.txtDV.Location = new System.Drawing.Point(164, 19);
            this.txtDV.Name = "txtDV";
            this.txtDV.Size = new System.Drawing.Size(25, 20);
            this.txtDV.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(42, 19);
            this.txtRut.MaxLength = 8;
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 1;
            this.txtRut.TextChanged += new System.EventHandler(this.txtRut_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSueldo);
            this.groupBox2.Controls.Add(this.lblDiasTrabajados);
            this.groupBox2.Controls.Add(this.lblValorDia);
            this.groupBox2.Controls.Add(this.lblFechaFin);
            this.groupBox2.Controls.Add(this.lblFechaInicio);
            this.groupBox2.Controls.Add(this.lblAmaterno);
            this.groupBox2.Controls.Add(this.lblApaterno);
            this.groupBox2.Controls.Add(this.lblNombre);
            this.groupBox2.Controls.Add(this.txtSueldo);
            this.groupBox2.Controls.Add(this.txtDiasTrabajados);
            this.groupBox2.Controls.Add(this.txtValorDia);
            this.groupBox2.Controls.Add(this.dtpFinObra);
            this.groupBox2.Controls.Add(this.dtpInicioObra);
            this.groupBox2.Controls.Add(this.txtAmaterno);
            this.groupBox2.Controls.Add(this.txtApaterno);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // lblSueldo
            // 
            this.lblSueldo.AutoSize = true;
            this.lblSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSueldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSueldo.Location = new System.Drawing.Point(126, 204);
            this.lblSueldo.Name = "lblSueldo";
            this.lblSueldo.Size = new System.Drawing.Size(24, 20);
            this.lblSueldo.TabIndex = 25;
            this.lblSueldo.Text = "$ ";
            // 
            // lblDiasTrabajados
            // 
            this.lblDiasTrabajados.AutoSize = true;
            this.lblDiasTrabajados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiasTrabajados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDiasTrabajados.Location = new System.Drawing.Point(127, 178);
            this.lblDiasTrabajados.Name = "lblDiasTrabajados";
            this.lblDiasTrabajados.Size = new System.Drawing.Size(0, 13);
            this.lblDiasTrabajados.TabIndex = 24;
            // 
            // lblValorDia
            // 
            this.lblValorDia.AutoSize = true;
            this.lblValorDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorDia.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblValorDia.Location = new System.Drawing.Point(126, 152);
            this.lblValorDia.Name = "lblValorDia";
            this.lblValorDia.Size = new System.Drawing.Size(14, 13);
            this.lblValorDia.TabIndex = 23;
            this.lblValorDia.Text = "$";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaFin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaFin.Location = new System.Drawing.Point(424, 129);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(63, 13);
            this.lblFechaFin.TabIndex = 22;
            this.lblFechaFin.Text = "aaaaaaaa";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaInicio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFechaInicio.Location = new System.Drawing.Point(424, 103);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(77, 13);
            this.lblFechaInicio.TabIndex = 21;
            this.lblFechaInicio.Text = "aaaaaaaaaa";
            // 
            // lblAmaterno
            // 
            this.lblAmaterno.AutoSize = true;
            this.lblAmaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmaterno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmaterno.Location = new System.Drawing.Point(127, 74);
            this.lblAmaterno.Name = "lblAmaterno";
            this.lblAmaterno.Size = new System.Drawing.Size(0, 13);
            this.lblAmaterno.TabIndex = 20;
            // 
            // lblApaterno
            // 
            this.lblApaterno.AutoSize = true;
            this.lblApaterno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApaterno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblApaterno.Location = new System.Drawing.Point(126, 48);
            this.lblApaterno.Name = "lblApaterno";
            this.lblApaterno.Size = new System.Drawing.Size(0, 13);
            this.lblApaterno.TabIndex = 19;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblNombre.Location = new System.Drawing.Point(126, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 13);
            this.lblNombre.TabIndex = 18;
            // 
            // txtSueldo
            // 
            this.txtSueldo.Enabled = false;
            this.txtSueldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSueldo.ForeColor = System.Drawing.Color.Red;
            this.txtSueldo.Location = new System.Drawing.Point(427, 209);
            this.txtSueldo.Name = "txtSueldo";
            this.txtSueldo.Size = new System.Drawing.Size(100, 26);
            this.txtSueldo.TabIndex = 17;
            // 
            // txtDiasTrabajados
            // 
            this.txtDiasTrabajados.Enabled = false;
            this.txtDiasTrabajados.Location = new System.Drawing.Point(427, 178);
            this.txtDiasTrabajados.Name = "txtDiasTrabajados";
            this.txtDiasTrabajados.Size = new System.Drawing.Size(25, 20);
            this.txtDiasTrabajados.TabIndex = 16;
            // 
            // txtValorDia
            // 
            this.txtValorDia.Enabled = false;
            this.txtValorDia.Location = new System.Drawing.Point(427, 152);
            this.txtValorDia.Name = "txtValorDia";
            this.txtValorDia.Size = new System.Drawing.Size(58, 20);
            this.txtValorDia.TabIndex = 15;
            // 
            // dtpFinObra
            // 
            this.dtpFinObra.Enabled = false;
            this.dtpFinObra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinObra.Location = new System.Drawing.Point(129, 123);
            this.dtpFinObra.Name = "dtpFinObra";
            this.dtpFinObra.Size = new System.Drawing.Size(100, 20);
            this.dtpFinObra.TabIndex = 14;
            // 
            // dtpInicioObra
            // 
            this.dtpInicioObra.Enabled = false;
            this.dtpInicioObra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioObra.Location = new System.Drawing.Point(129, 97);
            this.dtpInicioObra.Name = "dtpInicioObra";
            this.dtpInicioObra.Size = new System.Drawing.Size(100, 20);
            this.dtpInicioObra.TabIndex = 13;
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.Enabled = false;
            this.txtAmaterno.Location = new System.Drawing.Point(427, 71);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(129, 20);
            this.txtAmaterno.TabIndex = 12;
            // 
            // txtApaterno
            // 
            this.txtApaterno.Enabled = false;
            this.txtApaterno.Location = new System.Drawing.Point(427, 45);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(129, 20);
            this.txtApaterno.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(427, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(129, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Total a cancelar";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Dias Trabajados";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Valor Día";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Fin Obra";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Inicio Obra";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Apellido Materno";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Apellido Paterno";
            // 
            // frmSueldoTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSueldoTrabajador";
            this.Text = "...::: Sueldo Trabajador :::...";
            this.Load += new System.EventHandler(this.frmSueldoTrabajador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbObra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSueldo;
        private System.Windows.Forms.TextBox txtDiasTrabajados;
        private System.Windows.Forms.TextBox txtValorDia;
        private System.Windows.Forms.DateTimePicker dtpFinObra;
        private System.Windows.Forms.DateTimePicker dtpInicioObra;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSueldo;
        private System.Windows.Forms.Label lblDiasTrabajados;
        private System.Windows.Forms.Label lblValorDia;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.Label lblAmaterno;
        private System.Windows.Forms.Label lblApaterno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiar;
    }
}