using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите возраст Тани:");
            double age_t = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите возраст Мити:");
            double age_m = double.Parse(Console.ReadLine());


            Console.WriteLine((age_m + age_t) / 2);
            Console.ReadLine();
        }
    }
}
