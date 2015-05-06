namespace PrototipoInterfazTemplo_2013
{
    partial class GestionMiembro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        public static bool abierto =false; 

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
            this.btImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellido = new System.Windows.Forms.TextBox();
            this.bsMiembros = new System.Windows.Forms.BindingSource(this.components);
            this.tbTel = new System.Windows.Forms.TextBox();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.tbNombre = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDirecion = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.chMiembros = new System.Windows.Forms.CheckBox();
            this.chEliminados = new System.Windows.Forms.CheckBox();
            this.gbMiembros = new System.Windows.Forms.GroupBox();
            this.dgMiembros = new System.Windows.Forms.DataGridView();
            this.idMiembroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCompletoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaBajaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbAcciones = new System.Windows.Forms.GroupBox();
            this.btModificar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.lbBusqueda = new System.Windows.Forms.Label();
            this.tbBuscarMiembro = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bsMiembros)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.gbMiembros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMiembros)).BeginInit();
            this.gbAcciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExportar
            // 
            this.btExportar.Location = new System.Drawing.Point(4, 566);
            this.btExportar.Name = "btExportar";
            this.btExportar.Size = new System.Drawing.Size(75, 23);
            this.btExportar.TabIndex = 4;
            this.btExportar.Text = "Exportar";
            this.btExportar.UseVisualStyleBackColor = true;
            // 
            // btImportar
            // 
            this.btImportar.Location = new System.Drawing.Point(85, 566);
            this.btImportar.Name = "btImportar";
            this.btImportar.Size = new System.Drawing.Size(75, 23);
            this.btImportar.TabIndex = 5;
            this.btImportar.Text = "Importar";
            this.btImportar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Teléfono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Mail";
            // 
            // tbApellido
            // 
            this.tbApellido.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMiembros, "Apellido", true));
            this.errorProvider.SetError(this.tbApellido, "Apellido requerido.");
            this.tbApellido.Location = new System.Drawing.Point(6, 87);
            this.tbApellido.Name = "tbApellido";
            this.tbApellido.Size = new System.Drawing.Size(230, 20);
            this.tbApellido.TabIndex = 11;
            this.tbApellido.Validating += new System.ComponentModel.CancelEventHandler(this.tbApellido_Validating);
            // 
            // bsMiembros
            // 
            this.bsMiembros.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.Miembro);
            // 
            // tbTel
            // 
            this.tbTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMiembros, "Telefono", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.errorProvider.SetError(this.tbTel, "Telefono no válido.");
            this.tbTel.Location = new System.Drawing.Point(6, 139);
            this.tbTel.Name = "tbTel";
            this.tbTel.Size = new System.Drawing.Size(230, 20);
            this.tbTel.TabIndex = 12;
            this.tbTel.Validating += new System.ComponentModel.CancelEventHandler(this.tbTel_Validating);
            // 
            // tbMail
            // 
            this.tbMail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMiembros, "Mail", true));
            this.errorProvider.SetError(this.tbMail, "Mail invalido.");
            this.tbMail.Location = new System.Drawing.Point(6, 189);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(230, 20);
            this.tbMail.TabIndex = 13;
            this.tbMail.Validating += new System.ComponentModel.CancelEventHandler(this.tbMail_Validating);
            // 
            // btCerrar
            // 
            this.btCerrar.Location = new System.Drawing.Point(939, 566);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(100, 23);
            this.btCerrar.TabIndex = 14;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.tbNombre);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.btNuevo);
            this.gbDatos.Controls.Add(this.tbDirecion);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.tbMail);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.tbTel);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.tbApellido);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Location = new System.Drawing.Point(760, 117);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(285, 321);
            this.gbDatos.TabIndex = 15;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos";
            // 
            // tbNombre
            // 
            this.tbNombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMiembros, "Nombre", true));
            this.tbNombre.Location = new System.Drawing.Point(6, 43);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(230, 20);
            this.tbNombre.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Dirección";
            // 
            // tbDirecion
            // 
            this.tbDirecion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsMiembros, "Direccion", true));
            this.tbDirecion.Location = new System.Drawing.Point(6, 237);
            this.tbDirecion.Name = "tbDirecion";
            this.tbDirecion.Size = new System.Drawing.Size(233, 20);
            this.tbDirecion.TabIndex = 14;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(6, 36);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 23);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Borrar";
            this.toolTip1.SetToolTip(this.btEliminar, "Borra un Miembro seleccionado");
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(179, 65);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(100, 23);
            this.btGuardar.TabIndex = 1;
            this.btGuardar.Text = "Guardar";
            this.toolTip1.SetToolTip(this.btGuardar, "Agrega un nuevo Miembro");
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // chMiembros
            // 
            this.chMiembros.AutoSize = true;
            this.chMiembros.Location = new System.Drawing.Point(6, 19);
            this.chMiembros.Name = "chMiembros";
            this.chMiembros.Size = new System.Drawing.Size(139, 17);
            this.chMiembros.TabIndex = 20;
            this.chMiembros.Text = "Ver Todos los Miembros";
            this.toolTip1.SetToolTip(this.chMiembros, "Muestra los miembros activos y miembros eliminados.");
            this.chMiembros.UseVisualStyleBackColor = true;
            this.chMiembros.CheckedChanged += new System.EventHandler(this.chMiembros_CheckedChanged);
            // 
            // chEliminados
            // 
            this.chEliminados.AutoSize = true;
            this.chEliminados.Location = new System.Drawing.Point(6, 42);
            this.chEliminados.Name = "chEliminados";
            this.chEliminados.Size = new System.Drawing.Size(143, 17);
            this.chEliminados.TabIndex = 21;
            this.chEliminados.Text = "Ver Miembros Eliminados";
            this.toolTip1.SetToolTip(this.chEliminados, "Muestra solamente los miembro eliminados.");
            this.chEliminados.UseVisualStyleBackColor = true;
            this.chEliminados.CheckedChanged += new System.EventHandler(this.chEliminados_CheckedChanged);
            // 
            // gbMiembros
            // 
            this.gbMiembros.Controls.Add(this.dgMiembros);
            this.gbMiembros.Location = new System.Drawing.Point(8, 117);
            this.gbMiembros.Name = "gbMiembros";
            this.gbMiembros.Size = new System.Drawing.Size(746, 443);
            this.gbMiembros.TabIndex = 18;
            this.gbMiembros.TabStop = false;
            this.gbMiembros.Text = "Miembros";
            // 
            // dgMiembros
            // 
            this.dgMiembros.AllowUserToAddRows = false;
            this.dgMiembros.AllowUserToDeleteRows = false;
            this.dgMiembros.AllowUserToOrderColumns = true;
            this.dgMiembros.AllowUserToResizeRows = false;
            this.dgMiembros.AutoGenerateColumns = false;
            this.dgMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMiembros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMiembroDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.nombreCompletoDataGridViewTextBoxColumn,
            this.fechaBajaDataGridViewTextBoxColumn});
            this.dgMiembros.DataSource = this.bsMiembros;
            this.dgMiembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgMiembros.Location = new System.Drawing.Point(3, 16);
            this.dgMiembros.MultiSelect = false;
            this.dgMiembros.Name = "dgMiembros";
            this.dgMiembros.ReadOnly = true;
            this.dgMiembros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMiembros.Size = new System.Drawing.Size(740, 424);
            this.dgMiembros.TabIndex = 0;
            // 
            // idMiembroDataGridViewTextBoxColumn
            // 
            this.idMiembroDataGridViewTextBoxColumn.DataPropertyName = "IdMiembro";
            this.idMiembroDataGridViewTextBoxColumn.HeaderText = "IdMiembro";
            this.idMiembroDataGridViewTextBoxColumn.Name = "idMiembroDataGridViewTextBoxColumn";
            this.idMiembroDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMiembroDataGridViewTextBoxColumn.Visible = false;
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "Apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            this.apellidoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            this.telefonoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCompletoDataGridViewTextBoxColumn
            // 
            this.nombreCompletoDataGridViewTextBoxColumn.DataPropertyName = "NombreCompleto";
            this.nombreCompletoDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreCompletoDataGridViewTextBoxColumn.Name = "nombreCompletoDataGridViewTextBoxColumn";
            this.nombreCompletoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCompletoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fechaBajaDataGridViewTextBoxColumn
            // 
            this.fechaBajaDataGridViewTextBoxColumn.DataPropertyName = "FechaBaja";
            this.fechaBajaDataGridViewTextBoxColumn.HeaderText = "FechaBaja";
            this.fechaBajaDataGridViewTextBoxColumn.Name = "fechaBajaDataGridViewTextBoxColumn";
            this.fechaBajaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // gbAcciones
            // 
            this.gbAcciones.Controls.Add(this.btModificar);
            this.gbAcciones.Controls.Add(this.btCancelar);
            this.gbAcciones.Controls.Add(this.btEliminar);
            this.gbAcciones.Controls.Add(this.btGuardar);
            this.gbAcciones.Location = new System.Drawing.Point(760, 444);
            this.gbAcciones.Name = "gbAcciones";
            this.gbAcciones.Size = new System.Drawing.Size(285, 113);
            this.gbAcciones.TabIndex = 19;
            this.gbAcciones.TabStop = false;
            this.gbAcciones.Text = "Acciones";
            // 
            // btModificar
            // 
            this.btModificar.Location = new System.Drawing.Point(6, 65);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(100, 23);
            this.btModificar.TabIndex = 6;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Enabled = false;
            this.btCancelar.Location = new System.Drawing.Point(179, 36);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(100, 23);
            this.btCancelar.TabIndex = 5;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Location = new System.Drawing.Point(6, 292);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(100, 23);
            this.btNuevo.TabIndex = 4;
            this.btNuevo.Text = "Nuevo";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.DataSource = this.bsMiembros;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.lbBusqueda);
            this.gbFiltros.Controls.Add(this.tbBuscarMiembro);
            this.gbFiltros.Controls.Add(this.chEliminados);
            this.gbFiltros.Controls.Add(this.chMiembros);
            this.gbFiltros.Location = new System.Drawing.Point(8, 12);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1037, 99);
            this.gbFiltros.TabIndex = 21;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros";
            // 
            // lbBusqueda
            // 
            this.lbBusqueda.AutoSize = true;
            this.lbBusqueda.Location = new System.Drawing.Point(6, 68);
            this.lbBusqueda.Name = "lbBusqueda";
            this.lbBusqueda.Size = new System.Drawing.Size(146, 13);
            this.lbBusqueda.TabIndex = 23;
            this.lbBusqueda.Text = "Buscar Miembros por Nombre";
            // 
            // tbBuscarMiembro
            // 
            this.tbBuscarMiembro.Location = new System.Drawing.Point(158, 65);
            this.tbBuscarMiembro.Name = "tbBuscarMiembro";
            this.tbBuscarMiembro.Size = new System.Drawing.Size(585, 20);
            this.tbBuscarMiembro.TabIndex = 22;
            this.tbBuscarMiembro.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbBuscarMiembro_MouseClick);
            this.tbBuscarMiembro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBuscarMiembro_KeyPress);
            // 
            // GestionMiembro
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1057, 601);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.gbAcciones);
            this.Controls.Add(this.gbMiembros);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btImportar);
            this.Controls.Add(this.btExportar);
            this.Name = "GestionMiembro";
            this.Text = "Gestión Miembro";
            ((System.ComponentModel.ISupportInitialize)(this.bsMiembros)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbMiembros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgMiembros)).EndInit();
            this.gbAcciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btExportar;
        private System.Windows.Forms.Button btImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellido;
        private System.Windows.Forms.TextBox tbTel;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox gbMiembros;
        private System.Windows.Forms.GroupBox gbAcciones;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDirecion;
        private System.Windows.Forms.BindingSource bsMiembros;
        private System.Windows.Forms.DataGridView dgMiembros;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.MaskedTextBox tbNombre;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.CheckBox chEliminados;
        private System.Windows.Forms.CheckBox chMiembros;
        private System.Windows.Forms.TextBox tbBuscarMiembro;
        private System.Windows.Forms.Label lbBusqueda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMiembroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaBajaDataGridViewTextBoxColumn;
    }
}