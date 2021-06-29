using System;

namespace SnakeAndLadder1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Problem!");
            Program.RollDice();
        }
        public static void RollDice()
        {
            Random random = new Random();
            int rollDice = random.Next(1, 7);
            Console.WriteLine("Dice number : " + rollDice);


        }
    }
}
