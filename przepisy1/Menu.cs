using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace przepisy1
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Wyszukiwarka ss = new Wyszukiwarka();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Edytor ss = new Edytor();
            ss.Show();
        }
    }
}
