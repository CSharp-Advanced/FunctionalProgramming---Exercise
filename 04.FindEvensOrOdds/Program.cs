using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FindEvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int startIdx = numbers[0];
            int endIdx = numbers[1];
            string type = Console.ReadLine();

            Predicate<int> predicate = type == "odd"
            ? number => number % 2 != 0
            : new Predicate<int>((number)=>number%2==0);

            List<int> result = new List<int>();

            for (int number = startIdx; number <= endIdx; number++)
            {
                if (predicate(number))
                {
                    result.Add(number);
                }
            }
            Console.WriteLine(string.Join(' ',result));
        }
    }
}
