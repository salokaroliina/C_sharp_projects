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
        
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=" + "studypoint" + ";SSL Mode = None");
        CHARACTERS characters = new CHARACTERS();

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
            String Name = NameTB.Text;
            String Stars = StarsCB.Text;
            String Vision = VisionCB.Text;
            String Region = RegionCB.Text;
            String Weapon = WeaponCB.Text;
            String Gender = GenderCB.Text;
            

            if (Name.Trim().Equals("") || Stars.Trim().Equals("") || Vision.Trim().Equals("") || Region.Trim().Equals("") || Weapon.Trim().Equals("") || Gender.Trim().Equals(""))
            {
                MessageBox.Show("Fill all the information!");
            }
            else if (characters.CheckCharacter(Name))
            {
                MessageBox.Show("Character already exists");
            }
            else
            {
                Boolean NewCharAdded = characters.AddCharacter(Name,Stars,Vision,Region,Weapon,Gender);

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

            CharIDTB.Text = CharactersDTG.CurrentRow.Cells[0].Value.ToString();
            CharNameTB.Text = CharactersDTG.CurrentRow.Cells[1].Value.ToString();
            EditStarsCB.Text = CharactersDTG.CurrentRow.Cells[2].Value.ToString();
            EditVisCB.Text = CharactersDTG.CurrentRow.Cells[3].Value.ToString();
            EditRegCB.Text = CharactersDTG.CurrentRow.Cells[4].Value.ToString();
            EditWeaponCB.Text = CharactersDTG.CurrentRow.Cells[5].Value.ToString();
            EditGenderCB.Text = CharactersDTG.CurrentRow.Cells[6].Value.ToString();
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
            int CharID = Int32.Parse(CharIDTB.Text);
            String Name = CharNameTB.Text;
            String Stars = EditStarsCB.Text;
            String Vision = EditVisCB.Text;
            String Region = EditRegCB.Text;
            String Weapon = EditWeaponCB.Text;
            String Gender = EditGenderCB.Text;

            if (Name.Trim().Equals(""))
            {
                MessageBox.Show("Give the name");
            }
            else
            {
                Boolean SaveEdit = characters.EditCharacter(Name, Stars, Vision, Region, Weapon, Gender,CharID);

                if (SaveEdit)
                {
                    MessageBox.Show("Yahoo you fucker");
                }
                else
                {
                    MessageBox.Show("Boo you fucker");
                }
                CharactersDTG.DataSource = characters.GetCharacter();
            }
        }
    }
}
