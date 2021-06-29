using System;

namespace SnakeAndLadder1
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Problem!");

            //Program.RollDice();
            Program.CheckingOptions();
        }
        public static int RollDice()
        {
            Random random = new Random();
           int rollDice = random.Next(1, 7);
            //Console.WriteLine("Dice number : "+rollDice);
            return rollDice;
        }
       
        public static void CheckingOptions()
        {
            Random r = new Random();
            int check = r.Next(1, 4);
            int playerPosition = 0;
            int dice = Program.RollDice();
            Console.WriteLine("Dice number is " + dice);
            switch(check)
            {
                case 1:
                    Console.WriteLine("No Play");
                    break;
                case 2:
                     Console.WriteLine("Ladder Played");
                     playerPosition +=dice;
                     Console.WriteLine("Player Current Position " + playerPosition);
                     break;
                case 3:
                    Console.WriteLine("Snake Played");
                    playerPosition -= dice;
                    Console.WriteLine("Player Current Position " + playerPosition);
                    break;
            }
        }
    }
}
