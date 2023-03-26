using System;

namespace LanguageAcquaintance
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 0;
            var b = 0;

            
            Console.WriteLine("Введите первое число:");
            a = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Введите второе число:");
            b = int.Parse(Console.ReadLine() ?? string.Empty);

            if (a > b)
            {
                Console.WriteLine("max:");
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine("max:");
                Console.WriteLine(b);
            }
        }
    }
}
