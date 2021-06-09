using System;
using System.Linq;

namespace _08.CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int,bool> even = n => n % 2 == 0;
            Func<int,bool> odd = n => n % 2 != 0;

           int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderBy(n => n)
                .ToArray();

            Console.Write($"{string.Join(" ",numbers.Where(number=>even(number)))}");
            Console.Write(" ");
            Console.Write($"{string.Join(" ",numbers.Where(number=>odd(number)))}");
        }
    }
}
