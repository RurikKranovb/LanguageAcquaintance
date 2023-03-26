using System;
using System.Linq;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {

            var numbers = new int[3];


            Console.WriteLine("Введите первое число:");
            numbers[0] = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Введите второе число:");
            numbers[1] = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Введите третье число:");
            numbers[2] = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine(numbers.Max()); }
    }
}
