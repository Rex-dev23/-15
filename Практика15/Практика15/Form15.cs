using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                int summa = a * 1500;
                textBox2.Text = summa.ToString();

            }
            if (radioButton2.Checked)
            {
                int summa = a * 800;
                textBox2.Text = summa.ToString();
            }
            if (radioButton3.Checked)
            {
                int summa = a * 3000;
                textBox2.Text = summa.ToString();
            }
        }
    }
}
