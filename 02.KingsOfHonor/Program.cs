using System;
using System.Linq;

namespace _02.KingsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> name = (name) => Console.WriteLine($"Sir {name}");

            Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(name);
        }
    }
}
