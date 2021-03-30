using System;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите пожалуйста имя");
            var name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}, сегодня  {DateTime.Now} ");
            Console.ReadKey();
        }
    }
}
