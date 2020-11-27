using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace foursPicsOneWords
{
    public partial class Form1 : Form
    {
        public static int score = 0;
        private String answer = "BALL";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ch1.Text = "A";
            ch2.Text = "X";
            ch3.Text = "C";
            ch4.Text = "G";
            ch5.Text = "Q";
            ch6.Text = "D";
            ch7.Text = "B";
            ch8.Text = "L";
            ch9.Text = "F";
            ch10.Text = "E";
            ch11.Text = "I ";
            ch12.Text = "L";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int x = Int32.Parse(timer.Text);
            if (x == 0)
            {
                timer1.Stop();
                MessageBox.Show("Times up Game Over Your Score is " + score);
                this.Close();
            }
            x -= 1;
            timer.Text = x+"";
            

        }

        private void ch1_Click(object sender, EventArgs e)
        {
            setLabelValue(ch1);
            Console.WriteLine(ch1.Text);
        }

        public void setLabelValue(Label c)
        {
            if (a1.Text.Equals("  "))
            {
                a1.Text = c.Text;
            }
            else if (a2.Text.Equals("  "))
            {
                a2.Text = c.Text;
            }
            else if (a3.Text.Equals("  "))
            {
                a3.Text = c.Text;
            }
            else if (a4.Text.Equals("  "))
            {
                a4.Text = c.Text;
            }
        }
        private void ch2_Click(object sender, EventArgs e)
        {
            setLabelValue(ch2);

        }

        private void ch3_Click(object sender, EventArgs e)
        {
            setLabelValue(ch3);
        }

        private void ch4_Click(object sender, EventArgs e)
        {
            setLabelValue(ch4);
        }

        private void ch5_Click(object sender, EventArgs e)
        {
            setLabelValue(ch5);
        }

        private void ch6_Click(object sender, EventArgs e)
        {
            setLabelValue(ch6);
        }

        private void ch12_Click(object sender, EventArgs e)
        {
            setLabelValue(ch12);
        }

        private void ch11_Click(object sender, EventArgs e)
        {
            setLabelValue(ch11);
        }

        private void ch10_Click(object sender, EventArgs e)
        {
            setLabelValue(ch10);
        }

        private void ch9_Click(object sender, EventArgs e)
        {
            setLabelValue(ch9);
        }

        private void ch8_Click(object sender, EventArgs e)
        {
            setLabelValue(ch8);
        }

        private void ch7_Click(object sender, EventArgs e)
        {
            setLabelValue(ch7);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (!a4.Text.Equals("  "))
            {
                a4.Text = "  ";
            }
            else if (!a3.Text.Equals("  "))
            {
                a3.Text = "  ";
            }
            else if (!a2.Text.Equals("  "))
            {
                a2.Text = "  ";
            }
            else if (!a1.Text.Equals("  "))
            {
                a1.Text = "  ";
            }
        }

        private void accept_Click(object sender, EventArgs e)
        {
            String s = a1.Text.ToString().Substring(0, 1) + a2.Text.ToString().Substring(0, 1) + a3.Text.ToString().Substring(0, 1) + a4.Text.ToString().Substring(0, 1);
            if (s.Equals(answer))
            {
                score++;
                MessageBox.Show("Congrats Your score is now " + score);
                reset();
                
                  
              

            }
            else
            {
                MessageBox.Show("Wrong Answer Hurry Up You dont have time :-)");
            }
        }
        public void reset()
        {
            ch1.Text = "A";
            ch2.Text = "O";
            ch3.Text = "C";
            ch4.Text = "G";
            ch5.Text = "Q";
            ch6.Text = "D";
            ch7.Text = "B";
            ch8.Text = "L";
            ch9.Text = "F";
            ch10.Text = "E";
            ch11.Text = "I ";
            ch12.Text = "L";
            a1.Text = "  ";
            a2.Text = "  ";
            a3.Text = "  ";
            a4.Text = "  ";

            level.Text = (1 + score) + "";
            if (score == 1)
            {
                this.pictureBox1.Image = global::foursPicsOneWords.Properties.Resources.Level21;
                this.answer = "DEAL";
            }

            else if (score == 2)
            {
                ch4.Text = "P";
                ch12.Text = "N";
                this.answer = "PAIN";
                this.pictureBox1.Image = global::foursPicsOneWords.Properties.Resources.Level31;
            }

            else if (score == 3)
            {
                ch4.Text = "W";
                ch12.Text = "S";
                ch8.Text = "H";
                this.answer = "WISH";
                this.pictureBox1.Image = global::foursPicsOneWords.Properties.Resources.Level41;
            }

            else if (score == 4)
            {
                ch4.Text = "S";
                ch12.Text = "K";
                this.answer = "SOCK";
                this.pictureBox1.Image = global::foursPicsOneWords.Properties.Resources.Level51;

            }
            else
            {
                MessageBox.Show("Congrats You have Finish All Levels\n Score = " + 5);
                this.Close();
            }
            this.timer.Text = "120";
            this.timer1.Start();

               
        }
    }
}
