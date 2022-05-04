using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form2 : Form
    {
        int k;
        int km;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int km = Convert.ToInt32(textBox1.Text);
            int k = Convert.ToInt32(textBox2.Text);
            float p = (k* 100 / km);
            textBox3.Text = p.ToString();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.ShowDialog();
        }
    }
}
