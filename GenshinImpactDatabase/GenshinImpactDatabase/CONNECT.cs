using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenshinImpactDatabase
{
    internal class CONNECT
    {

        // NEW CONNECTION TO DATABASE
        private MySqlConnection _connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=" + "genshinimpactdb" + ";SSL Mode = None");

        public MySqlConnection Connection()
        {
            return _connection;
        }

        // OPENS CONNECTION
        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        // CLOSES CONNECTION
        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
