using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Практика15
{
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            {
                if (checkBox1.Checked)
                {
                    label2.Text = "1.500.000";
                    { pictureBox1.Image = Image.FromFile(@"D:\TITAN15document\bmw.jpg"); }
                }
                if (checkBox2.Checked)
                {
                    label2.Text = "17.500.000";
                    { pictureBox1.Image = Image.FromFile(@"D:\TITAN15document\x6m.jpg"); }
                }

                if (checkBox3.Checked)
                {
                    label2.Text = "20.500.000";
                    { pictureBox1.Image = Image.FromFile(@"D:\TITAN15document\16212361609957_ua3z5uzmcfe.jpg"); }
                }
            }
        }
    }
}
