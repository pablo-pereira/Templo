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
    class DatosOcupacion
    {
        public static BindingList<Ocupacion> GetAll()
        {
            BindingList<Ocupacion> lista = new BindingList<Ocupacion>();


            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from Ocupa;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Ocupa");
            foreach (DataRow r in dataSet.Tables["Ocupa"].Rows)
            {
                lista.Add(DRToOcupacion(r));

            }

            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static Ocupacion GetById(int id)
        {
            Ocupacion a = new Ocupacion();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * FROM Ocupa WHERE idOcupa=@id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Ocupa");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                a = DRToOcupacion(dataSet.Tables["Ocupa"].Rows[0]);
            }
            dataSet.Dispose();

            return a;
        }

        public static int Save(Ocupacion ocupacion)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (ocupacion.IdOcupacion == 0)//miembro nuevo
            {
                query = "INSERT INTO Ocupa (fechaDesde, fechaHasta, idMiembro, idCargo) VALUES (@fechaDesde, @fechaHasta, @idMiembro, @idCargo)";
            }
            else //edito miembro
            {
                id = ocupacion.IdOcupacion;
                query = "Update Ocupa SET fechaDesde=@fechaDesde, fechaHasta=@fechaHasta, idMiembro=@idMiembro, idCargo=@idCargo";
                cmd.Parameters.Add(new SQLiteParameter("@idocupacion", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //ocupacion el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@fechaDesde", ocupacion.FechaDesde));
            cmd.Parameters.Add(new SQLiteParameter("@fechaHasta", ocupacion.FechaHasta));
            cmd.Parameters.Add(new SQLiteParameter("@idMiembro", ocupacion.Miembro.IdMiembro));
            cmd.Parameters.Add(new SQLiteParameter("@idCargo", ocupacion.Cargo.IdCargo));
            cmd.ExecuteNonQuery();

            if (ocupacion.IdOcupacion == 0)
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
            SQLiteCommand cmd = new SQLiteCommand("DELETE Ocupa WHERE idOcupa=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        private static Ocupacion DRToOcupacion(DataRow row)
        {
            Ocupacion ocupacion = new Ocupacion();
            try
            {
                ocupacion.IdOcupacion = (int)row.Field<Int64>("idOcupa");
                ocupacion.FechaDesde = row.Field<DateTime>("fechaDesde");
                ocupacion.FechaHasta = row.Field<DateTime>("fechaHasta");
                ocupacion.Miembro = DatosMiembro.GetById((int)row.Field<Int64>("idMiembro"));
                ocupacion.Cargo = DatosCargo.GetById((int)row.Field<Int64>("idCargo"));

                return ocupacion;
            }
            catch (Exception e)
            {
                return ocupacion;
            }
        }
    }
}
