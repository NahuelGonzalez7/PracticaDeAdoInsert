using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Datos.Server;
using Entidades.Models;

namespace Datos.AdmModels
{
    public static class AdminEspecialidad
    {
        public static DataTable Listar()
        {
            string consultaSQL = "SELECT DISTINCT Id, Nombre FROM dbo.Especialidad";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL, AdminBD.conectarBase());

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Especialidades");

            return ds.Tables["Especialidades"];

            //ToDo devuelve un DataTable - PROBAR
            
        }

        public static DataTable TraerUno(int id)
        {
            string consultaSQL = "SELECT Id , Nombre FROM dbo.Especialidad WHERE Id = @Id";

            SqlDataAdapter adapter = new SqlDataAdapter(consultaSQL,AdminBD.conectarBase());

            adapter.SelectCommand.Parameters.Add("Id", SqlDbType.Int).Value = id;

            DataSet ds = new DataSet();

            adapter.Fill(ds, "Id");

            return ds.Tables["id"];

            //ToDo devuelve un DataTable Medico (modelo desconectado) - PROBAR
        }

        public static int Crear(Especialidad especialidad)
        {
            string insertSQL = "INSERT dbo.Especialidad(Nombre) VALUES (@Nombre)";

            SqlCommand command = new SqlCommand(insertSQL, AdminBD.conectarBase());

            command.Parameters.Add("Nombre", SqlDbType.VarChar, 50).Value = "Nombre";

            int filasAfectadas = command.ExecuteNonQuery();

            AdminBD.conectarBase().Close();

            return filasAfectadas;

            //ToDo retorna un int, operacion de modificacion - PROBAR
        }
    }
}
