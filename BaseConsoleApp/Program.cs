namespace BaseConsoleApp;

public class Program
{
    public const string ApplicationName = "Base Console App";
    
    public static void Main(string[] args)
    {
        Console.WriteLine($"Starting {ApplicationName}...");

        bool running = true;

        while (running)
        {
            // Display a prompt
            Console.Write("> ");
            string input = Console.ReadLine();

            switch (input.ToLower())
            {
                case "exit":
                    running = false;
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine($"Command '{input}' not recognised.");
                    break;
            }
        }
        
        Console.WriteLine("Program closed.");
    }
}