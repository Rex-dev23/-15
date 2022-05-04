using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form14 : Form
    {
        int summa = 0;
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            { int summa = a + 500;
                textBox2.Text = summa.ToString();
               }
            if (radioButton2.Checked)
            { int simma = a + 200;
                textBox2.Text = summa.ToString();          
            }
        }
    }
}
