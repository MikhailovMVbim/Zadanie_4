using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            if (number>0)
            {
                for (int i = 1; i <= number; i++)
                {
                    sum += 2 * i - 1;
                    Console.WriteLine("Квадрат числа {0} равен {1}",i,sum);
                }
            }
            else Console.WriteLine("Введены неверные данные!");
            Console.ReadKey();
        }
    }
}
