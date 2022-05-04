using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form3 : Form
    { 
        public Form3()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int k = Convert.ToInt32(textBox1.Text);
            if (comboBox1.SelectedIndex == 0) ;
            {
                int summa = k * 300;
                textBox2.Text = Convert.ToString(summa);

            }
            if (comboBox1.SelectedIndex == 1) ;
            {
                int summa = k * 500;

                textBox2.Text = Convert.ToString(summa);


            }
            if (comboBox1.SelectedIndex == 2) ;
            {
                int summa = k * 700;
                textBox2.Text = Convert.ToString(summa);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.ShowDialog();
        }
    }
}
