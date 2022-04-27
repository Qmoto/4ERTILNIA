using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1Task3
{
    class L1Task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите 4 числа: ");
            int a, b, c, d, sum1, sum2;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            sum1 = a + b;
            sum2 = c + d;
            Console.WriteLine(sum1>sum2);
            Console.ReadKey();
        }
    }
}
