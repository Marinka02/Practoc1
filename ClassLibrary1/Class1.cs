using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int Sum(int K, ref TextBox Rnd, ref TextBox Kol)
        {
            Random rnd = new Random();
            int n;
            int sum = 0,
                 kol = 0;
                while (sum < K)
                {
                    //Генерация числа из диапазона
                    n= rnd.Next(-3, 7);
                    //Вывод сгенерированного числа в строку
                    Rnd.Text = Rnd.Text + " " + n.ToString();
                    sum = sum+n;
                    //Счетчик чисел
                    kol = kol + 1;
                }
                Kol.Text = kol.ToString();
            return sum;
        }
    }
}
