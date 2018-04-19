using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество апельсинов:");
            double kol1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество людей:");
            double kol2 = double.Parse(Console.ReadLine());
            Console.WriteLine(kol1 / kol2);
            Console.ReadLine();
        }
    }
}
