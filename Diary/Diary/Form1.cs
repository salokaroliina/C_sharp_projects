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
    public partial class MyDiary : Form
    {
        // New connection to database
        MySqlConnection connection = new MySqlConnection("datasource=localhost; port=3306;username=root;password=;database=" + "diary" + ";SSL Mode = None");
        ENTRIES entries = new ENTRIES();

        public MyDiary()
        {
            InitializeComponent();
        }

        // Method to hide all panels at once
        private void HideAll()
        {
            FrontPL.Visible = false;
            RegisterPL.Visible = false;
            HomePL.Visible = false;
            NewEntryPL.Visible = false;
            OldEntriesPL.Visible = false;

        }

        // When the app loads, only front panel is visible
        private void MyDiary_Load(object sender, EventArgs e)
        {
            HideAll();
            HomePL.Visible = true;
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            HideAll();
            RegisterPL.Visible = true;
        }

        // NEW ENTRY 
        // Shows the new entry -panel
        private void NewEntryBtn_Click(object sender, EventArgs e)
        {
            HideAll();
            NewEntryPL.Visible = true;
        }

        // Saves the entry into database
        private void SaveEntryBtn_Click(object sender, EventArgs e)
        {
            String entrydate = DateTB.Text;
            String entrytext = EntryTB.Text;


            if (entrydate.Trim().Equals("") || entrytext.Trim().Equals(""))
            {
                MessageBox.Show("Please give the date and a diary entry");
            }
            else
            {   // If he program runs right, new diary entry gets added to the database
                Boolean NewEntry = entries.AddEntry(entrydate, entrytext);
                MessageBox.Show("New entry added!");

                DateTB.Text = "";
                EntryTB.Text = "";
            }
        }

        // Goes back to home-page and wipes date and entry texts
        private void NewEntryHomeBtn_Click(object sender, EventArgs e)
        {
            DateTB.Text = "";
            EntryTB.Text = "";
            HideAll();
            HomePL.Visible = true;
        }

        // OLD ENTRIES

        private void OldEntriesBtn_Click(object sender, EventArgs e)
        {
            HideAll();
            OldEntriesPL.Visible = true;
            
            EntriesDTG.DataSource = entries.GetEntry();
        }

        private void CreateEntry()
        {
            
        }

        private void OldEntriesHomeBtn_Click(object sender, EventArgs e)
        {
            HideAll();
            HomePL.Visible = true;
        }

        int labelTop = 35;
        int labelLeft = 10;
        int labelCount = 0;
        int labelStop = 9;

        private void MakeButtonBtn_Click(object sender, EventArgs e)
        {
            labelCount++;
           
            

                for (int j = 0; j < labelCount; j++)
                {
                    LinkLabel myLabel = new LinkLabel();
                    this.Controls.Add(myLabel);

                    myLabel.Font = new System.Drawing.Font("Mongolian Baiti", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    myLabel.ForeColor = System.Drawing.Color.Black;
                    myLabel.BackColor = System.Drawing.Color.Transparent;
                    myLabel.Location = new System.Drawing.Point(labelLeft, labelTop);
                    myLabel.Name = "myEntry";
                    myLabel.Size = new System.Drawing.Size(380, 50);
                    myLabel.TabIndex = 3;
                    myLabel.Text = "Hehe";
                    myLabel.Parent = OldEntriesPL;
                    labelTop += 55;
                    labelCount--;
                    labelStop--;

                }

            if(labelStop == 0)
            {
                MakeButtonBtn.Enabled = false;
            }

            
        }

    }
}
