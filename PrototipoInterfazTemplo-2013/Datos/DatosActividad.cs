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
    public class DatosActividad:Conexion
    {
        //propiedades de la clase Actividad que representan los campos de nuestra tabla

        public int ID { get; set; }
        public int idDepartamento {get; set;}
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Requeridos { get; set; }
        public int Dificultad { get; set; }

        //constructor que inicializa las propiedades de la clase
        public DatosActividad(int _ID=0, int _idDepartamento=0, string _Nombre="", string _Descripcion="", int _Requeridos=0, int _Dificultad=0)
        {
            this.ID = _ID;
            this.idDepartamento = _idDepartamento;
            this.Nombre = _Nombre;
            this.Descripcion = _Descripcion;
            this.Requeridos = _Requeridos;
            this.Dificultad = _Dificultad;
        }

        //constructor sobrecargado de nuestra clase
        public DatosActividad()
        { 

        }

        //metodos para agregar registros a la base
        public string Add()
        {
            try
            {
                string strQuery = String.Format("insert into actividades(idDepartamento,Nombre, Descripcion, Requeridos, Dificultad)" + "value ('{0}','{1}','{2}','{3}','{4}')", this.idDepartamento, this.Nombre, this.Descripcion, this.Requeridos, this.Dificultad);

                Ejecutar(strQuery, "insert");
                return "";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }


        public string Delete()
        {
            try
            {
                string strQuery = String.Format("delete from actividades where ID={0}", this.ID);
                Ejecutar(strQuery, "delete");
                return "";
            }
            catch(Exception ex)
            {
                return ex.ToString();
            }
        }


        public string Update()
        {
            try
            {
                string strQuery = String.Format("update actividades set idDepartamento={0}, Nombre={1}, Descripcion={2}, Requeridos={3}, Dificultad={4} where Id={}",
                    this.idDepartamento, this.Nombre, this.Descripcion, this.Requeridos, this.Dificultad, this.ID);
                Ejecutar(strQuery, "update");
                return "";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }


        //metodo para seleccionar registros
        public DataTable select()
        {
            DataTable dt = new DataTable();
            try
            {
                string strQuery = String.Format("select * from actividades");
                dt = Ejecutar(strQuery, "select");
                return dt;
            }
            catch (Exception ex)
            {
                return dt;
            }
        }

        /*public static BindingList<Actividad> GetAll()
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
        }*/
    }
}
