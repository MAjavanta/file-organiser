namespace FileOrganiser.Core.UserInput;

public class ConsoleUserInput : IUserInput
{
    public string GetFilePath()
    {
        string? inputPath;
        Console.WriteLine("Please provide a directory path:");
        while (true)
        {
            inputPath = Console.ReadLine();
            if (inputPath is null || inputPath.Length == 0)
            {
                Console.WriteLine("Must provide a path");
                continue;
            }
            break;
        }
        return inputPath;
    }
}