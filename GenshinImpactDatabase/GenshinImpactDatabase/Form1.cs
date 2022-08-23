using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinImpactDatabase
{
    public partial class Form1 : Form
    {
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
    }
}
