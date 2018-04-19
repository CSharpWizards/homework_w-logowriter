using System;

namespace task_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите сколько дней прошло от начала года:");
            int v1 = int.Parse(Console.ReadLine());
            Console.WriteLine(v1 / 7);
            Console.ReadLine();
        }
    }
}
