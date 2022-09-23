using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nelikentta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void EsimerkkiSeuraavaBtn_Click(object sender, EventArgs e)
        {
            EsimerkkiPL.Visible = false;
            BasePL.Visible = true;
        }

        private void EsimerkkiSivuTakaisinBtn_Click(object sender, EventArgs e)
        {
            BasePL.Visible = false;
            EsimerkkiPL.Visible = true;
        }


        // Kaikki buttonit ja textboxit ovat piilossa kunnes toisin kutsutaan
        private void Piilota()
        {
            YlaVasLisaaBtn.Visible = false;
            YlaVasTextBoxTB.Visible = false;
            YlaVasTyhjennaBtn.Visible = false;

            YlaOikLisaaBtn.Visible = false;
            YlaOikTextBoxTB.Visible = false;
            YlaOikTyhjennaBtn.Visible = false;

            AlaVasLisaaBtn.Visible = false;
            AlaVasTextBoxTB.Visible = false;
            AlaVasTyhjennaBtn.Visible = false;

            AlaOikLisaaBtn.Visible = false;
            AlaOikTextBoxTB.Visible = false;
            AlaOikTyhjennaBtn.Visible = false;
        }

        private void Nayta()
        {
            YlaVasKlikkaaLB.Visible = true;
            YlaOikKlikkaaLB.Visible = true;
            AlaVasKlikkaaLB.Visible = true;
            AlaOikKlikkaaLB.Visible = true;
        }


        // YLÄ-VASEN PANEELI
        private void YlaVasKlikkaaLB_Click(object sender, EventArgs e)
        {
            Piilota();
            Nayta();
            YlaVasKlikkaaLB.Visible = false;
            YlaVasTextBoxTB.Visible = true;
            YlaVasLisaaBtn.Visible = true;
            YlaVasTyhjennaBtn.Visible = true;
            
        }

        // Määritellään alkuarvot ensimmäisen labelin sijainnille, top ja left
        // Count, jonka avulla uusi label aina luodaan
        // Stopit, jotka määrittävät montako labelia mahtuu yhdelle puolelle sekä yhteensä
        int YlaVasTop = 10;
        int YlaVasLeft = 10;
        int YlaVasCount = 0;
        int YlaVasFullStop = 12;
       

        // LISÄÄ-NAPPI
        // Nappia painamalla luodaan uusi label, joka tulee näkyviin haluttuun kohtaan
        private void YlaVasLisaaBtn_Click(object sender, EventArgs e)
        {
            // Tarkistetaan, onko tekstiboksissa mitään
            if(YlaVasTextBoxTB.Text == "")
            {
                MessageBox.Show("Anna ensin sana tai lause");
            }
            else
            {

                YlaVasCount++;
                // For-looppi luo uuden labelin joka kerta kun nappia painetaan
                for (int i = 0; i < YlaVasCount; i++)
                {
                    Label SanaLB = new Label();
                    this.Controls.Add(SanaLB);

                    String UusiSana = YlaVasTextBoxTB.Text;

                    SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    SanaLB.Location = new System.Drawing.Point(YlaVasLeft, YlaVasTop);
                    SanaLB.Name = "SanaLB";
                    SanaLB.Size = new System.Drawing.Size(380,50);
                    SanaLB.TabIndex = 3;
                    SanaLB.Text = UusiSana;
                    SanaLB.Parent = YlaVasGB;
                    YlaVasTop += 55;
                    YlaVasCount--;
                    YlaVasFullStop--;
                    
                }

                // Tekstikenttä tyhjenee napin painalluksesta
                YlaVasTextBoxTB.Text = "";

                // Kun labelien määrä on tullut täyteen, uusia ei voi enää lisätä
                if (YlaVasFullStop == 6)
                {
                    YlaVasFullStop = 6;
                    YlaVasTop = 10;
                    YlaVasLeft = 420;
                    
                    for (int j = 0; j < YlaVasCount; j++)
                    {
                        Label SanaLB = new Label();
                        this.Controls.Add(SanaLB);

                        String UusiSana = YlaVasTextBoxTB.Text;

                        SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        SanaLB.Location = new System.Drawing.Point(YlaVasLeft, YlaVasTop);
                        SanaLB.Name = "SanaLB";
                        SanaLB.Size = new System.Drawing.Size(380, 50);
                        SanaLB.TabIndex = 3;
                        SanaLB.Text = UusiSana;
                        SanaLB.Parent = YlaVasGB;
                        YlaVasTop += 55;
                        YlaVasCount--;
                        YlaVasFullStop--;
                        
                    } 
                }
                if (YlaVasFullStop == 0)
                {
                    YlaVasTextBoxTB.Enabled = false;
                    YlaVasLisaaBtn.Enabled = false;
                }

            }
        }

        // TYHJENNÄ KAIKKI -NAPPI
        // Tyhjentää koko group boxin ja palauttaa alkuperäiset arvot
        private void YlaVasTyhjennaBtn_Click(object sender, EventArgs e)
        {
            YlaVasGB.Controls.Clear();
            YlaVasLisaaBtn.Enabled = true;
            YlaVasTextBoxTB.Enabled = true;
            YlaVasTop = 10;
            YlaVasLeft = 10;
            YlaVasCount = 0;
            YlaVasFullStop = 12;
        }


        // YLÄ-OIKEA PANEELI

        private void YlaOikKlikkaaLB_Click(object sender, EventArgs e)
        {
            Piilota();
            Nayta();
            YlaOikKlikkaaLB.Visible = false;
            YlaOikTextBoxTB.Visible = true;
            YlaOikLisaaBtn.Visible = true;
            YlaOikTyhjennaBtn.Visible = true;
        }


        int YlaOikTop = 10;
        int YlaOikLeft = 10;
        int YlaOikCount = 0;
        int YlaOikFullStop = 12;
        
        private void YlaOikLisaaBtn_Click(object sender, EventArgs e)
        {
            // Tarkistetaan, onko tekstiboksissa mitään
            if (YlaOikTextBoxTB.Text == "")
            {
                MessageBox.Show("Anna ensin sana tai lause");
            }
            else
            {

                YlaOikCount++;
                // For-looppi luo uuden labelin joka kerta kun nappia painetaan
                for (int i = 0; i < YlaOikCount; i++)
                {
                    Label SanaLB = new Label();
                    this.Controls.Add(SanaLB);

                    String UusiSana = YlaOikTextBoxTB.Text;

                    SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    SanaLB.Location = new System.Drawing.Point(YlaOikLeft, YlaOikTop);
                    SanaLB.Name = "SanaLB";
                    SanaLB.Size = new System.Drawing.Size(380, 50);
                    SanaLB.TabIndex = 3;
                    SanaLB.Text = UusiSana;
                    SanaLB.Parent = YlaOikGB;
                    YlaOikTop += 55;
                    YlaOikCount--;
                    YlaOikFullStop--;
                    
                }
                // Tekstikenttä tyhjenee napin painalluksesta
                YlaOikTextBoxTB.Text = "";

                if (YlaOikFullStop == 6)
                {
                    YlaOikFullStop = 6;
                    YlaOikTop = 10;
                    YlaOikLeft = 420;
                    for (int j = 0; j < YlaOikCount; j++)
                    {
                        Label SanaLB = new Label();
                        this.Controls.Add(SanaLB);

                        String UusiSana = YlaOikTextBoxTB.Text;

                        SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        SanaLB.Location = new System.Drawing.Point(YlaOikLeft, YlaOikTop);
                        SanaLB.Name = "SanaLB";
                        SanaLB.Size = new System.Drawing.Size(380, 50);
                        SanaLB.TabIndex = 3;
                        SanaLB.Text = UusiSana;
                        SanaLB.Parent = YlaOikGB;
                        YlaOikTop += 55;
                        YlaOikCount--;
                        YlaOikFullStop--;

                    }
                }
                if (YlaOikFullStop == 0)
                {
                    YlaOikTextBoxTB.Enabled = false;
                    YlaOikLisaaBtn.Enabled = false;
                }
            }
        }

        private void YlaOikTyhjennaBtn_Click(object sender, EventArgs e)
        {
            YlaOikGB.Controls.Clear();
            YlaOikLisaaBtn.Enabled = true;
            YlaOikTextBoxTB.Enabled = true;
            YlaOikTop = 10;
            YlaOikLeft = 10;
            YlaOikCount = 0;
            YlaOikFullStop = 12;
        }


        // ALA-VASEN PANEELI

        private void AlaVasKlikkaaLB_Click(object sender, EventArgs e)
        {
            Piilota();
            Nayta();
            AlaVasKlikkaaLB.Visible = false;
            AlaVasTextBoxTB.Visible = true;
            AlaVasLisaaBtn.Visible = true;
            AlaVasTyhjennaBtn.Visible = true;
        }


        int AlaVasTop = 10;
        int AlaVasLeft = 10;
        int AlaVasCount = 0;
        int AlaVasFullStop = 12;

        private void AlaVasLisaaBtn_Click(object sender, EventArgs e)
        {
            // Tarkistetaan, onko tekstiboksissa mitään
            if (AlaVasTextBoxTB.Text == "")
            {
                MessageBox.Show("Anna ensin sana tai lause");
            }
            else
            {

                AlaVasCount++;
                // For-looppi luo uuden labelin joka kerta kun nappia painetaan
                for (int i = 0; i < AlaVasCount; i++)
                {
                    Label SanaLB = new Label();
                    this.Controls.Add(SanaLB);

                    String UusiSana = AlaVasTextBoxTB.Text;

                    SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    SanaLB.Location = new System.Drawing.Point(AlaVasLeft, AlaVasTop);
                    SanaLB.Name = "SanaLB";
                    SanaLB.Size = new System.Drawing.Size(380, 50);
                    SanaLB.TabIndex = 3;
                    SanaLB.Text = UusiSana;
                    SanaLB.Parent = AlaVasGB;
                    AlaVasTop += 55;
                    AlaVasCount--;
                    AlaVasFullStop--;
                }
                // Tekstikenttä tyhjenee napin painalluksesta
                AlaVasTextBoxTB.Text = "";

                // Kun labelien määrä on tullut täyteen, uusia ei voi enää lisätä
                if (AlaVasFullStop == 6)
                {
                    AlaVasFullStop = 6;
                    AlaVasTop = 10;
                    AlaVasLeft = 420;

                    for (int j = 0; j < AlaVasCount; j++)
                    {
                        Label SanaLB = new Label();
                        this.Controls.Add(SanaLB);

                        String UusiSana = AlaVasTextBoxTB.Text;

                        SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        SanaLB.Location = new System.Drawing.Point(AlaVasLeft, AlaVasTop);
                        SanaLB.Name = "SanaLB";
                        SanaLB.Size = new System.Drawing.Size(380, 50);
                        SanaLB.TabIndex = 3;
                        SanaLB.Text = UusiSana;
                        SanaLB.Parent = AlaVasGB;
                        AlaVasTop += 55;
                        AlaVasCount--;
                        AlaVasFullStop--;
                    }

                }

                if (AlaVasFullStop == 0)
                {
                    AlaVasLisaaBtn.Enabled = false;
                    AlaVasTextBoxTB.Enabled = false;
                }
            }
        }

        private void AlaVasTyhjennaBtn_Click(object sender, EventArgs e)
        {
            AlaVasGB.Controls.Clear();
            AlaVasLisaaBtn.Enabled = true;
            AlaVasTextBoxTB.Enabled = true;
            AlaVasTop = 10;
            AlaVasLeft = 10;
            AlaVasCount = 0;
            AlaVasFullStop = 12;
        }



        // ALA-OIKEA PANEELI
     
        private void AlaOikKlikkaaLB_Click(object sender, EventArgs e)
        {
            Piilota();
            Nayta();
            AlaOikKlikkaaLB.Visible = false;
            AlaOikTextBoxTB.Visible = true;
            AlaOikLisaaBtn.Visible = true;
            AlaOikTyhjennaBtn.Visible = true;
        }

        int AlaOikTop = 10;
        int AlaOikLeft = 10;
        int AlaOikCount = 0;
        int AlaOikFullStop = 12;

        private void AlaOikLisaaBtn_Click(object sender, EventArgs e)
        {
            // Tarkistetaan, onko tekstiboksissa mitään
            if (AlaOikTextBoxTB.Text == "")
            {
                MessageBox.Show("Anna ensin sana tai lause");
            }
            else
            {

                AlaOikCount++;
                // For-looppi luo uuden labelin joka kerta kun nappia painetaan
                for (int i = 0; i < AlaOikCount; i++)
                {
                    Label SanaLB = new Label();
                    this.Controls.Add(SanaLB);

                    String UusiSana = AlaOikTextBoxTB.Text;

                    SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    SanaLB.Location = new System.Drawing.Point(AlaOikLeft, AlaOikTop);
                    SanaLB.Name = "SanaLB";
                    SanaLB.Size = new System.Drawing.Size(380, 50);
                    SanaLB.TabIndex = 3;
                    SanaLB.Text = UusiSana;
                    SanaLB.Parent = AlaOikGB;
                    AlaOikTop += 55;
                    AlaOikCount--;
                    AlaOikFullStop--;
                }
                // Tekstikenttä tyhjenee napin painalluksesta
                AlaOikTextBoxTB.Text = "";

                // Kun labelien määrä on tullut täyteen, uusia ei voi enää lisätä
                if (AlaOikFullStop == 6)
                {
                    AlaOikFullStop = 6;
                    AlaOikTop = 10;
                    AlaOikLeft = 420;

                    for (int j = 0; j < AlaOikCount; j++)
                    {
                        Label SanaLB = new Label();
                        this.Controls.Add(SanaLB);

                        String UusiSana = AlaOikTextBoxTB.Text;

                        SanaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        SanaLB.Location = new System.Drawing.Point(AlaOikLeft, AlaOikTop);
                        SanaLB.Name = "SanaLB";
                        SanaLB.Size = new System.Drawing.Size(380, 50);
                        SanaLB.TabIndex = 3;
                        SanaLB.Text = UusiSana;
                        SanaLB.Parent = AlaOikGB;
                        AlaOikTop += 55;
                        AlaOikCount--;
                        AlaOikFullStop--;
                    }
                }

                if(AlaOikFullStop == 0)
                {
                    AlaOikLisaaBtn.Enabled = false;
                    AlaOikTextBoxTB.Enabled = false;
                }
            }
        }

        private void AlaOikTyhjennaBtn_Click(object sender, EventArgs e)
        {
            AlaOikGB.Controls.Clear();
            AlaOikLisaaBtn.Enabled = true;
            AlaOikTextBoxTB.Enabled = true;
            AlaOikTop = 10;
            AlaOikLeft = 10;
            AlaOikCount = 0;
            AlaOikFullStop = 12;
        }

       
    }
}
