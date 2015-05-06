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
    public partial class GenerarVotacion : Form
    {
        public GenerarVotacion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GestionSesion gestD = new GestionSesion(new Sesion());
            gestD.MdiParent = this.MdiParent;
            gestD.Show();
        }


    }
}
