using System;
using System.Data;

using System.Data.SqlClient;

namespace SQLApp.Model.Classes
{
    public static class SqlManager
    {
        private static SqlConnection _connection = new SqlConnection();

        public static ConnectionState ConnectionState
        {
            get
            {
                return _connection.State;
            }
        }

        public static void Connect(SqlConnectionStringBuilder connectionBuilder)
        {
            if(connectionBuilder != null)
            {
                _connection = new SqlConnection(connectionBuilder.ConnectionString);
                _connection.Open();
            }
        }

        public static DataSet ExecuteDataAdapter(string command)
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter(command, _connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);

            return dataSet;
        }

        public static SqlDataReader ExecuteReader(string command)
        {
            SqlCommand sqlCommand = new SqlCommand(command, _connection);
            return sqlCommand.ExecuteReader();
        }

        public static DataTable GetSchema(string collectionName, string[] restrictionValues)
        {
            return _connection.GetSchema(collectionName, restrictionValues);
        }
    }
}