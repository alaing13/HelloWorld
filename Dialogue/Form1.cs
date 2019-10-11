using System;
using System.Windows.Forms;

namespace Dialogue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Bonjour {textBox2.Text}");
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Form f2 = new Form2())
            {
                f2.ShowDialog();
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = $"Bonjour {textBox2.Text}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                ActiveForm.BackColor = colorDialog1.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Form f3 = new Form3())
            {
                if (f3.ShowDialog() == DialogResult.OK)
                {
                    label4.Text = f3.Controls["textBox1"].Text + "-" + f3.Controls["textBox2"].Text + "-" + f3.Controls["textBox3"].Text + "-" + f3.Controls["textBox4"].Text + "-" + f3.Controls["textBox5"].Text;
                }
            }
        }
    }
}