using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите действительное число");
            double easy_task = double.Parse(Console.ReadLine());
            if (easy_task < 0)
            {
                Console.WriteLine(easy_task * -1);
            }
            else
            {
                Console.WriteLine(easy_task);
            }
            Console.ReadLine();




        }
    }
}
