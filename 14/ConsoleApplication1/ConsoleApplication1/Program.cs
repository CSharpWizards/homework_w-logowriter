using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("это программа управления летающей тарелки, которая ворует коровок (не конфеты). Собственно перейдем к делу наша расса хочет спереть у глупых землян   парочку сотен коров. Каждая корова весит 1-ну единицу измерения,а летающая тарелка может выдержать только 500 единиц. Введи сколько коров ты хочешь спереть потом введи грузоподъемность корабля");
            int maxmasscow = 0; 
            int massCow = int.Parse(Console.ReadLine());
            int massShip = int.Parse(Console.ReadLine()); 
            while(true){
                if (massCow <= massShip)
                {
                    Console.WriteLine("ужин будет вкусный");

                }
                else
                {
                    Console.WriteLine("эхх в следующий раз возьмем тарелку побольше");
                }
               
            }
            Console.ReadLine();
        }
    }
}
