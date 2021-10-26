using Entidades.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Server;

namespace Datos.AdmModels
{
    public static class AdminMedico
    {
        public static List<Medico> listar()
        {
            //ToDo Modelo conectado, devuelve una lista de Medicos.
            //ToDo CHEQUEAR 

            string consultaSQL = "SELECT Id , Nombre, Apellido , NroMatricula , EspecialidadId FROM dbo.Medico";

            SqlCommand command = new SqlCommand(consultaSQL, AdminBD.conectarBase());

            SqlDataReader reader;

            reader = command.ExecuteReader();

            List<Medico> listaMedicos = new List<Medico>();

            while (reader.Read())
            {
                listaMedicos.Add(
                    new Medico()
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        Nombre = reader["Nombre"].ToString(), 
                        Apellido = reader["Apellido"].ToString(), 
                        NroMatricula = Convert.ToInt32(reader["NroMatricula"]), 
                        EspecialidadId = Convert.ToInt32(reader["EspecialidadId"])
                    }
                    );
            }

            AdminBD.conectarBase().Close();
            reader.Close();

            return listaMedicos;
        }

        public static DataTable listar(int idEspecialidad)
        {
            //ToDo Modelo Desconectado, devuelve un Data Table de medico.
            //ToDo CHEQUEAR 

            string consultaSQL = "SELECT Id , Nombre, Apellido , NroMatricula , EspecialidadId FROM dbo.Medico WHERE EspecialidadId = @EspecialidadId";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminBD.conectarBase());

             adapter.SelectCommand.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = idEspecialidad;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "EspecialidadId");

            return ds.Tables["EspecialidadId"];

        }

        public static DataTable traerUno(int id)
        {
            //ToDo Modelo desconectado, devuelve un DataTable medico 
            //ToDo CHEQUEAR 
            string consultaSQL = "SELECT Id , Nombre, Apellido , NroMatricula , EspecialidadId FROM dbo.Medico WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminBD.conectarBase());

            adapter.SelectCommand.Parameters.Add("ID", SqlDbType.Int).Value = id;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "ID");

            return ds.Tables["ID"];
        }

        public static int Crear(Medico medico)
        {
            // ToDo crear un Medico, operacion de modificacion, retorna un INT.

            string insertSQL = "INSERT dbo.Medico (Nombre,Apellido,NroMatricula,EspecialidadId) VALUES(@Nombre, @Apellido, @NroMatricula, @EspecialidadId)";

            SqlCommand command = new SqlCommand(insertSQL, AdminBD.conectarBase());

            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
            command.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
            command.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = medico.EspecialidadId;

            int filasAfectadas = command.ExecuteNonQuery();

            AdminBD.conectarBase().Close();

            return filasAfectadas;
        }

        public static int eliminar (int id)
        {

            string consultaSQL = "DELETE FROM dbo.Medico WHERE Id = @Id";


            SqlCommand command = new SqlCommand(consultaSQL, AdminBD.conectarBase());

            command.Parameters.Add("@Id", SqlDbType.Int).Value = id;

            int filasAfectadas = command.ExecuteNonQuery();

            AdminBD.conectarBase().Close();

            return filasAfectadas;
            //ToDo implementarCodigo
        }

        public static int modificar(Medico medico)
        {
            string consultaSQL = "UPDATE dbo.Medico SET Nombre=@Nombre,Apellido=@Apellido,NroMatricula=@NroMatricula,EspecialidadId=@EspecialidadId WHERE Id=@Id ";

            SqlCommand command = new SqlCommand(consultaSQL, AdminBD.conectarBase());

            command.Parameters.Add("@Nombre", SqlDbType.VarChar, 50).Value = medico.Nombre;
            command.Parameters.Add("@Apellido", SqlDbType.VarChar, 50).Value = medico.Apellido;
            command.Parameters.Add("@NroMatricula", SqlDbType.Int).Value = medico.NroMatricula;
            command.Parameters.Add("@EspecialidadId", SqlDbType.Int).Value = medico.EspecialidadId;
            command.Parameters.Add("@Id", SqlDbType.Int).Value = medico.ID;

            int filasAfectadas = command.ExecuteNonQuery();

            AdminBD.conectarBase().Close();

            return filasAfectadas;
        }
    }
}
