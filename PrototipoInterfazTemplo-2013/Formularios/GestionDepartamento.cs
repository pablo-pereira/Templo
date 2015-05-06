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
    public partial class GestionDepartamento : Form
    {
        private Departamento deptoTemp;
        private BindingList<Departamento> departamentos;
        public GestionDepartamento()
        {
            InitializeComponent();
            CargarDatos();
            Actualizar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarDatos()
        {
            departamentos = DatosDepartamento.GetAll();
            bsDepartamentos.DataSource = departamentos;
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            bsDepartamentos.AddNew();
            btNuevo.Enabled = false;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;

            tbDescripcion.ReadOnly = false;
            tbNombre.ReadOnly = false;
           // tbJefe.Enabled = true;


        }

        private void Actualizar()
        {
            btNuevo.Enabled = true;
            btGuardar.Enabled = false;
            btCancelar.Enabled = false;
            btBorrar.Enabled = false;
            btModificar.Enabled = true;

            tbDescripcion.ReadOnly = true;
            tbNombre.ReadOnly = true;
            tbJefe.Enabled = false;          
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Departamento depto;
            if (bsDepartamentos.Current == null)
            {
                depto = new Departamento(0,
                                    tbNombre.Text,
                                    tbDescripcion.Text);
            }
            else
            {
                depto = (Departamento)bsDepartamentos.Current;
            }
            DatosDepartamento.Save(depto);
            CargarDatos();
            Actualizar();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (bsDepartamentos.Count != 0 || bsDepartamentos.Current != null)
            {
                if (MessageBox.Show("¿Esta seguro de borrar el Departamento seleccionado?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosDepartamento.Delete(((Departamento)bsDepartamentos.Current).IdDepartamento);
                    CargarDatos();
                    Actualizar();
                }
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            btNuevo.Enabled = false;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btBorrar.Enabled = true;
            btModificar.Enabled = false;

            tbDescripcion.ReadOnly = false;
            tbNombre.ReadOnly = false;
            //tbJefe.Enabled = true;    
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
             deptoTemp = (Departamento)bsDepartamentos.Current;
            if (deptoTemp.IdDepartamento == 0)
            {
                bsDepartamentos.RemoveCurrent();
            }
            

            CargarDatos();
            Actualizar();
        }

   
    }
}
