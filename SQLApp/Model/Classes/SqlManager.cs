using System;

using System.Data.SqlClient;

namespace SQLApp.Model.Classes
{
    public static class SqlManager
    {
        public delegate void VoidMethod();

        public delegate void VoidMethodWithString(string text);

        public static void SqlConnect(SqlConnectionStringBuilder connectionBuilder, VoidMethod mainMethod, VoidMethodWithString errorMethod)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionBuilder.ConnectionString))
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                errorMethod(ex.Message);
            }
        }
    }
}
