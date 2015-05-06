using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrototipoInterfazTemplo_2013
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

    
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void gestionarMiembrosToolStripMenuItem_Click(object sender, EventArgs e)
        {            
            GestionMiembro gest = GestionMiembro.getVentana(this);
           // fmAbierto(gest);
        }

        private void gestionarCargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionCargo gestC = new GestionCargo();
            fmAbierto(gestC);
        }

        private void gestionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionActividad gestA = new GestionActividad();
            fmAbierto(gestA);
        }

        private void gestionarSesionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionSesion gestS = new GestionSesion();
            fmAbierto(gestS);
        }      

        private void gestiónDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDepartamento gestD = new GestionDepartamento();
            fmAbierto(gestD);
        }

        private void gestiónPlanificadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionPlanificador gestPl = new GestionPlanificador();
            fmAbierto(gestPl);
        }

        private void generarListadoMensualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerarListadoMensual glm = GenerarListadoMensual.getVentana(this);
            //fmAbierto(glm);
        }

        private void gestionarVotacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionVotacion gv = new GestionVotacion();
            fmAbierto(gv);
        }

        private void fmAbierto(Form formulario)
        {
            bool abierto = false;
            foreach (Form v in this.MdiChildren)//recorro el array buscando en los formularios abiertos si ya hay un formulario del mismo tipo instanciado
            {
                if (v.GetType() == formulario.GetType())
                {
                    abierto = true;
                    v.WindowState = FormWindowState.Normal;
                    v.Activate();
                    v.BringToFront();
                    break;
                }
            }

            if (!abierto)
            {
                formulario.MdiParent = this;
                formulario.Show();
            }
            else
            {
                formulario.Close();
            }
        }
    }
}
