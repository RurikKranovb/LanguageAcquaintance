using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            var item = int.Parse(Console.ReadLine() ?? string.Empty);

            for (int i = 1; i <= item; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
