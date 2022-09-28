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
    public partial class Form2 : Form
    {
        Katsottava katso = new Katsottava();
        KatsottavaKaksi katsokaksi = new KatsottavaKaksi();

        public Form2()
        {
            InitializeComponent();
        }


        private void Form2_Load(object sender, EventArgs e) // formin latautuessa, haetaan edelliseltä formilta tieto
                                                            // mitä nappia on klikattu
        {
            KlikattuLB.Text = Form1.Klikattu;
        }

        private void TakaisinBtn_Click(object sender, EventArgs e) // siirrytään takaisin aiemmalle formille
        {
            this.Hide();
            Form1 formEka = new Form1();
            formEka.ShowDialog();
        }



        private void Meemi_Click(object sender, EventArgs e)
        {
            PictureBox kuva = sender as PictureBox;

            if (KlikattuLB.Text == "1")
            {
                katso.Meme(kuva.Name);
            }
            else if (KlikattuLB.Text == "2")
            {
                katsokaksi.Meme(kuva.Name);
            }
            else
            {
                MessageBox.Show("Mene takaisin ja valitse nappula");
            }



        }

       
    }
}
