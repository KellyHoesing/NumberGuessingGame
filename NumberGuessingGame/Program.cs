using System;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            int favNumber = r.Next(1, 10);
            bool win = false;
            do
            {
                Console.WriteLine($"What is your Favorite Number?");
                var a =int.Parse(Console.ReadLine());
                if (a > favNumber)
                {
                    Console.WriteLine($"Too high!  Guess again!");
                }
                else if (a < favNumber)
                {
                    Console.WriteLine($"Too Low!  Guess again!");
                }
                else
                {
                    Console.WriteLine($"Good job!");
                    win = true;
                }
            } 
            while (win == false);
        }
    }
}
