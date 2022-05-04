using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form13 : Form
       
    {
        int summa = 0;
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            int b = Convert.ToInt32(textBox2.Text);
            if (comboBox1.SelectedIndex == 0)
            { summa = 8000 + 1000; }
            else if (comboBox1.SelectedIndex == 1)
                { summa = 8000 + 1500; }
            else label6.Visible = true;
            if (checkBox1.Checked)
            { summa = summa + 300;  }
            if (checkBox2.Checked)
            { summa = summa + 2000; }
            if (checkBox3.Checked)
            { summa = summa + 2000; }


        }
    }
}
