using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter price of computer in last year");
            int comp1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter price of computer in this year");
            int comp2 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter price of computer in last year");
            int console1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter price of computer in this year");
            int console2 = int.Parse(Console.ReadLine());
            Console.WriteLine(comp2 / comp1);
            Console.WriteLine(console2 / console1);
            if ((comp2 / comp1) > (console2 / console1))
            {
                Console.WriteLine("computer");
            }
            else
            {
                Console.WriteLine("console");
            }

            Console.ReadLine();
        }
    }
}
