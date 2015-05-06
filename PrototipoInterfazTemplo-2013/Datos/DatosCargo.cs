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
    class DatosCargo
    {
        public static BindingList<Cargo> GetAll()
        {
            BindingList<Cargo> lista = new BindingList<Cargo>();


            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * from Cargos;", Conexion.Connection);
            query.CommandType = CommandType.Text;
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Cargos");
            foreach (DataRow r in dataSet.Tables["Cargos"].Rows)
            {
                lista.Add(DRToCargo(r));
            }

            Conexion.CloseConexion();
            dataSet.Dispose();
            return lista;
        }

        public static Cargo GetById(int id)
        {
            Cargo a = new Cargo();

            Conexion.OpenConexion();
            SQLiteCommand query = new SQLiteCommand("Select * FROM Cargos WHERE idCargo=@id", Conexion.Connection);
            query.CommandType = CommandType.Text;
            query.Parameters.Add(new SQLiteParameter("@id", id));
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(query);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "Cargos");
            Conexion.CloseConexion();
            if (dataSet.Tables.Count != 0)
            {
                a = DRToCargo(dataSet.Tables["Cargos"].Rows[0]);
            }
            dataSet.Dispose();

            return a;
        }

        public static int Save(Cargo cargo)
        {
            int id = 0;
            string query = "";
            SQLiteCommand cmd = new SQLiteCommand(Conexion.Connection);

            //creo la conexion
            Conexion.OpenConexion();
            if (cargo.IdCargo == 0)//miembro nuevo
            {
                query = "INSERT INTO Cargos (nombre, descripcion, cupo, mayoriaSimple, miembroJunta, idDepartamento, mitadMasUno ) VALUES (@nombre, @descripcion, @cupo, @mayoriaSimple, @miembroJunta, @idDepartamento, @mitadMasUno);";
            }
            else //edito miembro
            {
                id = cargo.IdCargo;
                query = "Update Cargos SET nombre=@nombre, descripcion=@descripcion, cupo=@cupo, mayoriaSimple=@mayoriaSimple, miembroJunta=@miembroJunta, idDepartamento=@idDepartamento, mitadMasUno=@mitadMasUno  WHERE idCargo=@idCargo;";
                cmd.Parameters.Add(new SQLiteParameter("@idCargo", id));
            }
            //Creo el comando sql a utlizar
            cmd.CommandText = query;
            //Cargo el valor del parametro                
            cmd.Parameters.Add(new SQLiteParameter("@nombre", cargo.Nombre));
            cmd.Parameters.Add(new SQLiteParameter("@descripcion", cargo.Descripcion));
            cmd.Parameters.Add(new SQLiteParameter("@cupo", cargo.Cupo));
            cmd.Parameters.Add(new SQLiteParameter("@mayoriaSimple", cargo.MayoriaSimple));
            cmd.Parameters.Add(new SQLiteParameter("@miembroJunta", cargo.MiembroJunta));
            cmd.Parameters.Add(new SQLiteParameter("@mitadMasUno", cargo.MiembroJunta));
            cmd.Parameters.Add(new SQLiteParameter("@idDepartamento", cargo.Departamento.IdDepartamento));
            cmd.ExecuteNonQuery();

            if (cargo.IdCargo == 0)
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
            SQLiteCommand cmd = new SQLiteCommand("DELETE Cargos WHERE idCargo=@id", Conexion.Connection);
            cmd.Parameters.Add(new SQLiteParameter("@id", id));
            cmd.ExecuteNonQuery();
            Conexion.CloseConexion();
        }

        private static Cargo DRToCargo(DataRow row)
        {
            Cargo cargo = new Cargo();
            try
            {
                cargo.IdCargo = (int)row.Field<Int64>("idCargo");
                cargo.Nombre = row.Field<string>("nombre");
                cargo.Descripcion = row.Field<string>("descripcion");
                cargo.Cupo = (int)row.Field<Int64>("cupo");
                cargo.Departamento = DatosDepartamento.GetById((int)row.Field<Int64>("idDepartamento"));
                cargo.MayoriaSimple = (bool)row.Field<Boolean>("mayoriaSimple");
                cargo.MiembroJunta = (bool)row.Field<Boolean>("miembroJunta");
                cargo.MitadMasUno = (bool)row.Field<Boolean>("mitadMasUno");
                return cargo;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return cargo;
            }
        }

    }
}
