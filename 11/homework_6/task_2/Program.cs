using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количестово очков которые набрала футбольная команда");
            int ochki1 = int.Parse(Console.ReadLine());

            if (ochki1 == 1 )
            {
                Console.WriteLine("ничья");
            }
            else if (ochki1 == 0)
            {
                Console.WriteLine("поражение");
            }
            else if (ochki1 == 3)
            {
                Console.WriteLine("выигрыш ");
            }

            Console.ReadLine();

        }
    }
}
