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

        private void przepisyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.przepisyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.przepisyDataSet1);

        }

        private void Wyszukiwarka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przepisyDataSet1.przepisy' table. You can move, or remove it, as needed.
            this.przepisyTableAdapter.Fill(this.przepisyDataSet1.przepisy);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
