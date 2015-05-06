using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using PrototipoInterfazTemplo_2013.Datos;
using PrototipoInterfazTemplo_2013.Entidades;

namespace PrototipoInterfazTemplo_2013
{
    public partial class GestionParticipantes : Form
    {
        private BindingList<Miembro> miembros;       
        private Miembro miembroTemp;
        private BindingList<IntegranteComNomb> integrantes;
        private BindingList<IntegranteComNomb> integrantesTem;

        public GestionParticipantes(BindingList<IntegranteComNomb> integrantesParam)
        {
            InitializeComponent();
            miembros = DatosMiembro.GetMiembros();
            integrantes = integrantesParam;
            integrantesTem = integrantesParam;
            CargarDatos();
        }

        public GestionParticipantes()
        {
            InitializeComponent();
            miembros = DatosMiembro.GetMiembros();
            integrantes = new BindingList<IntegranteComNomb>();
            CargarDatos();
        }

        //public GestionParticipantes(BindingList<IntegranteComNomb> integr, BindingList<Miembro> mie)
        //{
        //    InitializeComponent();
        //    miembros = DatosMiembro.GetMiembros();
        //    integrantes = new BindingList<IntegranteComNomb>();
        //    CargarDatos();
        //}
        

        private void CargarDatos()
        {
            bsMiembros.DataSource = miembros;
            bsParticipantes.DataSource = Integrantes;
            //integrantes = new BindingList<IntegranteComNomb>();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            this.integrantes = integrantesTem;//retorna lista sin cambios
            Close();
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {
            if (bsMiembros.Count != 0)
            {
                miembroTemp = (Miembro)bsMiembros.Current;
                bsParticipantes.Add(new IntegranteComNomb(0, miembroTemp, true));
                bsMiembros.RemoveCurrent();
            }
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            if (bsParticipantes.Count != 0)
            {
                bsMiembros.Add(((IntegranteComNomb)bsParticipantes.Current).Miembro);
                bsParticipantes.RemoveCurrent();
            }
        }

        private void btConfirmar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Close();
        }

        public BindingList<IntegranteComNomb> Integrantes 
        {
            get { return this.integrantes; }
            set { integrantes = value; }
        }

        
    }
}
