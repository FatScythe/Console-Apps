
namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int rounds = 0;
            int computer;
            int player;
            int computerWins = 0;
            int playerWins = 0;
            int i;

            BlockText("Dice Game");

            while (rounds <= 0)
            {
                Console.Write("How many rounds would you like to play? ");
                try
                {
                    rounds = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    rounds = 0;
                }
            }

            do
            {


                for (i = 0; i < rounds; i++)
                {
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("Round " + (i + 1));
                    Console.WriteLine("-----------------------\n");
                    Console.WriteLine("Press any key to roll the die\n\n");
                    Console.ReadKey();

                    player = random.Next(1, 7);
                    Console.WriteLine($"You rolled: {player} \n");


                    computer = random.Next(1, 7);
                    Console.WriteLine("Computer is rolling ...\n");
                    Thread.Sleep(1000);

                    Console.WriteLine($"Computer rolled: {computer}\n");

                    if (computer > player)
                    {
                        Console.WriteLine("You lose this round!!!");
                        computerWins++;
                    }
                    else if (player > computer)
                    {
                        Console.WriteLine("You win this round!!!");
                        playerWins++;
                    }
                    else
                    {
                        Console.WriteLine("It's draw for this round!!!");
                    }

                }

                if (playerWins > computerWins)
                {
                    BlockText("YOU WON!!!");
                }
                else if (computerWins > playerWins)
                {
                    BlockText("YOU LOSE!!!");
                }
                else
                {
                    BlockText("IT'S A DRAW!");
                }
                Console.Write("Would you like to play again (Y/N)? :");
            } while (Console.ReadLine()?.ToUpper() == "Y");

        }
        static void BlockText(string text)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
            Console.WriteLine(text);
            Console.WriteLine("-----------------------");
            Console.WriteLine("-----------------------");
        }
    }
}