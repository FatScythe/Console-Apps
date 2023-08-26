
namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            User? currentUser;
            string? cardNumber;
            Boolean done = false;
            int trials = 0;

            // Minature Database
            List<User> cardHolders = new List<User>();

            cardHolders.Add(new User("Fahm", "562890167238", 2341, 5000));
            cardHolders.Add(new User("Fardah", "562890163588", 2999, 2500));
            cardHolders.Add(new User("Furqan", "562899543523", 5119, 3000));
            cardHolders.Add(new User("Omolewa", "532891164570", 1220, 4000));

            Console.WriteLine();

            Console.WriteLine("Welcome to Sapa Bank!");

            while (true || trials >= 3)
            {
                Console.WriteLine("Please insert your debit card number");
                cardNumber = Console.ReadLine();

                currentUser = cardHolders.FirstOrDefault(a => a.CardNumber == cardNumber);


                if (currentUser == null)
                {
                    Console.WriteLine("Incorrect debit card number");

                    break;
                }


                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Please insert your debit card pin");
                    if (currentUser.Pin != Convert.ToInt32(Console.ReadLine()))
                    {
                        Console.WriteLine("Incorrect PIN!!");
                        Console.WriteLine($"You have {(2 - trials)} trials left!");
                        trials++;
                    }
                    else
                    {
                        break;
                    }

                }

                if (trials >= 3)
                {
                    break;
                }


                Console.WriteLine("Welcome " + currentUser.Name + "\n");
                do
                {
                    Console.WriteLine("Please select an option");
                    Console.WriteLine("1. My Balance");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Exit");

                    Console.Write("Your option: ");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            ShowBalance(currentUser);
                            Console.ReadKey();
                            break;
                        case "2":
                            Deposit(currentUser);
                            Console.ReadKey();
                            break;
                        case "3":
                            Withdraw(currentUser);
                            Console.ReadKey();
                            break;
                        case "4":
                            done = true;
                            break;
                        default:
                            Console.WriteLine("Please provide a valid input");
                            break;
                    }
                } while (!done);

                break;
            }

            Console.WriteLine("Thank you for banking with us!");

        }

        public static void ShowBalance(User user)
        {
            Console.WriteLine($"Your account balance is ${user.Balance}");
        }

        public static void Deposit(User user)
        {
            double deposit = 0;
            Console.WriteLine("How much would you like to deposit? ");

            while (true)
            {
                try
                {
                    deposit = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Please provide a valid input");
                }


            }


            if (user.Balance < deposit)
            {
                Console.WriteLine("Depositing...");
                Console.WriteLine();
                Thread.Sleep(1000);
                user.Balance += deposit;
                Console.Write($"Your new balance is ${user.Balance}");
            }
        }

        public static void Withdraw(User user)
        {
            double withdraw = 0;
            Console.WriteLine("How much would you like to withdraw? ");
            while (true)
            {
                try
                {
                    withdraw = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("Please provide a valid input");
                }
            }

            if (user.Balance >= withdraw)
            {
                user.Balance -= withdraw;
                Console.WriteLine("Withdrawing...");
                Console.WriteLine();
                Thread.Sleep(1000);
                Console.WriteLine("Would you like to print a receipt(Y/N)? ");
                if (Console.ReadLine()?.ToUpper() == "Y")
                {
                    Console.WriteLine("Printing...");
                    Thread.Sleep(1000);
                    Console.WriteLine("...");
                    Thread.Sleep(900);

                }

                Console.WriteLine($"Your new balance is ${user.Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient Funds!!!");
            }
        }
    }


    class User
    {
        // string? name;
        // string? cardNumber;
        // int? pin;
        // double balance;

        public User(string name, string cardNumber, int pin, double balance)
        {
            Name = name;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }

        public string Name { get; set; }

        public string CardNumber { get; set; }

        public int Pin { get; set; }

        public double Balance { get; set; }

        public override string ToString()
        {
            return $"Name: {Name} \ncardNumber: {CardNumber}\n balance: {Balance}";
        }

    }
}




