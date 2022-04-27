using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральные числа a и N");
            int a = int.Parse(Console.ReadLine());
            int N = int.Parse(Console.ReadLine());
            int result = a;
            for (int i = 1; i<=N; i++)
            {
                result++;
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(a, N);
            foreach (var x in seq)
                Console.WriteLine($"{x} ");
        }
    }
}
