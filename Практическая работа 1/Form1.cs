using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;



namespace Практическая_работа_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k, sum;
            //Получение данных с формы
          if( Int32.TryParse(K.Text,  out k))
            {
                sum = Class1.Sum( k, ref Rnd, ref Kol);
                textbox1.Text = sum.ToString();
            }

            else MessageBox.Show("Введите число", "Ошибка");
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнила Ефимкина Марина. Группа ИСП-31." +
                "Вариант № 5: Вычислить сумму целых случайных чисел, распределенных в диапазоне от - 3 до 7, пока эта сумма не превышает некоторого числа K. " +
                "Вывести на экран сгенерированные числа, значение суммы, и количество сгенерированных чисел.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            K.Clear();
            Rnd.Clear();
            Kol.Clear();
            textbox1.Clear();
        }
    }
}
