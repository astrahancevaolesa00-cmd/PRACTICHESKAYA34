using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadania
{
    public partial class Form10 : Form
    {
        double a;
        string op = "";
        bool done = false;
        public Form10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (done) { textBox1.Clear(); done = false; }
            textBox1.Text += ((Button)sender).Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text.Replace('.', ','), out a))
            {
                MessageBox.Show("Сначала введите число!");
                return;
            }
            op = ((Button)sender).Text;
            done = false;
            textBox1.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (op == "") return;

            if (!double.TryParse(textBox1.Text.Replace('.', ','), out double b))
            {
                MessageBox.Show("Ошибка ввода!");
                return;
            }

            double result = 0;
            switch (op)
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                        textBox1.Clear();
                        op = "";
                        return;
                    }
                    result = a / b;
                    break;
            }
            textBox1.Text = result.ToString();
            op = "";
            done = true;
        }
    }
}
