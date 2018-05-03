using System;

namespace homework_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter distance in meters");
            int dist1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter distance in feet");
            int dist2 = int.Parse(Console.ReadLine());
            double dist2_m = dist2 / 0.305;
            if (dist1 > dist2_m) {
                Console.WriteLine("dist2 is more");
            }
            else {
                Console.WriteLine("dist1 is more");
            }
            Console.ReadLine();
        }
    }
}
