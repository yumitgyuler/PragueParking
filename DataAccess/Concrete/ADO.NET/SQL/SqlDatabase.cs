using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Concrete.ADO.NET.SQL
{   //Connect with database and returns ready connection.
    public class SqlDatabase
    {
        public SqlConnection ConnectToDb(string connectionString)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
