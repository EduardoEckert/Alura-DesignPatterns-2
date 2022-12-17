using System.Data;
using System.Data.SqlClient;

namespace Alura_DesignPatterns_2.Atividade01
{
    public class ConnectionFactory
    {
        public IDbConnection GetConnection()
        {
            IDbConnection connection = new SqlConnection();
            connection.ConnectionString = "User Id = root;Password=;Server=localhost;Database=meuBanco ";
            connection.Open();

            return connection;
        }
    }
}
