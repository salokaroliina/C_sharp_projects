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

        public bool AddCharacter(String Name, String Stars,String Vision, String Region, String Weapon, String Gender)
        {
            MySqlCommand myCommand = new MySqlCommand();
            String addChar = "INSERT INTO characters " +
                "(name,stars,vision,region,weapon,gender) " +
                "VALUES (@name,@stars,@vis,@reg,@wpn,@gndr);";
            myCommand.CommandText = addChar;
            myCommand.Connection = connection.Connection();

            myCommand.Parameters.Add("@name", MySqlDbType.VarChar).Value = Name;
            myCommand.Parameters.Add("@stars", MySqlDbType.VarChar).Value = Stars;
            myCommand.Parameters.Add("@vis", MySqlDbType.VarChar).Value = Vision;
            myCommand.Parameters.Add("@reg", MySqlDbType.VarChar).Value = Region;
            myCommand.Parameters.Add("@wpn", MySqlDbType.VarChar).Value = Weapon;
            myCommand.Parameters.Add("@gndr", MySqlDbType.VarChar).Value = Gender;
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
            MySqlCommand mycommand = new MySqlCommand("SELECT name FROM characters WHERE name = '" + name + "'", connection.Connection());

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
            MySqlCommand MyCommand = new MySqlCommand("SELECT Name,Stars,Vision,Region,Weapon,Gender FROM characters", connection.Connection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable MyTable = new DataTable();

            MyAdapter.SelectCommand = MyCommand;
            MyAdapter.Fill(MyTable);

            return MyTable;
        }

       
    }
}
