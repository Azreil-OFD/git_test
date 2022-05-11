using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_test
{
    public partial class Form1 : Form
    {
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ВОт и всё!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Нажата кнопка";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Text += comboBox1.Text;
            count++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Remove(label1.Text.Length - count, count );

            count = 0;
        }
    }
}
