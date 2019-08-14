﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivia
{
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();

            // Английский язык

            if(Null.Funglish == 1)
            {
                label3.Text = "Score:";
                label1.Text = "Question №1";
                label2.Text = "What types of hub are there?";

                button1.Text = "Smart";
                button2.Text = "Passive and smart";
                button3.Text = "Active";
                button4.Text = "Smart, active and passive";

                Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
                Answer.Text = "Answer";
                Exit.Text = "Surrender";

                this.Text = "Question №1";
            }

            // Счет

            label3.Text += Convert.ToString(Null.Score);
            label4.Text += Convert.ToString(Null.NumText);
            label5.Text = Convert.ToString(Null.Q + "/15");

            // Подсказки

            if (Null.Answer == 1)
            {
                Answer.Enabled = true;
            }
            else
            {
                Answer.Enabled = false;
            }

            if(Null.Num == 0)
            {
                fifty.Enabled = false;
            }
            else
            {
                fifty.Enabled = true;
            }

            // Право на ошибку

            if(Null.Picture == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;

                Null.Picture = 3;
            }
            else if(Null.Picture == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;

                Null.Picture = 2;
            }
            else if (Null.Picture == 1)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                Null.Picture = 1;
            }
            else if (Null.Picture == 0)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                Null.Picture = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Null.Picture == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;

                button1.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                button1.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                button1.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 0)
            {
                Form f = new Fail();
                f.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Null.Picture == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;

                button2.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                button2.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                button2.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 0)
            {
                Form f = new Fail();
                f.Show();
                this.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Null.Picture == 3)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;

                button3.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 2)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                button3.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                button3.BackColor = Color.Red;

                Null.Picture -= 1;
            }
            else if (Null.Picture == 0)
            {
                Form f = new Fail();
                f.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Null.Answer == 0)
            {
                if (Null.Answer_Num == 1)
                {
                    Null.Score += 0;
                }
                else
                {
                    if (Null.Fifty == 1)
                    {
                        Null.Score += 5;
                    }
                    else
                    {
                        Null.Score += 10;
                    }
                }
            }
            else
            {
                if (fifty.Enabled == false)
                {
                    Null.Score += 5;
                }
                else
                {
                    Null.Score += 10;
                }
            }
            
            Null.Q += 1;
            Null.ScoreTrue += 1;
            Form f = new Question2();
            f.Show();
            this.Hide();
        }

        private void Answer_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Green;
            Answer.Enabled = false;
            Null.Answer = 0;
            Null.Answer_Num = 1;
        }

        private void fifty_Click_1(object sender, EventArgs e)
        {
            button1.Hide();
            button3.Hide();

            if (Null.Num == 3)
            {
                Null.NumText = "x2";
                Null.Num -= 1;
                label4.Text = Null.NumText;
            }
            else if (Null.Num == 2)
            {
                Null.NumText = "x1";
                Null.Num -= 1;
                label4.Text = Null.NumText;
            }
            else if (Null.Num == 1)
            {
                Null.NumText = "x0";
                Null.Num -= 1;
                label4.Text = Null.NumText;
            }

            fifty.Enabled = false;
            Null.Fifty = 1;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Form f = new Surrender();
            f.Show();
            this.Hide();
        }
    }
}
