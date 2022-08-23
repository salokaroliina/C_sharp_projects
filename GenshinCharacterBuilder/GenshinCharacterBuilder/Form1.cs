using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenshinCharacterBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RandomizeBT_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // new random to randomize strings
            string[] Visions = { "Cryo", "Hydro", "Anemo", "Pyro", "Dendro", "Geo", "Electro" }; // strings to randomize
            string[] Weapons = { "Sword", "Polearm", "Bow", "Claymore", "Catalyst" };
            string[] Regions = { "Mondstadt", "Liyue", "Inazuma", "Sumeru" };
            string[] Genders = { "Female", "Male" };
            string[] Bodytypes = { "Short", "Medium", "Tall" };

            int Vision = rnd.Next(Visions.Length); // Randomize the wanted string
            int Weapon = rnd.Next(Weapons.Length);
            int Region = rnd.Next(Regions.Length);
            int Gender = rnd.Next(Genders.Length);
            int BodyType = rnd.Next(Bodytypes.Length);

            VisionRandomLB.Text = Visions[Vision]; // displays the randomized text
            WeaponRandomLB.Text = Weapons[Weapon];
            RegionRandomLB.Text = Regions[Region];
            GenderRandomLB.Text = Genders[Gender];
            BodyRandomLB.Text = Bodytypes[BodyType];

            VisionRandomLB.Visible = true; // brings the hidden label back to visible
            WeaponRandomLB.Visible = true;
            RegionRandomLB.Visible = true;
            GenderRandomLB.Visible = true;
            BodyRandomLB.Visible = true;
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseLB_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
