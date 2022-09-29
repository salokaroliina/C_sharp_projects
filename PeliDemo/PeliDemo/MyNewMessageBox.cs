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
    public partial class MyNewMessageBox : Form
    {
        public MyNewMessageBox()
        {
            InitializeComponent();
        }

        private void OkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
