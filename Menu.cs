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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();

            if (Null.Funglish == 1)
            {
                label1.Text = "Trivia\n" + "\"Who wants to be a winner\"";
                Start.Text = "Start";
                Exit.Text = "Exit";

                this.Text = "Menu";
            }
            else
            {
                label1.Text = "Викторина\n" + "\"Кто хочет стать победителем\"";
                Start.Text = "Начать игру";
                Exit.Text = "Выход";

                this.Text = "Меню";
            }
        }   

        private void Start_Click_1(object sender, EventArgs e)
        {
            Form f1 = new Question1();
            f1.Show();
            this.Hide();
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f = new Setting();
            f.Show();
            this.Hide();
        }
    }
}
