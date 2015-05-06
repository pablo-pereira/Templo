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
    class DatosVotacion
    {
        public static BindingList<Votacion> GetAll()
        {
            BindingList<Votacion> lista = new BindingList<Votacion>();


            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from Votaciones;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Votaciones");
            foreach (DataRow r in dataSet.Tables["Votaciones"].Rows)
            {
                lista.Add(DRToVotacion(r));
            }


            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static Votacion GetById(int id)
        {
            Votacion a = new Votacion();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * FROM Votaciones WHERE idVotacion=@id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Votaciones");
           
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                a = DRToVotacion(dataSet.Tables["Votaciones"].Rows[0]);
            }
            dataSet.Dispose();

            return a;
        }

        public static int Save(Votacion votacion)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (votacion.IdVotacion == 0)//miembro nuevo
            {
                query = "INSERT INTO Votaciones (idSesion, idCargo) VALUES (@idSesion, @idCargo)";
            }
            else //edito miembro
            {
                id = votacion.IdVotacion;
                query = "Update Votaciones SET idSesion=@idSesion, idCargo=@idCargo WHERE idVotacion=@id";
                cmd.Parameters.Add(new SQLiteParameter("@id", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //ocupacion el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@idCargo", votacion.Cargo.IdCargo));
            cmd.Parameters.Add(new SQLiteParameter("@idSesion", votacion.Sesion.IdSesion));


            //cmd.Parameters.Add(new SQLiteParameter("@idCargo", votacion.Cargo.IdCargo));
            cmd.ExecuteNonQuery();
            if (votacion.IdVotacion == 0)//miembro nuevo
            {
                id = Conexion.LastInsertRowId();//devuelve la id de la ultima votacion creada

                foreach (Candidato candidato in votacion.ListaCandidatos)
                {
                    SaveCandidato(candidato, id);
                }
            }

            if (votacion.IdVotacion == 0)
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
            DeleteCandidatoByVotacion(id);//borra los integrantes de la tabla Candidatos
            SQLiteCommand cmd = new SQLiteCommand("DELETE Votaciones WHERE idVotacion=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        private static Votacion DRToVotacion(DataRow row)
        {
            Votacion votacion = new Votacion();
            try
            {
                votacion.IdVotacion = (int)row.Field<Int64>("idVotacion");
                votacion.Sesion = DatosSesion.GetById((int)row.Field<Int64>("idSesion"));
                votacion.Cargo = DatosCargo.GetById((int)row.Field<Int64>("idCargo"));
                votacion.ListaCandidatos = GetCandidatos(votacion.IdVotacion);

                return votacion;
            }
            catch (Exception e)
            {
                return votacion;
            }
        }

        #region Candidatos
        private static BindingList<Candidato> GetCandidatos(int idVotacion)
        {
            BindingList<Candidato> lista = new BindingList<Candidato>();


            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from Candidatos WHERE idVotacion= @id;", Conexion.Connection);
            query.Parameters.Add(new SQLiteParameter("@id", idVotacion));
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Candidatos");
            foreach (DataRow r in dataSet.Tables["Candidatos "].Rows)
            {
                lista.Add(DRToCandidato(r));

            }

            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static int SaveCandidato(Candidato candidato, int idVotacion)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (candidato.IdCandidato == 0)//miembro nuevo
            {
                query = "INSERT INTO Candidatos (idVotacion,idMiembro, cantidadVotos ) VALUES (@idVotacion, @idMiembro, @cantidadVotos)";
            }
            else //edito miembro
            {
                id = candidato.IdCandidato;
                query = "Update IntegranteComNomb SET idVotacion=@idVotacion, idMiembro=@idMiembro, cantidadVotos=@cantidadVotos WHERE idCandidato=@idCandidato;";
                cmd.Parameters.Add(new SQLiteParameter("@idCandidato", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //Cargo el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@idVotacion", idVotacion));
            cmd.Parameters.Add(new SQLiteParameter("@idMiembro", candidato.Miembro.IdMiembro));
            cmd.Parameters.Add(new SQLiteParameter("@cantidadVotos", candidato.CantidadVotos));
            cmd.ExecuteNonQuery();

            if (candidato.IdCandidato == 0)
            {
                return Conexion.LastInsertRowId();
            }
            else
            {
                Conexion.CloseConexion();
                return id;
            }
        }

        public static Candidato GetCandidatoById(int id)
        {
            Candidato a = new Candidato();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from Candidatos WHERE idCandidato= @id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Candidatos");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                a = DRToCandidato(dataSet.Tables["Candidatos"].Rows[0]);
            }
            dataSet.Dispose();

            return a;
        }

        public static void DeleteCandidato(int id)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE Candidatos WHERE idCandidato=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static int DeleteCandidatoByVotacion(int idVotacion)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE Candidatos WHERE idVotacion=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", idVotacion));
            int r =  cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
            return r;
        }


        private static Candidato DRToCandidato(DataRow row)
        {
            Candidato candidato = new Candidato();
            try
            {
                candidato.IdCandidato = (int)row.Field<Int64>("idCandidato");
                candidato.Miembro = DatosMiembro.GetById((int)row.Field<Int64>("idVotacion"));
                candidato.CantidadVotos = (int)row.Field<Int64>("cantidadVotos");
                //sesion.ListaIntegranteComNomb = DatosCargo.GetById((int)row.Field<Int64>("idCargo"));

                return candidato;
            }
            catch (Exception e)
            {
                return candidato;
            }
        }
        #endregion
    }
}
