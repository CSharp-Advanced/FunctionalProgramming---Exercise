using System;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Predicate<string> func = name => name.Length <= n;


            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Where(name=>func(name))
                .ToList()
                .ForEach(name => Console.WriteLine(name));
        }
    }
}
