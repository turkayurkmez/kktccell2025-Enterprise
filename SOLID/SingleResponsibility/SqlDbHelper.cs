using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class SqlDbHelper
    {
        private SqlConnection sqlConnection;

        public SqlDbHelper(string connectionString)
        {
            sqlConnection = new SqlConnection(connectionString);
        }

       public int ExecuteNonQuery(string commandText, Dictionary<string,object> parameters)
        
        {
            SqlCommand command = createCommand(commandText, parameters);

            command.Connection.Open();
            int affectedRows = command.ExecuteNonQuery();
            command.Connection.Close();
            return affectedRows;
        }

        private SqlCommand createCommand(string commandText, Dictionary<string, object> parameters)
        {
            var command = sqlConnection.CreateCommand();
            command.CommandText = commandText;

            addParametersToCommand(command, parameters);
            return command;
        }

        private void addParametersToCommand(SqlCommand command, Dictionary<string, object> parameters)
        {
            foreach (var parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

        }
    }
}
