namespace PrototipoInterfazTemplo_2013
{
    partial class GestionActividad
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
            this.btGuardar = new System.Windows.Forms.Button();
            this.btBorrar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btNuevo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbDepartamento = new System.Windows.Forms.ComboBox();
            this.cbDificultad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUPDRequeridos = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbActividades = new System.Windows.Forms.ListBox();
            this.bsActividades = new System.Windows.Forms.BindingSource(this.components);
            this.bsDepartamentos = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDRequeridos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsActividades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(15, 27);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btGuardar, "Agrega una nueva Actividad");
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btBorrar
            // 
            this.btBorrar.Location = new System.Drawing.Point(96, 27);
            this.btBorrar.Name = "btBorrar";
            this.btBorrar.Size = new System.Drawing.Size(75, 23);
            this.btBorrar.TabIndex = 2;
            this.btBorrar.Text = "Borrar";
            this.toolTip1.SetToolTip(this.btBorrar, "Borra una Actividad seleccionada");
            this.btBorrar.UseVisualStyleBackColor = true;
            this.btBorrar.Click += new System.EventHandler(this.btBorrar_Click);
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(177, 27);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 3;
            this.btModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btModificar, "Modifica una Actividad seleccionada");
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActividades, "Nombre", true));
            this.tbNombre.Location = new System.Drawing.Point(12, 48);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(346, 20);
            this.tbNombre.TabIndex = 5;
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(646, 520);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 6;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btNuevo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbDepartamento);
            this.groupBox1.Controls.Add(this.cbDificultad);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nUPDRequeridos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNombre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(356, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 423);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(257, 394);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(101, 23);
            this.btNuevo.TabIndex = 15;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Departamento";
            // 
            // cbDepartamento
            // 
            this.cbDepartamento.DataSource = this.bsDepartamentos;
            this.cbDepartamento.DisplayMember = "Nombre";
            this.cbDepartamento.FormattingEnabled = true;
            this.cbDepartamento.Location = new System.Drawing.Point(12, 102);
            this.cbDepartamento.Name = "cbDepartamento";
            this.cbDepartamento.Size = new System.Drawing.Size(346, 21);
            this.cbDepartamento.TabIndex = 13;
            this.cbDepartamento.ValueMember = "IdDepartamento";
            // 
            // cbDificultad
            // 
            this.cbDificultad.FormattingEnabled = true;
            this.cbDificultad.Location = new System.Drawing.Point(14, 358);
            this.cbDificultad.Name = "cbDificultad";
            this.cbDificultad.Size = new System.Drawing.Size(344, 21);
            this.cbDificultad.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Dificultad";
            // 
            // nUPDRequeridos
            // 
            this.nUPDRequeridos.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsActividades, "Requeridos", true));
            this.nUPDRequeridos.Location = new System.Drawing.Point(15, 310);
            this.nUPDRequeridos.Name = "nUPDRequeridos";
            this.nUPDRequeridos.Size = new System.Drawing.Size(60, 20);
            this.nUPDRequeridos.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Requeridos";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsActividades, "Descripcion", true));
            this.tbDescripcion.Location = new System.Drawing.Point(12, 153);
            this.tbDescripcion.Multiline = true;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(346, 122);
            this.tbDescripcion.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripción";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCancelar);
            this.groupBox2.Controls.Add(this.btBorrar);
            this.groupBox2.Controls.Add(this.btGuardar);
            this.groupBox2.Controls.Add(this.btModificar);
            this.groupBox2.Location = new System.Drawing.Point(356, 448);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 66);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(258, 27);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 23);
            this.btCancelar.TabIndex = 6;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbActividades);
            this.groupBox3.Location = new System.Drawing.Point(12, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(338, 501);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actividades";
            // 
            // lbActividades
            // 
            this.lbActividades.DataSource = this.bsActividades;
            this.lbActividades.DisplayMember = "Nombre";
            this.lbActividades.FormattingEnabled = true;
            this.lbActividades.Location = new System.Drawing.Point(12, 22);
            this.lbActividades.Name = "lbActividades";
            this.lbActividades.Size = new System.Drawing.Size(315, 459);
            this.lbActividades.TabIndex = 0;
            this.lbActividades.ValueMember = "IdActividad";
            // 
            // bsActividades
            // 
            this.bsActividades.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.Actividad);
            // 
            // bsDepartamentos
            // 
            this.bsDepartamentos.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.Departamento);
            // 
            // GestionActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 547);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCerrar);
            this.Name = "GestionActividad";
            this.Text = "Gestión Actividad";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUPDRequeridos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsActividades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDepartamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btBorrar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nUPDRequeridos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDificultad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbDepartamento;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.ListBox lbActividades;
        private System.Windows.Forms.BindingSource bsActividades;
        private System.Windows.Forms.BindingSource bsDepartamentos;
    }
}