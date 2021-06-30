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
        /// UC6-Finding out the number of times dice rolled
        /// UC7-the winner among two player are found
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
            //Console.WriteLine("Dice number is " + rollDice);
           return rollDice;
        }

        public static void CheckingOptions()
        {
            Random r = new Random();

            int player1 = 0;
            int player2 = 0;
            
            int win = 1;
            int swappingOfPlayers = 1;
            

            while (player1 <= SIZE || player2 <= SIZE)
            {
                
                int check = r.Next(1, 4);


                //Calling a rolldice function

                int dice = Program.RollDice();
                Console.WriteLine("Dice number is " + dice);
                
                switch (check)
                {
                    //No play for Player1 and Player2
                    case 1:
                        
                        if (swappingOfPlayers == 1)
                        {
                            if (player1 != 100)
                            {

                                Console.WriteLine("Player1 has no play and current position is " + player1);
                                swappingOfPlayers = 2;
                            }
                            else
                            {
                                win = 1;
                                Console.WriteLine("Player 1 has won");
                            }
                        }
                        else if (swappingOfPlayers == 2)
                        {
                            if (player2 != 100)
                            {
                                Console.WriteLine("Player2 has no play and current position is " + player2);
                                swappingOfPlayers = 1;
                            }
                            else
                            {
                                win = 2;
                                Console.WriteLine("Player2 has won");
                            }
                        }
                        break;
                    //For checking ladder condition for both players
                    case 2:

                        if (swappingOfPlayers == 1)
                        {

                            if (player1 + dice <= SIZE)
                            {
                                Console.WriteLine("Player1 has got ladder and current position is " + (player1 += dice));
                                if (player1 != 100)
                                {
                                    Console.WriteLine("Player1 plays again");
                                    swappingOfPlayers = 1;

                                    //Program.RollDice();
                                }
                                else if(player1==100)
                                {
                                    
                                    win = 1;
                                    Console.WriteLine("Player 1 has won");
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (swappingOfPlayers == 2)
                            {
                                if (player2 + dice <= SIZE)
                                {
                                    Console.WriteLine("Player2 has got ladder and current position is " + (player2 += dice));
                                    if (player2 != 100)
                                    {
                                        Console.WriteLine("Player2 plays again");
                                        swappingOfPlayers = 2;
                                        
                                    }
                                    else if(player2==100)
                                    {
                                        win = 2;
                                        Console.WriteLine("Player 2 has won");
                                        break;
                                    }
                                }
                            }

                        }
                        break;
                    //For checking snake bite condition for both players
                    case 3:

                        if (swappingOfPlayers == 1)
                        {
                            if ((player1 - dice) < 0)
                            {
                                player1 = 0;
                                Console.WriteLine("Player1 has got snake and current position is " + player1);
                                swappingOfPlayers = 2;
                            }

                            else
                            {
                                Console.WriteLine("Player1 has got snake and current position is " + (player1 -= dice));

                                swappingOfPlayers = 2;
                            }
                        }
                        else if (swappingOfPlayers == 2)
                        {
                            if ((player2 - dice) < 0)
                            {
                                player2 = 0;
                                Console.WriteLine("Player2 has got snake and current position is " + player2);
                                swappingOfPlayers = 1;
                            }
                            else
                            {
                                Console.WriteLine("Player2  has got snake and current position is " + (player2 -= dice));
                                swappingOfPlayers = 1;
                            }
                        }
                        break;
                }
                if(player1==100 || player2==100)
                {
                    break;
                }
            }
        }
    }
}
        
    