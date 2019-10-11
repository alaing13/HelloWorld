using System;
using System.Windows.Forms;

namespace Dialogue
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 2) textBox2.Focus();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 2) textBox3.Focus();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 2) textBox4.Focus();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length == 2) textBox5.Focus();
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text.Length == 2) button1.Focus();
        }
    }
}
