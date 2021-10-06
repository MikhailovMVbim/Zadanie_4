using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KvadratVPryamoug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину стороны прямоугольника А:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны прямоугольника B:");
            int B = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину стороны квадрата С:");
            int C = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            int totalA = 0;
            int incC = C;
            // кол-во по А
            while (incC<=A)
            {
                totalA += 1;
                incC += C;
            }
            // по стороне В
            incC = C;
            while (incC <= B)
            {
                total += totalA;
                incC += C;
            }
            Console.WriteLine("В прямоугольнике со сторонами А={0} и В={1} количество квадратов со стороной С={2} равно {3}",A,B,C,total);
            Console.ReadKey();
        }
    }
}
