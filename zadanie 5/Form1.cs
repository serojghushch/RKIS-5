using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       private void Obrabotka()
        {
            try
            {
                double x = double.Parse(textBox1.Text);
                string select = l1.SelectedItem as string;
                
                if (select == null)
                {
                    textBox2.Text = "Выберите функцию";
                    return;
                }
                double result = 0;
                switch (select)
                {
                    case "Тангенс":
                        result = Math.Tan(x);
                        break;
                    case "Синус":
                        result = Math.Sin(x);
                        break;
                    case "Логарифм":
                        result = Math.Log(x);
                        break;
                }
                textBox2.Text = result.ToString();
            }
            catch (FormatException)
            {
                textBox2.Text = "Ошибка: Введите число";
            }
            catch (Exception ex)
            {
                textBox2.Text = "Ошибка: " + ex.Message;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Obrabotka();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Obrabotka();
        }
    }
}
