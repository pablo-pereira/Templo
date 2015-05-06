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
    public partial class GestionActividad : Form
    {
        private Actividad actividadTemp;
        private BindingList<Actividad> actividades;
        private BindingList<Departamento> departamentos;
        public GestionActividad()
        {
            InitializeComponent();
            CargarDatos();
            Actualizar();
        }

        private void Actualizar()
        {
            actividadTemp = (Actividad)bsActividades.Current;
            if (actividadTemp != null)
            {
                if (actividadTemp.IdActividad != 0 || actividadTemp.Departamento != null)
                {
                    cbDepartamento.SelectedValue = actividadTemp.Departamento.IdDepartamento;
                }
                else
                    cbDepartamento.SelectedIndex = 0;
            }

            btNuevo.Enabled = true;
            btGuardar.Enabled = false;            
            btCancelar.Enabled = false;
            btBorrar.Enabled = false;
            btModificar.Enabled = true;

            tbDescripcion.ReadOnly = true;
            tbNombre.ReadOnly = true;
            cbDepartamento.Enabled = false;
            cbDificultad.Enabled = false;            
            nUPDRequeridos.ReadOnly = true;         
        }

        private void CargarDatos()
        {
            actividades = DatosActividad.GetAll();
            departamentos = DatosDepartamento.GetAll();
            bsActividades.DataSource = actividades;
            bsDepartamentos.DataSource = departamentos;

         //   cbDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
            cbDificultad.DataSource = Enum.GetValues(typeof(Dificultad));
            
            
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            bsActividades.AddNew();
            btNuevo.Enabled = false;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btBorrar.Enabled = false;
            btModificar.Enabled = false;

            tbDescripcion.ReadOnly = false;
            tbNombre.ReadOnly = false;
            cbDepartamento.Enabled = true;
            cbDificultad.Enabled = true;
            nUPDRequeridos.ReadOnly = false; 

        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Actividad actividad;
            if (bsActividades.Current != null)
            {
                actividad = (Actividad)bsActividades.Current;
                if (bsDepartamentos.Current != null)
                {
                    actividad.Departamento = (Departamento)bsDepartamentos.Current;

                }
                actividad.Dificultad = (Dificultad)cbDificultad.SelectedValue;
            }
            else
            {
                actividad = new Actividad(0,
                                    tbNombre.Text,
                                    tbDescripcion.Text,
                                    (int)nUPDRequeridos.Value,
                                    (Dificultad)cbDificultad.SelectedValue,
                                    (Departamento)cbDepartamento.SelectedItem);
            }

            DatosActividad.Save(actividad);
            CargarDatos();
            Actualizar();
        }

        private void btBorrar_Click(object sender, EventArgs e)
        {
            if (bsActividades.Count != 0 || bsActividades.Current != null)
            {
                if (MessageBox.Show("¿Esta seguro de borrar la Actividad seleccionada?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    DatosActividad.Delete(((Actividad)bsActividades.Current).IdActividad);
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
            cbDepartamento.Enabled = true;
            cbDificultad.Enabled = true;
            nUPDRequeridos.ReadOnly = false; 
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            actividadTemp = (Actividad)bsActividades.Current;
            if (actividadTemp.IdActividad == 0)
            {
                bsActividades.RemoveCurrent();
            }

            CargarDatos();
            Actualizar();
        }  
    }
}
