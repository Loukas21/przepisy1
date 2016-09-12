using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace przepisy1
{
    public partial class Edytor : Form
    {
        public Edytor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void przepisy1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.przepisy1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.przepisy1DataSet1);

        }

        private void Edytor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'przepisy1DataSet1.przepisy1' table. You can move, or remove it, as needed.
            this.przepisy1TableAdapter.Fill(this.przepisy1DataSet1.przepisy1);

        }
    }
}
