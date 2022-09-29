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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        // Ensimmäinen sivu

        // Start game -nappia painamalla ensimmäinen sivu menee piiloon
        // tuodaan esiin language-form
        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Language selectlanguage = new Language();
            selectlanguage.ShowDialog();
        }

        private void CreditsBtn_Click(object sender, EventArgs e)
        {
            
        }
    }
}
