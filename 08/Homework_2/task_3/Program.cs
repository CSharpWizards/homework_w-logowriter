using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость монитора:");
            double price_monitor = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость системного блока:");
            double price_system = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость клавиатуры:");
            double price_keyboard = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите стоимость мыши:");
            double price_mouse = double.Parse(Console.ReadLine());



            Console.WriteLine(price_monitor+price_system+price_keyboard+price_mouse);
            Console.ReadLine();
        }
    }
}
