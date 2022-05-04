using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 f = new Form8();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f = new Form9();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form10 f = new Form10();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 f = new Form11();
            f.ShowDialog();
        }
    }
}
