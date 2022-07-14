using System;
using System.Data;

using System.Data.SqlClient;

namespace SQLApp.Model.Classes
{
    public static class SqlManager
    {
        public static ConnectionState ConnectionState(SqlConnectionStringBuilder connectionBuilder)
        {
            using (SqlConnection connection = new SqlConnection(connectionBuilder.ConnectionString))
            {
                connection.Open();

                return connection.State;
            }
        }

        public static DataSet ExecuteDataAdapter(SqlConnectionStringBuilder connectionBuilder, string command)
        {
            using (SqlConnection connection = new SqlConnection(connectionBuilder.ConnectionString))
            {
                connection.Open();

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connection);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet;
            }
        }

        public static DataTable GetSchema(SqlConnectionStringBuilder connectionBuilder)
        {
            using (SqlConnection connection = new SqlConnection(connectionBuilder.ConnectionString))
            {
                connection.Open();

                return connection.GetSchema("Tables");
            }
        }
    }
}
