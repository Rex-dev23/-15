using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form5 : Form
    {
        int c;
        int b;
        public Form5()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text);
            if (c > 50)
            {
                int b = c - 50;
                textBox1.Text = b.ToString();
                label1.Text = "$" + b.ToString();


            }
            else { label1.Text = "Минимальный взнос составляет 50$";
                textBox1.Text = "50"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int c = Convert.ToInt32(textBox1.Text);
            if (c >= 50) 

            {
                int b = c + 50;
                textBox1.Text = b.ToString();
                label1.Text = "$" + b.ToString();


            }
            else textBox1.Text = c.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 f = new Form6();
            f.ShowDialog();
        }
    }
}
