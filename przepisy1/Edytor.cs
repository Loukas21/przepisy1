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

        private string sprawdz_dane()
        {
            string a="Wszystkie dane wprowadzono poprawnie";
            if (textBox1.Text == "")
            { 
                a="Pole z nazwą przepisu nie może pozostać puste!";
                return a;
            }
            if (textBox2.Text == "")
            { 
                a="Pole z tagami nie może pozostać puste!";
                return a;
            }
            if (richTextBox1.Text == "")
            { 
                a="Pole ze składnikami nie może pozostać puste!";
                return a;
            }
            if (richTextBox2.Text == "")
            {
                a = "Pole ze sposobem przygotowania nie może pozostać puste!";
                return a;
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu ss = new Menu();
            ss.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = sprawdz_dane();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.CheckFileExists==true)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }
    }
}
