using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace zadania
{
    public partial class Form2 : Form
    {
        Random rnd = new Random();
        int secret;
        int attempts;
        public Form2()
        {
            InitializeComponent();
        }
        void NewGame()
        {
            secret = rnd.Next(1, 10);
            attempts = 0;
            label4.Text = "0";
            label2.Text = "";
            label5.Text = "";
            textBox1.Clear();
            button1.Enabled = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            NewGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int n))
            {
                MessageBox.Show("Введите целое число!");
                return;
            }
            attempts++;
            label4.Text = attempts.ToString();

            if (n == secret)
            {
                label5.Text = "ВЫ УГАДАЛИ!";
                label2.Text = "";
                button1.Enabled = false;
            }
            else if (n > secret)
                label2.Text = "число меньше!";
            else
                label2.Text = "число больше!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewGame();
        }
    }
}
