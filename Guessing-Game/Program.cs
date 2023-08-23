namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            BlockText("GUESSING GAME!");

            Random random = new Random();
            bool play = true;
            int guess;
            int max;
            int min;
            int number;
            int guesses;
            string? response;

            do
            {
                guesses = 0;
                guess = 0;
                min = 0;
                max = 100;
                number = random.Next(min, max + 1);
                response = "";
                Console.WriteLine("Guess a number between " + min + " and " + max + " ;");
                while (guess != number)
                {
                    Console.Write("Your guess: ");
                    try
                    {
                        guess = Convert.ToInt32(Console.ReadLine());
                        if (guess > number)
                        {
                            Console.WriteLine("Go lower!");
                        }
                        else
                        {
                            Console.WriteLine("Go Higher!");
                        }
                        guesses++;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Guess a number between " + min + " and " + max + " ;");
                    }
                }

                BlockText("YOU WON!!!");
                Console.WriteLine("The number: " + number);
                Console.WriteLine("Your guess: " + guess);
                Console.WriteLine("No. of trials: " + guesses);
                Console.WriteLine();

                Console.WriteLine("Would you like to play again? (y/n)");
                response = Console.ReadLine()?.ToUpper();

                if (response != "Y")
                {
                    play = false;
                }

            } while (play);

            BlockText("THANK YOU FOR PLAYING!!!");
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