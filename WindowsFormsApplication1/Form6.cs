using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        public int sc;
        public System.Media.SoundPlayer s = new System.Media.SoundPlayer(@"startscreen_cut.wav");
        private void Form6_Load(object sender, EventArgs e)
        {
            s.PlayLooping();
            label1.Text = "Your Score is " + Form3.score;
            label2.Text = "Number Of Correct Answers "+Form3.Noofcorrect;
            label3.Text = "Winning Percentage is " + Form3.score + "%";
            FileStream f1 = new FileStream(@"highscore.txt", FileMode.Open);
            StreamReader s1 = new StreamReader(f1);
            sc = Convert.ToInt32(s1.ReadLine());
            s1.Close();
            f1.Close();
            FileStream f2 = new FileStream(@"highscore.txt", FileMode.Create);
            StreamWriter s2 = new StreamWriter(f2);


            if (Form3.score > sc)
            {
                sc = Form3.score;
                s2.Write(sc);
            }
            s2.Close();
            f2.Close();      
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            MessageBox.Show("Highest Score Is : " + sc.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Stop();
            Form3.score = 0;
            Form3.Noofcorrect = 0;
            Form2 f2 = new Form2();
            this.Hide();
            f2.Show();
        }
       
    }
}
