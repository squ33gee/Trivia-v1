using System;
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
    public partial class Surrender : Form
    {
        public Surrender()
        {
            InitializeComponent();

            if (Null.Funglish == 1)
            {
                label3.Text = "The number of correct answers:";
                label1.Text = "You scored points:";
                label2.Text = "You gave up :(";

                button1.Text = "Menu";
                button2.Text = "Exit";

                this.Text = "Surrender";
            }

            label1.Text += Convert.ToString(Null.Score);
            label3.Text += Convert.ToString(Null.ScoreTrue);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Null.Score = 0;
            Null.ScoreTrue = 0;
            Null.Q = 1;
            Null.NumText = "x3";
            Null.Num = 3;
            Null.Answer = 1;
            Null.Picture = 3;

            Form f = new Menu();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
