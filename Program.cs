namespace MainProgram;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nChoose Level:\n");
        Console.WriteLine("1. Level 1 (Task 1-3)");
        Console.WriteLine("2. Level 2 (Task 4-6)");
        Console.WriteLine("0. Exit");
        string? input = InputHelpers.StringInput("\nYour choice: ");

        if (int.TryParse(input, out int userChoice))
        {
            if (userChoice == 0)
            {
                Console.WriteLine("\nExitting...");
                return;
            }
            else if (userChoice == 1)
            {
                Level1.Menu.Run();
            }
            else if (userChoice == 2)
            {
                Level2.Menu.Run();
            }
            else
            {
                Console.WriteLine("\nInvalid choice! Enter a digit between 0-3!");
            }
        }
        else
        {
            Console.WriteLine("\nInvalid input! Enter a digit!");
        }
    }
}