using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace GenshinImpactDatabase
{
    public partial class Form1 : Form
    {
        CHARACTERS characters = new CHARACTERS();
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=" + "studypoint" + ";SSL Mode = None");
        MySqlCommand command;
        MySqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

      

        private void CloseAll(object sender, EventArgs e)
        {
            HomePL.Visible = false;
            AddNewPL.Visible = false;
            CharactersPL.Visible = false;
            StatsPL.Visible = false;
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            AddNewPL.Visible = true;
            HomeBtn.Visible = true;
        }

        private void CharactersBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            CharactersPL.Visible = true;
            HomeBtn.Visible = true;
        }

        private void StatsBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            StatsPL.Visible = true;
            HomeBtn.Visible = true;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomePL.Visible = true;
            HomeBtn.Visible = false;
        }

        private void CloseLB_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddCharacterBtn_Click(object sender, EventArgs e)
        {
            String name = NameTB.Text;
            String vision = VisionCB.Text;
            String region = RegionCB.Text;
            String weapon = WeaponCB.Text;
            String gender = GenderCB.Text;
            

            if (name == "" || vision == "" || region == "" || weapon == "" || gender == "")
            {
                MessageBox.Show("Fill all the information!");
            }
            else
            {
                Boolean NewFeedback = characters.AddCharacter(name,vision,region,weapon,gender);

                NameTB.Text = "";
                VisionCB.Text = "";
                RegionCB.Text = "";
                WeaponCB.Text = "";
                GenderCB.Text = "";
            }
        }
    }
}
