using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Task2
{
    class L1Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите два числа: ");
            int number_1 = int.Parse(Console.ReadLine());
            int number_2 = int.Parse(Console.ReadLine());
            double result = (number_1 + number_2) / 2.0;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
