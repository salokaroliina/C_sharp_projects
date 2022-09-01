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
    public partial class GenshinImpactDB : Form
    {
        CHARACTERS characters = new CHARACTERS();
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=" + "studypoint" + ";SSL Mode = None");

        public GenshinImpactDB()
        {
            InitializeComponent();
        }


        private void CloseAll(object sender, EventArgs e)
        {
            HomePL.Visible = false;
            AddNewPL.Visible = false;
            CharactersPL.Visible = false;
            StatsPL.Visible = false;
            EditCharacterPL.Visible = false;
        }

        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            AddNewPL.Visible = true;
            HomeBtn.Visible = true;
        }


        private void giveCharacters(object sender, EventArgs e)
        {
            CharactersDTG.DataSource = characters.GetCharacter();
            CharactersDTG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }

        private void CharactersBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            CharactersPL.Visible = true;
            HomeBtn.Visible = true;

            giveCharacters(sender,e);
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

            NameTB.Text = "";
            StarsCB.Text = "";
            VisionCB.Text = "";
            RegionCB.Text = "";
            WeaponCB.Text = "";
            GenderCB.Text = "";
        }


        private void AddCharacterBtn_Click(object sender, EventArgs e)
        {
            String name = NameTB.Text;
            String stars = StarsCB.Text;
            String vision = VisionCB.Text;
            String region = RegionCB.Text;
            String weapon = WeaponCB.Text;
            String gender = GenderCB.Text;
            

            if (name.Trim().Equals("") || stars.Trim().Equals("") || vision.Trim().Equals("") || region.Trim().Equals("") || weapon.Trim().Equals("") || gender.Trim().Equals(""))
            {
                MessageBox.Show("Fill all the information!");
            }
            else if (characters.CheckCharacter(name))
            {
                MessageBox.Show("Character already exists");
            }
            else
            {
                Boolean NewFeedback = characters.AddCharacter(name,stars,vision,region,weapon,gender);

                NameTB.Text = "";
                StarsCB.Text = "";
                VisionCB.Text = "";
                RegionCB.Text = "";
                WeaponCB.Text = "";
                GenderCB.Text = "";
            }
        }

        private void CharactersDTG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CloseAll(sender, e);
            EditCharacterPL.Visible = true;
            HomeBtn.Visible = true;

            CharNameTB.Text = CharactersDTG.CurrentRow.Cells[0].Value.ToString();
            EditStarsCB.Text = CharactersDTG.CurrentRow.Cells[1].Value.ToString();
            EditVisCB.Text = CharactersDTG.CurrentRow.Cells[2].Value.ToString();
            EditRegCB.Text = CharactersDTG.CurrentRow.Cells[3].Value.ToString();
            EditWeaponCB.Text = CharactersDTG.CurrentRow.Cells[4].Value.ToString();
            EditGenderCB.Text = CharactersDTG.CurrentRow.Cells[5].Value.ToString();
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            CharactersPL.Visible = true;
            HomeBtn.Visible = true;

            giveCharacters(sender, e);
        }

        private void SaveEditBtn_Click(object sender, EventArgs e)
        {
            


        }
    }
}
