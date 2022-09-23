using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    internal class ENTRIES
    {
        CONNECT connection = new CONNECT();

        public bool AddEntry(String entrydate, String entrytext)
        {
            MySqlCommand myCommand = new MySqlCommand();
            String addEntry = "INSERT INTO entries " +
                "(entrydate,entrytext) " +
                "VALUES (@entrydate, @entrytext);";
            myCommand.CommandText = addEntry;
            myCommand.Connection = connection.Connection();

            myCommand.Parameters.Add("@entrydate", MySqlDbType.VarChar).Value = entrydate;
            myCommand.Parameters.Add("@entrytext", MySqlDbType.VarChar).Value = entrytext;

            

            connection.OpenConnection();
            if (myCommand.ExecuteNonQuery() == 1)
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


        public DataTable GetEntry()
        {
            MySqlCommand MyCommand = new MySqlCommand("SELECT Entryid,Entrydate,Entrytext FROM entries", connection.Connection());
            MySqlDataAdapter MyAdapter = new MySqlDataAdapter();
            DataTable MyTable = new DataTable();

            MyAdapter.SelectCommand = MyCommand;
            MyAdapter.Fill(MyTable);

            return MyTable;
        }

        public bool EditCharacter(String Date, String Entry)
        {
            MySqlCommand myCommand = new MySqlCommand();
            String updateCharacters = "UPDATE `entries` SET  " +
                "`Date` = @entrydate,`Entry` = @entrytext" +
                "WHERE Entryid = @entryid ";
            myCommand.CommandText = updateCharacters;
            myCommand.Connection = connection.Connection();

            myCommand.Parameters.Add("@Date", MySqlDbType.UInt32).Value = Date;
            myCommand.Parameters.Add("@Entry", MySqlDbType.VarChar).Value = Entry;


            connection.OpenConnection();
            if (myCommand.ExecuteNonQuery() == 1)
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
    }
}