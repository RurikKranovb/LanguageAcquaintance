using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var item = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine((item % 2) == 1 ? "нечетное:" : "четное:");
        }
    }
}
