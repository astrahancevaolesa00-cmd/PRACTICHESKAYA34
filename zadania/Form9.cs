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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (!double.TryParse(textBox1.Text.Replace('.', ','), out double a) ||
                !double.TryParse(textBox3.Text.Replace('.', ','), out double b))
            {
                MessageBox.Show("Ошибка ввода: введите числа!");
                return;
            }

            double result;
            switch (textBox2.Text.Trim())
            {
                case "+": result = a + b; break;
                case "-": result = a - b; break;
                case "*": result = a * b; break;
                case "/":
                    if (b == 0)
                    {
                        MessageBox.Show("На ноль делить нельзя!");
                        return;
                    }
                    result = a / b;
                    break;
                default:
                    MessageBox.Show("Неизвестная операция. Допустимо: + - * /");
                    return;
            }
            textBox4.Text = result.ToString();
        }
    }
}
