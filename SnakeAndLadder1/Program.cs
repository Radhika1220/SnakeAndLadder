using System;

namespace SnakeAndLadder1
{
    class Program
    {
        /// <summary>
        ///UC1-Initializing a player position
        ///UC2-Creating a random function for rolling the dice
        ///UC3-Checking Options
        /// UC4-Repeat till position reached 100
        /// UC5-Stop at 100 position
        /// </summary>

        //Declaring Constant variables
        public const int SIZE = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Snake And Ladder Problem!");


            //Calling a checkingoptions function 
            Program.CheckingOptions();
        }
        public static int RollDice()
        {
            //Creating a random function
            Random random = new Random();
            int rollDice = random.Next(1, 7);

            return rollDice;
        }

        public static void CheckingOptions()
        {
            Random r = new Random();

            int playerPosition = 0;

            while (playerPosition <= SIZE)
            {
                int check = r.Next(1, 4);


                //Calling a rolldice function

                int dice = Program.RollDice();
                Console.WriteLine("Dice number is " + dice);

                switch (check)
                {
                    case 1:
                        Console.WriteLine("No Play");
                        break;
                    case 2:

                        Console.WriteLine("Ladder Played");
                        if (playerPosition + dice <= 100)
                        {
                            playerPosition += dice;
                        }

                        Console.WriteLine("Player Current Position " + playerPosition);
                        break;
                    case 3:

                        Console.WriteLine("Snake Played");
                        playerPosition -= dice;
                        if (playerPosition < 0)
                        {
                            playerPosition = 0;
                        }
                        Console.WriteLine("Player Current Position " + playerPosition);
                        break;
                }

                if (playerPosition == 100)
                {
                    break;
                }
            }
        }
    }
}