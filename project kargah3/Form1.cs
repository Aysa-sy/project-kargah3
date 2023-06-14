using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_kargah3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1_TextChanged(null, null);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double age;
            age = Convert.ToDouble(textBox2.Text);
            if (age >= 1 && age < 10)
            {
                label3.Text = textBox1.Text + " " + "کودک";
            }
            else if (age >= 10 && age < 18)
            {
                label3.Text = textBox1.Text + " " + "نوجوان";
            }
            else if (age >= 18 && age < 30)
            {
                label3.Text = textBox1.Text + " " + "جوان";
            }
            else if (age >= 30 && age < 60)
            {
                label3.Text = textBox1.Text + " " + "میانسال";
            }
            else
            {
                label3.Text = textBox1.Text + " " + "کهنسال";
            }
        }
    }
}
