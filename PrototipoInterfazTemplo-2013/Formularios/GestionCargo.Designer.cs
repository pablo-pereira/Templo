namespace PrototipoInterfazTemplo_2013
{
    partial class GestionCargo
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
            this.components = new System.ComponentModel.Container();
            this.btExportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.bsCargos = new System.Windows.Forms.BindingSource(this.components);
            this.chMayoriaSimple = new System.Windows.Forms.CheckBox();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.bsDepartamentos = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.chMiembroJunta = new System.Windows.Forms.CheckBox();
            this.chMitadMasUno = new System.Windows.Forms.CheckBox();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUPDCupo = new System.Windows.Forms.NumericUpDown();
            this.btCerrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btBorrar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartamentos)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDCupo)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(356, 510);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(75, 23);
            this.btExportar.TabIndex = 4;
            this.btExportar.Text = "Exportar";
            this.btExportar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCargos, "Nombre", true));
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bsCargos, "Nombre", true));
            this.tbNombre.Location = new System.Drawing.Point(15, 53);
            this.tbNombre.Multiline = true;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(342, 20);
            this.tbNombre.TabIndex = 6;
            // 
            // bsCargos
            // 
            this.bsCargos.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.Cargo);
            // 
            // chMayoriaSimple
            // 
            this.chMayoriaSimple.AutoSize = true;
            this.chMayoriaSimple.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsCargos, "MayoriaSimple", true));
            this.chMayoriaSimple.Location = new System.Drawing.Point(15, 296);
            this.chMayoriaSimple.Name = "chMayoriaSimple";
            this.chMayoriaSimple.Size = new System.Drawing.Size(97, 17);
            this.chMayoriaSimple.TabIndex = 8;
            this.chMayoriaSimple.Text = "Mayoría simple";
            this.chMayoriaSimple.UseVisualStyleBackColor = true;
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DataSource = this.bsDepartamentos;
            this.cbDepartamento.DisplayMember = "Nombre";
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(15, 103);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(342, 21);
            this.cbDepartamento.TabIndex = 10;
            this.cbDepartamento.ValueMember = "IdDepartamento";
            // 
            // bsDepartamentos
            // 
            this.bsDepartamentos.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.Departamento);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Limite de Cargos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNuevo);
            this.groupBox1.Controls.Add(this.chMiembroJunta);
            this.groupBox1.Controls.Add(this.chMitadMasUno);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nUPDCupo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.chMayoriaSimple);
            this.groupBox1.Controls.Add(this.cbDepartamento);
            this.groupBox1.Location = new System.Drawing.Point(356, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 395);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(297, 363);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(60, 23);
            this.btNuevo.TabIndex = 4;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // chMiembroJunta
            // 
            this.chMiembroJunta.AutoSize = true;
            this.chMiembroJunta.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsCargos, "MiembroJunta", true));
            this.chMiembroJunta.Location = new System.Drawing.Point(15, 363);
            this.chMiembroJunta.Name = "chMiembroJunta";
            this.chMiembroJunta.Size = new System.Drawing.Size(110, 17);
            this.chMiembroJunta.TabIndex = 18;
            this.chMiembroJunta.Text = "Miembro de Junta";
            this.chMiembroJunta.UseVisualStyleBackColor = true;
            // 
            // chMitadMasUno
            // 
            this.chMitadMasUno.AutoSize = true;
            this.chMitadMasUno.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsCargos, "MitadMasUno", true));
            this.chMitadMasUno.Location = new System.Drawing.Point(16, 330);
            this.chMitadMasUno.Name = "chMitadMasUno";
            this.chMitadMasUno.Size = new System.Drawing.Size(95, 17);
            this.chMitadMasUno.TabIndex = 17;
            this.chMitadMasUno.Text = "Mitad más uno";
            this.chMitadMasUno.UseVisualStyleBackColor = true;
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCargos, "Descripcion", true));
            this.tbDescripcion.Location = new System.Drawing.Point(15, 157);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(342, 70);
            this.tbDescripcion.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Descripción";
            // 
            // nUPDCupo
            // 
            this.nUPDCupo.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsCargos, "Cupo", true));
            this.nUPDCupo.Location = new System.Drawing.Point(15, 258);
            this.nUPDCupo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUPDCupo.Name = "nUPDCupo";
            this.nUPDCupo.Size = new System.Drawing.Size(52, 20);
            this.nUPDCupo.TabIndex = 14;
            this.nUPDCupo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(644, 510);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 7;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(177, 27);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 2;
            this.btBorrar.Text = "Borrar";
            this.toolTip1.SetToolTip(this.btBorrar, "Borra un Cargo seleccionado");
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(15, 27);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btGuardar, "Agrega un nuevo Cargo");
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(96, 27);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 3;
            this.btModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btModificar, "Modifica un Cargo seleccionado");
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 521);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cargos";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.bsCargos;
            this.listBox1.DisplayMember = "Nombre";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(326, 498);
            this.listBox1.TabIndex = 1;
            this.listBox1.ValueMember = "IdCargo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCancelar);
            this.groupBox2.Controls.Add(this.btBorrar);
            this.groupBox2.Controls.Add(this.btGuardar);
            this.groupBox2.Controls.Add(this.btModificar);
            this.groupBox2.Location = new System.Drawing.Point(356, 423);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 69);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(258, 28);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(81, 22);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // GestionCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 545);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btExportar);
            this.Name = "GestionCargo";
            this.Text = "Gestión Cargo";
            ((System.ComponentModel.ISupportInitialize)(this.bsCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartamentos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDCupo)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chMayoriaSimple;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.NumericUpDown nUPDCupo;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chMitadMasUno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.CheckBox chMiembroJunta;
        private System.Windows.Forms.BindingSource bsCargos;
        private System.Windows.Forms.BindingSource bsDepartamentos;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ListBox listBox1;
        internal System.Windows.Forms.TextBox tbNombre;
    }
}