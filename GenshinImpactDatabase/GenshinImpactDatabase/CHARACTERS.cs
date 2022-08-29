using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinImpactDatabase
{
    internal class CHARACTERS
    {
        CONNECT connection = new CONNECT();

        public bool AddCharacter(String name, String vision, String region, String weapon, String gender)
        {
            MySqlCommand myCommand = new MySqlCommand();
            String addChar = "INSERT INTO characters " +
                "(name,vision,region,weapon,gender) " +
                "VALUES (@name,@vis,@reg,@wpn,@gndr);";
            myCommand.CommandText = addChar;
            myCommand.Connection = connection.Connection();

            myCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
            myCommand.Parameters.Add("@vis", MySqlDbType.VarChar).Value = vision;
            myCommand.Parameters.Add("@reg", MySqlDbType.VarChar).Value = region;
            myCommand.Parameters.Add("@wpn", MySqlDbType.VarChar).Value = weapon;
            myCommand.Parameters.Add("@gndr", MySqlDbType.VarChar).Value = gender;
            MessageBox.Show("New character added!");

            connection.OpenConnection();
            if(myCommand.ExecuteNonQuery() == 1)
            {
                connection.CloseConnection();
                return true;
            }
            else
            {
                connection.CloseConnection();
                return false;
            }
        }

        public bool CheckCharacter(string name)
        {
            connection.OpenConnection();
            MySqlCommand mycommand = new MySqlCommand("SELECT name FROM characters WHERW name = '" + name + "'", connection.Connection());

            var word = (string)mycommand.ExecuteScalar();
            connection.CloseConnection();

            if (word == name)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public DataTable GetCharacter()
        {
            MySqlCommand MyCommand = new MySqlCommand("SELECT name,vision,region,weapon,gender FROM characters", connection.Connection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable MyTable = new DataTable();

            MyAdapter.SelectCommand = MyCommand;
            MyAdapter.Fill(MyTable);

            return MyTable;
        }

    }
}
