namespace RPS
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockText("ROCK, PAPER, AND SCISSORS GAME!!!");
            Random random = new Random();
            bool play = true;
            string? player;
            string computer;
            int round;
            string? response;
            int computerWins;
            int playerWins;


            while (play)
            {
                round = 0;
                computerWins = 0;
                playerWins = 0;
                response = "";

                while (round < 3)
                {
                    BlockText($"ROUND ({(round + 1)} / 3)");

                    player = "";
                    computer = "";

                    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                    {
                        Console.Write("Enter a ROCK, PAPER OR SCISSORS: ");
                        player = Console.ReadLine();

                        player = player?.ToUpper();
                    }

                    switch (random.Next(1, 4))
                    {
                        case 1:
                            computer = "ROCK";
                            break;
                        case 2:
                            computer = "PAPER";
                            break;
                        case 3:
                            computer = "SCISSORS";
                            break;
                    }

                    Console.WriteLine("Computer: " + computer);

                    switch (player)
                    {
                        case "ROCK":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("It's a draw!, Round " + (round + 1));
                            }
                            else if (computer == "PAPER")
                            {
                                Console.WriteLine("You lose!!!, Round " + (round + 1));
                                computerWins++;
                            }
                            else
                            {
                                Console.WriteLine("You Win!!!, Round " + (round + 1));
                                playerWins++;
                            }
                            break;

                        case "PAPER":
                            if (computer == "PAPER")
                            {
                                Console.WriteLine("It's a draw!, Round " + (round + 1));
                            }
                            else if (computer == "SCISSORS")
                            {
                                Console.WriteLine("You lose!!!, Round " + (round + 1));
                                computerWins++;
                            }
                            else
                            {
                                Console.WriteLine("You Win!!!, Round " + (round + 1));
                                playerWins++;
                            }
                            break;

                        case "SCISSORS":
                            if (computer == "SCISSORS")
                            {
                                Console.WriteLine("It's a draw!, Round " + (round + 1));
                            }
                            else if (computer == "ROCK")
                            {
                                Console.WriteLine("You lose!!!, Round " + (round + 1));
                                computerWins++;
                            }
                            else
                            {
                                Console.WriteLine("You Win!!!, Round " + (round + 1));
                                playerWins++;
                            }
                            break;
                    }
                    Console.WriteLine();
                    if (round < 2)
                    {

                        Console.WriteLine("NEXT ROUND ...");
                    }
                    round++;
                    Thread.Sleep(2000);
                }

                if (computerWins > playerWins)
                {
                    BlockText("YOU LOSE!!!");
                }
                else if (computerWins < playerWins)
                {
                    BlockText("YOU WON!!!");
                }
                else
                {
                    BlockText("IT WAS A DRAW");
                }

                Console.Write("Would you like to play again? (y/n) ");
                response = Console.ReadLine();
                response = response?.ToUpper();
                if (response != "Y")
                {
                    play = false;
                }
            }

            BlockText("Thank you for playing");


            Console.ReadKey();
        }
        static void BlockText(string text)
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(text);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
        }
    }
}