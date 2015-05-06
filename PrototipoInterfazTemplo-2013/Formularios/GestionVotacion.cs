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
    public partial class GestionVotacion : Form
    {
        public GestionVotacion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerarVotacion gv = new GenerarVotacion();
            gv.MdiParent = this.MdiParent;
            gv.Show();
        }
    }
}
