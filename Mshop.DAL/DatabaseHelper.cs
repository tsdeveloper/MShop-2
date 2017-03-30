using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Mshop.DAL
{
    public class DatabaseHelper
    {
        private string connectionStr;

        public DatabaseHelper()
        {
            connectionStr = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
        }

        public object GetAll()
        {
            using (var con = new MySqlConnection(connectionStr))
            {
                con.Open();
                var commandText = "select name from abpusers where id=@id";
                var command = new MySqlCommand(commandText, con);
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Add(new MySqlParameter("@id",1));
                object result = command.ExecuteScalar();
                return result;
            }
        }
    }
}
