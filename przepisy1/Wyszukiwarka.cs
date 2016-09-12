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

        }

        private void przepisy1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.przepisy1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.przepisy1DataSet1);

        }

        private void Wyszukiwarka_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przepisy1DataSet1.przepisy1' table. You can move, or remove it, as needed.
            this.przepisy1TableAdapter.Fill(this.przepisy1DataSet1.przepisy1);

        }

        private void searchNameToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.przepisy1TableAdapter.SearchName(this.przepisy1DataSet1.przepisy1, nazwaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

    }
}
