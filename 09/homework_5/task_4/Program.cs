using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ener name of first player ");
            string player1 = Console.ReadLine();
            Console.WriteLine("ener raiting of first player ");
            int ratingOfPlayer1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ener name of second player ");
            string player2 = Console.ReadLine();
            Console.WriteLine("ener reiting of second player ");
            int ratingOfPlayer2 = int.Parse(Console.ReadLine());
            if (ratingOfPlayer1>ratingOfPlayer2)
            {
                Console.WriteLine(player1 + " " + player2);
            }    
            else {
                Console.WriteLine(player2 + " " + player1);  
            }
            Console.ReadLine();
        }
    }
}
