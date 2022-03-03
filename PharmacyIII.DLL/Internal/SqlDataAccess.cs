using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyIII.DLL
{
    public class SqlDataAccess : ISqlDataAccess
    {

        private string ConnectionString { get; set; } = "Default";

        public SqlDataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.Text).AsList();
                return rows;
            }
        }
    }
}
