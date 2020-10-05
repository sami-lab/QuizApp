using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public static bool expert = false;
        public static string name;
        public System.Media.SoundPlayer Screenlauch = new System.Media.SoundPlayer(@"startscreen_cut.wav");        
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (String.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(textBox1, "Field Cannot be Left Empty");
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                Screenlauch.Stop();
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Screenlauch.PlayLooping();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.Show();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            if (String.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(textBox1, "Field Cannot be Left Empty");
                textBox1.ForeColor = Color.Red;
            }
            else
            {
                expert = true;
                Screenlauch.Stop();
                Form3 f3 = new Form3();
                this.Hide();
                f3.Show();
            }
        }
    }
}
