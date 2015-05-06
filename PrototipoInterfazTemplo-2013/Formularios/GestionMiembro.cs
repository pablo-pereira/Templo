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
    public partial class GestionMiembro : Form
    {
        private static GestionMiembro ventana=null;
        private static BindingList<Miembro> miembros;
        private Miembro miembroTemp;


        public static GestionMiembro getVentana(Form parent)
        {
            if (ventana == null)
	        {
                ventana = new GestionMiembro();
                ventana.MdiParent = parent;                
                ventana.Show();
	        }
            else
            {
                ventana.BringToFront();
            }
            return ventana;
        }

        private GestionMiembro()
        {
            InitializeComponent();
            miembros = DatosMiembro.GetAll();
            idMiembroDataGridViewTextBoxColumn.Visible = false;
            Actualizar();
        }

        private void btCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (bsMiembros.Count != 0 || (bsMiembros.Current != null))
            {
                //eliminar
                if (MessageBox.Show("¿Esta seguro de borrar al Miembro seleccionado?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Miembro miembro = (Miembro)bsMiembros.Current;
                    DatosMiembro.Delete(miembro.IdMiembro);
                    miembros = DatosMiembro.GetAll();
                    Actualizar();
                }
            }
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            Miembro miembro;
            if (bsMiembros.Current != null)
                miembro = (Miembro)bsMiembros.Current;
            else
            {
                miembro = new Miembro();
                miembro.Apellido = tbApellido.Text;
                miembro.Direccion = tbDirecion.Text;
                miembro.IdMiembro = 0;
                miembro.Mail = tbMail.Text;
                miembro.Nombre = tbNombre.Text;
                miembro.Telefono = tbTel.Text;
            }

            DatosMiembro.Save(miembro);
            dgMiembros.Enabled = true;
            Actualizar();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            bsMiembros.DataSource = miembros;
            bsMiembros.AddNew();
            //Miembro miembro = new Miembro();
            //bsMiembros.DataSource = miembro;
            //bsMiembros.Add(miembro);
            dgMiembros.Enabled = false;
            btGuardar.Enabled = true;
            btCancelar.Enabled = true;
            btModificar.Enabled = false;

            tbApellido.ReadOnly = false;
            tbDirecion.ReadOnly = false;
            tbMail.ReadOnly = false;
            tbNombre.ReadOnly = false;
            tbTel.ReadOnly = false;
        }

        //************** Validaciones *******************

        private void tbTel_Validating(object sender, CancelEventArgs e)
        {
            Regex exreg = new Regex("^((\\+)?[1-9]{1,4})?([-\\s\\.\\/])?((\\(\\d{1,4}\\))|\\d{1,4})(([-\\s\\.\\/])?[0-9]{1,6}){2,6}(\\s?(ext|x)\\s?[0-9]{1,6})?$");
            if (!exreg.IsMatch(tbTel.Text))
            {
                errorProvider.SetError(tbTel, "Télefono invalido.");
                e.Cancel = true;
                return;
            }
            errorProvider.SetError(tbTel, "");
        }

        private void tbNombre_Validating(object sender, CancelEventArgs e)
        {

            //if (tbNombre.Text.Trim() == "")
            //{
            //    errorProvider.SetError(tbNombre, "Ingresar nombre");
            //    e.Cancel = true;
            //    return;
            //}
            //errorProvider.SetError(tbNombre, "");
        }

        private void tbApellido_Validating(object sender, CancelEventArgs e)
        {
            if (tbNombre.Text.Trim() == "")
            {
                errorProvider.SetError(tbNombre, "Ingresar apellido");
                e.Cancel = true;
                return;
            }
            errorProvider.SetError(tbNombre, "");
        }

        private void tbMail_Validating(object sender, CancelEventArgs e)
        {

            //    Regex exreg = new Regex("[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            //    if(!exreg.IsMatch(tbMail.Text))
            //    {
            //        errorProvider.SetError(tbMail,"Mail invalido.");
            //        e.Cancel= true;
            //        return;
            //    }
            //    errorProvider.SetError(tbMail,"");
        }
        //******************* Fin Validaciones *********************

        private void btCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de cancelar los cambios? ", "Cancelar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                miembroTemp =(Miembro)bsMiembros.Current;
                if(miembroTemp.IdMiembro ==0)
                {
                    bsMiembros.RemoveCurrent();
                }
                Actualizar();
            }
        }

        private void TextChangedtb(object sender, EventArgs e)
        {
            //btCancelar.Enabled = true;
            //btGuardar.Enabled = true;
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            if (bsMiembros.Count != 0)
            {
                btGuardar.Enabled = true;
                btCancelar.Enabled = true;

                tbApellido.ReadOnly = false;
                tbDirecion.ReadOnly = false;
                tbMail.ReadOnly = false;
                tbNombre.ReadOnly = false;
                tbTel.ReadOnly = false;
            }
        }

        private void Actualizar()
        {

            if (dgMiembros.DataMember != null)
                btModificar.Enabled = true;
            else
                btModificar.Enabled = false;
            btGuardar.Enabled = false;
            btExportar.Enabled = false;
            btImportar.Enabled = false;
            btCancelar.Enabled = false;
            btEliminar.Enabled = false;

            tbApellido.ReadOnly = true;
            tbDirecion.ReadOnly = true;
            tbMail.ReadOnly = true;
            tbNombre.ReadOnly = true;
            tbTel.ReadOnly = true;

            //miembros = DatosMiembro.GetAll();

            tbBuscarMiembro_KeyPress(miembros, new KeyPressEventArgs(' '));
            idMiembroDataGridViewTextBoxColumn.Visible = false;
        }

        private void chMiembros_CheckedChanged(object sender, EventArgs e)
        {
            if (chMiembros.Checked)
            {
                chEliminados.Checked = false;
                var lista = from m in miembros
                            select m;

                bsMiembros.DataSource = lista;
            }
            else
                Actualizar();
        }

        private void chEliminados_CheckedChanged(object sender, EventArgs e)
        {
            if (chEliminados.Checked)
            {
                chMiembros.Checked = false;
                var lista = from m in miembros
                            where m.FechaBaja.Year != 1
                            select m;

                bsMiembros.DataSource = lista;
            }
            else
                Actualizar();
        }

        private void tbBuscarMiembro_MouseClick(object sender, MouseEventArgs e)
        {
            tbBuscarMiembro.SelectAll();
        }

        private void tbBuscarMiembro_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar == (char)13) || (char.IsWhiteSpace(e.KeyChar)))
            {
                string buscar = tbBuscarMiembro.Text + e.KeyChar.ToString();
                var lista = from m in miembros
                            where m.FechaBaja.Year == 1
                            select m;
                cargarDatasource(lista);

            }
            else
            {
                if (chMiembros.Checked)
                {
                    if (e.KeyChar == 8)
                    {
                        string buscar = tbBuscarMiembro.Text;
                        var lista = from m in miembros
                                    where (m.Apellido.ToLower().Contains(buscar.ToLower()) ||
                                           m.Nombre.ToLower().Contains(buscar.ToLower()))
                                    select m;

                        cargarDatasource((BindingList<Miembro>)lista);


                    }
                    else
                    {
                        string buscar = tbBuscarMiembro.Text + e.KeyChar.ToString();

                        var lista = from m in miembros
                                    where (m.Apellido.ToLower().Contains(buscar.ToLower()) ||
                                           m.Nombre.ToLower().Contains(buscar.ToLower()))
                                    select m;
                        cargarDatasource((BindingList<Miembro>)lista);

                    }
                }
                else if (chEliminados.Checked)
                {
                    if (e.KeyChar == 8)
                    {
                        string buscar = tbBuscarMiembro.Text;
                        var lista = from m in miembros
                                    where ((m.Apellido.ToLower().Contains(buscar.ToLower()) ||
                                            m.Nombre.ToLower().Contains(buscar.ToLower())) &&
                                            m.FechaBaja.Year != 1)
                                    select m;

                        cargarDatasource((BindingList<Miembro>)lista);

                    }
                    else
                    {
                        string buscar = tbBuscarMiembro.Text + e.KeyChar.ToString();
                        var lista = from m in miembros
                                    where ((m.Apellido.ToLower().Contains(buscar.ToLower()) ||
                                            m.Nombre.ToLower().Contains(buscar.ToLower())) &&
                                            m.FechaBaja.Year != 1)
                                    select m;

                        cargarDatasource((BindingList<Miembro>)lista);
                    }
                }

                else
                {
                    if (e.KeyChar == 8)
                    {
                        string buscar = tbBuscarMiembro.Text;
                        var lista = from m in miembros
                                    where ((m.Apellido.ToLower().Contains(buscar.ToLower()) ||
                                            m.Nombre.ToLower().Contains(buscar.ToLower())) &&
                                            m.FechaBaja.Year == 1)
                                    select m;

                        cargarDatasource((BindingList<Miembro>)lista);


                    }
                    else
                    {
                        string buscar = tbBuscarMiembro.Text + e.KeyChar.ToString();
                        var lista = from m in miembros
                                    where ((m.Apellido.ToLower().Contains(buscar.ToLower()) ||
                                            m.Nombre.ToLower().Contains(buscar.ToLower())) &&
                                            m.FechaBaja.Year == 1)
                                    select m;

                        cargarDatasource((BindingList<Miembro>)lista);

                    }
                }
            }
        }

        private void cargarDatasource(object lista)
        {
            //BindingList<Miembro> lista2= new BindingList<Miembro>();
            try
             {
                bsMiembros.DataSource= lista;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                bsMiembros.DataSource = typeof(Miembro);
            }
        }


    }
}
