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
    public partial class GestionSesion : Form
    {
        private Sesion sesion;
        //public static BindingList<IntegranteComNomb> integrantes;
        public GestionSesion(Sesion sesion)
        {
            this.sesion = sesion;
            InitializeComponent();
            CargarDatos();
            Actualizar();
        }

        private void Actualizar()
        {
            //throw new NotImplementedException();
        }

        private void CargarDatos()
        {
            bsSesiones.DataSource = DatosSesion.GetAll();
        }

        public GestionSesion()
        {
            InitializeComponent();
            CargarDatos();
            Actualizar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGestionParticipantes_Click(object sender, EventArgs e)
        {
            GestionParticipantes gp = new GestionParticipantes();
            gp.MdiParent = this.MdiParent;
            gp.Show();         
            this.sesion.ListaIntegranteComNomb = gp.Integrantes;
            gp.Close();//values preserved after close
                
            
        }

        public Sesion Sesion
        {
            get { return this.sesion; }
            set { this.sesion = value; }
        }

       
    }
}
