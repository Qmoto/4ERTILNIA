using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_6Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 9;
            int result = 0;
            for (int i = 1; i <= b; i++)
            {
                result+=2;
            }
            IEnumerable<int> seq;
            seq = System.Linq.Enumerable.Range(a, result);
            foreach (var x in seq)
                if (x%2!=0)
                {
                    Console.WriteLine($"{x} ");
                }

        }
    }
}
