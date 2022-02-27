using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            string? name = Console.ReadLine();
            Console.WriteLine($"Привет {name}, сегодня {DateTime.Today.ToString("d")}");
        }
    }
}
