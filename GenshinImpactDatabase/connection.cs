using System;

public class Class1
{
    internal class connection
    {


        private MySqlConnection _connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=" + "genshinimpactdb" + ";SSL Mode = None");

        public MySqlConnection Connection()
        {
            return _connection;
        }

        public void OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }

        }

        public void CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }
    }
}
}
