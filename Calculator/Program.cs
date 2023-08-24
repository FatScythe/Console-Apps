namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;
            String? symbol;

            Console.WriteLine("----------------");
            Console.WriteLine("Calculator Program");
            Console.WriteLine("----------------");

            do
            {


                try
                {
                    Console.Write("Enter the first number: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter numbers only!!!");
                }

                Console.WriteLine();
                Console.WriteLine("Arithmetic Operations Options: ");
                Console.WriteLine("\t Addition +");
                Console.WriteLine("\t Subtraction -");
                Console.WriteLine("\t Multiplication *");
                Console.WriteLine("\t Division /");

                Console.WriteLine();

                Console.Write("Option: ");
                symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        Console.WriteLine("That is not an option");
                        break;
                }

                Console.WriteLine($"The result of {num1} {symbol} {num2} = {result}");
                Console.WriteLine();

                Thread.Sleep(500);

                Console.Write("Would you like to continue(Y/N)? ");
                Console.WriteLine();

            } while (Console.ReadLine()?.ToUpper() == "Y");
            Console.WriteLine("Thank you, Bye!");
            Console.ReadKey();
        }
    }
}