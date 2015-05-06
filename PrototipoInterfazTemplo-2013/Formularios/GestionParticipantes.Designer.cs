namespace PrototipoInterfazTemplo_2013
{
    partial class GestionParticipantes
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbIntegrantes = new System.Windows.Forms.ListBox();
            this.bsParticipantes = new System.Windows.Forms.BindingSource(this.components);
            this.lbMiembros = new System.Windows.Forms.ListBox();
            this.bsMiembros = new System.Windows.Forms.BindingSource(this.components);
            this.btConfirmar = new System.Windows.Forms.Button();
            this.btQuitar = new System.Windows.Forms.Button();
            this.btAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsParticipantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbIntegrantes);
            this.groupBox3.Controls.Add(this.lbMiembros);
            this.groupBox3.Controls.Add(this.btConfirmar);
            this.groupBox3.Controls.Add(this.btQuitar);
            this.groupBox3.Controls.Add(this.btAgregar);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(642, 522);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Participantes";
            // 
            // lbIntegrantes
            // 
            this.lbIntegrantes.DataSource = this.bsParticipantes;
            this.lbIntegrantes.DisplayMember = "Miembro.NombreCompleto";
            this.lbIntegrantes.FormattingEnabled = true;
            this.lbIntegrantes.Location = new System.Drawing.Point(365, 48);
            this.lbIntegrantes.Name = "lbIntegrantes";
            this.lbIntegrantes.Size = new System.Drawing.Size(261, 459);
            this.lbIntegrantes.TabIndex = 18;
            this.lbIntegrantes.ValueMember = "IdIntegranteComNomb";
            // 
            // bsParticipantes
            // 
            this.bsParticipantes.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.IntegranteComNomb);
            // 
            // lbMiembros
            // 
            this.lbMiembros.DataSource = this.bsMiembros;
            this.lbMiembros.DisplayMember = "NombreCompleto";
            this.lbMiembros.FormattingEnabled = true;
            this.lbMiembros.Location = new System.Drawing.Point(13, 48);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.Size = new System.Drawing.Size(261, 459);
            this.lbMiembros.TabIndex = 17;
            this.lbMiembros.ValueMember = "IdMiembro";
            // 
            // bsMiembros
            // 
            this.bsMiembros.DataSource = typeof(PrototipoInterfazTemplo_2013.Entidades.Miembro);
            // 
            // btConfirmar
            // 
            this.btConfirmar.Location = new System.Drawing.Point(284, 303);
            this.btConfirmar.Name = "btConfirmar";
            this.btConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btConfirmar.TabIndex = 16;
            this.btConfirmar.Text = "Confirmar";
            this.btConfirmar.UseVisualStyleBackColor = true;
            this.btConfirmar.Click += new System.EventHandler(this.btConfirmar_Click);
            // 
            // btQuitar
            // 
            this.btQuitar.Location = new System.Drawing.Point(284, 246);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(75, 23);
            this.btQuitar.TabIndex = 4;
            this.btQuitar.Text = "<<";
            this.btQuitar.UseVisualStyleBackColor = true;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(284, 182);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 3;
            this.btAgregar.Text = ">>";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(398, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Lista de participantes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lista de miembros";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(579, 540);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Cerrar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // GestionParticipantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 575);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox3);
            this.Name = "GestionParticipantes";
            this.Text = "GestionParticipantes";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsParticipantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMiembros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btConfirmar;
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbIntegrantes;
        private System.Windows.Forms.ListBox lbMiembros;
        private System.Windows.Forms.BindingSource bsMiembros;
        private System.Windows.Forms.BindingSource bsParticipantes;
    }
}