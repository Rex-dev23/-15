using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "12345")
            { this.Hide();
                Form Form7 = new Form7();
                Form7.Show();
            }
            if (textBox1.Text == "student" && textBox2.Text == "password")
            {
                this.Hide();
                Form7 f = new Form7();
                f.ShowDialog();
            }
        }
    }
}
