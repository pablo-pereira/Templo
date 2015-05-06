using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;
using System.Data.SqlClient;
using PrototipoInterfazTemplo_2013.Entidades;

namespace PrototipoInterfazTemplo_2013.Datos
{
    class DatosActividad
    {
        public static BindingList<Actividad> GetAll()
        {
            BindingList<Actividad> lista = new BindingList<Actividad>();


            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from actividades;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Actividades");
            foreach (DataRow r in dataSet.Tables["Actividades"].Rows)
            {
                lista.Add(DRToActividad(r));

            }
            
            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static Actividad GetById(int id)
        {
            Actividad a = new Actividad();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * FROM Actividades WHERE idactividad=@id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Actividades");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                a = DRToActividad(dataSet.Tables["Actividades"].Rows[0]);
            }
            dataSet.Dispose();

            return a;
        }

        public static int Save(Actividad actividad)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (actividad.IdActividad == 0)//miembro nuevo
            {
                query = "INSERT INTO Actividades (nombre, descripcion, requeridos, dificultad, idDepartamento ) VALUES (@nombre, @descripcion, @requeridos,@dificultad, @idDepartamento);";
            }
            else //edito miembro
            {
                id = actividad.IdActividad;
                query = "Update Actividades SET nombre=@nombre, descripcion=@descripcion, requeridos=@requeridos, dificultad=@dificultad, idDepartamento=@idDepartamento  WHERE idActividad=@idActividad;";
                cmd.Parameters.Add(new SQLiteParameter("@idActividad", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //Cargo el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@nombre", actividad.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@descripcion", actividad.Descripcion));
            cmd.Parameters.Add(new SQLiteParameter("@requeridos", actividad.Requeridos));
            cmd.Parameters.Add(new SQLiteParameter("@dificultad", actividad.Dificultad));
            cmd.Parameters.Add(new SQLiteParameter("@idDepartamento", actividad.Departamento.IdDepartamento));
            cmd.ExecuteNonQuery();

            if (actividad.IdActividad == 0)
            {
                return Conexion.LastInsertRowId();
            }
            else
            {
                Conexion.CloseConexion();
                return id;
            }
        }

        public static void Delete(int id)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Actividades WHERE idActividad=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        private static Actividad DRToActividad(DataRow row)
        {
            Actividad actividad = new Actividad();
            try
            {

                actividad.IdActividad = (int)row.Field<Int64>("idActividad");
                actividad.Nombre = row.Field<string>("nombre");
                actividad.Descripcion = row.Field<string>("descripcion");
                actividad.Dificultad = (Dificultad)row.Field<Int32>("dificultad");
                actividad.Departamento = DatosDepartamento.GetById((int)row.Field<Int64>("idDepartamento"));
                actividad.Requeridos = (int)row.Field<Int32>("requeridos");
                return actividad;                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return actividad;
            }
        }
    }
}
