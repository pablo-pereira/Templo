using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Data;

namespace PrototipoInterfazTemplo_2013.Datos
{
    class Conexion
    {
        public static string cadena = @"Data Source=../../Datos/Templo.s3db";
        private static SQLiteConnection connection = new SQLiteConnection(Conexion.cadena);
        private static Boolean blockConexion;
                    
        public static void OpenConexion()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public static void CloseConexion()
        {
            if (!blockConexion)
                connection.Close();
        }

        public static Boolean BlockConexion
        {
            set { blockConexion = value; }
            get { return blockConexion; }
        }

        public static int LastInsertRowId()
        {
            SQLiteCommand cmd2 = new SQLiteCommand("SELECT Last_Insert_Rowid(); ", Connection);
            SQLiteDataReader obdr = cmd2.ExecuteReader();
            obdr.Read();
            int id = obdr.GetInt32(0);
            CloseConexion();

            return id;
        }

               
        public static SQLiteConnection Connection
        {
            set { connection = value; }
            get { return connection; }
        }

        
    }
}
