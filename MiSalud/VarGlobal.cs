using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiSalud
{
    public static class VarGlobal
    {
        private const string postgres = "Server=localhost;Port=5432;Database=H.T.Misalud;User Id=postgres;Password=postgres;";
        public static string ConexionDB { get { return postgres; } }
        public static DataTable EjecutaConsulta(string query)
        {
            DataTable dataTable = new DataTable();

            using (NpgsqlConnection connection = new NpgsqlConnection(ConexionDB))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }

            return dataTable;
        }

        public static void EjecutaSentencia(string query)
        {

            using (NpgsqlConnection connection = new NpgsqlConnection(ConexionDB))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
