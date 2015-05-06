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
    public partial class GestionCargo : Form
    {
        private BindingList<Cargo> cargos;
        private BindingList<Departamento> departamentos;
        //private Departamento depTemp;
        private Cargo cargoTemp;
        public GestionCargo()
        {
            InitializeComponent();
            CargarDatos();
            Actualizar();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Cargo cargo;
            if (bsCargos.Current != null)
            {
                cargo = (Cargo)bsCargos.Current;
                if (bsDepartamentos.Current != null)
                {
                    cargo.Departamento = (Departamento)bsDepartamentos.Current;
                }
            }
            else
            {
                cargo = new Cargo(0,
                                    tbNombre.Text,
                                    tbDescripcion.Text,
                                    (int)nUPDCupo.Value,
                                    (Departamento)bsDepartamentos.Current,
                                    chMayoriaSimple.Checked,
                                    chMiembroJunta.Checked,
                                    chMitadMasUno.Checked);
            }


            DatosCargo.Save(cargo);
            CargarDatos();
            Actualizar();

        }

        private void CargarDatos()
        {
            cargos = DatosCargo.GetAll();
            departamentos = DatosDepartamento.GetAll();
            bsCargos.DataSource = cargos;
            bsDepartamentos.DataSource = departamentos;
        }

        private void Actualizar()
        {
            cargoTemp = (Cargo)bsCargos.Current;
            if (cargoTemp.IdCargo!=0 || cargoTemp.Departamento!= null )
            {
                cbDepartamento.SelectedValue = cargoTemp.Departamento.IdDepartamento;
            }
            else
                cbDepartamento.SelectedIndex = 0;

            btNuevo.Enabled = true;
            btGuardar.Enabled = false;
            btExportar.Enabled = false;
            btCancelar.Enabled = false;
            btBorrar.Enabled = false;
            btModificar.Enabled = true;

            tbDescripcion.ReadOnly = true;
            tbNombre.ReadOnly = true;
            chMayoriaSimple.AutoCheck = false;
            chMiembroJunta.AutoCheck = false;
            chMitadMasUno.AutoCheck = false;
            nUPDCupo.ReadOnly = true;
            cbDepartamento.Enabled=false ;
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (bsCargos.Count != 0 || bsCargos.Current != null)
            {
                if (MessageBox.Show("¿Esta seguro de borrar el Cargo seleccionado?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosCargo.Delete(((Cargo)bsCargos.Current).IdCargo);
                    CargarDatos();
                    Actualizar();
                }
            }
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            bsCargos.AddNew();
            btNuevo.Enabled = false;
            btBorrar.Enabled = false;
            btGuardar.Enabled = true;
            btModificar.Enabled = false;
            //btExportar.Enabled = true;
            btCancelar.Enabled = true;

            tbDescripcion.ReadOnly = false;
            tbNombre.ReadOnly = false;
            chMayoriaSimple.AutoCheck = true;
            chMiembroJunta.AutoCheck = true;
            chMitadMasUno.AutoCheck = true;
            nUPDCupo.ReadOnly = false;
            cbDepartamento.Enabled = true;

        }

        private void dgCargos_SelectionChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            cargoTemp = (Cargo)bsCargos.Current;
            if (cargoTemp.IdCargo == 0)
            {
                bsCargos.RemoveCurrent();
            }
            

            CargarDatos();
            Actualizar();
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            btBorrar.Enabled = true;
            btGuardar.Enabled = true;
            btNuevo.Enabled = false;
            btModificar.Enabled = false;
            btCancelar.Enabled = true;

            tbDescripcion.ReadOnly = false;
            tbNombre.ReadOnly = false;
            chMayoriaSimple.AutoCheck = true;
            chMiembroJunta.AutoCheck = true;
            chMitadMasUno.AutoCheck = true;
            nUPDCupo.ReadOnly = false;
            cbDepartamento.Enabled = true;
        }

    }
}
