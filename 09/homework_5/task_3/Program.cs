using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter your age");
            int age = int.Parse(Console.ReadLine());
            if (age >= 10) {
                if (age < 20) {
                    Console.WriteLine("you are teenage");
                }
            }
        }
    }
}
