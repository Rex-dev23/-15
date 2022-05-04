using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form18 : Form
    {
        int rub;
        int usd;
        int eur;
        int gbr;
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rub = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            usd = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            eur = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            gbr = 1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (usd == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 71);
            if (eur == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 76);
            if (gbr == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 84);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (rub == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 71);
            if (eur == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 1.05);
            if (gbr == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * 0.86);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (rub == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 0.014);
            if (eur == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 0.95);
            if (gbr == 1)
                textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) / 0.86);
        }
    }
    }

