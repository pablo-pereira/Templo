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
    class DatosSesion
    {
        public static BindingList<Sesion> GetAll()
        {
            BindingList<Sesion> lista = new BindingList<Sesion>();


            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from Sesiones;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Sesiones");
            foreach (DataRow r in dataSet.Tables["Sesiones"].Rows)
            {
                lista.Add(DRToSesion(r));
            }

            checked
            {

            }
            
            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static Sesion GetById(int id)
        {
            Sesion a = new Sesion();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * FROM Sesiones WHERE idSesion=@id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Ocupa");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                a = DRToSesion(dataSet.Tables["Sesiones"].Rows[0]);
            }
            dataSet.Dispose();

            return a;
        }

        public static int Save(Sesion sesion)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);          

            //creo la conexion
            Conexion.OpenConexion();
            if (sesion.IdSesion == 0)//miembro nuevo
            {
                query = "INSERT INTO Sesiones (fechaHoraInicio, fechaHoraFin, primeraOracion, segundaOracion) VALUES (@fechaHoraInicio, @fechaHoraFin, @primeraOracion, @segundaOracion)";
            }
            else //edito miembro
            {
                id = sesion.IdSesion;
                query = "Update Sesiones SET fechaHoraInicio=@fechaHoraInicio, fechaHoraFin=@fechaHoraFin, primeraOracion=@primeraOracion, segundaOracion=@segundaOracion";
                cmd.Parameters.Add(new SQLiteParameter("@idSesion", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //ocupacion el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@fechaHoraInicio", sesion.FechaHoraInicio));
            cmd.Parameters.Add(new SQLiteParameter("@fechaHoraFin", sesion.FechaHoraFin));
            cmd.Parameters.Add(new SQLiteParameter("@primeraOracion", sesion.PrimeraOracion.IdMiembro));
            cmd.Parameters.Add(new SQLiteParameter("@segundaOracion", sesion.SegundaOracion.IdMiembro));

            //cmd.Parameters.Add(new SQLiteParameter("@idCargo", sesion.Cargo.IdCargo));
            cmd.ExecuteNonQuery();
            if (sesion.IdSesion == 0)//miembro nuevo
            {
                id = Conexion.LastInsertRowId();//devuelve la id de la ultima sesion creada

                foreach (IntegranteComNomb integrante in sesion.ListaIntegranteComNomb)
                {
                    SaveIntegrante(integrante, id);
                }
            }

            if (sesion.IdSesion == 0)
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
            DeleteIntegranteBySesion(id);//borra los integrantes de la tabla IntegrantesComNomb
            SQLiteCommand cmd = new SQLiteCommand("DELETE Sesiones WHERE idSesion=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        private static Sesion DRToSesion(DataRow row)
        {
            Sesion sesion = new Sesion();
            try
            {
                sesion.IdSesion = (int)row.Field<Int64>("idSesion");
                sesion.FechaHoraInicio = row.Field<DateTime>("fechaHoraInicio");
                sesion.FechaHoraFin = row.Field<DateTime>("fechaHoraFin");
                sesion.PrimeraOracion = DatosMiembro.GetById((int)row.Field<Int64>("idMiembro"));
                sesion.SegundaOracion = DatosMiembro.GetById((int)row.Field<Int64>("idMiembro"));
                sesion.ListaIntegranteComNomb = GetIntegrantes(sesion.IdSesion); 
                
                //sesion.ListaIntegranteComNomb = DatosCargo.GetById((int)row.Field<Int64>("idCargo"));

                return sesion;
            }
            catch (Exception e)
            {
                return sesion;
            }
        }

        #region IntegrantesComNom

        private static BindingList<IntegranteComNomb> GetIntegrantes(int idSesion)
        {
            BindingList<IntegranteComNomb> lista = new BindingList<IntegranteComNomb>();


            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from IntegrantesComNomb WHERE idSesion= @id;", Conexion.Connection);
            query.Parameters.Add(new SQLiteParameter("@id", idSesion));
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "IntegrantesComNomb");
            foreach (DataRow r in dataSet.Tables["IntegrantesComNomb "].Rows)
            {
                lista.Add(DRToIntegrante(r));

            }

            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista; 
        }

        public static int SaveIntegrante(IntegranteComNomb integrante, int idSesion)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (integrante.IdIntegranteComNomb == 0)//miembro nuevo
            {
                query = "INSERT INTO IntegranteComNomb (idSesion,idMiembro, presente ) VALUES (@idSesion, @idMiembro, @idSesion)";
            }
            else //edito miembro
            {
                id = integrante.IdIntegranteComNomb;
                query = "Update IntegranteComNomb SET idSesion=@idSesion, idMiembro=@idMiembro, presente=@presente WHERE idIntegranteComNomb=@idIntegranteComNomb;";
                cmd.Parameters.Add(new SQLiteParameter("@idIntegranteComNomb", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //Cargo el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@idSesion", idSesion));
            cmd.Parameters.Add(new SQLiteParameter("@idMiembro", integrante.Miembro.IdMiembro));
            cmd.Parameters.Add(new SQLiteParameter("@presente", integrante.Presente));
            cmd.ExecuteNonQuery();

            if (integrante.IdIntegranteComNomb == 0)
            {
                return Conexion.LastInsertRowId();
            }
            else
            {
                Conexion.CloseConexion();
                return id;
            }
        }

        public static IntegranteComNomb GetIntegranteById(int id)
        {
            IntegranteComNomb a = new IntegranteComNomb();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from IntegrantesComNomb WHERE idIntegrantesComNomb= @id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "IntegrantesComNomb");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                a = DRToIntegrante(dataSet.Tables["IntegrantesComNomb"].Rows[0]);
            }
            dataSet.Dispose();

            return a;
        }

        public static void DeleteIntegrante(int id)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE IntegrantesComNomb WHERE idIntegrantesComNomb=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        public static void DeleteIntegranteBySesion(int idSesion)
        {
            Conexion.OpenConexion();
            SQLiteCommand cmd = new SQLiteCommand("DELETE IntegrantesComNomb WHERE idSesion=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", idSesion));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        private static IntegranteComNomb DRToIntegrante(DataRow row)
        {
            IntegranteComNomb integrante = new IntegranteComNomb();
            try
            {
                integrante.IdIntegranteComNomb = (int)row.Field<Int64>("idSesion");
                integrante.Miembro = DatosMiembro.GetById((int)row.Field<Int64>("idMiembro"));
                integrante.Presente = row.Field<Boolean>("presente");
                //sesion.ListaIntegranteComNomb = DatosCargo.GetById((int)row.Field<Int64>("idCargo"));

                return integrante;
            }
            catch (Exception e)
            {
                return integrante;
            }   
        }
        
        #endregion 
    }
}
