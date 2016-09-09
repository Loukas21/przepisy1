using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace przepisy1
{
    public partial class Wyszukiwarka : Form
    {
        public Wyszukiwarka()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }
    }
}
