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
        // Opening a connection to database
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=" + "studypoint" + ";SSL Mode = None");
        CHARACTERS characters = new CHARACTERS();
        

        public GenshinImpactDB()
        {
            InitializeComponent();

        }

        // Method to close all the panels
        private void CloseAll(object sender, EventArgs e)
        {
            HomePL.Visible = false;
            AddNewPL.Visible = false;
            CharactersPL.Visible = false;
            StatsPL.Visible = false;
            EditCharacterPL.Visible = false;
        }

        private void AddNewHomeBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            HomePL.Visible = true;
        }

        private void CharactersHomeBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            HomePL.Visible = true;
        }

        private void EditHomeBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            HomePL.Visible = true;
        }

        private void StatsHomeBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            HomePL.Visible = true;
        }

        // Open panel to add characters
        private void AddNewBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            AddNewPL.Visible = true;
        }

        // Fill the characters datagrid
        private void giveCharacters(object sender, EventArgs e)
        {
            CharactersDTG.DataSource = characters.GetCharacter();
            CharactersDTG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            var datagridview = new DataGridView();
            datagridview.RowTemplate.MinimumHeight = 125;
        }

        // Opens the characters-panel
        private void CharactersBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            CharactersPL.Visible = true;

            giveCharacters(sender,e);

        }

        // Opens the stats-panel
        private void StatsBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            StatsPL.Visible = true;
        }

        // Button to return to homepage
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomePL.Visible = true;

            NameTB.Text = "";
            StarsCB.Text = "";
            VisionCB.Text = "";
            RegionCB.Text = "";
            WeaponCB.Text = "";
            GenderCB.Text = "";
        }

        // Adds character to the database
        private void AddCharacterBtn_Click(object sender, EventArgs e)
        {
            String Name = NameTB.Text;
            String Stars = StarsCB.Text;
            String Vision = VisionCB.Text;
            String Region = RegionCB.Text;
            String Weapon = WeaponCB.Text;
            String Gender = GenderCB.Text;
            
            // Checks that all the information is given
            if (Name.Trim().Equals("") || Stars.Trim().Equals("") || Vision.Trim().Equals("") || Region.Trim().Equals("") || Weapon.Trim().Equals("") || Gender.Trim().Equals(""))
            {
                MessageBox.Show("Fill all the information!");
            }
            else if (characters.CheckCharacter(Name))
            {
                MessageBox.Show("Character already exists");
            }
            else
            {   // If he program runs right, character gets added and textboxs get emptied
                Boolean NewCharAdded = characters.AddCharacter(Name,Stars,Vision,Region,Weapon,Gender);

                NameTB.Text = "";
                StarsCB.Text = "";
                VisionCB.Text = "";
                RegionCB.Text = "";
                WeaponCB.Text = "";
                GenderCB.Text = "";
            }
        }

        // The background changes depending of the vision (element) of the character
        private void BackgroundChange(object sender, EventArgs e)
        {
            var BgImage = CharactersDTG.CurrentRow.Cells[3].Value.ToString();

            Image pyro = new Bitmap(@"C:\Users\salok\source\repos\C_sharp_projects\GenshinImpactDatabase\GenshinImpactDatabase\Resources\pyrobg.png");
            Image geo = new Bitmap(@"C:\Users\salok\source\repos\C_sharp_projects\GenshinImpactDatabase\GenshinImpactDatabase\Resources\geobg.png");
            Image hydro = new Bitmap(@"C:\Users\salok\source\repos\C_sharp_projects\GenshinImpactDatabase\GenshinImpactDatabase\Resources\hydrobg.png");
            Image cryo = new Bitmap(@"C:\Users\salok\source\repos\C_sharp_projects\GenshinImpactDatabase\GenshinImpactDatabase\Resources\cryobg.png");
            Image dendro = new Bitmap(@"C:\Users\salok\source\repos\C_sharp_projects\GenshinImpactDatabase\GenshinImpactDatabase\Resources\dendrobg.png");
            Image anemo = new Bitmap(@"C:\Users\salok\source\repos\C_sharp_projects\GenshinImpactDatabase\GenshinImpactDatabase\Resources\anemobg.png");
            Image electro = new Bitmap(@"C:\Users\salok\source\repos\C_sharp_projects\GenshinImpactDatabase\GenshinImpactDatabase\Resources\electrobg.png");

            switch (BgImage)
            {
                case "Pyro":
                    EditCharacterPL.BackgroundImage = pyro;
                    break;
                case "Geo":
                    EditCharacterPL.BackgroundImage = geo;
                    break;
                case "Hydro":
                    EditCharacterPL.BackgroundImage = hydro;
                    break;
                case "Cryo":
                    EditCharacterPL.BackgroundImage = cryo;
                    break;
                case "Dendro":
                    EditCharacterPL.BackgroundImage = dendro;
                    break;
                case "Anemo":
                    EditCharacterPL.BackgroundImage = anemo;
                    break;
                case "Electro":
                    EditCharacterPL.BackgroundImage = electro;
                    break;
                default:
                    EditCharacterPL.BackgroundImage = anemo;
                    break;
            }
        }

        // When datagrid's cell is clicked, character editing panel opens
        private void CharactersDTG_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CloseAll(sender, e);
            EditCharacterPL.Visible = true;
            CharIDTB.Visible = false;

            CharIDTB.Text = CharactersDTG.CurrentRow.Cells[0].Value.ToString();
            CharNameTB.Text = CharactersDTG.CurrentRow.Cells[1].Value.ToString();
            EditStarsCB.Text = CharactersDTG.CurrentRow.Cells[2].Value.ToString();
            EditVisCB.Text = CharactersDTG.CurrentRow.Cells[3].Value.ToString();
            EditRegCB.Text = CharactersDTG.CurrentRow.Cells[4].Value.ToString();
            EditWeaponCB.Text = CharactersDTG.CurrentRow.Cells[5].Value.ToString();
            EditGenderCB.Text = CharactersDTG.CurrentRow.Cells[6].Value.ToString();

            BackgroundChange(sender, e);
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            CloseAll(sender, e);
            CharactersPL.Visible = true;

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

            if (Name.Trim().Equals("") || Stars.Trim().Equals("") || Vision.Trim().Equals("") || Region.Trim().Equals("") || Weapon.Trim().Equals("") || Gender.Trim().Equals(""))
            {
                MessageBox.Show("Fill all the information!");
            }
            else if (Stars.Length > 5  || Stars.Length < 4)
            {
                MessageBox.Show("Please check the stars");
            }
            else
            {
                Boolean SaveEdit = characters.EditCharacter(Name, Stars, Vision, Region, Weapon, Gender,CharID);

                if (SaveEdit)
                {
                    MessageBox.Show("Character updated succesfully!");

                }
                else
                {
                    MessageBox.Show("Something went wrong here");
                }
                CharactersDTG.DataSource = characters.GetCharacter();
            }
        }

       
    }
}
