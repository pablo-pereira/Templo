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
    class DatosMiembro
    {
        //public static List<Miembro> GetAll()
        //{
        //    List<Miembro> miembros = new List<Miembro>();
        //    Conexion.OpenConexion();
        //    SQLiteCommand query = new SQLiteCommand("Select * from miembros");
        //    query.Connection = Conexion.Connection;
        //    SQLiteDataReader obdr = query.ExecuteReader();
        //    Conexion.BlockConexion = true;
        //    while (obdr.Read())
        //    {
        //        miembros.Add(new Miembro(
        //                                obdr.GetInt32(0), 
        //                                obdr.GetString(1),
        //                                obdr.GetString(2),
        //                                obdr.GetString(3),
        //                                obdr.GetString(4),
        //                                obdr.GetString(5)
        //                              ));
        //    }
        //    Conexion.BlockConexion = false;
        //    Conexion.CloseConexion();
        //    return miembros;
        //}

        public static BindingList<Miembro> GetMiembros()
        {
            BindingList<Miembro> lista = new BindingList<Miembro>();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from miembros WHERE fechabaja is null;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Miembros");

            foreach (DataRow r in dataSet.Tables["Miembros"].Rows)
            {
                lista.Add(DataRowToMiembro(r));
            }
            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static Miembro GetById(int id)
        {
            Miembro m = new Miembro();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * FROM miembros WHERE idMiembro=@id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Miembros");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                m = DataRowToMiembro(dataSet.Tables["Miembros"].Rows[0]);
            }
            dataSet.Dispose();

            return m;
        }

        public static BindingList<Miembro> GetAll()
        {
            BindingList<Miembro> lista = new BindingList<Miembro>();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from miembros;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Miembros");

            foreach (DataRow r in dataSet.Tables["Miembros"].Rows)
            {
                lista.Add(DataRowToMiembro(r));

            }
            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static int Save(Miembro miembro)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (miembro.IdMiembro == 0)//miembro nuevo
            {
                query = "INSERT INTO miembros (nombre, apellido, direccion, mail, telefono ) VALUES (@nombre, @apellido, @direccion,@mail, @telefono);";
            }
            else //edito miembro
            {
                id = miembro.IdMiembro;
                query = "Update miembros SET nombre=@nombre, apellido=@apellido, direccion=@direccion, mail=@mail, telefono=@telefono  WHERE idMiembro=@idMiembro;";
                cmd.Parameters.Add(new SQLiteParameter("@idMiembro", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //Cargo el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@nombre", miembro.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@apellido", miembro.Apellido));
            cmd.Parameters.Add(new SQLiteParameter("@direccion", miembro.Direccion));
            cmd.Parameters.Add(new SQLiteParameter("@mail", miembro.Mail));
            cmd.Parameters.Add(new SQLiteParameter("@telefono", miembro.Telefono));
            cmd.ExecuteNonQuery();

            if (miembro.IdMiembro == 0)
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
            SQLiteCommand cmd = new SQLiteCommand("UPDATE Miembros SET fechaBaja=DateTime('Now') WHERE idMiembro=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static Miembro DataRowToMiembro(DataRow row)
        {
            Miembro miembro = new Miembro();
            try
            {
                miembro.IdMiembro = (int)row.Field<Int64>("idMiembro");
                miembro.Mail = row.Field<string>("mail");
                miembro.Nombre = row.Field<string>("nombre");
                miembro.Telefono = row.Field<string>("telefono");
                miembro.Apellido = row.Field<string>("apellido");
                miembro.Direccion = row.Field<string>("direccion");
                if (!row.IsNull("fechaBaja"))
                {
                    miembro.FechaBaja = row.Field<DateTime>("fechaBaja");
                }
                return miembro;
            }
            catch (Exception e)
            {
                return miembro;
            }
        }
    }
}
