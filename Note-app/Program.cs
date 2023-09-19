namespace Notes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? response = "";
            List<string> notes = new List<string>();

            BlockText("NOTES APP");

            while (response != "e")
            {
                Console.WriteLine("Press 'a' to add a note");
                Console.WriteLine("Press 'l' to list all notes");
                Console.WriteLine("Press 'd' to delete a note");
                Console.WriteLine("Press 'u' to update a note");
                Console.WriteLine("Press 'e' to exit the program\n");

                Console.Write(">>>>  ");
                response = Console.ReadLine();

                switch (response)
                {
                    case "a":
                        Console.WriteLine("\nAdd a Note\n");
                        Console.Write(">> >>  ");
                        notes.Add(Console.ReadLine());
                        Console.WriteLine("\nNote Added\n");
                        break;
                    case "d":
                        Console.WriteLine("\nDelete note\n");
                        Console.WriteLine("Select an index to delete");
                        Console.Write(">> >>  ");

                        try
                        {
                            notes.RemoveAt(Convert.ToInt32(Console.ReadLine()) - 1);
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Invalid response, select a number between 0 -" + notes.Count());
                            break;
                        }
                        Console.WriteLine("\nNote Deleted\n");
                        break;
                    case "l":
                        Console.WriteLine("\nALL NOTES\n");
                        for (int i = 0; i < notes.Count(); i++)
                        {
                            Console.WriteLine((i + 1) + ") " + notes[i]);
                            Console.WriteLine();
                        }
                        break;
                    case "u":
                        Console.WriteLine("\nUpdate a note\n");
                        Console.WriteLine("Select an index to update");
                        Console.Write(">> >>  ");

                        try
                        {
                            int index = Convert.ToInt32(Console.ReadLine()) - 1;
                            Console.WriteLine(index + 1 + ") " + notes[index] + "\n");

                            Console.Write("New Note: ");
                            notes[index] = Console.ReadLine();
                        }
                        catch (System.Exception)
                        {
                            Console.WriteLine("Invalid response, select a number between 0 -" + notes.Count());
                            break;
                        }

                        Console.WriteLine("\nNote Updated\n");
                        break;
                    case "e":
                        Console.WriteLine("Exiting notes app...\n");
                        break;
                    default:
                        Console.WriteLine("Invalid response, Try again!\n");
                        break;

                }
            }

            Console.WriteLine("Thank you for using the notes app");
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