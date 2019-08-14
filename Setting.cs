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
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();

            if (Null.Funglish == 1)
            {
                button2.Enabled = false;
                button1.Enabled = true;
                label1.Text = "Language:";
                button1.Text = "Russian";
                button2.Text = "English";
                button3.Text = "Back";
                this.Text = "Setting";
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = true;
                label1.Text = "Выберите язык:";
                button1.Text = "Русский";
                button2.Text = "Английский";
                button3.Text = "Назад";
                this.Text = "Настройки";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Null.Funglish = 0;
            button1.Enabled = false;
            button2.Enabled = true;
            label1.Text = "Выберите язык:";
            button1.Text = "Русский";
            button2.Text = "Английский";
            button3.Text = "Назад";
            this.Text = "Настройки";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Null.Funglish = 1;
            button2.Enabled = false;
            button1.Enabled = true;
            label1.Text = "Language:";
            button1.Text = "Russian";
            button2.Text = "English";
            button3.Text = "Back";
            this.Text = "Setting";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form f = new Menu();
            f.Show();
            this.Hide();
        }
    }
}
