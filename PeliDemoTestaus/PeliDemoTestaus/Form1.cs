using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeliDemoTestaus
{
    public partial class Form1 : Form
    {
        Katsottava katso = new Katsottava(); // kutsutaan sanastoluokkia, joita halutaan käyttää
        KatsottavaKaksi katsokaksi = new KatsottavaKaksi();

        public static string Klikattu = ""; // tallennetaan tähän tieto klikatusta napista, jonka mukaan sanastoluokka määräytyy

        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e) // nappia 1  painamalla tallennetaan "klikattu" muuttujaan 1
                                                               // ohjelmassa oleva label saa tiedot kyseisestä muuttujasta
        {                                                      // joka sitten siirretään seuraavalle formille
            Klikattu = "1";
            KlikattuLB.Text = Klikattu;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Klikattu = "2";
            KlikattuLB.Text = Klikattu;
        }


        private void Meemi_Click(object sender, EventArgs e) // kuvaa klikattaessa katsotaan, mitä nappia on painettu
        {
            PictureBox kuva = sender as PictureBox; // triggerinä toimii picturebox, jolloin kaikkia kuvia ei tarvitse erikseen
                                                    // määritellä vielä tässä vaiheessa

           if(KlikattuLB.Text == "1")               // painettu nappi määrittää mitä sanastoa käytetään
            {
                katso.Meme(kuva.Name);
            }
           else if(KlikattuLB.Text == "2")
            {
                katsokaksi.Meme(kuva.Name);
            }
            else
            {
                MessageBox.Show("Valitse ensin nappula");
            }
        }

        private void button3_Click(object sender, EventArgs e) // siirrytään seuraavalle formille, joka on jo mekaanisesti luotu
        {
            Klikattu = KlikattuLB.Text;                        // uudella formilla on myös label, jossa on tallennettuna tieto
                                                               // painetusta napista

            this.Hide(); // piilotetaan nykyinen form
            Form2 formKaksi = new Form2(); // alustetaan uusi form
            formKaksi.ShowDialog(); // näytetään uus form
            

        }
    }
}
