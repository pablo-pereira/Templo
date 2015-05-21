using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Data.SqlClient;
//using System.Data.SQLite;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;


namespace PrototipoInterfazTemplo_2013.Datos
{
    class Conexion
    {
        private string servidor = "localhost";
        private string puerto = "3306";
        private string usuario = "root";
        private string pass = "mariotejerina240991";
        private string db = "templo";
        static public string strConexion;

        public Conexion()
        {
            strConexion = string.Format("server={0});" +
                "port={1}" +
                "user id={2}; password={3}" +
                "database={4}; pooling=false;" +
                "Allow Zero Datetime=False;Convert Zero Datetime=True",
                this.servidor, this.puerto, this.usuario, this.pass, this.db);
        }

        public DataTable Ejecutar(string _query, string _type = "insert")
        {
            MySqlConnection cnx = new MySqlConnection(strConexion);
            cnx.Open();
            MySqlCommand cmd = new MySqlCommand(_query, cnx);
            if (_type == "select")
            {//este if sirce para ejecutar los comandos de select
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dtActividad = ds.Tables[0];
            }
            else {//este else sirve para ejecutar los comandos insert, update, delete
                cmd.ExecuteNonQuery();
            }
            cnx.Close();
            return dtActividad;
        }

        /*public static string cadena = @"Data Source=../../Datos/TemploDB.s3db";
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
        }*/


    }
}
