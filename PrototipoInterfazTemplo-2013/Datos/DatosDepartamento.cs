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
    class DatosDepartamento 
    {
        public static BindingList<Departamento> GetAll()
        {
            BindingList<Departamento> lista = new BindingList<Departamento>();
            

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from departamentos;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Departamentos");        
            foreach (DataRow r in dataSet.Tables["Departamentos"].Rows)
            {
                lista.Add(DRToDepartamento(r));
            }
            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static Departamento GetById(int id)
        {
            Departamento d;

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * FROM departamentos WHERE idDepartamento=@id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Departamentos");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                d = DRToDepartamento(dataSet.Tables["Departamentos"].Rows[0]);
            }
            else
                return null;

            return d;
        }

        public static int Save(Departamento depto)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (depto.IdDepartamento == 0)//depto nuevo
            {
                query = "INSERT INTO departamentos (nombre, descripcion) VALUES (@nombre, @descripcion);";
            }
            else //edito depto
            {
                id = depto.IdDepartamento;
                query = "Update Departamentos SET nombre=@nombre, descripcion=@descripcion WHERE idDepartamento=@idDepartamento;";
                cmd.Parameters.Add(new SQLiteParameter("@idDepartamento", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //Cargo el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@nombre", depto.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@descripcion", depto.Descripcion));
         
            cmd.ExecuteNonQuery();

            if (depto.IdDepartamento == 0)
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
            SQLiteCommand cmd = new SQLiteCommand("DELETE Departamentos WHERE idDepartamento=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static Departamento DRToDepartamento(DataRow row)
        {
            Departamento depto = new Departamento();
            depto.IdDepartamento = (int)row.Field<Int64>("idDepartamento");
            depto.Nombre = row.Field<string>("nombre");
            depto.Descripcion = row.Field<string>("descripcion");
           
            return depto;
        }        
    }
}
