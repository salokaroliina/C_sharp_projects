using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliDemo
{
    public partial class Game : Form
    {
        // kutsutaan kaikki kieliluokat
        English english = new English();
        Finnish finnish = new Finnish();

        // siirretään tieto valitusta kielestä jälleen eteenpäin
        public static string lang = "";

        public Game()
        {
            InitializeComponent();
        }

        // game-formin latautuessa saadaan tieto valitusta kielestä
        private void Game_Load(object sender, EventArgs e)
        {
            lang = Language.lang;
        }

 
        // kuvaa klikatessa tarkistetaan valittu kieli
        private void Picture_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;

            // jos valittu kieli on suomi, haetaan Finnish-luokasta metodi fin, joka tarkistaa klikatun kuvan nimen
            // ja sen perusteella käynnistää halutun metodin
            if (lang == "Finnish")
            {
                finnish.Fin(picture.Name);
                
            }
            else if(lang == "English")
            {
                english.Eng(picture.Name);
            }
            else
            {
                MessageBox.Show("What did you do?");
            }

        }

        // nappi sulkee ohjelman
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
