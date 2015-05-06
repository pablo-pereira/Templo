namespace PrototipoInterfazTemplo_2013
{
    partial class GestionSesion
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
            this.btCerrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSegundaOracion = new System.Windows.Forms.ComboBox();
            this.listaIntegrantePresente = new System.Windows.Forms.BindingSource(this.components);
            this.bsSesiones = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.cbPrimeraOracion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.btParticipantes = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listaIntegranteAusentes = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaIntegrantePresente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesiones)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaIntegranteAusentes)).BeginInit();
            this.SuspendLayout();
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(868, 494);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 23);
            this.btCerrar.TabIndex = 4;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Fecha y hora inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha y horario fin";
            // 
            // dtInicio
            // 
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtInicio.Location = new System.Drawing.Point(12, 52);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(81, 20);
            this.dtInicio.TabIndex = 9;
            // 
            // dtFin
            // 
            this.dtFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtFin.Location = new System.Drawing.Point(380, 52);
            this.dtFin.Name = "dtFin";
            this.dtFin.Size = new System.Drawing.Size(81, 20);
            this.dtFin.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Primera oración";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSegundaOracion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbPrimeraOracion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dtFin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtInicio);
            this.groupBox1.Location = new System.Drawing.Point(368, 418);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 99);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // cbSegundaOracion
            // 
            this.cbSegundaOracion.DataSource = this.listaIntegrantePresente;
            this.cbSegundaOracion.DisplayMember = "Miembro";
            this.cbSegundaOracion.FormattingEnabled = true;
            this.cbSegundaOracion.Location = new System.Drawing.Point(237, 51);
            this.cbSegundaOracion.Name = "cbSegundaOracion";
            this.cbSegundaOracion.Size = new System.Drawing.Size(121, 21);
            this.cbSegundaOracion.TabIndex = 15;
            this.cbSegundaOracion.ValueMember = "IdIntegranteComNomb";
            // 
            // listaIntegrantePresente
            // 
            this.listaIntegrantePresente.DataMember = "ListaIntegranteComNomb";
            this.listaIntegrantePresente.DataSource = this.bsSesiones;
            // 
            // bsSesiones
            // 
            this.bsSesiones.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.Sesion);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Segunda oración";
            // 
            // cbPrimeraOracion
            // 
            this.cbPrimeraOracion.DataSource = this.listaIntegrantePresente;
            this.cbPrimeraOracion.DisplayMember = "Miembro";
            this.cbPrimeraOracion.FormattingEnabled = true;
            this.cbPrimeraOracion.Location = new System.Drawing.Point(110, 51);
            this.cbPrimeraOracion.Name = "cbPrimeraOracion";
            this.cbPrimeraOracion.Size = new System.Drawing.Size(121, 21);
            this.cbPrimeraOracion.TabIndex = 13;
            this.cbPrimeraOracion.ValueMember = "IdIntegranteComNomb";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBox3);
            this.groupBox3.Controls.Add(this.listBox2);
            this.groupBox3.Controls.Add(this.btParticipantes);
            this.groupBox3.Controls.Add(this.btQuitar);
            this.groupBox3.Controls.Add(this.btAgregar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(368, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(494, 400);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Participantes";
            // 
            // listBox3
            // 
            this.listBox3.DataSource = this.listaIntegranteAusentes;
            this.listBox3.DisplayMember = "Miembro";
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(289, 59);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(199, 303);
            this.listBox3.TabIndex = 23;
            this.listBox3.ValueMember = "IdIntegranteComNomb";
            // 
            // listBox2
            // 
            this.listBox2.DataSource = this.listaIntegrantePresente;
            this.listBox2.DisplayMember = "Miembro";
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(16, 58);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(186, 303);
            this.listBox2.TabIndex = 22;
            this.listBox2.ValueMember = "IdIntegranteComNomb";
            // 
            // btParticipantes
            // 
            this.btParticipantes.Location = new System.Drawing.Point(183, 371);
            this.btParticipantes.Name = "btParticipantes";
            this.btParticipantes.Size = new System.Drawing.Size(128, 23);
            this.btParticipantes.TabIndex = 21;
            this.btParticipantes.Text = "Gestión Participantes";
            this.btParticipantes.UseVisualStyleBackColor = true;
            this.btParticipantes.Click += new System.EventHandler(this.btGestionParticipantes_Click);
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(209, 198);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(75, 23);
            this.btQuitar.TabIndex = 4;
            this.btQuitar.Text = "<<";
            this.toolTip1.SetToolTip(this.btQuitar, "Quita un participante de la lista Comisión Nombramiento");
            this.btQuitar.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(208, 152);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.Text = ">>";
            this.toolTip1.SetToolTip(this.btAgregar, "Agrega un miembro a la Comisión Nombramiento");
            this.btAgregar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Presentes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ausentes";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox1);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 505);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sesiones";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.bsSesiones;
            this.listBox1.DisplayMember = "FechaHoraInicio";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 23);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(316, 472);
            this.listBox1.TabIndex = 0;
            this.listBox1.ValueMember = "IdSesion";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btGuardar);
            this.groupBox2.Controls.Add(this.btModificar);
            this.groupBox2.Location = new System.Drawing.Point(867, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 99);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(15, 27);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btGuardar, "Agrega una nueva Sesión");
            this.btGuardar.UseVisualStyleBackColor = true;
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(15, 59);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 3;
            this.btModificar.Text = "Modificar";
            this.toolTip1.SetToolTip(this.btModificar, "Modifica una Sesión seleccionada");
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // listaIntegranteAusentes
            // 
            this.listaIntegranteAusentes.DataMember = "ListaIntegranteComNomb";
            this.listaIntegranteAusentes.DataSource = this.bsSesiones;
            // 
            // GestionSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 530);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btCerrar);
            this.Name = "GestionSesion";
            this.Text = "Gestión Sesión";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listaIntegrantePresente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSesiones)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listaIntegranteAusentes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSegundaOracion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPrimeraOracion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btParticipantes;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.BindingSource bsSesiones;
        private System.Windows.Forms.BindingSource listaIntegrantePresente;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.BindingSource listaIntegranteAusentes;
    }
}