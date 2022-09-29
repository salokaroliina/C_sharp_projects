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
    public partial class Language : Form
    {
        // stringiin tallentuu tieto valitusta kielestä
        public static string lang = "";

        public Language()
        {
            InitializeComponent();
        }

        // toinen sivu

        // valitaan kieleksi englanti
        private void EnglishBtn_Click(object sender, EventArgs e)
        {
            // tieto valitusta kielestä siirretään eteenpäin
            lang = "English";

            // piilotetaan nykyinen form ja tuodaan näkyviin game-form
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
        }

        // valitaan kieleksi suomi
        private void FinnishBtn_Click(object sender, EventArgs e)
        {
            // tieto valitusta kielestä siirretään eteenpäin
            lang = "Finnish";

            // piilotetaan nykyinen form ja tuodaan näkyviin game-form
            this.Hide();
            Game game = new Game();
            game.ShowDialog();
        }

    }
}
