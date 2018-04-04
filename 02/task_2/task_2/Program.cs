using System;

namespace task_2
{
    class Program
    {
        static void Main()
        {
            string a = "world123";
            string b = "hello";

            string copy_a = a;
            a = b;
            b = copy_a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }

    }
}
