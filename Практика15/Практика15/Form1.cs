using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form1 : Form
    {
        int price;
        int k;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            price = 12;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            price = 24;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            price = 60;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = Convert.ToInt32(textBox3.Text);
            int summa = k * price;
            textBox1.Text = summa.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }
    }
}
