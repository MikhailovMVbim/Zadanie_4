using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolozhOtritz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int pol = 0;
            int otr = 0;
            do
            {
                Console.WriteLine("Введите положительное или отрицательное целое число:");
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0) pol += 1;
                else if (num<0) otr += 1;
            } while (num!=0);
            Console.WriteLine("Количество положительных чисел: {0}",pol);
            Console.WriteLine("Количество отрицательных чисел: {0}", otr);
            Console.ReadKey();
        }
    }
}
